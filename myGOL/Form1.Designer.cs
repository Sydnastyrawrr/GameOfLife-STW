﻿namespace myGOL
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.aStatusStrip = new System.Windows.Forms.StatusStrip();
            this.aStripStatusGenerations = new System.Windows.Forms.ToolStripStatusLabel();
            this.aMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripItemStart = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripItemPause = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripItemNext = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripItemRunTo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aStripButtonPlay = new System.Windows.Forms.ToolStripButton();
            this.aStripButtonPause = new System.Windows.Forms.ToolStripButton();
            this.aStripButtonNext = new System.Windows.Forms.ToolStripButton();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.aGraphicsPanel = new myGOL.MyGraphicsPanel();
            this.aLabelUniverseSize = new System.Windows.Forms.Label();
            this.aLabelBoundaryType = new System.Windows.Forms.Label();
            this.aLabelCellCount = new System.Windows.Forms.Label();
            this.aLabelGenerations = new System.Windows.Forms.Label();
            this.aStripStatusCellCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.aStripStatusBoundaryType = new System.Windows.Forms.ToolStripStatusLabel();
            this.aStripStatusUniverseSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.aStatusStrip.SuspendLayout();
            this.aMenuStrip.SuspendLayout();
            this.aToolStrip.SuspendLayout();
            this.aGraphicsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // aStatusStrip
            // 
            this.aStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aStripStatusGenerations,
            this.aStripStatusCellCount,
            this.aStripStatusBoundaryType,
            this.aStripStatusUniverseSize});
            this.aStatusStrip.Location = new System.Drawing.Point(0, 633);
            this.aStatusStrip.Name = "aStatusStrip";
            this.aStatusStrip.Size = new System.Drawing.Size(1185, 22);
            this.aStatusStrip.TabIndex = 0;
            this.aStatusStrip.Text = "statusStrip1";
            // 
            // aStripStatusGenerations
            // 
            this.aStripStatusGenerations.Name = "aStripStatusGenerations";
            this.aStripStatusGenerations.Size = new System.Drawing.Size(70, 17);
            this.aStripStatusGenerations.Text = "Generations";
            // 
            // aMenuStrip
            // 
            this.aMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.runToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.aMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.aMenuStrip.Name = "aMenuStrip";
            this.aMenuStrip.Size = new System.Drawing.Size(1185, 24);
            this.aMenuStrip.TabIndex = 1;
            this.aMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripItemStart,
            this.aToolStripItemPause,
            this.aToolStripItemNext,
            this.aToolStripItemRunTo});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // aToolStripItemStart
            // 
            this.aToolStripItemStart.Name = "aToolStripItemStart";
            this.aToolStripItemStart.Size = new System.Drawing.Size(117, 22);
            this.aToolStripItemStart.Text = "Start";
            this.aToolStripItemStart.Click += new System.EventHandler(this.aStripButtonPlay_Click);
            // 
            // aToolStripItemPause
            // 
            this.aToolStripItemPause.Enabled = false;
            this.aToolStripItemPause.Name = "aToolStripItemPause";
            this.aToolStripItemPause.Size = new System.Drawing.Size(117, 22);
            this.aToolStripItemPause.Text = "Pause";
            this.aToolStripItemPause.Click += new System.EventHandler(this.aStripButtonPause_Click);
            // 
            // aToolStripItemNext
            // 
            this.aToolStripItemNext.Name = "aToolStripItemNext";
            this.aToolStripItemNext.Size = new System.Drawing.Size(117, 22);
            this.aToolStripItemNext.Text = "Next";
            this.aToolStripItemNext.Click += new System.EventHandler(this.aStripButtonNext_Click);
            // 
            // aToolStripItemRunTo
            // 
            this.aToolStripItemRunTo.Name = "aToolStripItemRunTo";
            this.aToolStripItemRunTo.Size = new System.Drawing.Size(117, 22);
            this.aToolStripItemRunTo.Text = "Run To..";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomizeToolStripMenuItem,
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // randomizeToolStripMenuItem
            // 
            this.randomizeToolStripMenuItem.Name = "randomizeToolStripMenuItem";
            this.randomizeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.randomizeToolStripMenuItem.Text = "Randomize";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Enabled = false;
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Enabled = false;
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Enabled = false;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Enabled = false;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // aToolStrip
            // 
            this.aToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator2,
            this.aStripButtonPlay,
            this.aStripButtonPause,
            this.aStripButtonNext,
            this.helpToolStripButton});
            this.aToolStrip.Location = new System.Drawing.Point(0, 24);
            this.aToolStrip.Name = "aToolStrip";
            this.aToolStrip.Size = new System.Drawing.Size(1185, 25);
            this.aToolStrip.TabIndex = 2;
            this.aToolStrip.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // aStripButtonPlay
            // 
            this.aStripButtonPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aStripButtonPlay.Image = global::myGOL.Properties.Resources.PlayImage;
            this.aStripButtonPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aStripButtonPlay.Name = "aStripButtonPlay";
            this.aStripButtonPlay.Size = new System.Drawing.Size(23, 22);
            this.aStripButtonPlay.Text = "aStripButtonPlay";
            this.aStripButtonPlay.Click += new System.EventHandler(this.aStripButtonPlay_Click);
            // 
            // aStripButtonPause
            // 
            this.aStripButtonPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aStripButtonPause.Enabled = false;
            this.aStripButtonPause.Image = ((System.Drawing.Image)(resources.GetObject("aStripButtonPause.Image")));
            this.aStripButtonPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aStripButtonPause.Name = "aStripButtonPause";
            this.aStripButtonPause.Size = new System.Drawing.Size(23, 22);
            this.aStripButtonPause.Text = "aStripButtonPause";
            this.aStripButtonPause.Click += new System.EventHandler(this.aStripButtonPause_Click);
            // 
            // aStripButtonNext
            // 
            this.aStripButtonNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aStripButtonNext.Image = global::myGOL.Properties.Resources.NextImage;
            this.aStripButtonNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aStripButtonNext.Name = "aStripButtonNext";
            this.aStripButtonNext.Size = new System.Drawing.Size(23, 22);
            this.aStripButtonNext.Text = "aStripButtonNext";
            this.aStripButtonNext.Click += new System.EventHandler(this.aStripButtonNext_Click);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // aGraphicsPanel
            // 
            this.aGraphicsPanel.Controls.Add(this.aLabelUniverseSize);
            this.aGraphicsPanel.Controls.Add(this.aLabelBoundaryType);
            this.aGraphicsPanel.Controls.Add(this.aLabelCellCount);
            this.aGraphicsPanel.Controls.Add(this.aLabelGenerations);
            this.aGraphicsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aGraphicsPanel.Location = new System.Drawing.Point(0, 49);
            this.aGraphicsPanel.Name = "aGraphicsPanel";
            this.aGraphicsPanel.Size = new System.Drawing.Size(1185, 584);
            this.aGraphicsPanel.TabIndex = 3;
            this.aGraphicsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.aGraphicsPanel_Paint);
            this.aGraphicsPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.aGraphicsPanel_MouseClick);
            // 
            // aLabelUniverseSize
            // 
            this.aLabelUniverseSize.AutoSize = true;
            this.aLabelUniverseSize.BackColor = System.Drawing.Color.Transparent;
            this.aLabelUniverseSize.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aLabelUniverseSize.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelUniverseSize.ForeColor = System.Drawing.Color.SteelBlue;
            this.aLabelUniverseSize.Location = new System.Drawing.Point(0, 512);
            this.aLabelUniverseSize.Name = "aLabelUniverseSize";
            this.aLabelUniverseSize.Size = new System.Drawing.Size(100, 18);
            this.aLabelUniverseSize.TabIndex = 3;
            this.aLabelUniverseSize.Text = "UniverseSize";
            // 
            // aLabelBoundaryType
            // 
            this.aLabelBoundaryType.AutoSize = true;
            this.aLabelBoundaryType.BackColor = System.Drawing.Color.Transparent;
            this.aLabelBoundaryType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aLabelBoundaryType.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelBoundaryType.ForeColor = System.Drawing.Color.SteelBlue;
            this.aLabelBoundaryType.Location = new System.Drawing.Point(0, 530);
            this.aLabelBoundaryType.Name = "aLabelBoundaryType";
            this.aLabelBoundaryType.Size = new System.Drawing.Size(114, 18);
            this.aLabelBoundaryType.TabIndex = 2;
            this.aLabelBoundaryType.Text = "BoundaryType";
            // 
            // aLabelCellCount
            // 
            this.aLabelCellCount.AutoSize = true;
            this.aLabelCellCount.BackColor = System.Drawing.Color.Transparent;
            this.aLabelCellCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aLabelCellCount.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelCellCount.ForeColor = System.Drawing.Color.SteelBlue;
            this.aLabelCellCount.Location = new System.Drawing.Point(0, 548);
            this.aLabelCellCount.Name = "aLabelCellCount";
            this.aLabelCellCount.Size = new System.Drawing.Size(76, 18);
            this.aLabelCellCount.TabIndex = 1;
            this.aLabelCellCount.Text = "CellCount";
            // 
            // aLabelGenerations
            // 
            this.aLabelGenerations.AutoSize = true;
            this.aLabelGenerations.BackColor = System.Drawing.Color.Transparent;
            this.aLabelGenerations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aLabelGenerations.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelGenerations.ForeColor = System.Drawing.Color.SteelBlue;
            this.aLabelGenerations.Location = new System.Drawing.Point(0, 566);
            this.aLabelGenerations.Name = "aLabelGenerations";
            this.aLabelGenerations.Size = new System.Drawing.Size(94, 18);
            this.aLabelGenerations.TabIndex = 0;
            this.aLabelGenerations.Text = "Generations";
            // 
            // aStripStatusCellCount
            // 
            this.aStripStatusCellCount.Name = "aStripStatusCellCount";
            this.aStripStatusCellCount.Size = new System.Drawing.Size(60, 17);
            this.aStripStatusCellCount.Text = "CellCount";
            // 
            // aStripStatusBoundaryType
            // 
            this.aStripStatusBoundaryType.Name = "aStripStatusBoundaryType";
            this.aStripStatusBoundaryType.Size = new System.Drawing.Size(83, 17);
            this.aStripStatusBoundaryType.Text = "BoundaryType";
            // 
            // aStripStatusUniverseSize
            // 
            this.aStripStatusUniverseSize.Name = "aStripStatusUniverseSize";
            this.aStripStatusUniverseSize.Size = new System.Drawing.Size(72, 17);
            this.aStripStatusUniverseSize.Text = "UniverseSize";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 655);
            this.Controls.Add(this.aGraphicsPanel);
            this.Controls.Add(this.aToolStrip);
            this.Controls.Add(this.aStatusStrip);
            this.Controls.Add(this.aMenuStrip);
            this.MainMenuStrip = this.aMenuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.aStatusStrip.ResumeLayout(false);
            this.aStatusStrip.PerformLayout();
            this.aMenuStrip.ResumeLayout(false);
            this.aMenuStrip.PerformLayout();
            this.aToolStrip.ResumeLayout(false);
            this.aToolStrip.PerformLayout();
            this.aGraphicsPanel.ResumeLayout(false);
            this.aGraphicsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip aStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel aStripStatusGenerations;
        private System.Windows.Forms.MenuStrip aMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip aToolStrip;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MyGraphicsPanel aGraphicsPanel;
        private System.Windows.Forms.ToolStripButton aStripButtonPlay;
        private System.Windows.Forms.ToolStripButton aStripButtonPause;
        private System.Windows.Forms.ToolStripButton aStripButtonNext;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripItemStart;
        private System.Windows.Forms.ToolStripMenuItem aToolStripItemPause;
        private System.Windows.Forms.ToolStripMenuItem aToolStripItemNext;
        private System.Windows.Forms.ToolStripMenuItem aToolStripItemRunTo;
        private System.Windows.Forms.ToolStripMenuItem randomizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label aLabelUniverseSize;
        private System.Windows.Forms.Label aLabelBoundaryType;
        private System.Windows.Forms.Label aLabelCellCount;
        private System.Windows.Forms.Label aLabelGenerations;
        private System.Windows.Forms.ToolStripStatusLabel aStripStatusCellCount;
        private System.Windows.Forms.ToolStripStatusLabel aStripStatusBoundaryType;
        private System.Windows.Forms.ToolStripStatusLabel aStripStatusUniverseSize;
    }
}

