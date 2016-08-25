namespace ChartSuite
{
    partial class ChartView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveImageAsSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmMenu
            // 
            this.cmMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveImageAsSToolStripMenuItem});
            this.cmMenu.Name = "cmMenu";
            this.cmMenu.Size = new System.Drawing.Size(198, 30);
            // 
            // saveImageAsSToolStripMenuItem
            // 
            this.saveImageAsSToolStripMenuItem.Name = "saveImageAsSToolStripMenuItem";
            this.saveImageAsSToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.saveImageAsSToolStripMenuItem.Text = "Save image as(&S)";
            this.saveImageAsSToolStripMenuItem.Click += new System.EventHandler(this.saveImageAsSToolStripMenuItem_Click);
            // 
            // ChartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name = "ChartView";
            this.Size = new System.Drawing.Size(920, 525);
            this.Load += new System.EventHandler(this.ChartView_Load);
            this.cmMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmMenu;
        private System.Windows.Forms.ToolStripMenuItem saveImageAsSToolStripMenuItem;
    }
}
