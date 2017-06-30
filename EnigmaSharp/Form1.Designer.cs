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
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Sprites");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Sounds");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Backgrounds");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Paths");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Scripts");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Shaders");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Fonts");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Timelines");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Objects");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Rooms");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Includes");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Extensions");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Constants");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Game Information");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Game Settings");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Extension Packages");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMain = new System.Windows.Forms.ToolStrip();
            this.ImageListIcons = new System.Windows.Forms.ImageList(this.components);
            this.TreeViewResources = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ButtonNewScript = new System.Windows.Forms.ToolStripButton();
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
            this.MenuStripMain.Size = new System.Drawing.Size(517, 24);
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
            this.ToolStripMain.Size = new System.Drawing.Size(517, 25);
            this.ToolStripMain.TabIndex = 1;
            this.ToolStripMain.Text = "toolStrip1";
            // 
            // ImageListIcons
            // 
            this.ImageListIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListIcons.ImageStream")));
            this.ImageListIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListIcons.Images.SetKeyName(0, "Icon_Folder2_Brown.png");
            this.ImageListIcons.Images.SetKeyName(1, "Icon_Script_CC.png");
            // 
            // TreeViewResources
            // 
            this.TreeViewResources.Dock = System.Windows.Forms.DockStyle.Left;
            this.TreeViewResources.ImageIndex = 0;
            this.TreeViewResources.ImageList = this.ImageListIcons;
            this.TreeViewResources.Location = new System.Drawing.Point(0, 49);
            this.TreeViewResources.Name = "TreeViewResources";
            treeNode17.Name = "NodeSprites";
            treeNode17.Text = "Sprites";
            treeNode18.Name = "NodeSounds";
            treeNode18.Text = "Sounds";
            treeNode19.Name = "NodeBackgrounds";
            treeNode19.Text = "Backgrounds";
            treeNode20.Name = "NodePaths";
            treeNode20.Text = "Paths";
            treeNode21.Name = "NodeScripts";
            treeNode21.Text = "Scripts";
            treeNode22.Name = "NodeShaders";
            treeNode22.Text = "Shaders";
            treeNode23.Name = "NodeFonts";
            treeNode23.Text = "Fonts";
            treeNode24.Name = "NodeTimelines";
            treeNode24.Text = "Timelines";
            treeNode25.Name = "NodeObjects";
            treeNode25.Text = "Objects";
            treeNode26.Name = "NodeRooms";
            treeNode26.Text = "Rooms";
            treeNode27.Name = "NodeIncludes";
            treeNode27.Text = "Includes";
            treeNode28.Name = "NodeExtensions";
            treeNode28.Text = "Extensions";
            treeNode29.Name = "NodeConstants";
            treeNode29.Text = "Constants";
            treeNode30.Name = "NodeGameInfo";
            treeNode30.Text = "Game Information";
            treeNode31.Name = "NodeGameSettings";
            treeNode31.Text = "Game Settings";
            treeNode32.Name = "NodeExtensionPackages";
            treeNode32.Text = "Extension Packages";
            this.TreeViewResources.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31,
            treeNode32});
            this.TreeViewResources.SelectedImageIndex = 0;
            this.TreeViewResources.Size = new System.Drawing.Size(163, 272);
            this.TreeViewResources.TabIndex = 3;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(163, 49);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 272);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
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
            // TabsEditors
            // 
            this.TabsEditors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabsEditors.Location = new System.Drawing.Point(166, 49);
            this.TabsEditors.Name = "TabsEditors";
            this.TabsEditors.SelectedIndex = 0;
            this.TabsEditors.Size = new System.Drawing.Size(351, 272);
            this.TabsEditors.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 321);
            this.Controls.Add(this.TabsEditors);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.TreeViewResources);
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
        private System.Windows.Forms.TreeView TreeViewResources;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripButton ButtonNewScript;
        private System.Windows.Forms.TabControl TabsEditors;
    }
}

