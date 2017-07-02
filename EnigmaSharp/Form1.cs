using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaSharp
{
    public partial class Form1 : Form
    {
        List<Script> LocalScripts = new List<Script>();
        public Form1()
        {
            InitializeComponent();
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
            newScript.SetName("Script"+ScriptNumber);
            LocalScripts.Add(newScript);
            ResourcesTreeView.Nodes[4].Nodes.Add(newScript.Name);
            ResourcesTreeView.Nodes[4].Nodes[ScriptNumber].ImageIndex = 1; ResourcesTreeView.Nodes[4].Nodes[ScriptNumber].SelectedImageIndex = 1;
            ResourcesTreeView.Nodes[4].Expand();
            OpenScriptEditor(LocalScripts[ScriptNumber],ResourcesTreeView.Nodes[4].Nodes[ScriptNumber]);
        }

        private void OpenScriptEditor(Script PassedScript, TreeNode Node)
        {
            TabPage t = new TabPage();
            t.Text = PassedScript.Name;
            ScriptEditor newEditor = new ScriptEditor(PassedScript,Node);
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
    }
}
