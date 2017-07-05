using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaSharp
{
    public partial class MainForm : Form
    {
        // Constants for the treeview
        private const int SCRIPTS = 4;
        List<Script> LocalScripts = new List<Script>();
        HashSet<String>[] _LexerData = new HashSet<string>[5];
        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ButtonNewScript.Image = ImageListIcons.Images[1];
        }

        private void ButtonNewScript_Click(object sender, EventArgs e)
        {
            int ScriptNumber;
            ScriptNumber = LocalScripts.Count;
            Script newScript = new Script();
            newScript.Name = "Script"+ScriptNumber;
            LocalScripts.Add(newScript);
            ResourcesTreeView.Nodes[SCRIPTS].Nodes.Add(newScript.Name);
            ResourcesTreeView.Nodes[SCRIPTS].Nodes[ScriptNumber].ImageIndex = 1; ResourcesTreeView.Nodes[SCRIPTS].Nodes[ScriptNumber].SelectedImageIndex = 1;
            ResourcesTreeView.Nodes[SCRIPTS].Expand();
            OpenScriptEditor(LocalScripts[ScriptNumber],ResourcesTreeView.Nodes[SCRIPTS].Nodes[ScriptNumber]);
        }

        private void OpenScriptEditor(Script PassedScript, TreeNode Node)
        {
            TabPage t = new TabPage();
            t.Text = PassedScript.Name;
            ScriptEditor newEditor = new ScriptEditor(PassedScript,Node,_LexerData);
            newEditor.TopLevel = false;
            newEditor.Parent = t;
            newEditor.Dock = DockStyle.Fill;
            newEditor.Show();
            TabsEditors.TabPages.Add(t);
            TabsEditors.SelectedIndex = TabsEditors.TabCount - 1;
        }

        private void ResourcesTreeView_DoubleClick(object sender, EventArgs e)
        {
            // Check if it's under scripts or something
            if(ResourcesTreeView.SelectedNode.Level==1 && ResourcesTreeView.SelectedNode.Parent.Index == 4)
            {
                OpenScriptEditor(LocalScripts[ResourcesTreeView.SelectedNode.Index], ResourcesTreeView.SelectedNode);
            }
        }

        public void LoadData()
        {
            LoadLexerData();
        }

        public void LoadLexerData()
        {
            LexerImporter Importer = new LexerImporter();
            _LexerData = Importer.LoadLexerData();
        }
    }
}
