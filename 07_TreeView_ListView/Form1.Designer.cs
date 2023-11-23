namespace Dz_na_30._11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode1 = new TreeNode("Node11");
            TreeNode treeNode2 = new TreeNode("Node10", new TreeNode[] { treeNode1 });
            TreeNode treeNode3 = new TreeNode("Node9", new TreeNode[] { treeNode2 });
            TreeNode treeNode4 = new TreeNode("Node6", new TreeNode[] { treeNode3 });
            TreeNode treeNode5 = new TreeNode("Node7");
            TreeNode treeNode6 = new TreeNode("Node8");
            TreeNode treeNode7 = new TreeNode("Node1", new TreeNode[] { treeNode4, treeNode5, treeNode6 });
            TreeNode treeNode8 = new TreeNode("Node2");
            TreeNode treeNode9 = new TreeNode("Node3");
            TreeNode treeNode10 = new TreeNode("Node4");
            TreeNode treeNode11 = new TreeNode("Node5");
            TreeNode treeNode12 = new TreeNode("Root", new TreeNode[] { treeNode7, treeNode8, treeNode9, treeNode10, treeNode11 });
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            fileList = new ListView();
            dirTree = new TreeView();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // fileList
            // 
            fileList.Location = new Point(495, 42);
            fileList.Margin = new Padding(1);
            fileList.Name = "fileList";
            fileList.Size = new Size(533, 471);
            fileList.TabIndex = 3;
            fileList.UseCompatibleStateImageBehavior = false;
            fileList.View = View.Details;
            // 
            // dirTree
            // 
            dirTree.BackColor = SystemColors.HighlightText;
            dirTree.Location = new Point(3, 42);
            dirTree.Margin = new Padding(1);
            dirTree.Name = "dirTree";
            treeNode1.Name = "Node11";
            treeNode1.Text = "Node11";
            treeNode2.Name = "Node10";
            treeNode2.Text = "Node10";
            treeNode3.Name = "Node9";
            treeNode3.Text = "Node9";
            treeNode4.Name = "Node6";
            treeNode4.Text = "Node6";
            treeNode5.Name = "Node7";
            treeNode5.Text = "Node7";
            treeNode6.Name = "Node8";
            treeNode6.Text = "Node8";
            treeNode7.Name = "Node1";
            treeNode7.Text = "Node1";
            treeNode8.Name = "Node2";
            treeNode8.Text = "Node2";
            treeNode9.Name = "Node3";
            treeNode9.Text = "Node3";
            treeNode10.Name = "Node4";
            treeNode10.Text = "Node4";
            treeNode11.Name = "Node5";
            treeNode11.Text = "Node5";
            treeNode12.BackColor = Color.White;
            treeNode12.ForeColor = Color.Black;
            treeNode12.Name = "Node0";
            treeNode12.Text = "Root";
            dirTree.Nodes.AddRange(new TreeNode[] { treeNode12 });
            dirTree.Size = new Size(490, 471);
            dirTree.TabIndex = 2;
            dirTree.BeforeCollapse += dirTree_BeforeCollapse;
            dirTree.AfterExpand += dirTree_AfterExpand;
            dirTree.AfterSelect += dirTree_AfterSelect;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.ControlLight;
            toolStrip1.ImageScalingSize = new Size(30, 30);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4, toolStripButton5 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1035, 37);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(34, 34);
            toolStripButton1.Text = "List";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(34, 34);
            toolStripButton2.Text = "Tile";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(34, 34);
            toolStripButton3.Text = "Details";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(34, 34);
            toolStripButton4.Text = "Large Icon";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(34, 34);
            toolStripButton5.Text = "Small Icon";
            toolStripButton5.Click += toolStripButton5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1035, 532);
            Controls.Add(toolStrip1);
            Controls.Add(fileList);
            Controls.Add(dirTree);
            Name = "Form1";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView fileList;
        private TreeView dirTree;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
    }
}