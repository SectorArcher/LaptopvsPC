namespace LaptopvsPC
{
    partial class ResultFrm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rchTxtBxResult = new System.Windows.Forms.RichTextBox();
            this.chrt = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bttnSave = new System.Windows.Forms.Button();
            this.bttnRestart = new System.Windows.Forms.Button();
            this.bttnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chrt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(413, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eredmény";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Specifikáció:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(603, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Melyik eszköz?";
            // 
            // rchTxtBxResult
            // 
            this.rchTxtBxResult.Location = new System.Drawing.Point(12, 174);
            this.rchTxtBxResult.Name = "rchTxtBxResult";
            this.rchTxtBxResult.Size = new System.Drawing.Size(475, 408);
            this.rchTxtBxResult.TabIndex = 5;
            this.rchTxtBxResult.Text = "";
            // 
            // chrt
            // 
            chartArea2.Name = "ChartArea1";
            this.chrt.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrt.Legends.Add(legend2);
            this.chrt.Location = new System.Drawing.Point(609, 174);
            this.chrt.Name = "chrt";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "PC";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Laptop";
            this.chrt.Series.Add(series3);
            this.chrt.Series.Add(series4);
            this.chrt.Size = new System.Drawing.Size(475, 408);
            this.chrt.TabIndex = 6;
            this.chrt.Text = "chart1";
            // 
            // bttnSave
            // 
            this.bttnSave.Location = new System.Drawing.Point(403, 136);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(84, 32);
            this.bttnSave.TabIndex = 7;
            this.bttnSave.Text = "Mentés";
            this.bttnSave.UseVisualStyleBackColor = true;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // bttnRestart
            // 
            this.bttnRestart.Location = new System.Drawing.Point(882, 12);
            this.bttnRestart.Name = "bttnRestart";
            this.bttnRestart.Size = new System.Drawing.Size(98, 32);
            this.bttnRestart.TabIndex = 7;
            this.bttnRestart.Text = "Újraindítás";
            this.bttnRestart.UseVisualStyleBackColor = true;
            this.bttnRestart.Click += new System.EventHandler(this.bttnRestart_Click);
            // 
            // bttnExit
            // 
            this.bttnExit.Location = new System.Drawing.Point(986, 12);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(98, 32);
            this.bttnExit.TabIndex = 7;
            this.bttnExit.Text = "Kilépés";
            this.bttnExit.UseVisualStyleBackColor = true;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // ResultFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 594);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.bttnRestart);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.chrt);
            this.Controls.Add(this.rchTxtBxResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ResultFrm";
            this.Text = "ResultFrm";
            this.Load += new System.EventHandler(this.ResultFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rchTxtBxResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt;
        private System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.Button bttnRestart;
        private System.Windows.Forms.Button bttnExit;
    }
}