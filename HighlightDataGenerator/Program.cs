using System;
using System.Collections.Generic;
using System.IO;

namespace HighlightDataGenerator
{
    public partial class Program
    {
        /// <summary>
        /// Program exit codes.
        /// </summary>
        public enum ExitCode : int
        {
            Success = 0,
            MissingArguments = 1,
            InvalidArguments = 2,
            MissingFiles = 3
        }

        /// <summary>
        /// The directory where the lexer files can be found.
        /// </summary>
        public static string LexerDirectory;

        /// <summary>
        /// The directory to write SyntaxHighlightData.cs to.
        /// </summary>
        public static string OutputDirectory;

        /// <summary>
        /// The data read from each file.
        /// </summary>
        public static HashSet<string>[] LexerData = new HashSet<string>[5];

        /// <summary>
        /// The parameters for each function.
        /// </summary>
        public static Dictionary<string, List<HashSet<string>>> FunctionParameters;

        /// <summary>
        /// Main program entry point.
        /// </summary>
        /// <param name="args">Arguments supplied by the command line.</param>
        /// <returns>The exit code.</returns>
        public static int Main(string[] args)
        {
#if DEBUG
            // We're in debug mode, supply arguments
            if (args.Length == 0)
            {
                args = new string[]
                {
                   @"../../../EnigmaSharp/Lexer",
                   @"../../../EnigmaSharp/"
                };
            }
#endif
            // Do we have enough arguments?
            if (args.Length != 2)
            {
                Console.WriteLine("usage: HighlightDataGenerator.exe <lexer-directory> <output-directory>");
                return (int)ExitCode.MissingArguments;
            }

            // Arguments
            LexerDirectory = Path.GetFullPath(args[0]);
            OutputDirectory = Path.GetFullPath(args[1]);

            // Do these directories exist?
            if (!Directory.Exists(LexerDirectory))
            {
                Console.WriteLine("Specified lexer directory does not exist.");
                return (int)ExitCode.InvalidArguments;
            }

            if (!Directory.Exists(OutputDirectory))
            {
                Console.WriteLine("Specified output directory does not exist.");
                return (int)ExitCode.InvalidArguments;
            }

            // Go through each lexer file
            for (int i = 0; i < RequiredLexerFiles.Length; i++)
            {
                // Check if the file exists
                string file = RequiredLexerFiles[i];
                if (!File.Exists(Path.Combine(LexerDirectory, file)))
                {
                    Console.WriteLine("Required file missing in lexer directory: {0}", file);
                    return (int)ExitCode.MissingFiles;
                }

                // Read the file
                Read(i);
            }

            // Generate the file
            Generate();

            // We successfully generated the file
            return (int)ExitCode.Success;
        }

        /// <summary>
        /// Reads the specified lexer file.
        /// </summary>
        /// <param name="fileIndex">The index of the filename inside RequiredLexerFiles.</param>
        /// <returns>Whether reading was successfully completed.</returns>
        public static void Read(int fileIndex)
        {
            // Create the hash set for this file
            LexerData[fileIndex] = new HashSet<string>();

            // Is this the functions file?
            if (fileIndex == Functions)
            {
                ReadFunctions();
                return;
            }

            // Read the lines in the file
            string filename = RequiredLexerFiles[fileIndex];
            string[] lines = File.ReadAllLines(Path.Combine(LexerDirectory, filename));
            foreach (string line in lines)
            {
                // Split the line by space
                string[] items = line.Split(' ');
                foreach (string item in items)
                    LexerData[fileIndex].Add(item);
            }
        }

        /// <summary>
        /// Reads the functions lexer file.
        /// </summary>
        /// <returns>Whether reading was successfully completed.</returns>
        public static void ReadFunctions()
        {
            // Create the parameters dictionary
            FunctionParameters = new Dictionary<string, List<HashSet<string>>>();

            // Read the lines in the file
            string filename = RequiredLexerFiles[Functions];
            string[] lines = File.ReadAllLines(Path.Combine(LexerDirectory, filename));
            int i = 0;
            while (i < lines.Length)
            {
                // Skip the empty line
                if (lines[i] == "")
                    i++;

                // Read the function name and parameters
                string name = lines[i++];
                string[] parameters = lines[i++].Split(',');

                // Are there parameters?
                if (parameters.Length >= 1)
                {
                    // Remove the 'none' parameter
                    if (parameters[0] == "none")
                        parameters = new string[0];
                }

                // Is this a new function name?
                if (!LexerData[Functions].Contains(name))
                {
                    // Add this function name to the data
                    LexerData[Functions].Add(name);
                    FunctionParameters.Add(name, new List<HashSet<string>>());
                }

                // Add the parameters data
                HashSet<string> callParameters = new HashSet<string>();
                foreach (string parameter in parameters)
                    callParameters.Add(parameter);
                FunctionParameters[name].Add(callParameters);
            }
        }

        /// <summary>
        /// Generates the SyntaxHighlightData.cs file.
        /// </summary>
        public static void Generate()
        {
            // Start off with the template code
            string contents = Template;

            // Go through each of the data sets
            for (int i = 0; i < LexerData.Length; i++)
            {
                // Generate simple string literal code for each item
                string code = "";
                foreach (string item in LexerData[i])
                    code += "\t\t\t\"" + item + "\",\n";

                // Replace the appropriate string with the code
                contents = contents.Replace(TemplateReplaceStrings[i], code);
            }

            // Go through the function parameters
            string parametersCode = "";
            foreach (string name in LexerData[Functions])
            {
                parametersCode += "\t\t\t{\n";
                parametersCode += "\t\t\t\t\"" + name + "\",\n";
                parametersCode += "\t\t\t\t" + "new string[][]" + "\n";
                parametersCode += "\t\t\t\t{\n";

                foreach (var function in FunctionParameters[name])
                {
                    parametersCode += "\t\t\t\t\tnew string[] {\n";
                    foreach (var parameter in function)
                        parametersCode += "\t\t\t\t\t\t\"" + parameter + "\",\n";
                    parametersCode += "\t\t\t\t\t},\n";
                }

                parametersCode += "\t\t\t\t}\n";
                parametersCode += "\t\t\t},\n";
            }

            // Replace the parameters string with the code
            contents = contents.Replace(TemplateReplaceStrings[Parameters], parametersCode);

            // Write the contents to the file
            File.WriteAllText(Path.Combine(OutputDirectory, "SyntaxHighlightData.cs"), contents);
        }
    }
}
