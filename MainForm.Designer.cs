namespace csTexti
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernUnterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rückgängigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ausschneidenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einfügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allesMarkierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suchenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suchenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.weitersuchenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ersetzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schriftartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zeilenumbruchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.textBox = new System.Windows.Forms.TextBox();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            resources.ApplyResources(this.mainMenu, "mainMenu");
            this.mainMenu.BackColor = System.Drawing.SystemColors.Control;
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.suchenToolStripMenuItem,
            this.optionenToolStripMenuItem,
            this.toolStripMenuItem1});
            this.mainMenu.Name = "mainMenu";
            // 
            // dateiToolStripMenuItem
            // 
            resources.ApplyResources(this.dateiToolStripMenuItem, "dateiToolStripMenuItem");
            this.dateiToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.öffnenToolStripMenuItem,
            this.speichernToolStripMenuItem,
            this.speichernUnterToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            // 
            // neuToolStripMenuItem
            // 
            resources.ApplyResources(this.neuToolStripMenuItem, "neuToolStripMenuItem");
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Click += new System.EventHandler(this.New_Click);
            // 
            // öffnenToolStripMenuItem
            // 
            resources.ApplyResources(this.öffnenToolStripMenuItem, "öffnenToolStripMenuItem");
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.Click += new System.EventHandler(this.Open_Click);
            // 
            // speichernToolStripMenuItem
            // 
            resources.ApplyResources(this.speichernToolStripMenuItem, "speichernToolStripMenuItem");
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.Save_Click);
            // 
            // speichernUnterToolStripMenuItem
            // 
            resources.ApplyResources(this.speichernUnterToolStripMenuItem, "speichernUnterToolStripMenuItem");
            this.speichernUnterToolStripMenuItem.Name = "speichernUnterToolStripMenuItem";
            this.speichernUnterToolStripMenuItem.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // beendenToolStripMenuItem
            // 
            resources.ApplyResources(this.beendenToolStripMenuItem, "beendenToolStripMenuItem");
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.Close_Click);
            // 
            // bearbeitenToolStripMenuItem
            // 
            resources.ApplyResources(this.bearbeitenToolStripMenuItem, "bearbeitenToolStripMenuItem");
            this.bearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rückgängigToolStripMenuItem,
            this.kopierenToolStripMenuItem,
            this.ausschneidenToolStripMenuItem,
            this.einfügenToolStripMenuItem,
            this.allesMarkierenToolStripMenuItem});
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            // 
            // rückgängigToolStripMenuItem
            // 
            resources.ApplyResources(this.rückgängigToolStripMenuItem, "rückgängigToolStripMenuItem");
            this.rückgängigToolStripMenuItem.Name = "rückgängigToolStripMenuItem";
            this.rückgängigToolStripMenuItem.Click += new System.EventHandler(this.Rückgängig_Click);
            // 
            // kopierenToolStripMenuItem
            // 
            resources.ApplyResources(this.kopierenToolStripMenuItem, "kopierenToolStripMenuItem");
            this.kopierenToolStripMenuItem.Name = "kopierenToolStripMenuItem";
            this.kopierenToolStripMenuItem.Click += new System.EventHandler(this.Kopieren_Click);
            // 
            // ausschneidenToolStripMenuItem
            // 
            resources.ApplyResources(this.ausschneidenToolStripMenuItem, "ausschneidenToolStripMenuItem");
            this.ausschneidenToolStripMenuItem.Name = "ausschneidenToolStripMenuItem";
            this.ausschneidenToolStripMenuItem.Click += new System.EventHandler(this.Ausschneiden_Click);
            // 
            // einfügenToolStripMenuItem
            // 
            resources.ApplyResources(this.einfügenToolStripMenuItem, "einfügenToolStripMenuItem");
            this.einfügenToolStripMenuItem.Name = "einfügenToolStripMenuItem";
            this.einfügenToolStripMenuItem.Click += new System.EventHandler(this.Einfügen_Click);
            // 
            // allesMarkierenToolStripMenuItem
            // 
            resources.ApplyResources(this.allesMarkierenToolStripMenuItem, "allesMarkierenToolStripMenuItem");
            this.allesMarkierenToolStripMenuItem.Name = "allesMarkierenToolStripMenuItem";
            this.allesMarkierenToolStripMenuItem.Click += new System.EventHandler(this.AllesMarkieren_Click);
            // 
            // suchenToolStripMenuItem
            // 
            resources.ApplyResources(this.suchenToolStripMenuItem, "suchenToolStripMenuItem");
            this.suchenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suchenToolStripMenuItem1,
            this.weitersuchenToolStripMenuItem,
            this.ersetzenToolStripMenuItem});
            this.suchenToolStripMenuItem.Name = "suchenToolStripMenuItem";
            // 
            // suchenToolStripMenuItem1
            // 
            resources.ApplyResources(this.suchenToolStripMenuItem1, "suchenToolStripMenuItem1");
            this.suchenToolStripMenuItem1.Name = "suchenToolStripMenuItem1";
            this.suchenToolStripMenuItem1.Click += new System.EventHandler(this.Suchen_Click);
            // 
            // weitersuchenToolStripMenuItem
            // 
            resources.ApplyResources(this.weitersuchenToolStripMenuItem, "weitersuchenToolStripMenuItem");
            this.weitersuchenToolStripMenuItem.Name = "weitersuchenToolStripMenuItem";
            this.weitersuchenToolStripMenuItem.Click += new System.EventHandler(this.Weitersuchen_Click);
            // 
            // ersetzenToolStripMenuItem
            // 
            resources.ApplyResources(this.ersetzenToolStripMenuItem, "ersetzenToolStripMenuItem");
            this.ersetzenToolStripMenuItem.Name = "ersetzenToolStripMenuItem";
            this.ersetzenToolStripMenuItem.Click += new System.EventHandler(this.Ersetzen_Click);
            // 
            // optionenToolStripMenuItem
            // 
            resources.ApplyResources(this.optionenToolStripMenuItem, "optionenToolStripMenuItem");
            this.optionenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schriftartToolStripMenuItem,
            this.zeilenumbruchToolStripMenuItem,
            this.darkModeToolStripMenuItem});
            this.optionenToolStripMenuItem.Name = "optionenToolStripMenuItem";
            // 
            // schriftartToolStripMenuItem
            // 
            resources.ApplyResources(this.schriftartToolStripMenuItem, "schriftartToolStripMenuItem");
            this.schriftartToolStripMenuItem.Name = "schriftartToolStripMenuItem";
            this.schriftartToolStripMenuItem.Click += new System.EventHandler(this.Font_Click);
            // 
            // zeilenumbruchToolStripMenuItem
            // 
            resources.ApplyResources(this.zeilenumbruchToolStripMenuItem, "zeilenumbruchToolStripMenuItem");
            this.zeilenumbruchToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.zeilenumbruchToolStripMenuItem.CheckOnClick = true;
            this.zeilenumbruchToolStripMenuItem.Name = "zeilenumbruchToolStripMenuItem";
            this.zeilenumbruchToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.Zeilenumbruch_CheckStateChanged);
            // 
            // darkModeToolStripMenuItem
            // 
            resources.ApplyResources(this.darkModeToolStripMenuItem, "darkModeToolStripMenuItem");
            this.darkModeToolStripMenuItem.CheckOnClick = true;
            this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            this.darkModeToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.DarkMode_CheckedChanged);
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // infoToolStripMenuItem
            // 
            resources.ApplyResources(this.infoToolStripMenuItem, "infoToolStripMenuItem");
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.Info_Click);
            // 
            // textBox
            // 
            resources.ApplyResources(this.textBox, "textBox");
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Name = "textBox";
            this.textBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mainMenu;
        private ToolStripMenuItem dateiToolStripMenuItem;
        private ToolStripMenuItem öffnenToolStripMenuItem;
        private ToolStripMenuItem speichernToolStripMenuItem;
        private ToolStripMenuItem beendenToolStripMenuItem;
        private ToolStripMenuItem neuToolStripMenuItem;
        private ToolStripMenuItem speichernUnterToolStripMenuItem;
        private FontDialog fontDialog;
        private ToolStripMenuItem optionenToolStripMenuItem;
        private ToolStripMenuItem schriftartToolStripMenuItem;
        private ToolStripMenuItem darkModeToolStripMenuItem;
        private ToolStripMenuItem zeilenumbruchToolStripMenuItem;
        private TextBox textBox;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem bearbeitenToolStripMenuItem;
        private ToolStripMenuItem kopierenToolStripMenuItem;
        private ToolStripMenuItem ausschneidenToolStripMenuItem;
        private ToolStripMenuItem einfügenToolStripMenuItem;
        private ToolStripMenuItem allesMarkierenToolStripMenuItem;
        private ToolStripMenuItem suchenToolStripMenuItem;
        private ToolStripMenuItem suchenToolStripMenuItem1;
        private ToolStripMenuItem ersetzenToolStripMenuItem;
        private ToolStripMenuItem weitersuchenToolStripMenuItem;
        private ToolStripMenuItem rückgängigToolStripMenuItem;
    }
}