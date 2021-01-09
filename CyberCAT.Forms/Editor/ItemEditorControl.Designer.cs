
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
            this.lblItemName = new System.Windows.Forms.Label();
            this.partListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addStatButton = new System.Windows.Forms.Button();
            this.lblGameName = new System.Windows.Forms.Label();
            this.cbQuestItem = new System.Windows.Forms.CheckBox();
            this.cbUnequippable = new System.Windows.Forms.CheckBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.statsSelect = new System.Windows.Forms.ComboBox();
            this.editPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(5, 31);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(63, 13);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "{ItemName}";
            // 
            // partListBox
            // 
            this.partListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.partListBox.Enabled = false;
            this.partListBox.FormattingEnabled = true;
            this.partListBox.Location = new System.Drawing.Point(6, 117);
            this.partListBox.Name = "partListBox";
            this.partListBox.Size = new System.Drawing.Size(245, 290);
            this.partListBox.TabIndex = 1;
            this.partListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parts";
            // 
            // addStatButton
            // 
            this.addStatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addStatButton.Enabled = false;
            this.addStatButton.Location = new System.Drawing.Point(444, 383);
            this.addStatButton.Name = "addStatButton";
            this.addStatButton.Size = new System.Drawing.Size(77, 23);
            this.addStatButton.TabIndex = 4;
            this.addStatButton.Text = "Add";
            this.addStatButton.UseVisualStyleBackColor = true;
            this.addStatButton.Click += new System.EventHandler(this.addStatButton_Click);
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName.Location = new System.Drawing.Point(3, 0);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(145, 26);
            this.lblGameName.TabIndex = 5;
            this.lblGameName.Text = "{GameName}";
            // 
            // cbQuestItem
            // 
            this.cbQuestItem.AutoSize = true;
            this.cbQuestItem.Location = new System.Drawing.Point(8, 56);
            this.cbQuestItem.Name = "cbQuestItem";
            this.cbQuestItem.Size = new System.Drawing.Size(77, 17);
            this.cbQuestItem.TabIndex = 6;
            this.cbQuestItem.Text = "Quest Item";
            this.cbQuestItem.UseVisualStyleBackColor = true;
            this.cbQuestItem.CheckedChanged += new System.EventHandler(this.cbQuestItem_CheckedChanged);
            // 
            // cbUnequippable
            // 
            this.cbUnequippable.AutoSize = true;
            this.cbUnequippable.Location = new System.Drawing.Point(8, 79);
            this.cbUnequippable.Name = "cbUnequippable";
            this.cbUnequippable.Size = new System.Drawing.Size(112, 17);
            this.cbUnequippable.TabIndex = 7;
            this.cbUnequippable.Text = "Not Unequippable";
            this.cbUnequippable.UseVisualStyleBackColor = true;
            this.cbUnequippable.CheckedChanged += new System.EventHandler(this.cbUnequippable_CheckedChanged);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Enabled = false;
            this.nudQuantity.Location = new System.Drawing.Point(180, 78);
            this.nudQuantity.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 20);
            this.nudQuantity.TabIndex = 8;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.ValueChanged += new System.EventHandler(this.nudQuantity_ValueChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(306, 80);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Quantity";
            // 
            // statsSelect
            // 
            this.statsSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statsSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statsSelect.Enabled = false;
            this.statsSelect.FormattingEnabled = true;
            this.statsSelect.Location = new System.Drawing.Point(257, 117);
            this.statsSelect.Name = "statsSelect";
            this.statsSelect.Size = new System.Drawing.Size(264, 21);
            this.statsSelect.TabIndex = 10;
            this.statsSelect.SelectedIndexChanged += new System.EventHandler(this.statsSelect_SelectedIndexChanged);
            // 
            // editPanel
            // 
            this.editPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editPanel.Location = new System.Drawing.Point(257, 144);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(264, 236);
            this.editPanel.TabIndex = 11;
            // 
            // ItemEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.statsSelect);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.cbUnequippable);
            this.Controls.Add(this.cbQuestItem);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.addStatButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.partListBox);
            this.Controls.Add(this.lblItemName);
            this.Name = "ItemEditorControl";
            this.Size = new System.Drawing.Size(524, 427);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.ListBox partListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addStatButton;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.CheckBox cbQuestItem;
        private System.Windows.Forms.CheckBox cbUnequippable;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox statsSelect;
        private System.Windows.Forms.Panel editPanel;
    }
}
