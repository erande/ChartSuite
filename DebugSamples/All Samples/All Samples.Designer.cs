namespace DebugSamples.All_Samples
{
    partial class All_Samples
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Column Chart");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Line Chart");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Curve Chart");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Pie Chart");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Chart Type", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Change Font Size");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Change Font Style");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Change Chart Style");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Chart Style", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Add Row Data");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Add Column Data");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Add Data To Chart", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Add Two Charts");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Add Muiltiple Charts");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Add Chart", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(All_Samples));
            this.SampleTree = new System.Windows.Forms.TreeView();
            this.TitleImagePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TitleImagePic)).BeginInit();
            this.SuspendLayout();
            // 
            // SampleTree
            // 
            this.SampleTree.Location = new System.Drawing.Point(12, 68);
            this.SampleTree.Name = "SampleTree";
            treeNode1.Name = "ColumnChart";
            treeNode1.Text = "Column Chart";
            treeNode2.Name = "LineChart";
            treeNode2.Text = "Line Chart";
            treeNode3.Name = "CurveChart";
            treeNode3.Text = "Curve Chart";
            treeNode4.Name = "PieChart";
            treeNode4.Text = "Pie Chart";
            treeNode5.Name = "ChartType";
            treeNode5.Text = "Chart Type";
            treeNode6.Name = "ChangeFontSize";
            treeNode6.Text = "Change Font Size";
            treeNode7.Name = "ChangeFontStyle";
            treeNode7.Text = "Change Font Style";
            treeNode8.Name = "ChangeChartStyle";
            treeNode8.Text = "Change Chart Style";
            treeNode9.Name = "ChartStyle";
            treeNode9.Text = "Chart Style";
            treeNode10.Name = "AddRowData";
            treeNode10.Text = "Add Row Data";
            treeNode11.Name = "AddColumnData";
            treeNode11.Text = "Add Column Data";
            treeNode12.Name = "AddData";
            treeNode12.Text = "Add Data To Chart";
            treeNode13.Name = "AddTwoCharts";
            treeNode13.Text = "Add Two Charts";
            treeNode14.Name = "AddMuiltipleCharts";
            treeNode14.Text = "Add Muiltiple Charts";
            treeNode15.Name = "AddChart";
            treeNode15.Text = "Add Chart";
            this.SampleTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode9,
            treeNode12,
            treeNode15});
            this.SampleTree.Size = new System.Drawing.Size(165, 415);
            this.SampleTree.TabIndex = 0;
            // 
            // TitleImagePic
            // 
            this.TitleImagePic.Image = ((System.Drawing.Image)(resources.GetObject("TitleImagePic.Image")));
            this.TitleImagePic.Location = new System.Drawing.Point(12, 12);
            this.TitleImagePic.Name = "TitleImagePic";
            this.TitleImagePic.Size = new System.Drawing.Size(165, 50);
            this.TitleImagePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TitleImagePic.TabIndex = 1;
            this.TitleImagePic.TabStop = false;
            // 
            // All_Samples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 508);
            this.Controls.Add(this.TitleImagePic);
            this.Controls.Add(this.SampleTree);
            this.Name = "All_Samples";
            this.Text = "All Samples";
            ((System.ComponentModel.ISupportInitialize)(this.TitleImagePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView SampleTree;
        private System.Windows.Forms.PictureBox TitleImagePic;
    }
}