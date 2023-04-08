using Recognition.Application;
using Recognition.Image;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Recognition.NeuralNet;

namespace InfDetector
{
    public partial class MainForm : Form
    {
        private Graphics _graphics;
        private Bitmap _bitmap;
        private bool _isDrawing;
        private Pen _pen;
        public Point position;
        private Figure _currentFigure;
        private List<Figure> _figures;
        private NetworkForm _networkForm;
        private MNistImage[] nistImages;
        //private MNistImage currentMNistImage;
        private NormalizedImage currentInputImage;
        private CancellationTokenSource _tokenSource;

        public MainForm()
        {
            InitializeComponent();
            _bitmap = new Bitmap(panel2.Width, panel2.Height);
            _graphics = Graphics.FromImage(_bitmap);
            Rectangle rect = new Rectangle(0, 0, panel2.Width, panel2.Height);
            _graphics.DrawRectangle(new Pen(Color.Red), rect);
            _graphics.FillRectangle(new SolidBrush(Color.White), rect);
            //_graphics = panel2.CreateGraphics();
            _pen = new Pen(Color.Black, 5);
            _isDrawing = false;
            position = new Point(-1, -1);
            _graphics.SmoothingMode = SmoothingMode.AntiAlias;
            _pen.StartCap = _pen.EndCap = LineCap.Round;
            _pen.Width = 40;
            _figures = new List<Figure>();
            _networkForm = new NetworkForm();
            _networkForm.Show();
            textBox1.Text = $"Нажмите РАСПОЗНАТЬ чтобы проверить нарисована ли повернутая восьмерка";
            DisablePanels(PanelsState.TrainingDisabled | PanelsState.TestingDisabled | PanelsState.RecognizingDisabled);
        }

        private void DisablePanels(PanelsState panelsState)
        {
            // включение всего
            btnOpenMNist.Enabled = true;
            btnStartTraining.Enabled = btnStopTraining.Enabled = true;
            btnStartTesting.Enabled = btnStopTesting.Enabled = true;

            var panelsStateValues = Enum.GetValues(typeof(PanelsState));
            foreach (PanelsState stateValue in panelsStateValues)
            {
                if (panelsState.HasFlag(stateValue))
                {
                    switch (stateValue)
                    {
                        case PanelsState.OpeningDisabled:
                            btnOpenMNist.Enabled = false;
                            break;
                        case PanelsState.StartTrainingDisabled:
                            btnStartTraining.Enabled = false;
                            break;
                        case PanelsState.StopTrainingDisabled:
                            btnStopTraining.Enabled = false;
                            break;
                        case PanelsState.StartTestingDisabled:
                            btnStartTesting.Enabled = false;
                            break;
                        case PanelsState.StopTestingDisabled:
                            btnStopTesting.Enabled = false;
                            break;
                    }
                }
            }
        }

        private void btnOpenMNist_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Title = "Выберите файл изображений";
            dialog.Filter = "Файл изображений|*.idx3-ubyte";
            if (dialog.ShowDialog() != DialogResult.OK) return;
            var imagesPath = dialog.FileName;

            dialog.Reset();
            dialog.Title = "Выберите файл подписей";
            dialog.Filter = "Файл подписей|*.idx1-ubyte";
            if (dialog.ShowDialog() != DialogResult.OK) return;
            var labelsPath = dialog.FileName;

            nistImages = MNistFileManager.GetImageSet(labelsPath, imagesPath);

            lblMNistInfo.Text = string.Format("{0} элементов", nistImages.Length);
            lblMNistInfo.ForeColor = Color.DarkGreen;

            DisablePanels(PanelsState.AllEnabled);
        }

        private async void btnStartTraining_Click(object sender, EventArgs e)
        {
            if (nistImages != null)
            {
                DisablePanels(PanelsState.TrainingNow);
                _tokenSource = new CancellationTokenSource();
                await Task.Factory.StartNew(() => _networkForm.TrainNetwork(nistImages, _tokenSource.Token));
                DisablePanels(PanelsState.AllEnabled);
            }
        }

        private void btnStopTraining_Click(object sender, EventArgs e)
        {
            _tokenSource.Cancel();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _isDrawing = true;
            position.X = e.X;
            position.Y = e.Y;
            _currentFigure = new Figure();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox2.Text = $"X-{e.Location.X} Y-{e.Location.Y}";
            if (!_isDrawing) return;
            Point location = e.Location;
            if ((location.X < 0 || location.X > this.Width) || (location.Y < 0 || location.Y > this.Height))
            {
                return;
            }
            _graphics.DrawLine(_pen, position, location);
            pictureBox1.Image = _bitmap;
            position = location;
            _currentFigure.AddPoint(position);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _isDrawing = false;
            _currentFigure.Cap();
            if (_currentFigure.Points.Length > 0) _figures.Add(_currentFigure);
        }

        private async void btnStartTesting_Click(object sender, EventArgs e)
        {
            if (nistImages != null)
            {
                DisablePanels(PanelsState.TestingNow);
                _tokenSource = new CancellationTokenSource();
                await Task.Factory.StartNew(() => _networkForm.TestNetwork(nistImages, _tokenSource.Token));
                DisablePanels(PanelsState.AllEnabled);
            }
        }

        private void btnStopTesting_Click(object sender, EventArgs e)
        {
            _tokenSource.Cancel();
        }

        private void btnRecognizeImage_Click(object sender, EventArgs e)
        {
            bool success = _networkForm.RecognizeImage(_bitmap, "8", _currentFigure);
            string successString = "";
            string unsuccessString = "не ";
            textBox1.Text = $"Повернутая восьмерка {(success ? successString : unsuccessString)}найдена";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, panel2.Width, panel2.Height);
            _graphics.FillRectangle(new SolidBrush(Color.White), rect);
            _currentFigure = null;
            _figures.Clear();
            pictureBox1.Image = _bitmap;
        }
    }
}
