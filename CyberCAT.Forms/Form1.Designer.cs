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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.compressionTabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblRecompress = new System.Windows.Forms.Label();
            this.lblSelectedFileForRecompression = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.recompressButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSelectedFileForDecompression = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLoadSaveDecompress = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uncompressButton = new System.Windows.Forms.Button();
            this.editorTabPage = new System.Windows.Forms.TabPage();
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.leftContainer = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEditorFilter = new System.Windows.Forms.TextBox();
            this.EditorTree = new System.Windows.Forms.TreeView();
            this.editorTreeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPCSave = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPS4Save = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePCSave = new System.Windows.Forms.ToolStripMenuItem();
            this.savePS4Save = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.footerLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbStartInSaves = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.compressionTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.editorTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftContainer)).BeginInit();
            this.leftContainer.Panel1.SuspendLayout();
            this.leftContainer.Panel2.SuspendLayout();
            this.leftContainer.SuspendLayout();
            this.editorTreeContextMenu.SuspendLayout();
            this.settingsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.compressionTabPage);
            this.tabControl1.Controls.Add(this.editorTabPage);
            this.tabControl1.Controls.Add(this.settingsTabPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(734, 412);
            this.tabControl1.TabIndex = 0;
            // 
            // compressionTabPage
            // 
            this.compressionTabPage.Controls.Add(this.groupBox2);
            this.compressionTabPage.Controls.Add(this.groupBox1);
            this.compressionTabPage.Location = new System.Drawing.Point(4, 22);
            this.compressionTabPage.Name = "compressionTabPage";
            this.compressionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.compressionTabPage.Size = new System.Drawing.Size(726, 386);
            this.compressionTabPage.TabIndex = 0;
            this.compressionTabPage.Text = "Compression";
            this.compressionTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblRecompress);
            this.groupBox2.Controls.Add(this.lblSelectedFileForRecompression);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.recompressButton);
            this.groupBox2.Location = new System.Drawing.Point(8, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 143);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recompress into a sav.dat";
            // 
            // lblRecompress
            // 
            this.lblRecompress.AutoSize = true;
            this.lblRecompress.Location = new System.Drawing.Point(9, 54);
            this.lblRecompress.Name = "lblRecompress";
            this.lblRecompress.Size = new System.Drawing.Size(78, 13);
            this.lblRecompress.TabIndex = 3;
            this.lblRecompress.Text = "2. Recompress";
            // 
            // lblSelectedFileForRecompression
            // 
            this.lblSelectedFileForRecompression.Location = new System.Drawing.Point(9, 86);
            this.lblSelectedFileForRecompression.Name = "lblSelectedFileForRecompression";
            this.lblSelectedFileForRecompression.Size = new System.Drawing.Size(432, 54);
            this.lblSelectedFileForRecompression.TabIndex = 2;
            this.lblSelectedFileForRecompression.Text = "Selected File: <None>";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "1. Select a decompressed .bin";
            // 
            // recompressButton
            // 
            this.recompressButton.Enabled = false;
            this.recompressButton.Location = new System.Drawing.Point(187, 49);
            this.recompressButton.Name = "recompressButton";
            this.recompressButton.Size = new System.Drawing.Size(75, 23);
            this.recompressButton.TabIndex = 3;
            this.recompressButton.Text = "Recompress";
            this.recompressButton.UseVisualStyleBackColor = true;
            this.recompressButton.Click += new System.EventHandler(this.recompressButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSelectedFileForDecompression);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnLoadSaveDecompress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.uncompressButton);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 121);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Decompressing a sav.dat";
            // 
            // lblSelectedFileForDecompression
            // 
            this.lblSelectedFileForDecompression.Location = new System.Drawing.Point(6, 86);
            this.lblSelectedFileForDecompression.Name = "lblSelectedFileForDecompression";
            this.lblSelectedFileForDecompression.Size = new System.Drawing.Size(435, 32);
            this.lblSelectedFileForDecompression.TabIndex = 5;
            this.lblSelectedFileForDecompression.Text = "Selected File: <None>";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(292, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 55);
            this.label8.TabIndex = 4;
            this.label8.Text = "Decompressed files will be located in the same folder as the selected save file.\r" +
    "\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "2. Decompress:";
            // 
            // btnLoadSaveDecompress
            // 
            this.btnLoadSaveDecompress.Location = new System.Drawing.Point(187, 21);
            this.btnLoadSaveDecompress.Name = "btnLoadSaveDecompress";
            this.btnLoadSaveDecompress.Size = new System.Drawing.Size(75, 23);
            this.btnLoadSaveDecompress.TabIndex = 2;
            this.btnLoadSaveDecompress.Text = "Load file";
            this.btnLoadSaveDecompress.UseVisualStyleBackColor = true;
            this.btnLoadSaveDecompress.Click += new System.EventHandler(this.btnLoadSaveDecompress_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Select a save file to decompress:";
            // 
            // uncompressButton
            // 
            this.uncompressButton.Enabled = false;
            this.uncompressButton.Location = new System.Drawing.Point(187, 53);
            this.uncompressButton.Name = "uncompressButton";
            this.uncompressButton.Size = new System.Drawing.Size(75, 23);
            this.uncompressButton.TabIndex = 0;
            this.uncompressButton.Text = "Decompress";
            this.uncompressButton.UseVisualStyleBackColor = true;
            this.uncompressButton.Click += new System.EventHandler(this.uncompressButton_Click);
            // 
            // editorTabPage
            // 
            this.editorTabPage.Controls.Add(this.mainContainer);
            this.editorTabPage.Location = new System.Drawing.Point(4, 22);
            this.editorTabPage.Name = "editorTabPage";
            this.editorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.editorTabPage.Size = new System.Drawing.Size(726, 386);
            this.editorTabPage.TabIndex = 2;
            this.editorTabPage.Text = "Editor";
            this.editorTabPage.UseVisualStyleBackColor = true;
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainContainer.Location = new System.Drawing.Point(3, 3);
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.Controls.Add(this.leftContainer);
            this.mainContainer.Size = new System.Drawing.Size(720, 380);
            this.mainContainer.SplitterDistance = 247;
            this.mainContainer.TabIndex = 0;
            // 
            // leftContainer
            // 
            this.leftContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.leftContainer.IsSplitterFixed = true;
            this.leftContainer.Location = new System.Drawing.Point(0, 0);
            this.leftContainer.Name = "leftContainer";
            this.leftContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // leftContainer.Panel1
            // 
            this.leftContainer.Panel1.Controls.Add(this.label2);
            this.leftContainer.Panel1.Controls.Add(this.txtEditorFilter);
            this.leftContainer.Panel1MinSize = 27;
            // 
            // leftContainer.Panel2
            // 
            this.leftContainer.Panel2.Controls.Add(this.EditorTree);
            this.leftContainer.Size = new System.Drawing.Size(247, 380);
            this.leftContainer.SplitterDistance = 27;
            this.leftContainer.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filter:";
            // 
            // txtEditorFilter
            // 
            this.txtEditorFilter.Location = new System.Drawing.Point(43, 3);
            this.txtEditorFilter.Name = "txtEditorFilter";
            this.txtEditorFilter.Size = new System.Drawing.Size(156, 20);
            this.txtEditorFilter.TabIndex = 2;
            this.txtEditorFilter.TextChanged += new System.EventHandler(this.txtEditorFilter_TextChanged);
            // 
            // EditorTree
            // 
            this.EditorTree.ContextMenuStrip = this.editorTreeContextMenu;
            this.EditorTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorTree.HideSelection = false;
            this.EditorTree.Location = new System.Drawing.Point(0, 0);
            this.EditorTree.Name = "EditorTree";
            this.EditorTree.Size = new System.Drawing.Size(247, 349);
            this.EditorTree.TabIndex = 0;
            this.EditorTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.EditorTree_AfterSelect);
            // 
            // editorTreeContextMenu
            // 
            this.editorTreeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.exportAllToolStripMenuItem,
            this.exportJSONToolStripMenuItem});
            this.editorTreeContextMenu.Name = "editorTreeContextMenu";
            this.editorTreeContextMenu.Size = new System.Drawing.Size(140, 70);
            this.editorTreeContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.editorTreeContextMenu_Opening);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Enabled = false;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // exportAllToolStripMenuItem
            // 
            this.exportAllToolStripMenuItem.Name = "exportAllToolStripMenuItem";
            this.exportAllToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.exportAllToolStripMenuItem.Text = "Export All";
            this.exportAllToolStripMenuItem.Click += new System.EventHandler(this.exportAllToolStripMenuItem_Click);
            // 
            // exportJSONToolStripMenuItem
            // 
            this.exportJSONToolStripMenuItem.Name = "exportJSONToolStripMenuItem";
            this.exportJSONToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.exportJSONToolStripMenuItem.Text = "Export JSON";
            this.exportJSONToolStripMenuItem.Click += new System.EventHandler(this.exportJSONToolStripMenuItem_Click);
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.Controls.Add(this.cbStartInSaves);
            this.settingsTabPage.Controls.Add(this.dataGridView1);
            this.settingsTabPage.Controls.Add(this.label6);
            this.settingsTabPage.Controls.Add(this.saveSettingsButton);
            this.settingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Size = new System.Drawing.Size(726, 386);
            this.settingsTabPage.TabIndex = 3;
            this.settingsTabPage.Text = "Settings";
            this.settingsTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(252, 357);
            this.dataGridView1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Enabled Parsers:";
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveSettingsButton.Location = new System.Drawing.Point(643, 360);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.saveSettingsButton.TabIndex = 1;
            this.saveSettingsButton.Text = "Save";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadPCSave,
            this.loadPS4Save});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // loadPCSave
            // 
            this.loadPCSave.Name = "loadPCSave";
            this.loadPCSave.Size = new System.Drawing.Size(133, 22);
            this.loadPCSave.Text = "PC sav.dat";
            this.loadPCSave.Click += new System.EventHandler(this.LoadPcSaveClick);
            // 
            // loadPS4Save
            // 
            this.loadPS4Save.Name = "loadPS4Save";
            this.loadPS4Save.Size = new System.Drawing.Size(133, 22);
            this.loadPS4Save.Text = "PS4 sav.dat";
            this.loadPS4Save.Click += new System.EventHandler(this.LoadPs4SaveClick);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savePCSave,
            this.savePS4Save});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // savePCSave
            // 
            this.savePCSave.Name = "savePCSave";
            this.savePCSave.Size = new System.Drawing.Size(111, 22);
            this.savePCSave.Text = "for PC";
            this.savePCSave.Click += new System.EventHandler(this.SavePcSaveClick);
            // 
            // savePS4Save
            // 
            this.savePS4Save.Name = "savePS4Save";
            this.savePS4Save.Size = new System.Drawing.Size(111, 22);
            this.savePS4Save.Text = "for PS4";
            this.savePS4Save.Click += new System.EventHandler(this.SavePs4SaveClick);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.footerLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(734, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // footerLabel
            // 
            this.footerLabel.Name = "footerLabel";
            this.footerLabel.Size = new System.Drawing.Size(88, 17);
            this.footerLabel.Text = "No save loaded";
            // 
            // cbStartInSaves
            // 
            this.cbStartInSaves.AutoSize = true;
            this.cbStartInSaves.Location = new System.Drawing.Point(290, 26);
            this.cbStartInSaves.Name = "cbStartInSaves";
            this.cbStartInSaves.Size = new System.Drawing.Size(250, 17);
            this.cbStartInSaves.TabIndex = 5;
            this.cbStartInSaves.Text = "Start Open/Save dialogs in CP2077 save folder";
            this.cbStartInSaves.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "Form1";
            this.Text = "CyberCAT";
            this.tabControl1.ResumeLayout(false);
            this.compressionTabPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.editorTabPage.ResumeLayout(false);
            this.mainContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.leftContainer.Panel1.ResumeLayout(false);
            this.leftContainer.Panel1.PerformLayout();
            this.leftContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftContainer)).EndInit();
            this.leftContainer.ResumeLayout(false);
            this.editorTreeContextMenu.ResumeLayout(false);
            this.settingsTabPage.ResumeLayout(false);
            this.settingsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage compressionTabPage;
        private System.Windows.Forms.Button uncompressButton;
        private System.Windows.Forms.Button recompressButton;
        private System.Windows.Forms.TabPage editorTabPage;
        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.SplitContainer leftContainer;
        private System.Windows.Forms.TreeView EditorTree;
        private System.Windows.Forms.ContextMenuStrip editorTreeContextMenu;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.TabPage settingsTabPage;
        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem exportAllToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLoadSaveDecompress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSelectedFileForDecompression;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblRecompress;
        private System.Windows.Forms.Label lblSelectedFileForRecompression;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEditorFilter;
        private System.Windows.Forms.ToolStripMenuItem exportJSONToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPCSave;
        private System.Windows.Forms.ToolStripMenuItem loadPS4Save;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePCSave;
        private System.Windows.Forms.ToolStripMenuItem savePS4Save;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel footerLabel;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbStartInSaves;
    }
}

