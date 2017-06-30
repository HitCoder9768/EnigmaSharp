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
    public partial class ScriptEditor : Form
    {
        Script editorScript = new Script();
        public ScriptEditor(Script passedScript)
        {
            InitializeComponent();
            TextBoxName.Text = passedScript.Name;
            TextBoxBody.Text = passedScript.Contents;
            editorScript.SetName(passedScript.Name);
        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            editorScript.SetName(TextBoxName.Text);
            if (Parent!=null)
                Parent.Text = TextBoxName.Text;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            if(Parent.Parent.GetType() == typeof(TabControl))
            {
                TabControl t = (TabControl)Parent.Parent;
                t.TabPages.RemoveAt(t.SelectedIndex);
            }
        }
    }
}
