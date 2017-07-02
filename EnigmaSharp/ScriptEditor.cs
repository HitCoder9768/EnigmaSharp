using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScintillaNET;

namespace EnigmaSharp
{
    public partial class ScriptEditor : Form
    {
        public Script editorScript { get; private set; }
        private TreeNode _node;
        public ScriptEditor(Script passedScript, TreeNode passedNode)
        {
            editorScript = passedScript;
            _node = passedNode;
            InitializeComponent();
            NameTextBox.Text = passedScript.Name;
            CodeEditorScintilla.Text = passedScript.Contents;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            editorScript.SetName(NameTextBox.Text);
            if (Parent!=null)
                Parent.Text = NameTextBox.Text;
            _node.Text = NameTextBox.Text;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            if(Parent.Parent.GetType() == typeof(TabControl))
            {
                TabControl t = (TabControl)Parent.Parent;
                t.TabPages.RemoveAt(t.SelectedIndex);
            }
        }

        private void ScriptEditor_Load(object sender, EventArgs e)
        {
            CodeEditorScintilla.StyleResetDefault();
            CodeEditorScintilla.Styles[0].Font = "Consolas";
            CodeEditorScintilla.Styles[0].Size = 11;
            CodeEditorScintilla.Margins[0].Width = CodeEditorScintilla.TextWidth(Style.LineNumber, new string('9', Math.Min(CodeEditorScintilla.Lines.Count.ToString().Length,5) + 1)) + 2;
            CodeEditorScintilla.Margins[1].Width = 0;
            LineNumberPositionLabel.Text = CodeEditorScintilla.CurrentLine + 1 + "/" + CodeEditorScintilla.Lines.Count + ": " + CodeEditorScintilla.CurrentPosition;
        }

        private void CodeEditorScintilla_TextChanged(object sender, EventArgs e)
        {
            CodeEditorScintilla.Margins[0].Width = CodeEditorScintilla.TextWidth(Style.LineNumber, new string('9', Math.Min(CodeEditorScintilla.Lines.Count.ToString().Length, 5) + 1)) + 2;
        }

        private void CodeEditorScintilla_UpdateUI(object sender, UpdateUIEventArgs e)
        {
            LineNumberPositionLabel.Text = CodeEditorScintilla.CurrentLine+1 + "/" + CodeEditorScintilla.Lines.Count + ": " + CodeEditorScintilla.CurrentPosition;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            editorScript.SetContents(CodeEditorScintilla.Text);
            if (Parent.Parent.GetType() == typeof(TabControl))
            {
                TabControl t = (TabControl)Parent.Parent;
                t.TabPages.RemoveAt(t.SelectedIndex);
            }
        }
    }
}
