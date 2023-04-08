namespace InfDetector
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlRecognizing = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.btnRecognizeImage = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MNistDBPage = new System.Windows.Forms.TabPage();
            this.pnlTesting = new System.Windows.Forms.GroupBox();
            this.btnStopTesting = new System.Windows.Forms.Button();
            this.btnStartTesting = new System.Windows.Forms.Button();
            this.pnlTraining = new System.Windows.Forms.GroupBox();
            this.btnStopTraining = new System.Windows.Forms.Button();
            this.btnStartTraining = new System.Windows.Forms.Button();
            this.pnlOpening = new System.Windows.Forms.GroupBox();
            this.lblMNistInfo = new System.Windows.Forms.Label();
            this.btnOpenMNist = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.pnlRecognizing.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.MNistDBPage.SuspendLayout();
            this.pnlTesting.SuspendLayout();
            this.pnlTraining.SuspendLayout();
            this.pnlOpening.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.pnlRecognizing);
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 652);
            this.panel2.TabIndex = 0;
            // 
            // pnlRecognizing
            // 
            this.pnlRecognizing.Controls.Add(this.clearButton);
            this.pnlRecognizing.Controls.Add(this.btnRecognizeImage);
            this.pnlRecognizing.Location = new System.Drawing.Point(345, 35);
            this.pnlRecognizing.Name = "pnlRecognizing";
            this.pnlRecognizing.Size = new System.Drawing.Size(107, 161);
            this.pnlRecognizing.TabIndex = 9;
            this.pnlRecognizing.TabStop = false;
            this.pnlRecognizing.Text = "Взаимодействие";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(6, 36);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(89, 30);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // btnRecognizeImage
            // 
            this.btnRecognizeImage.Location = new System.Drawing.Point(6, 106);
            this.btnRecognizeImage.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.btnRecognizeImage.Name = "btnRecognizeImage";
            this.btnRecognizeImage.Size = new System.Drawing.Size(89, 30);
            this.btnRecognizeImage.TabIndex = 7;
            this.btnRecognizeImage.Text = "Распознать";
            this.btnRecognizeImage.UseVisualStyleBackColor = true;
            this.btnRecognizeImage.Click += new System.EventHandler(this.btnRecognizeImage_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MNistDBPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 19);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(327, 176);
            this.tabControl1.TabIndex = 3;
            // 
            // MNistDBPage
            // 
            this.MNistDBPage.Controls.Add(this.pnlTesting);
            this.MNistDBPage.Controls.Add(this.pnlTraining);
            this.MNistDBPage.Controls.Add(this.pnlOpening);
            this.MNistDBPage.Location = new System.Drawing.Point(4, 22);
            this.MNistDBPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MNistDBPage.Name = "MNistDBPage";
            this.MNistDBPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MNistDBPage.Size = new System.Drawing.Size(319, 150);
            this.MNistDBPage.TabIndex = 0;
            this.MNistDBPage.Text = "База MNist";
            this.MNistDBPage.UseVisualStyleBackColor = true;
            // 
            // pnlTesting
            // 
            this.pnlTesting.Controls.Add(this.btnStopTesting);
            this.pnlTesting.Controls.Add(this.btnStartTesting);
            this.pnlTesting.Location = new System.Drawing.Point(210, 10);
            this.pnlTesting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTesting.Name = "pnlTesting";
            this.pnlTesting.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTesting.Size = new System.Drawing.Size(104, 130);
            this.pnlTesting.TabIndex = 14;
            this.pnlTesting.TabStop = false;
            this.pnlTesting.Text = "Тестирование";
            // 
            // btnStopTesting
            // 
            this.btnStopTesting.Location = new System.Drawing.Point(12, 20);
            this.btnStopTesting.Margin = new System.Windows.Forms.Padding(0);
            this.btnStopTesting.Name = "btnStopTesting";
            this.btnStopTesting.Size = new System.Drawing.Size(80, 30);
            this.btnStopTesting.TabIndex = 11;
            this.btnStopTesting.Text = "Закончить";
            this.btnStopTesting.UseVisualStyleBackColor = true;
            this.btnStopTesting.Click += new System.EventHandler(this.btnStopTesting_Click);
            // 
            // btnStartTesting
            // 
            this.btnStartTesting.Location = new System.Drawing.Point(12, 90);
            this.btnStartTesting.Margin = new System.Windows.Forms.Padding(0);
            this.btnStartTesting.Name = "btnStartTesting";
            this.btnStartTesting.Size = new System.Drawing.Size(80, 30);
            this.btnStartTesting.TabIndex = 10;
            this.btnStartTesting.Text = "Начать";
            this.btnStartTesting.UseVisualStyleBackColor = true;
            this.btnStartTesting.Click += new System.EventHandler(this.btnStartTesting_Click);
            // 
            // pnlTraining
            // 
            this.pnlTraining.Controls.Add(this.btnStopTraining);
            this.pnlTraining.Controls.Add(this.btnStartTraining);
            this.pnlTraining.Location = new System.Drawing.Point(10, 80);
            this.pnlTraining.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTraining.Name = "pnlTraining";
            this.pnlTraining.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTraining.Size = new System.Drawing.Size(190, 60);
            this.pnlTraining.TabIndex = 13;
            this.pnlTraining.TabStop = false;
            this.pnlTraining.Text = "Обучение";
            // 
            // btnStopTraining
            // 
            this.btnStopTraining.Location = new System.Drawing.Point(100, 20);
            this.btnStopTraining.Margin = new System.Windows.Forms.Padding(0);
            this.btnStopTraining.Name = "btnStopTraining";
            this.btnStopTraining.Size = new System.Drawing.Size(80, 30);
            this.btnStopTraining.TabIndex = 9;
            this.btnStopTraining.Text = "Закончить";
            this.btnStopTraining.UseVisualStyleBackColor = true;
            this.btnStopTraining.Click += new System.EventHandler(this.btnStopTraining_Click);
            // 
            // btnStartTraining
            // 
            this.btnStartTraining.Location = new System.Drawing.Point(10, 20);
            this.btnStartTraining.Margin = new System.Windows.Forms.Padding(0);
            this.btnStartTraining.Name = "btnStartTraining";
            this.btnStartTraining.Size = new System.Drawing.Size(80, 30);
            this.btnStartTraining.TabIndex = 7;
            this.btnStartTraining.Text = "Начать";
            this.btnStartTraining.UseVisualStyleBackColor = true;
            this.btnStartTraining.Click += new System.EventHandler(this.btnStartTraining_Click);
            // 
            // pnlOpening
            // 
            this.pnlOpening.Controls.Add(this.lblMNistInfo);
            this.pnlOpening.Controls.Add(this.btnOpenMNist);
            this.pnlOpening.Location = new System.Drawing.Point(10, 10);
            this.pnlOpening.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlOpening.Name = "pnlOpening";
            this.pnlOpening.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlOpening.Size = new System.Drawing.Size(190, 60);
            this.pnlOpening.TabIndex = 10;
            this.pnlOpening.TabStop = false;
            this.pnlOpening.Text = "Информация о базе";
            // 
            // lblMNistInfo
            // 
            this.lblMNistInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMNistInfo.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMNistInfo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMNistInfo.Location = new System.Drawing.Point(10, 20);
            this.lblMNistInfo.Name = "lblMNistInfo";
            this.lblMNistInfo.Size = new System.Drawing.Size(130, 30);
            this.lblMNistInfo.TabIndex = 12;
            this.lblMNistInfo.Text = "База не загружена";
            this.lblMNistInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpenMNist
            // 
            this.btnOpenMNist.Location = new System.Drawing.Point(150, 20);
            this.btnOpenMNist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenMNist.Name = "btnOpenMNist";
            this.btnOpenMNist.Size = new System.Drawing.Size(30, 30);
            this.btnOpenMNist.TabIndex = 4;
            this.btnOpenMNist.Text = "...";
            this.btnOpenMNist.UseVisualStyleBackColor = true;
            this.btnOpenMNist.Click += new System.EventHandler(this.btnOpenMNist_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(284, 620);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 20);
            this.textBox2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 412);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 620);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(275, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Изображена повернутая восьмерка";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(464, 652);
            this.Controls.Add(this.panel2);
            this.Name = "MainForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlRecognizing.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.MNistDBPage.ResumeLayout(false);
            this.pnlTesting.ResumeLayout(false);
            this.pnlTraining.ResumeLayout(false);
            this.pnlOpening.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MNistDBPage;
        private System.Windows.Forms.GroupBox pnlTesting;
        private System.Windows.Forms.Button btnStopTesting;
        private System.Windows.Forms.Button btnStartTesting;
        private System.Windows.Forms.GroupBox pnlTraining;
        private System.Windows.Forms.Button btnStopTraining;
        private System.Windows.Forms.Button btnStartTraining;
        private System.Windows.Forms.GroupBox pnlOpening;
        private System.Windows.Forms.Label lblMNistInfo;
        private System.Windows.Forms.Button btnOpenMNist;
        private System.Windows.Forms.GroupBox pnlRecognizing;
        private System.Windows.Forms.Button btnRecognizeImage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

