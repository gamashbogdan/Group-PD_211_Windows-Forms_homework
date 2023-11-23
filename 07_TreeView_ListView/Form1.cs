namespace Dz_na_30._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dirTree.Nodes.Clear();
            LoadImageList();
            LoadDirectories(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), dirTree.Nodes);
            fileList.View = View.Details;
            fileList.Columns.Add("Name").Width = 300;
            fileList.Columns.Add("Extencion", 300);
            fileList.Columns.Add("Create Time", 300);
        }
        void LoadImageList()
        {
            ImageList imageList = new ImageList();
            imageList.Images.Add(new Bitmap(@"C:\Users\Dell 7510\source\repos\gamashbogdan\Group-PD_211_Windows-Forms_homework\07_TreeView_ListView\img\folder.png"));
            imageList.Images.Add(new Bitmap(@"C:\Users\Dell 7510\source\repos\gamashbogdan\Group-PD_211_Windows-Forms_homework\07_TreeView_ListView\img\openFolder.png"));
            imageList.Images.Add(new Bitmap(@"C:\Users\Dell 7510\source\repos\gamashbogdan\Group-PD_211_Windows-Forms_homework\07_TreeView_ListView\img\select.png"));

            dirTree.ImageList = imageList;
            dirTree.ImageList.ImageSize = new Size(30, 30);
        }
        void LoadDirectories(string dirPath, TreeNodeCollection nodes)
        {

            DirectoryInfo dirInfo = new DirectoryInfo(dirPath);

            foreach (var subDir in dirInfo.GetDirectories())
            {
                TreeNode newNode = new TreeNode(subDir.Name, 0, 2);
                newNode.Tag = subDir.FullName;
                nodes.Add(newNode);
                // dirTree.Nodes.Add(subDir.Name);
                if (subDir.GetDirectories().Length > 0)
                    LoadDirectories(subDir.FullName, newNode.Nodes);
            }
        }

        private void dirTree_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 1;
        }

        private void dirTree_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 0;
        }

        private void dirTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

            DirectoryInfo directory = new DirectoryInfo(e.Node.Tag.ToString());
            foreach (var file in directory.GetFiles())
            {
                fileList.Items.Clear();
                ListViewItem item = new ListViewItem(file.Name);
                item.SubItems.Add(file.Extension);
                item.SubItems.Add(file.CreationTime.ToString());
                fileList.Items.Add(item);
            }

            //fileList.Items.Add();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fileList.View = View.List;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            fileList.View = View.Tile;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (fileList.View != View.Details)
            {
                fileList.View = View.Details;
                fileList.Columns.Add("Name").Width = 300;
                fileList.Columns.Add("Extencion", 300);
                fileList.Columns.Add("Create Time", 300);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            fileList.View = View.LargeIcon;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            fileList.View = View.SmallIcon;
        }
    }
}