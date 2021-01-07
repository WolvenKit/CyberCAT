
namespace CyberCAT.Forms.Editor
{
    partial class ItemEditorControl
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
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.partListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statsListBox = new System.Windows.Forms.ListBox();
            this.addStatButton = new System.Windows.Forms.Button();
            this.tmpSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(3, 9);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(54, 13);
            this.itemNameLabel.TabIndex = 0;
            this.itemNameLabel.Text = "itemName";
            // 
            // partListBox
            // 
            this.partListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.partListBox.FormattingEnabled = true;
            this.partListBox.Location = new System.Drawing.Point(6, 51);
            this.partListBox.Name = "partListBox";
            this.partListBox.Size = new System.Drawing.Size(150, 329);
            this.partListBox.TabIndex = 1;
            this.partListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parts";
            // 
            // statsListBox
            // 
            this.statsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statsListBox.FormattingEnabled = true;
            this.statsListBox.Location = new System.Drawing.Point(276, 51);
            this.statsListBox.Name = "statsListBox";
            this.statsListBox.Size = new System.Drawing.Size(207, 303);
            this.statsListBox.TabIndex = 3;
            this.statsListBox.DoubleClick += new System.EventHandler(this.statsListBox_DoubleClick);
            // 
            // addStatButton
            // 
            this.addStatButton.Location = new System.Drawing.Point(408, 357);
            this.addStatButton.Name = "addStatButton";
            this.addStatButton.Size = new System.Drawing.Size(75, 23);
            this.addStatButton.TabIndex = 4;
            this.addStatButton.Text = "Add";
            this.addStatButton.UseVisualStyleBackColor = true;
            this.addStatButton.Click += new System.EventHandler(this.addStatButton_Click);
            // 
            // tmpSave
            // 
            this.tmpSave.Location = new System.Drawing.Point(314, 357);
            this.tmpSave.Name = "tmpSave";
            this.tmpSave.Size = new System.Drawing.Size(88, 22);
            this.tmpSave.TabIndex = 5;
            this.tmpSave.Text = "FIXME: Save";
            this.tmpSave.UseVisualStyleBackColor = true;
            this.tmpSave.Click += new System.EventHandler(this.tmpSave_Click);
            // 
            // ItemEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tmpSave);
            this.Controls.Add(this.addStatButton);
            this.Controls.Add(this.statsListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.partListBox);
            this.Controls.Add(this.itemNameLabel);
            this.Name = "ItemEditorControl";
            this.Size = new System.Drawing.Size(486, 403);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.ListBox partListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox statsListBox;
        private System.Windows.Forms.Button addStatButton;
        private System.Windows.Forms.Button tmpSave;
    }
}
