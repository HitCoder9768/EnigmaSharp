using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScintillaNET;
using System.IO;

namespace EnigmaSharp
{
    class EnigmaScintillaLexer
    {
        public const int StyleDefault = 0;
        public const int StyleString = 1;
        public const int StyleNumber = 2;
        public const int StyleConstructor = 3;
        public const int StyleOperator = 4;
        public const int StyleVariable = 5;
        public const int StyleConstant = 6;
        public const int StyleFunction = 7;

        private const int STATE_UNKNOWN = 0;
        private const int STATE_IDENTIFIER = 1;
        private const int STATE_NUMBER = 2;
        private const int STATE_STRING = 3;

        private HashSet<string> _Constants, _Constructors, _Operators, _Variables, _Functions;

        public void Style(Scintilla scintilla, int startPos, int endPos)
        {
            // Go to the start
            int line = scintilla.LineFromPosition(startPos);
            startPos = scintilla.Lines[line].Position;

            int length = 0;
            int state = STATE_UNKNOWN;

            // okay so we've configured all that, time to start the styling process
            scintilla.StartStyling(startPos);
            // Iterate until we hit the end of the code.
            while (startPos < endPos)
            {
                // cast getchar at from int to char so we know what the next character is
                char c = (char)scintilla.GetCharAt(startPos);

                REPROCESS:
                switch (state)
                {
                    case STATE_UNKNOWN:
                        if (c == '"')
                        {
                            scintilla.SetStyling(1, StyleString);
                            state = STATE_STRING;
                        }
                        else if (Char.IsDigit(c))
                        {
                            state = STATE_NUMBER;
                            goto REPROCESS;
                        }
                        else if (Char.IsLetter(c) || c == '_')
                        {
                            state = STATE_IDENTIFIER;
                            goto REPROCESS;
                        }
                        else
                        {
                            scintilla.SetStyling(1, StyleDefault);
                        }
                        break;
                    case STATE_STRING:
                        if (c == '"')
                        {
                            length++;
                            scintilla.SetStyling(length, StyleString);
                            length = 0;
                            state = STATE_UNKNOWN;
                        }
                        else
                        {
                            length++;
                        }
                        break;
                    case STATE_NUMBER:
                        // check if character is a number
                        if (Char.IsDigit(c))
                        {
                            length++;
                        }
                        else
                        {
                            scintilla.SetStyling(length, StyleNumber);
                            length = 0;
                            state = STATE_UNKNOWN;
                            goto REPROCESS;
                        }
                        break;
                    case STATE_IDENTIFIER:
                        if (Char.IsLetterOrDigit(c) || c=='_')
                        {
                            length++;
                        }
                        else
                        {
                            var style = StyleDefault;
                            var identifier = scintilla.GetTextRange(startPos - length, length);
                            Console.WriteLine("Identifier: " + identifier);
                            Console.WriteLine(_Constants.First());
                            if (_Constants.Contains(identifier))
                                style = StyleConstant;
                            if (_Constructors.Contains(identifier))
                                style = StyleConstructor;
                            if (_Operators.Contains(identifier))
                                style = StyleOperator;
                            if (_Variables.Contains(identifier))
                                style = StyleVariable;
                            if (_Functions.Contains(identifier))
                                style = StyleFunction;

                            scintilla.SetStyling(length, style);
                            length = 0;
                            state = STATE_UNKNOWN;
                            goto REPROCESS;
                        }
                        break;
                }
                startPos++;
            }
        }

        public EnigmaScintillaLexer(HashSet<string>[] Parts)
        {
            // Load constants
            _Constants = Parts[0];
            // Load constructors
            _Constructors = Parts[1];
            // Load variables
            _Variables = Parts[2];
            // Load operators
            _Operators = Parts[3];
            // Load functions
            _Functions = Parts[4];
        }
    }
}
