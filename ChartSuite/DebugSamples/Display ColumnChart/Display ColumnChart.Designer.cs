namespace DebugSamples
{
    partial class Display_ColumnChart
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
            this.ChangeStyleBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadDataBtn = new System.Windows.Forms.Button();
            this.LineChartBtn = new System.Windows.Forms.Button();
            this.ColumnChartBtn = new System.Windows.Forms.Button();
            this.dataSourcePathBtn = new System.Windows.Forms.Button();
            this.dataSourcePathTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CurveChartBtn = new System.Windows.Forms.Button();
            this.AddChartBtn = new System.Windows.Forms.Button();
            this.PieChartbtn = new System.Windows.Forms.Button();
            this.AddRowDataBtn = new System.Windows.Forms.Button();
            this.AddColumnDataBtn = new System.Windows.Forms.Button();
            this.TransposeMatrixBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangeStyleBtn
            // 
            this.ChangeStyleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeStyleBtn.Location = new System.Drawing.Point(970, 303);
            this.ChangeStyleBtn.Name = "ChangeStyleBtn";
            this.ChangeStyleBtn.Size = new System.Drawing.Size(109, 27);
            this.ChangeStyleBtn.TabIndex = 1;
            this.ChangeStyleBtn.Text = "ChangeStyle";
            this.ChangeStyleBtn.UseVisualStyleBackColor = true;
            this.ChangeStyleBtn.Click += new System.EventHandler(this.ChangeStyleBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Select : ";
            // 
            // LoadDataBtn
            // 
            this.LoadDataBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadDataBtn.Location = new System.Drawing.Point(970, 63);
            this.LoadDataBtn.Name = "LoadDataBtn";
            this.LoadDataBtn.Size = new System.Drawing.Size(91, 23);
            this.LoadDataBtn.TabIndex = 32;
            this.LoadDataBtn.Text = "LoadData";
            this.LoadDataBtn.UseVisualStyleBackColor = true;
            this.LoadDataBtn.Click += new System.EventHandler(this.LoadDataBtn_Click_1);
            // 
            // LineChartBtn
            // 
            this.LineChartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LineChartBtn.Location = new System.Drawing.Point(969, 123);
            this.LineChartBtn.Name = "LineChartBtn";
            this.LineChartBtn.Size = new System.Drawing.Size(93, 25);
            this.LineChartBtn.TabIndex = 31;
            this.LineChartBtn.Text = "Line";
            this.LineChartBtn.UseVisualStyleBackColor = true;
            this.LineChartBtn.Click += new System.EventHandler(this.LineChartBtn_Click);
            // 
            // ColumnChartBtn
            // 
            this.ColumnChartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColumnChartBtn.Location = new System.Drawing.Point(969, 92);
            this.ColumnChartBtn.Name = "ColumnChartBtn";
            this.ColumnChartBtn.Size = new System.Drawing.Size(93, 25);
            this.ColumnChartBtn.TabIndex = 30;
            this.ColumnChartBtn.Text = "Column";
            this.ColumnChartBtn.UseVisualStyleBackColor = true;
            this.ColumnChartBtn.Click += new System.EventHandler(this.ColumnChartBtn_Click);
            // 
            // dataSourcePathBtn
            // 
            this.dataSourcePathBtn.Location = new System.Drawing.Point(851, 13);
            this.dataSourcePathBtn.Name = "dataSourcePathBtn";
            this.dataSourcePathBtn.Size = new System.Drawing.Size(93, 27);
            this.dataSourcePathBtn.TabIndex = 29;
            this.dataSourcePathBtn.Text = "browse(&O)";
            this.dataSourcePathBtn.UseVisualStyleBackColor = true;
            this.dataSourcePathBtn.Click += new System.EventHandler(this.dataSourcePathBtn_Click);
            // 
            // dataSourcePathTxt
            // 
            this.dataSourcePathTxt.Location = new System.Drawing.Point(104, 12);
            this.dataSourcePathTxt.Name = "dataSourcePathTxt";
            this.dataSourcePathTxt.Size = new System.Drawing.Size(719, 22);
            this.dataSourcePathTxt.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(23, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(921, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // CurveChartBtn
            // 
            this.CurveChartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CurveChartBtn.Location = new System.Drawing.Point(970, 155);
            this.CurveChartBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CurveChartBtn.Name = "CurveChartBtn";
            this.CurveChartBtn.Size = new System.Drawing.Size(91, 24);
            this.CurveChartBtn.TabIndex = 37;
            this.CurveChartBtn.Text = "Curve";
            this.CurveChartBtn.UseVisualStyleBackColor = true;
            this.CurveChartBtn.Click += new System.EventHandler(this.CurveChartBtn_Click);
            // 
            // AddChartBtn
            // 
            this.AddChartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddChartBtn.Location = new System.Drawing.Point(969, 215);
            this.AddChartBtn.Name = "AddChartBtn";
            this.AddChartBtn.Size = new System.Drawing.Size(91, 23);
            this.AddChartBtn.TabIndex = 38;
            this.AddChartBtn.Text = "AddChart";
            this.AddChartBtn.UseVisualStyleBackColor = true;
            this.AddChartBtn.Click += new System.EventHandler(this.AddChartBtn_Click);
            // 
            // PieChartbtn
            // 
            this.PieChartbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PieChartbtn.Location = new System.Drawing.Point(970, 186);
            this.PieChartbtn.Name = "PieChartbtn";
            this.PieChartbtn.Size = new System.Drawing.Size(91, 23);
            this.PieChartbtn.TabIndex = 39;
            this.PieChartbtn.Text = "Pie";
            this.PieChartbtn.UseVisualStyleBackColor = true;
            this.PieChartbtn.Click += new System.EventHandler(this.PieChartbtn_Click);           
            // 
            // AddRowDataBtn
            // 
            this.AddRowDataBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddRowDataBtn.Location = new System.Drawing.Point(970, 245);
            this.AddRowDataBtn.Name = "AddRowDataBtn";
            this.AddRowDataBtn.Size = new System.Drawing.Size(118, 23);
            this.AddRowDataBtn.TabIndex = 41;
            this.AddRowDataBtn.Text = "AddRowData";
            this.AddRowDataBtn.UseVisualStyleBackColor = true;
            this.AddRowDataBtn.Click += new System.EventHandler(this.AddDataBtn_Click);
            // 
            // AddColumnDataBtn
            // 
            this.AddColumnDataBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddColumnDataBtn.Location = new System.Drawing.Point(970, 274);
            this.AddColumnDataBtn.Name = "AddColumnDataBtn";
            this.AddColumnDataBtn.Size = new System.Drawing.Size(118, 23);
            this.AddColumnDataBtn.TabIndex = 42;
            this.AddColumnDataBtn.Text = "AddColumnData";
            this.AddColumnDataBtn.UseVisualStyleBackColor = true;
            this.AddColumnDataBtn.Click += new System.EventHandler(this.AddColumnDataBtn_Click);
            // 
            // TransposeMatrixBtn
            // 
            this.TransposeMatrixBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TransposeMatrixBtn.Location = new System.Drawing.Point(970, 336);
            this.TransposeMatrixBtn.Name = "TransposeMatrixBtn";
            this.TransposeMatrixBtn.Size = new System.Drawing.Size(109, 27);
            this.TransposeMatrixBtn.TabIndex = 43;
            this.TransposeMatrixBtn.Text = "Transpose";
            this.TransposeMatrixBtn.UseVisualStyleBackColor = true;
            this.TransposeMatrixBtn.Click += new System.EventHandler(this.TransposeMatrixBtn_Click);
            // 
            // Display_ColumnChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 684);
            this.Controls.Add(this.TransposeMatrixBtn);
            this.Controls.Add(this.AddColumnDataBtn);
            this.Controls.Add(this.AddRowDataBtn);
            this.Controls.Add(this.PieChartbtn);
            this.Controls.Add(this.AddChartBtn);
            this.Controls.Add(this.CurveChartBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadDataBtn);
            this.Controls.Add(this.LineChartBtn);
            this.Controls.Add(this.ColumnChartBtn);
            this.Controls.Add(this.dataSourcePathBtn);
            this.Controls.Add(this.dataSourcePathTxt);
            this.Controls.Add(this.ChangeStyleBtn);
            this.Name = "Display_ColumnChart";
            this.Text = "Display ColumnChart";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ChangeStyleBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoadDataBtn;
        private System.Windows.Forms.Button LineChartBtn;
        private System.Windows.Forms.Button ColumnChartBtn;
        private System.Windows.Forms.Button dataSourcePathBtn;
        private System.Windows.Forms.TextBox dataSourcePathTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CurveChartBtn;
        private System.Windows.Forms.Button AddChartBtn;
        private System.Windows.Forms.Button PieChartbtn;
        private System.Windows.Forms.Button AddRowDataBtn;
        private System.Windows.Forms.Button AddColumnDataBtn;
        private System.Windows.Forms.Button TransposeMatrixBtn;
    }
}

