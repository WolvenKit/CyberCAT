namespace CyberCAT.Forms.Editor
{
    partial class CharacterCustomizationControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tppList = new System.Windows.Forms.ListView();
            this.columnHash = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // tppList
            // 
            this.tppList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHash,
            this.columnKey,
            this.columnValue});
            this.tppList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tppList.HideSelection = false;
            this.tppList.Location = new System.Drawing.Point(0, 0);
            this.tppList.MultiSelect = false;
            this.tppList.Name = "tppList";
            this.tppList.Size = new System.Drawing.Size(771, 540);
            this.tppList.TabIndex = 1;
            this.tppList.UseCompatibleStateImageBehavior = false;
            this.tppList.View = System.Windows.Forms.View.Details;
            // 
            // columnHash
            // 
            this.columnHash.Text = "Hash";
            // 
            // columnKey
            // 
            this.columnKey.Text = "Key";
            // 
            // columnValue
            // 
            this.columnValue.Text = "Value";
            // 
            // CharacterCustomizationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tppList);
            this.Name = "CharacterCustomizationControl";
            this.Size = new System.Drawing.Size(771, 540);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView tppList;
        private System.Windows.Forms.ColumnHeader columnHash;
        private System.Windows.Forms.ColumnHeader columnKey;
        private System.Windows.Forms.ColumnHeader columnValue;
    }
}
