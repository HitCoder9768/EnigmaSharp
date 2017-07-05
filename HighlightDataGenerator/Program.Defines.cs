namespace HighlightDataGenerator
{
    public partial class Program
    {
        /// <summary>
        /// The lexer files that are required to successfully generate
        /// the highlight data.
        /// </summary>
        public static readonly string[] RequiredLexerFiles =
        {
            "constants.txt",
            "constructs.txt",
            "functions.txt",
            "operators.txt",
            "variables.txt"
        };

        /// <summary>
        /// The constants file index in RequiredLexerFiles.
        /// </summary>
        public const int Constants = 0;

        /// <summary>
        /// The constructs file index in RequiredLexerFiles.
        /// </summary>
        public const int Constructs = 1;

        /// <summary>
        /// The functions file index in RequiredLexerFiles.
        /// </summary>
        public const int Functions = 2;

        /// <summary>
        /// The operators file index in RequiredLexerFiles.
        /// </summary>
        public const int Operators = 3;

        /// <summary>
        /// The variables file index in RequiredLexerFiles.
        /// </summary>
        public const int Variables = 4;

        /// <summary>
        /// The template for the generated SyntaxHighlightData.cs file.
        /// </summary>
        public static readonly string Template = @"
using System.Collections.Generic;

namespace EnigmaSharp
{
    public static class SyntaxHighlightData
    {
        public static readonly HashSet<string> Constants = new HashSet<string>
        {
CONSTANTS_DATA
        };

        public static readonly HashSet<string> Constructs = new HashSet<string>
        {
CONSTRUCTS_DATA
        };

        public static readonly HashSet<string> Variables = new HashSet<string>
        {
VARIABLES_DATA
        };

        public static readonly HashSet<string> Operators = new HashSet<string>
        {
OPERATORS_DATA
        };

        public static readonly HashSet<string> Functions = new HashSet<string>
        {
FUNCTIONS_DATA
        };

        public static readonly Dictionary<string, string[][]> Parameters = new Dictionary<string, string[][]>
        {
PARAMETERS_DATA
        };
    }
}";
        /// <summary>
        /// Strings inside the template that should be replaced with real code.
        /// </summary>
        public static readonly string[] TemplateReplaceStrings =
        {
            "CONSTANTS_DATA",
            "CONSTRUCTS_DATA",
            "VARIABLES_DATA",
            "OPERATORS_DATA",
            "FUNCTIONS_DATA",
            "PARAMETERS_DATA"
        };

        /// <summary>
        /// The parameters index in TemplateReplaceStrings.
        /// </summary>
        public const int Parameters = 5;
    }
}
