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
        List<Script> LocalScripts;
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
            Script newScript = new Script();
            newScript.SetName("scr_0");
            TabPage t = new TabPage();
            t.Text = newScript.Name;
            ScriptEditor newEditor = new ScriptEditor(newScript);
            newEditor.TopLevel = false;
            newEditor.Parent = t;
            newEditor.Dock = DockStyle.Fill;
            newEditor.Show();
            TabsEditors.TabPages.Add(t);
        }
    }
}
