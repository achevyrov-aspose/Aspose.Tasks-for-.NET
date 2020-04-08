﻿namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.IO;
    using System.Reflection;

    public class ApiExampleBase
    {
        static ApiExampleBase()
        {
            CodeBaseDir = GetCodeBaseDir(Assembly.GetExecutingAssembly());
            DataDir = new Uri(new Uri(CodeBaseDir), @"Data/").LocalPath;
            OutDir = new Uri(new Uri(CodeBaseDir), @"Data/Out/").LocalPath;
            
            var l = new License();
            l.SetLicense(@"C:\Users\HOME\Source\Repos\aspose-tasks-net\aspose-tasks-testdata\testdata\Aspose.Tasks.lic");
        }

        /// <summary>
        /// Returns the code-base directory.
        /// </summary>
        private static string GetCodeBaseDir(Assembly assembly)
        {
            // CodeBase is a full URI
            var uri = new Uri(assembly.CodeBase);
            var mainFolder = Path.GetDirectoryName(uri.LocalPath)
                ?.Substring(0, uri.LocalPath.IndexOf("CSharp", StringComparison.Ordinal));
            return mainFolder;
        }

        /// <summary>
        /// Gets the path to the codebase directory.
        /// </summary>
        private static string CodeBaseDir { get; }

        /// <summary>
        /// Gets the path to the documents used by the code examples. Ends with a back slash.
        /// </summary>
        internal static string DataDir { get; }

        /// <summary>
        /// Gets the path to the output documents generated by the code examples. Ends with a back slash.
        /// </summary>
        internal static string OutDir { get; }
    }
}