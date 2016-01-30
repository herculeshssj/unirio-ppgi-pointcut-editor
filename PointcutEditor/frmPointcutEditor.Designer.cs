namespace PointcutEditor
{
    partial class frmPointcutEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPointcutEditor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miAspect = new System.Windows.Forms.ToolStripMenuItem();
            this.miAspectNew = new System.Windows.Forms.ToolStripMenuItem();
            this.miAspectEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miAspectDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.miAdvice = new System.Windows.Forms.ToolStripMenuItem();
            this.miAdviceNew = new System.Windows.Forms.ToolStripMenuItem();
            this.miAdviceEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miAdviceDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.miPointcut = new System.Windows.Forms.ToolStripMenuItem();
            this.miPointcutNew = new System.Windows.Forms.ToolStripMenuItem();
            this.miPointcutEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miPointcutDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlAspects = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gvAspect = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAspectNew = new System.Windows.Forms.ToolStripButton();
            this.tsbAspectEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbAspectDelete = new System.Windows.Forms.ToolStripButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.pnlPointcut = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.gvPointcut = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.tsbPointcutNew = new System.Windows.Forms.ToolStripButton();
            this.tsbPointcutEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbPointcutDelete = new System.Windows.Forms.ToolStripButton();
            this.pnlAdvice = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.gvAdvice = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbAdviceNew = new System.Windows.Forms.ToolStripButton();
            this.tsbAdviceEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbAdviceDelete = new System.Windows.Forms.ToolStripButton();
            this.cmAspect = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmAdvice = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmPointcut = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.pnlAspects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvAspect)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlPointcut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPointcut)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.pnlAdvice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvAdvice)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.cmAspect.SuspendLayout();
            this.cmAdvice.SuspendLayout();
            this.cmPointcut.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.viewToolStripMenuItem,
            this.miHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(605, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAspect,
            this.miAdvice,
            this.miPointcut,
            this.toolStripMenuItem1,
            this.reloadToolStripMenuItem,
            this.miSave,
            this.toolStripMenuItem2,
            this.miExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(37, 20);
            this.miFile.Text = "&File";
            // 
            // miAspect
            // 
            this.miAspect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAspectNew,
            this.miAspectEdit,
            this.miAspectDelete});
            this.miAspect.Name = "miAspect";
            this.miAspect.Size = new System.Drawing.Size(152, 22);
            this.miAspect.Text = "&Aspect";
            // 
            // miAspectNew
            // 
            this.miAspectNew.Name = "miAspectNew";
            this.miAspectNew.Size = new System.Drawing.Size(152, 22);
            this.miAspectNew.Text = "&New";
            this.miAspectNew.Click += new System.EventHandler(this.tsbAspectNew_Click);
            // 
            // miAspectEdit
            // 
            this.miAspectEdit.Name = "miAspectEdit";
            this.miAspectEdit.Size = new System.Drawing.Size(152, 22);
            this.miAspectEdit.Text = "&Edit";
            this.miAspectEdit.Click += new System.EventHandler(this.tsbAspectEdit_Click);
            // 
            // miAspectDelete
            // 
            this.miAspectDelete.Name = "miAspectDelete";
            this.miAspectDelete.Size = new System.Drawing.Size(152, 22);
            this.miAspectDelete.Text = "&Delet";
            this.miAspectDelete.Click += new System.EventHandler(this.tsbAspectDelete_Click);
            // 
            // miAdvice
            // 
            this.miAdvice.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAdviceNew,
            this.miAdviceEdit,
            this.miAdviceDelete});
            this.miAdvice.Name = "miAdvice";
            this.miAdvice.Size = new System.Drawing.Size(152, 22);
            this.miAdvice.Text = "Ad&vice";
            // 
            // miAdviceNew
            // 
            this.miAdviceNew.Name = "miAdviceNew";
            this.miAdviceNew.Size = new System.Drawing.Size(152, 22);
            this.miAdviceNew.Text = "&New";
            this.miAdviceNew.Click += new System.EventHandler(this.tsbAdviceNew_Click);
            // 
            // miAdviceEdit
            // 
            this.miAdviceEdit.Name = "miAdviceEdit";
            this.miAdviceEdit.Size = new System.Drawing.Size(152, 22);
            this.miAdviceEdit.Text = "&Edit";
            this.miAdviceEdit.Click += new System.EventHandler(this.tsbAdviceEdit_Click);
            // 
            // miAdviceDelete
            // 
            this.miAdviceDelete.Name = "miAdviceDelete";
            this.miAdviceDelete.Size = new System.Drawing.Size(152, 22);
            this.miAdviceDelete.Text = "&Delet";
            this.miAdviceDelete.Click += new System.EventHandler(this.tsbAdviceDelete_Click);
            // 
            // miPointcut
            // 
            this.miPointcut.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPointcutNew,
            this.miPointcutEdit,
            this.miPointcutDelete});
            this.miPointcut.Name = "miPointcut";
            this.miPointcut.Size = new System.Drawing.Size(152, 22);
            this.miPointcut.Text = "&Pointcut";
            this.miPointcut.Click += new System.EventHandler(this.chooseSpecificationToolStripMenuItem_Click);
            // 
            // miPointcutNew
            // 
            this.miPointcutNew.Name = "miPointcutNew";
            this.miPointcutNew.Size = new System.Drawing.Size(101, 22);
            this.miPointcutNew.Text = "&New";
            this.miPointcutNew.Click += new System.EventHandler(this.tsbPointcutNew_Click);
            // 
            // miPointcutEdit
            // 
            this.miPointcutEdit.Name = "miPointcutEdit";
            this.miPointcutEdit.Size = new System.Drawing.Size(101, 22);
            this.miPointcutEdit.Text = "&Edit";
            this.miPointcutEdit.Click += new System.EventHandler(this.tsbPointcutEdit_Click);
            // 
            // miPointcutDelete
            // 
            this.miPointcutDelete.Name = "miPointcutDelete";
            this.miPointcutDelete.Size = new System.Drawing.Size(101, 22);
            this.miPointcutDelete.Text = "&Delet";
            this.miPointcutDelete.Click += new System.EventHandler(this.tsbPointcutDelete_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reloadToolStripMenuItem.Text = "&Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.Size = new System.Drawing.Size(152, 22);
            this.miSave.Text = "&Save All";
            this.miSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(152, 22);
            this.miExit.Text = "E&xit";
            this.miExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processViewToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            this.viewToolStripMenuItem.Visible = false;
            // 
            // processViewToolStripMenuItem
            // 
            this.processViewToolStripMenuItem.Enabled = false;
            this.processViewToolStripMenuItem.Name = "processViewToolStripMenuItem";
            this.processViewToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.processViewToolStripMenuItem.Text = "&Process View";
            // 
            // miHelp
            // 
            this.miHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAbout});
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(44, 20);
            this.miHelp.Text = "&Help";
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(107, 22);
            this.miAbout.Text = "&About";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // pnlAspects
            // 
            this.pnlAspects.Controls.Add(this.label1);
            this.pnlAspects.Controls.Add(this.gvAspect);
            this.pnlAspects.Controls.Add(this.toolStrip1);
            this.pnlAspects.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAspects.Location = new System.Drawing.Point(0, 24);
            this.pnlAspects.Name = "pnlAspects";
            this.pnlAspects.Size = new System.Drawing.Size(605, 136);
            this.pnlAspects.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aspects";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gvAspect
            // 
            this.gvAspect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAspect.ContextMenuStrip = this.cmAspect;
            this.gvAspect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvAspect.Location = new System.Drawing.Point(0, 25);
            this.gvAspect.Name = "gvAspect";
            this.gvAspect.ReadOnly = true;
            this.gvAspect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvAspect.Size = new System.Drawing.Size(605, 111);
            this.gvAspect.TabIndex = 1;
            this.gvAspect.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvAspect_CellDoubleClick);
            this.gvAspect.SelectionChanged += new System.EventHandler(this.gvAspect_SelectionChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAspectNew,
            this.tsbAspectEdit,
            this.tsbAspectDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(605, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "Aspects";
            // 
            // tsbAspectNew
            // 
            this.tsbAspectNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAspectNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbAspectNew.Image")));
            this.tsbAspectNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAspectNew.Name = "tsbAspectNew";
            this.tsbAspectNew.Size = new System.Drawing.Size(23, 22);
            this.tsbAspectNew.Text = "New Aspect";
            this.tsbAspectNew.Click += new System.EventHandler(this.tsbAspectNew_Click);
            // 
            // tsbAspectEdit
            // 
            this.tsbAspectEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAspectEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbAspectEdit.Image")));
            this.tsbAspectEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAspectEdit.Name = "tsbAspectEdit";
            this.tsbAspectEdit.Size = new System.Drawing.Size(23, 22);
            this.tsbAspectEdit.Text = "Edit Aspect";
            this.tsbAspectEdit.Click += new System.EventHandler(this.tsbAspectEdit_Click);
            // 
            // tsbAspectDelete
            // 
            this.tsbAspectDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAspectDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbAspectDelete.Image")));
            this.tsbAspectDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAspectDelete.Name = "tsbAspectDelete";
            this.tsbAspectDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbAspectDelete.Text = "Delete Aspect";
            this.tsbAspectDelete.Click += new System.EventHandler(this.tsbAspectDelete_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 516);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(605, 3);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 160);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(605, 3);
            this.splitter2.TabIndex = 5;
            this.splitter2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitter3);
            this.panel1.Controls.Add(this.pnlPointcut);
            this.panel1.Controls.Add(this.pnlAdvice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 353);
            this.panel1.TabIndex = 6;
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Location = new System.Drawing.Point(0, 145);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(605, 3);
            this.splitter3.TabIndex = 5;
            this.splitter3.TabStop = false;
            // 
            // pnlPointcut
            // 
            this.pnlPointcut.Controls.Add(this.label3);
            this.pnlPointcut.Controls.Add(this.gvPointcut);
            this.pnlPointcut.Controls.Add(this.statusStrip1);
            this.pnlPointcut.Controls.Add(this.toolStrip3);
            this.pnlPointcut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPointcut.Location = new System.Drawing.Point(0, 145);
            this.pnlPointcut.Name = "pnlPointcut";
            this.pnlPointcut.Size = new System.Drawing.Size(605, 208);
            this.pnlPointcut.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(446, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pointcuts";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gvPointcut
            // 
            this.gvPointcut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPointcut.ContextMenuStrip = this.cmPointcut;
            this.gvPointcut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvPointcut.Location = new System.Drawing.Point(0, 25);
            this.gvPointcut.Name = "gvPointcut";
            this.gvPointcut.ReadOnly = true;
            this.gvPointcut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvPointcut.Size = new System.Drawing.Size(605, 161);
            this.gvPointcut.TabIndex = 6;
            this.gvPointcut.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPointcut_CellDoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 186);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(605, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPointcutNew,
            this.tsbPointcutEdit,
            this.tsbPointcutDelete});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(605, 25);
            this.toolStrip3.TabIndex = 1;
            this.toolStrip3.Text = "Aspects";
            // 
            // tsbPointcutNew
            // 
            this.tsbPointcutNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPointcutNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbPointcutNew.Image")));
            this.tsbPointcutNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPointcutNew.Name = "tsbPointcutNew";
            this.tsbPointcutNew.Size = new System.Drawing.Size(23, 22);
            this.tsbPointcutNew.Text = "New Pointcut";
            this.tsbPointcutNew.Click += new System.EventHandler(this.tsbPointcutNew_Click);
            // 
            // tsbPointcutEdit
            // 
            this.tsbPointcutEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPointcutEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbPointcutEdit.Image")));
            this.tsbPointcutEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPointcutEdit.Name = "tsbPointcutEdit";
            this.tsbPointcutEdit.Size = new System.Drawing.Size(23, 22);
            this.tsbPointcutEdit.Text = "Edit Pointcut";
            this.tsbPointcutEdit.Click += new System.EventHandler(this.tsbPointcutEdit_Click);
            // 
            // tsbPointcutDelete
            // 
            this.tsbPointcutDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPointcutDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbPointcutDelete.Image")));
            this.tsbPointcutDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPointcutDelete.Name = "tsbPointcutDelete";
            this.tsbPointcutDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbPointcutDelete.Text = "Delete Pointcut";
            this.tsbPointcutDelete.Click += new System.EventHandler(this.tsbPointcutDelete_Click);
            // 
            // pnlAdvice
            // 
            this.pnlAdvice.Controls.Add(this.label2);
            this.pnlAdvice.Controls.Add(this.gvAdvice);
            this.pnlAdvice.Controls.Add(this.toolStrip2);
            this.pnlAdvice.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdvice.Location = new System.Drawing.Point(0, 0);
            this.pnlAdvice.Name = "pnlAdvice";
            this.pnlAdvice.Size = new System.Drawing.Size(605, 145);
            this.pnlAdvice.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(446, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Advices";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gvAdvice
            // 
            this.gvAdvice.AllowUserToAddRows = false;
            this.gvAdvice.AllowUserToDeleteRows = false;
            this.gvAdvice.AllowUserToOrderColumns = true;
            this.gvAdvice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAdvice.ContextMenuStrip = this.cmAdvice;
            this.gvAdvice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvAdvice.Location = new System.Drawing.Point(0, 25);
            this.gvAdvice.MultiSelect = false;
            this.gvAdvice.Name = "gvAdvice";
            this.gvAdvice.ReadOnly = true;
            this.gvAdvice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvAdvice.Size = new System.Drawing.Size(605, 120);
            this.gvAdvice.TabIndex = 2;
            this.gvAdvice.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvAdvice_CellDoubleClick);
            this.gvAdvice.SelectionChanged += new System.EventHandler(this.gvAdvice_SelectionChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdviceNew,
            this.tsbAdviceEdit,
            this.tsbAdviceDelete});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(605, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "Aspects";
            // 
            // tsbAdviceNew
            // 
            this.tsbAdviceNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdviceNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdviceNew.Image")));
            this.tsbAdviceNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdviceNew.Name = "tsbAdviceNew";
            this.tsbAdviceNew.Size = new System.Drawing.Size(23, 22);
            this.tsbAdviceNew.Text = "New Advice";
            this.tsbAdviceNew.Click += new System.EventHandler(this.tsbAdviceNew_Click);
            // 
            // tsbAdviceEdit
            // 
            this.tsbAdviceEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdviceEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdviceEdit.Image")));
            this.tsbAdviceEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdviceEdit.Name = "tsbAdviceEdit";
            this.tsbAdviceEdit.Size = new System.Drawing.Size(23, 22);
            this.tsbAdviceEdit.Text = "Edit Advice";
            this.tsbAdviceEdit.Click += new System.EventHandler(this.tsbAdviceEdit_Click);
            // 
            // tsbAdviceDelete
            // 
            this.tsbAdviceDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdviceDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdviceDelete.Image")));
            this.tsbAdviceDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdviceDelete.Name = "tsbAdviceDelete";
            this.tsbAdviceDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbAdviceDelete.Text = "Delete Advice";
            this.tsbAdviceDelete.Click += new System.EventHandler(this.tsbAdviceDelete_Click);
            // 
            // cmAspect
            // 
            this.cmAspect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmAspect.Name = "cmAspect";
            this.cmAspect.Size = new System.Drawing.Size(108, 70);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem.Text = "New";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.tsbAspectNew_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.tsbAspectEdit_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.tsbAspectDelete_Click);
            // 
            // cmAdvice
            // 
            this.cmAdvice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.cmAdvice.Name = "cmAdvice";
            this.cmAdvice.Size = new System.Drawing.Size(108, 70);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.tsbAdviceNew_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.tsbAdviceEdit_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.tsbAdviceDelete_Click);
            // 
            // cmPointcut
            // 
            this.cmPointcut.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.editToolStripMenuItem2,
            this.deleteToolStripMenuItem2});
            this.cmPointcut.Name = "cmPointcut";
            this.cmPointcut.Size = new System.Drawing.Size(108, 70);
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.newToolStripMenuItem1.Text = "New";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.tsbPointcutNew_Click);
            // 
            // editToolStripMenuItem2
            // 
            this.editToolStripMenuItem2.Name = "editToolStripMenuItem2";
            this.editToolStripMenuItem2.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem2.Text = "Edit";
            this.editToolStripMenuItem2.Click += new System.EventHandler(this.tsbPointcutEdit_Click);
            // 
            // deleteToolStripMenuItem2
            // 
            this.deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            this.deleteToolStripMenuItem2.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem2.Text = "Delete";
            this.deleteToolStripMenuItem2.Click += new System.EventHandler(this.tsbPointcutDelete_Click);
            // 
            // frmPointcutEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 519);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlAspects);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPointcutEditor";
            this.Text = "PointcutEditor";
            this.Load += new System.EventHandler(this.frmPointcutEditor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlAspects.ResumeLayout(false);
            this.pnlAspects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvAspect)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlPointcut.ResumeLayout(false);
            this.pnlPointcut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPointcut)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.pnlAdvice.ResumeLayout(false);
            this.pnlAdvice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvAdvice)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.cmAspect.ResumeLayout(false);
            this.cmAdvice.ResumeLayout(false);
            this.cmPointcut.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miPointcut;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.Panel pnlAspects;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAspectNew;
        private System.Windows.Forms.ToolStripButton tsbAspectEdit;
        private System.Windows.Forms.ToolStripButton tsbAspectDelete;
        private System.Windows.Forms.ToolStripMenuItem miAspect;
        private System.Windows.Forms.ToolStripMenuItem miAspectNew;
        private System.Windows.Forms.ToolStripMenuItem miAspectEdit;
        private System.Windows.Forms.ToolStripMenuItem miAspectDelete;
        private System.Windows.Forms.ToolStripMenuItem miAdvice;
        private System.Windows.Forms.ToolStripMenuItem miAdviceNew;
        private System.Windows.Forms.ToolStripMenuItem miAdviceEdit;
        private System.Windows.Forms.ToolStripMenuItem miAdviceDelete;
        private System.Windows.Forms.ToolStripMenuItem miPointcutNew;
        private System.Windows.Forms.ToolStripMenuItem miPointcutEdit;
        private System.Windows.Forms.ToolStripMenuItem miPointcutDelete;
        private System.Windows.Forms.DataGridView gvAspect;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Panel pnlPointcut;
        private System.Windows.Forms.DataGridView gvPointcut;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton tsbPointcutNew;
        private System.Windows.Forms.ToolStripButton tsbPointcutEdit;
        private System.Windows.Forms.ToolStripButton tsbPointcutDelete;
        private System.Windows.Forms.Panel pnlAdvice;
        private System.Windows.Forms.DataGridView gvAdvice;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbAdviceNew;
        private System.Windows.Forms.ToolStripButton tsbAdviceEdit;
        private System.Windows.Forms.ToolStripButton tsbAdviceDelete;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processViewToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmAspect;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmAdvice;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip cmPointcut;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem2;
    }
}

