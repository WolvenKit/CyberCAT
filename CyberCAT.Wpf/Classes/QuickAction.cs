using CyberCAT.Core.Classes;
using IronPython.Hosting;
using IronPython.Runtime;
using Microsoft.CodeAnalysis;
using Microsoft.Scripting.Hosting;
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
        public string Icon { get; set; }
        public string Description { get; set; }
        public string SuccessMessage { get; set; }
        public List<QuickActionArgument> Arguments {get;set;}

        public QuickAction()
        {
            Arguments = new List<QuickActionArgument>();
        }
        public void Execute(SaveFile saveFile, string folderPath)
        {
            ScriptEngine engine = Python.CreateEngine();
            ScriptScope scope = engine.CreateScope();
            scope.SetVariable("saveFile", saveFile);
            engine.Execute("import clr", scope);
            engine.Execute("clr.AddReference(\"System.Core\")", scope);
            engine.Execute("from System.Collections.Generic import List", scope);
            engine.Execute("import System", scope);
            engine.Execute("clr.ImportExtensions(System.Linq)", scope);
            engine.Execute("reload = None", scope);
            engine.ExecuteFile(Path.Combine(folderPath, "script.py"), scope);
        }
    }
}
