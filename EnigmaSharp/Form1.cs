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
    public partial class Form1 : Form
    {
        List<Script> LocalScripts = new List<Script>();
        HashSet<String>[] _LexerData = new HashSet<string>[5];
        public Form1()
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
            _LexerData[0] = new HashSet<string>();
            _LexerData[1] = new HashSet<string>();
            _LexerData[2] = new HashSet<string>();
            _LexerData[3] = new HashSet<string>();
            _LexerData[4] = new HashSet<string>();
            StreamReader reader;
            // Load constants
            reader = new StreamReader("Lexer\\Constants.txt");
            while (reader.Peek() != -1)
            {
                string line = reader.ReadLine();
                string[] items = line.Split(' ');
                for (int i = 0; i < items.Length; i++)
                {
                    _LexerData[0].Add(items[i]);
                }
            }
            // Load constructors
            reader = new StreamReader("Lexer\\Constructors.txt");
            while (reader.Peek() != -1)
            {
                string line = reader.ReadLine();
                for (int i = 0; i < line.Split(' ').Length; i++)
                {
                    _LexerData[1].Add(line.Split(' ')[i]);
                }
            }
            // Load variables

            reader = new StreamReader("Lexer\\Variables.txt");
            while (reader.Peek() != -1)
            {
                string line = reader.ReadLine();
                for (int i = 0; i < line.Split(' ').Length; i++)
                {
                    _LexerData[2].Add(line.Split(' ')[i]);
                }
            }
            // Load operators
            reader = new StreamReader("Lexer\\Operators.txt");
            while (reader.Peek() != -1)
            {
                string line = reader.ReadLine();
                for (int i = 0; i < line.Split(' ').Length; i++)
                {
                    _LexerData[3].Add(line.Split(' ')[i]);
                }
            }
            // Load functions
            reader = new StreamReader("Lexer\\Functions.txt");
            while (reader.Peek() != -1)
            {
                string line = reader.ReadLine();
                for (int i = 0; i < line.Split(' ').Length; i++)
                {
                    _LexerData[4].Add(line.Split(' ')[i]);
                }
                reader.ReadLine(); reader.ReadLine();
            }
        }
    }
}
