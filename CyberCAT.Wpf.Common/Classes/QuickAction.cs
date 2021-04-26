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

namespace CyberCAT.Wpf.Common.Classes
{
    public class QuickAction
    {
        public string DisplayName { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public string SuccessMessage { get; set; }
        public List<QuickActionArgument> Arguments {get;set;}
        private static V8ScriptEngine _engine;
        public QuickAction()
        {
            Arguments = new List<QuickActionArgument>();
        }
        public void Execute(SaveFile saveFile, string folderPath, bool debuggingEnabled, int debuggingPort)
        {
            V8ScriptEngineFlags flag;
            if (debuggingEnabled)
            {
                flag = V8ScriptEngineFlags.EnableDebugging;
            }
            else
            {
                flag = V8ScriptEngineFlags.None;
            }
            if (_engine == null)
            {
                _engine = new V8ScriptEngine(flag, debuggingPort);
            }
            _engine.DocumentSettings.AccessFlags = DocumentAccessFlags.EnableFileLoading;
            _engine.AddHostObject("lib", new HostTypeCollection(typeof(SaveFile).Assembly));
            _engine.AddHostObject("nodes", saveFile.Nodes);
            _engine.AddHostObject("host", new HostFunctions());
            _engine.AddHostType(typeof(Enumerable));
            _engine.AddHostType(typeof(EnumerableExtensions));
            _engine.ExecuteDocument(Path.Combine(folderPath, "script.js"));
        }
        public static void ResetEngine()
        {
            _engine = null;
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
