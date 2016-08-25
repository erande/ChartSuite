namespace DebugSamples
{
    partial class Display_PieChart
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
            this.chartView2 = new ChartSuite.ChartView();
            this.SuspendLayout();
            // 
            // chartView2
            // 
            this.chartView2.ChartType = ChartSuite.ChartType.Line;
            this.chartView2.Location = new System.Drawing.Point(6, 4);
            this.chartView2.Name = "chartView2";
            this.chartView2.Path = null;
            this.chartView2.Size = new System.Drawing.Size(694, 503);
            this.chartView2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chartView2.TabIndex = 0;
            this.chartView2.Load += new System.EventHandler(this.chartView1_Load_1);
            // 
            // Display_PieChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 515);
            this.Controls.Add(this.chartView2);
            this.Name = "Display_PieChart";
            this.Text = "Display PieChart";
            this.ResumeLayout(false);

        }

        #endregion

        private ChartSuite.ChartView chartView2;
    }
}