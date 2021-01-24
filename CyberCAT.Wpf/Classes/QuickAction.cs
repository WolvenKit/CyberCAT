using CyberCAT.Core.Classes;
using CyberCAT.Core.Classes.NodeRepresentations;
using Microsoft.ClearScript;
using Microsoft.ClearScript.V8;
using Microsoft.CodeAnalysis;
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
            using (var engine = new V8ScriptEngine())
            {
                engine.DocumentSettings.AccessFlags = DocumentAccessFlags.EnableFileLoading;
                engine.AddHostObject("lib", new HostTypeCollection(typeof(SaveFile).Assembly));
                engine.AddHostObject("nodes", saveFile.Nodes);
                engine.AddHostObject("host", new HostFunctions());
                engine.AddHostType(typeof(Enumerable));
                engine.AddHostType(typeof(EnumerableExtensions));
                engine.ExecuteDocument(Path.Combine(folderPath, "script.js"));
                var eddies = engine.Script.eddies;
                var quantity = engine.Script.quantity;
            }
        }
    }
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> where<T>(this IEnumerable<T> source, dynamic pred)
        {
            return source.Where(item => Convert.ToBoolean(pred(item)));
        }
    }
}
