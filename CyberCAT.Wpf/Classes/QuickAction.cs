using CyberCAT.Core.Classes;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using System.Text;

namespace CyberCAT.Wpf.Classes
{
    public class QuickAction
    {
        public string DisplayName { get; set; }
        public string ClassName { get; set; }
        public string Icon { get; set; }
        public string Script { get; set; }
        private object _instance;
        private MethodInfo _methodInfo;
        public void CompileScript(SaveFile saveFile)
        {
            SyntaxTree syntaxTree = CSharpSyntaxTree.ParseText(Script);

            string assemblyName = Path.GetRandomFileName();
            var refPaths = new[] {
                typeof(System.Object).GetTypeInfo().Assembly.Location,
                typeof(SaveFile).GetTypeInfo().Assembly.Location,
                Path.Combine(Path.GetDirectoryName(typeof(System.Runtime.GCSettings).GetTypeInfo().Assembly.Location), "System.Runtime.dll"),
                Path.Combine(Path.GetDirectoryName(typeof(System.Runtime.GCSettings).GetTypeInfo().Assembly.Location), "System.Linq.dll"),
                Path.Combine(Path.GetDirectoryName(typeof(System.Runtime.GCSettings).GetTypeInfo().Assembly.Location), "netstandard.dll"),
                Path.Combine(Path.GetDirectoryName(typeof(System.Runtime.GCSettings).GetTypeInfo().Assembly.Location), "System.Collections.dll"),
                Path.Combine(Path.GetDirectoryName(typeof(System.Runtime.GCSettings).GetTypeInfo().Assembly.Location), "System.ObjectModel.dll")
            };

            MetadataReference[] references = refPaths.Select(r => MetadataReference.CreateFromFile(r)).ToArray();
            CSharpCompilation compilation = CSharpCompilation.Create(
                assemblyName,
                syntaxTrees: new[] { syntaxTree },
                references: references,
                options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

            using (var ms = new MemoryStream())
            {
                EmitResult result = compilation.Emit(ms);

                if (!result.Success)
                {
                    IEnumerable<Diagnostic> failures = result.Diagnostics.Where(diagnostic =>
                        diagnostic.IsWarningAsError ||
                        diagnostic.Severity == DiagnosticSeverity.Error);

                    foreach (Diagnostic diagnostic in failures)
                    {
                        Console.Error.WriteLine("\t{0}: {1}", diagnostic.Id, diagnostic.GetMessage());
                    }
                }
                else
                {
                    ms.Seek(0, SeekOrigin.Begin);

                    Assembly assembly = AssemblyLoadContext.Default.LoadFromStream(ms);
                    var type = assembly.GetType(ClassName);
                    _instance = assembly.CreateInstance(ClassName);
                    _methodInfo = type.GetMember("Execute").First() as MethodInfo;
                    
                }
            }
        }
        public void Execute(SaveFile saveFile)
        {
            
            _methodInfo.Invoke(_instance, new[] { saveFile });
        }
    }
}
