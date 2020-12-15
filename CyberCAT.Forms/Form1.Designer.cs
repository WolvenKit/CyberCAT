namespace CyberCAT.Forms
{
    partial class Form1
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.recompressFilePathTextbox = new System.Windows.Forms.TextBox();
            this.recompressButton = new System.Windows.Forms.Button();
            this.uncompressFilePathTextbox = new System.Windows.Forms.TextBox();
            this.uncompressButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metaInformationFilePathTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.metaInformationFilePathTextbox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.recompressFilePathTextbox);
            this.tabPage1.Controls.Add(this.recompressButton);
            this.tabPage1.Controls.Add(this.uncompressFilePathTextbox);
            this.tabPage1.Controls.Add(this.uncompressButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // recompressFilePathTextbox
            // 
            this.recompressFilePathTextbox.AllowDrop = true;
            this.recompressFilePathTextbox.Location = new System.Drawing.Point(6, 90);
            this.recompressFilePathTextbox.Name = "recompressFilePathTextbox";
            this.recompressFilePathTextbox.Size = new System.Drawing.Size(407, 20);
            this.recompressFilePathTextbox.TabIndex = 4;
            this.recompressFilePathTextbox.DragDrop += new System.Windows.Forms.DragEventHandler(this.recompressFilePathTextbox_DragDrop);
            this.recompressFilePathTextbox.DragEnter += new System.Windows.Forms.DragEventHandler(this.recompressFilePathTextbox_DragEnter);
            // 
            // recompressButton
            // 
            this.recompressButton.Location = new System.Drawing.Point(419, 129);
            this.recompressButton.Name = "recompressButton";
            this.recompressButton.Size = new System.Drawing.Size(75, 23);
            this.recompressButton.TabIndex = 3;
            this.recompressButton.Text = "Recompress";
            this.recompressButton.UseVisualStyleBackColor = true;
            this.recompressButton.Click += new System.EventHandler(this.recompressButton_Click);
            // 
            // uncompressFilePathTextbox
            // 
            this.uncompressFilePathTextbox.AllowDrop = true;
            this.uncompressFilePathTextbox.Location = new System.Drawing.Point(6, 27);
            this.uncompressFilePathTextbox.Name = "uncompressFilePathTextbox";
            this.uncompressFilePathTextbox.Size = new System.Drawing.Size(407, 20);
            this.uncompressFilePathTextbox.TabIndex = 2;
            this.uncompressFilePathTextbox.TextChanged += new System.EventHandler(this.uncompressFilePathTextbox_TextChanged);
            this.uncompressFilePathTextbox.DragDrop += new System.Windows.Forms.DragEventHandler(this.uncompressFilePathTextbox_DragDrop);
            this.uncompressFilePathTextbox.DragEnter += new System.Windows.Forms.DragEventHandler(this.uncompressFilePathTextbox_DragEnter);
            // 
            // uncompressButton
            // 
            this.uncompressButton.Location = new System.Drawing.Point(419, 25);
            this.uncompressButton.Name = "uncompressButton";
            this.uncompressButton.Size = new System.Drawing.Size(75, 23);
            this.uncompressButton.TabIndex = 0;
            this.uncompressButton.Text = "Uncompress";
            this.uncompressButton.UseVisualStyleBackColor = true;
            this.uncompressButton.Click += new System.EventHandler(this.uncompressButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Save File Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Uncompressed File Path:";
            // 
            // metaInformationFilePathTextbox
            // 
            this.metaInformationFilePathTextbox.AllowDrop = true;
            this.metaInformationFilePathTextbox.Location = new System.Drawing.Point(6, 129);
            this.metaInformationFilePathTextbox.Name = "metaInformationFilePathTextbox";
            this.metaInformationFilePathTextbox.Size = new System.Drawing.Size(407, 20);
            this.metaInformationFilePathTextbox.TabIndex = 7;
            this.metaInformationFilePathTextbox.DragDrop += new System.Windows.Forms.DragEventHandler(this.metaInformationFilePathTextbox_DragDrop);
            this.metaInformationFilePathTextbox.DragEnter += new System.Windows.Forms.DragEventHandler(this.metaInformationFilePathTextbox_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Metainfo File Path:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "CyberCAT";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button uncompressButton;
        private System.Windows.Forms.TextBox uncompressFilePathTextbox;
        private System.Windows.Forms.Button recompressButton;
        private System.Windows.Forms.TextBox recompressFilePathTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox metaInformationFilePathTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

