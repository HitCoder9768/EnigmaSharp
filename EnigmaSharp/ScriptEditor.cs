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
        private HashSet<string>[] _LexerElements = new HashSet<string>[5];
        private EnigmaScintillaLexer _lexer;
        public ScriptEditor(Script passedScript, TreeNode passedNode, HashSet<string>[] _LexerData)
        {
            editorScript = passedScript;
            _node = passedNode;
            InitializeComponent();
            NameTextBox.Text = passedScript.Name;
            CodeEditorScintilla.Text = passedScript.Content;
            _LexerElements = _LexerData;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            editorScript.Name = NameTextBox.Text;
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
            // set styling
            CodeEditorScintilla.StyleResetDefault();
            for (int i = 0; i <= 7; i++)
            {
                CodeEditorScintilla.Styles[i].Font = "Consolas";
                CodeEditorScintilla.Styles[i].Size = 10;
            }
            

            // lexer-specific
            CodeEditorScintilla.Styles[EnigmaScintillaLexer.StyleDefault].ForeColor = Color.Black;
            CodeEditorScintilla.Styles[EnigmaScintillaLexer.StyleConstructor].ForeColor = Color.Blue;
            CodeEditorScintilla.Styles[EnigmaScintillaLexer.StyleOperator].ForeColor = Color.Blue;
            CodeEditorScintilla.Styles[EnigmaScintillaLexer.StyleVariable].ForeColor = Color.Red;
            CodeEditorScintilla.Styles[EnigmaScintillaLexer.StyleConstant].ForeColor = Color.SandyBrown;
            CodeEditorScintilla.Styles[EnigmaScintillaLexer.StyleFunction].ForeColor = Color.Teal;
            CodeEditorScintilla.Styles[EnigmaScintillaLexer.StyleNumber].ForeColor = Color.Purple;
            CodeEditorScintilla.Styles[EnigmaScintillaLexer.StyleString].ForeColor = Color.Red;

            // configure margins
            CodeEditorScintilla.Margins[0].Width = CodeEditorScintilla.TextWidth(Style.LineNumber, new string('9', Math.Min(CodeEditorScintilla.Lines.Count.ToString().Length,5) + 1)) + 2;
            CodeEditorScintilla.Margins[1].Width = 2;
            Console.WriteLine(CodeEditorScintilla.Margins[1].GetType());
            CodeEditorScintilla.Margins[1].Type = MarginType.Text;
            CodeEditorScintilla.Margins[1].BackColor = (Color)ColorTranslator.FromHtml("#f0f0f0");

            // display line position in status bar
            LineNumberPositionLabel.Text = CodeEditorScintilla.CurrentLine + 1 + "/" + CodeEditorScintilla.Lines.Count + ": " + CodeEditorScintilla.CurrentPosition;
        }

        private void CodeEditorScintilla_TextChanged(object sender, EventArgs e)
        {
            CodeEditorScintilla.Margins[0].Width = CodeEditorScintilla.TextWidth(Style.LineNumber, new string('9', Math.Min(CodeEditorScintilla.Lines.Count.ToString().Length, 5) + 1)) + 2;
            CodeEditorScintilla.Lines[CodeEditorScintilla.CurrentLine].MarginText = "|";
            CodeEditorScintilla.Margins[1].BackColor = (Color)ColorTranslator.FromHtml("#f0f0f0");
            //CodeEditorScintilla.Lines[CodeEditorScintilla.CurrentLine].MarginStyle = ;
        }

        private void CodeEditorScintilla_UpdateUI(object sender, UpdateUIEventArgs e)
        {
            LineNumberPositionLabel.Text = CodeEditorScintilla.CurrentLine+1 + "/" + CodeEditorScintilla.Lines.Count + ": " + CodeEditorScintilla.CurrentPosition;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            editorScript.Content = CodeEditorScintilla.Text;
            if (Parent.Parent.GetType() == typeof(TabControl))
            {
                TabControl t = (TabControl)Parent.Parent;
                t.TabPages.RemoveAt(t.SelectedIndex);
            }
        }

        private void CodeEditorScintilla_StyleNeeded(object sender, StyleNeededEventArgs e)
        {
            var StartPosition = CodeEditorScintilla.GetEndStyled();
            var EndPosition = e.Position;
            _lexer = new EnigmaScintillaLexer(_LexerElements);
            _lexer.Style(CodeEditorScintilla, StartPosition, EndPosition);
        }
    }
}
