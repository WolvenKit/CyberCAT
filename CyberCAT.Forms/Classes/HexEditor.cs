using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace CyberCAT.Forms.Classes
{
    class HexEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value)
        {
            if (!(value is byte[]))
            {
                return value;
            }
            // Uses the IWindowsFormsEditorService to display a
            // drop-down UI in the Properties window.
            IWindowsFormsEditorService edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
            if (edSvc != null)
            {
                // Display an angle selection control and retrieve the value.
                var editor = new HexEditorForm((byte[])value);
                if (edSvc.ShowDialog(editor) == DialogResult.OK)
                {
                    return editor.Data;
                }
            }
            return value;
        }
    }
}
