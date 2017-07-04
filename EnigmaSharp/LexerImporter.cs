using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaSharp
{
    class LexerImporter
    {
        // Constants for the lexer import
        private const int CONSTANTS = 0;
        private const int CONSTRUCTORS = 1;
        private const int VARIABLES = 2;
        private const int OPERATORS = 3;
        private const int FUNCTIONS = 4;

        private HashSet<String>[] _LexerData = new HashSet<string>[5];

        public HashSet<String>[] LoadLexerData()
        {
            _LexerData[CONSTANTS] = new HashSet<string>();
            _LexerData[CONSTRUCTORS] = new HashSet<string>();
            _LexerData[VARIABLES] = new HashSet<string>();
            _LexerData[OPERATORS] = new HashSet<string>();
            _LexerData[FUNCTIONS] = new HashSet<string>();
            // Load constants
            using (StreamReader reader = new StreamReader("Lexer\\Constants.txt"))
            {
                while (reader.Peek() != -1)
                {
                    string line = reader.ReadLine();
                    string[] items = line.Split(' ');
                    for (int i = 0; i < items.Length; i++)
                    {
                        _LexerData[CONSTANTS].Add(items[i]);
                    }
                }
            }
            // Load constructors
            using (StreamReader reader = new StreamReader("Lexer\\Constructors.txt"))
            {
                while (reader.Peek() != -1)
                {
                    string line = reader.ReadLine();
                    string[] items = line.Split(' ');
                    for (int i = 0; i < items.Length; i++)
                    {
                        _LexerData[CONSTRUCTORS].Add(items[i]);
                    }
                }
            }
            // Load variables
            using (StreamReader reader = new StreamReader("Lexer\\Variables.txt"))
            {
                while (reader.Peek() != -1)
                {
                    string line = reader.ReadLine();
                    string[] items = line.Split(' ');
                    for (int i = 0; i < items.Length; i++)
                    {
                        _LexerData[VARIABLES].Add(items[i]);
                    }
                }
            }
            // Load operators
            using (StreamReader reader = new StreamReader("Lexer\\Operators.txt"))
            {
                while (reader.Peek() != -1)
                {
                    string line = reader.ReadLine();
                    string[] items = line.Split(' ');
                    for (int i = 0; i < items.Length; i++)
                    {
                        _LexerData[OPERATORS].Add(items[i]);
                    }
                }
            }
            // Load functions
            using (StreamReader reader = new StreamReader("Lexer\\Functions.txt"))
            {
                while (reader.Peek() != -1)
                {
                    string line = reader.ReadLine();
                    string[] items = line.Split(' ');
                    for (int i = 0; i < items.Length; i++)
                    {
                        _LexerData[FUNCTIONS].Add(items[i]);
                    }
                    reader.ReadLine(); reader.ReadLine();
                }
            }

            return _LexerData;
        }
    }
}
