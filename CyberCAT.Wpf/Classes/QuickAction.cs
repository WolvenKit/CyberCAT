using CyberCAT.Core.Classes;
using IronPython.Hosting;
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
        public string Icon {get; set;}
        public string ScriptPath { get; set;}
        public string Description {get; set;}
        public void Execute(SaveFile saveFile)
        {

            ScriptEngine engine = Python.CreateEngine();
            ScriptScope scope = engine.CreateScope();
            SaveFile file = new SaveFile();
            scope.SetVariable("saveFile", saveFile);
            engine.ExecuteFile(Path.Combine("QuickActions",ScriptPath), scope);
        }
    }
}
