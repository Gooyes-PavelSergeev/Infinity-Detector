namespace Recognition.Application
{
    partial class NetworkForm
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
            this.txtStatistics = new System.Windows.Forms.TextBox();
            this.imgLayersOutputs = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imgLayersOutputs)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStatistics
            // 
            this.txtStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStatistics.Location = new System.Drawing.Point(3, 3);
            this.txtStatistics.Multiline = true;
            this.txtStatistics.Name = "txtStatistics";
            this.txtStatistics.ReadOnly = true;
            this.txtStatistics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatistics.Size = new System.Drawing.Size(275, 433);
            this.txtStatistics.TabIndex = 9;
            // 
            // imgLayersOutputs
            // 
            this.imgLayersOutputs.BackColor = System.Drawing.Color.White;
            this.imgLayersOutputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgLayersOutputs.Location = new System.Drawing.Point(284, 3);
            this.imgLayersOutputs.Name = "imgLayersOutputs";
            this.tableLayoutPanel1.SetRowSpan(this.imgLayersOutputs, 2);
            this.imgLayersOutputs.Size = new System.Drawing.Size(652, 462);
            this.imgLayersOutputs.TabIndex = 6;
            this.imgLayersOutputs.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.txtStatistics, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.imgLayersOutputs, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClearHistory, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(939, 488);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearHistory.Location = new System.Drawing.Point(3, 442);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(275, 23);
            this.btnClearHistory.TabIndex = 10;
            this.btnClearHistory.Text = "Очистить историю";
            this.btnClearHistory.UseVisualStyleBackColor = true;
            this.btnClearHistory.Click += new System.EventHandler(this.BtnClearHistoryClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 471);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 14);
            this.panel1.TabIndex = 11;
            // 
            // NetworkForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(939, 488);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NetworkForm";
            this.Text = "Нейронная сеть - Новая";
            ((System.ComponentModel.ISupportInitialize)(this.imgLayersOutputs)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtStatistics;
        private System.Windows.Forms.PictureBox imgLayersOutputs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnClearHistory;
        private System.Windows.Forms.Panel panel1;
    }
}