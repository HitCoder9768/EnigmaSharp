namespace EnigmaSharp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Sprites");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Sounds");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Backgrounds");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Paths");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Scripts");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Shaders");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Fonts");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Timelines");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Objects");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Rooms");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Includes");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Extensions");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Constants");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Game Information");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Game Settings");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Extension Packages");
            this.MenuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMain = new System.Windows.Forms.ToolStrip();
            this.ButtonNewScript = new System.Windows.Forms.ToolStripButton();
            this.ImageListIcons = new System.Windows.Forms.ImageList(this.components);
            this.ResourcesTreeView = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.TabsEditors = new System.Windows.Forms.TabControl();
            this.MenuStripMain.SuspendLayout();
            this.ToolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripMain
            // 
            this.MenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.buildToolStripMenuItem,
            this.editToolStripMenuItem,
            this.resourcesToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuStripMain.Location = new System.Drawing.Point(0, 0);
            this.MenuStripMain.Name = "MenuStripMain";
            this.MenuStripMain.Size = new System.Drawing.Size(613, 24);
            this.MenuStripMain.TabIndex = 0;
            this.MenuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.buildToolStripMenuItem.Text = "Build";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // resourcesToolStripMenuItem
            // 
            this.resourcesToolStripMenuItem.Name = "resourcesToolStripMenuItem";
            this.resourcesToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.resourcesToolStripMenuItem.Text = "Resources";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // ToolStripMain
            // 
            this.ToolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonNewScript});
            this.ToolStripMain.Location = new System.Drawing.Point(0, 24);
            this.ToolStripMain.Name = "ToolStripMain";
            this.ToolStripMain.Size = new System.Drawing.Size(613, 25);
            this.ToolStripMain.TabIndex = 1;
            this.ToolStripMain.Text = "toolStrip1";
            // 
            // ButtonNewScript
            // 
            this.ButtonNewScript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonNewScript.Image = ((System.Drawing.Image)(resources.GetObject("ButtonNewScript.Image")));
            this.ButtonNewScript.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonNewScript.Name = "ButtonNewScript";
            this.ButtonNewScript.Size = new System.Drawing.Size(23, 22);
            this.ButtonNewScript.Text = "toolStripButton1";
            this.ButtonNewScript.Click += new System.EventHandler(this.ButtonNewScript_Click);
            // 
            // ImageListIcons
            // 
            this.ImageListIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListIcons.ImageStream")));
            this.ImageListIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListIcons.Images.SetKeyName(0, "Icon_Folder2_Brown.png");
            this.ImageListIcons.Images.SetKeyName(1, "Icon_Script_CC.png");
            // 
            // ResourcesTreeView
            // 
            this.ResourcesTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.ResourcesTreeView.ImageIndex = 0;
            this.ResourcesTreeView.ImageList = this.ImageListIcons;
            this.ResourcesTreeView.Location = new System.Drawing.Point(0, 49);
            this.ResourcesTreeView.Name = "ResourcesTreeView";
            treeNode1.Name = "NodeSprites";
            treeNode1.Text = "Sprites";
            treeNode2.Name = "NodeSounds";
            treeNode2.Text = "Sounds";
            treeNode3.Name = "NodeBackgrounds";
            treeNode3.Text = "Backgrounds";
            treeNode4.Name = "NodePaths";
            treeNode4.Text = "Paths";
            treeNode5.Name = "NodeScripts";
            treeNode5.Text = "Scripts";
            treeNode6.Name = "NodeShaders";
            treeNode6.Text = "Shaders";
            treeNode7.Name = "NodeFonts";
            treeNode7.Text = "Fonts";
            treeNode8.Name = "NodeTimelines";
            treeNode8.Text = "Timelines";
            treeNode9.Name = "NodeObjects";
            treeNode9.Text = "Objects";
            treeNode10.Name = "NodeRooms";
            treeNode10.Text = "Rooms";
            treeNode11.Name = "NodeIncludes";
            treeNode11.Text = "Includes";
            treeNode12.Name = "NodeExtensions";
            treeNode12.Text = "Extensions";
            treeNode13.Name = "NodeConstants";
            treeNode13.Text = "Constants";
            treeNode14.Name = "NodeGameInfo";
            treeNode14.Text = "Game Information";
            treeNode15.Name = "NodeGameSettings";
            treeNode15.Text = "Game Settings";
            treeNode16.Name = "NodeExtensionPackages";
            treeNode16.Text = "Extension Packages";
            this.ResourcesTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            this.ResourcesTreeView.SelectedImageIndex = 0;
            this.ResourcesTreeView.Size = new System.Drawing.Size(163, 310);
            this.ResourcesTreeView.TabIndex = 3;
            this.ResourcesTreeView.DoubleClick += new System.EventHandler(this.ResourcesTreeView_DoubleClick);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(163, 49);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 310);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // TabsEditors
            // 
            this.TabsEditors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabsEditors.Location = new System.Drawing.Point(166, 49);
            this.TabsEditors.Name = "TabsEditors";
            this.TabsEditors.SelectedIndex = 0;
            this.TabsEditors.Size = new System.Drawing.Size(447, 310);
            this.TabsEditors.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 359);
            this.Controls.Add(this.TabsEditors);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.ResourcesTreeView);
            this.Controls.Add(this.ToolStripMain);
            this.Controls.Add(this.MenuStripMain);
            this.MainMenuStrip = this.MenuStripMain;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStripMain.ResumeLayout(false);
            this.MenuStripMain.PerformLayout();
            this.ToolStripMain.ResumeLayout(false);
            this.ToolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ToolStripMain;
        private System.Windows.Forms.ImageList ImageListIcons;
        private System.Windows.Forms.TreeView ResourcesTreeView;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripButton ButtonNewScript;
        private System.Windows.Forms.TabControl TabsEditors;
    }
}

