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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            mainMenu = new MenuStrip();
            dateiToolStripMenuItem = new ToolStripMenuItem();
            neuToolStripMenuItem = new ToolStripMenuItem();
            öffnenToolStripMenuItem = new ToolStripMenuItem();
            speichernToolStripMenuItem = new ToolStripMenuItem();
            speichernUnterToolStripMenuItem = new ToolStripMenuItem();
            beendenToolStripMenuItem = new ToolStripMenuItem();
            bearbeitenToolStripMenuItem = new ToolStripMenuItem();
            rückgängigToolStripMenuItem = new ToolStripMenuItem();
            kopierenToolStripMenuItem = new ToolStripMenuItem();
            ausschneidenToolStripMenuItem = new ToolStripMenuItem();
            einfügenToolStripMenuItem = new ToolStripMenuItem();
            allesMarkierenToolStripMenuItem = new ToolStripMenuItem();
            suchenToolStripMenuItem = new ToolStripMenuItem();
            suchenToolStripMenuItem1 = new ToolStripMenuItem();
            weitersuchenToolStripMenuItem = new ToolStripMenuItem();
            ersetzenToolStripMenuItem = new ToolStripMenuItem();
            optionenToolStripMenuItem = new ToolStripMenuItem();
            schriftartToolStripMenuItem = new ToolStripMenuItem();
            zeilenumbruchToolStripMenuItem = new ToolStripMenuItem();
            darkModeToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            fontDialog = new FontDialog();
            textBox = new TextBox();
            mainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.BackColor = SystemColors.Control;
            mainMenu.ImageScalingSize = new Size(20, 20);
            mainMenu.Items.AddRange(new ToolStripItem[] { dateiToolStripMenuItem, bearbeitenToolStripMenuItem, suchenToolStripMenuItem, optionenToolStripMenuItem, toolStripMenuItem1 });
            resources.ApplyResources(mainMenu, "mainMenu");
            mainMenu.Name = "mainMenu";
            // 
            // dateiToolStripMenuItem
            // 
            dateiToolStripMenuItem.BackColor = SystemColors.Control;
            dateiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { neuToolStripMenuItem, öffnenToolStripMenuItem, speichernToolStripMenuItem, speichernUnterToolStripMenuItem, beendenToolStripMenuItem });
            dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            resources.ApplyResources(dateiToolStripMenuItem, "dateiToolStripMenuItem");
            // 
            // neuToolStripMenuItem
            // 
            neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            resources.ApplyResources(neuToolStripMenuItem, "neuToolStripMenuItem");
            neuToolStripMenuItem.Click += New_Click;
            // 
            // öffnenToolStripMenuItem
            // 
            öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            resources.ApplyResources(öffnenToolStripMenuItem, "öffnenToolStripMenuItem");
            öffnenToolStripMenuItem.Click += Open_Click;
            // 
            // speichernToolStripMenuItem
            // 
            speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            resources.ApplyResources(speichernToolStripMenuItem, "speichernToolStripMenuItem");
            speichernToolStripMenuItem.Click += Save_Click;
            // 
            // speichernUnterToolStripMenuItem
            // 
            speichernUnterToolStripMenuItem.Name = "speichernUnterToolStripMenuItem";
            resources.ApplyResources(speichernUnterToolStripMenuItem, "speichernUnterToolStripMenuItem");
            speichernUnterToolStripMenuItem.Click += SaveAs_Click;
            // 
            // beendenToolStripMenuItem
            // 
            beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            resources.ApplyResources(beendenToolStripMenuItem, "beendenToolStripMenuItem");
            beendenToolStripMenuItem.Click += Close_Click;
            // 
            // bearbeitenToolStripMenuItem
            // 
            bearbeitenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rückgängigToolStripMenuItem, kopierenToolStripMenuItem, ausschneidenToolStripMenuItem, einfügenToolStripMenuItem, allesMarkierenToolStripMenuItem });
            bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            resources.ApplyResources(bearbeitenToolStripMenuItem, "bearbeitenToolStripMenuItem");
            // 
            // rückgängigToolStripMenuItem
            // 
            rückgängigToolStripMenuItem.Name = "rückgängigToolStripMenuItem";
            resources.ApplyResources(rückgängigToolStripMenuItem, "rückgängigToolStripMenuItem");
            rückgängigToolStripMenuItem.Click += Rückgängig_Click;
            // 
            // kopierenToolStripMenuItem
            // 
            kopierenToolStripMenuItem.Name = "kopierenToolStripMenuItem";
            resources.ApplyResources(kopierenToolStripMenuItem, "kopierenToolStripMenuItem");
            kopierenToolStripMenuItem.Click += Kopieren_Click;
            // 
            // ausschneidenToolStripMenuItem
            // 
            ausschneidenToolStripMenuItem.Name = "ausschneidenToolStripMenuItem";
            resources.ApplyResources(ausschneidenToolStripMenuItem, "ausschneidenToolStripMenuItem");
            ausschneidenToolStripMenuItem.Click += Ausschneiden_Click;
            // 
            // einfügenToolStripMenuItem
            // 
            einfügenToolStripMenuItem.Name = "einfügenToolStripMenuItem";
            resources.ApplyResources(einfügenToolStripMenuItem, "einfügenToolStripMenuItem");
            einfügenToolStripMenuItem.Click += Einfügen_Click;
            // 
            // allesMarkierenToolStripMenuItem
            // 
            allesMarkierenToolStripMenuItem.Name = "allesMarkierenToolStripMenuItem";
            resources.ApplyResources(allesMarkierenToolStripMenuItem, "allesMarkierenToolStripMenuItem");
            allesMarkierenToolStripMenuItem.Click += AllesMarkieren_Click;
            // 
            // suchenToolStripMenuItem
            // 
            suchenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { suchenToolStripMenuItem1, weitersuchenToolStripMenuItem, ersetzenToolStripMenuItem });
            suchenToolStripMenuItem.Name = "suchenToolStripMenuItem";
            resources.ApplyResources(suchenToolStripMenuItem, "suchenToolStripMenuItem");
            // 
            // suchenToolStripMenuItem1
            // 
            suchenToolStripMenuItem1.Name = "suchenToolStripMenuItem1";
            resources.ApplyResources(suchenToolStripMenuItem1, "suchenToolStripMenuItem1");
            suchenToolStripMenuItem1.Click += Suchen_Click;
            // 
            // weitersuchenToolStripMenuItem
            // 
            weitersuchenToolStripMenuItem.Name = "weitersuchenToolStripMenuItem";
            resources.ApplyResources(weitersuchenToolStripMenuItem, "weitersuchenToolStripMenuItem");
            weitersuchenToolStripMenuItem.Click += Weitersuchen_Click;
            // 
            // ersetzenToolStripMenuItem
            // 
            ersetzenToolStripMenuItem.Name = "ersetzenToolStripMenuItem";
            resources.ApplyResources(ersetzenToolStripMenuItem, "ersetzenToolStripMenuItem");
            ersetzenToolStripMenuItem.Click += Ersetzen_Click;
            // 
            // optionenToolStripMenuItem
            // 
            optionenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { schriftartToolStripMenuItem, zeilenumbruchToolStripMenuItem, darkModeToolStripMenuItem });
            optionenToolStripMenuItem.Name = "optionenToolStripMenuItem";
            resources.ApplyResources(optionenToolStripMenuItem, "optionenToolStripMenuItem");
            // 
            // schriftartToolStripMenuItem
            // 
            schriftartToolStripMenuItem.Name = "schriftartToolStripMenuItem";
            resources.ApplyResources(schriftartToolStripMenuItem, "schriftartToolStripMenuItem");
            schriftartToolStripMenuItem.Click += Font_Click;
            // 
            // zeilenumbruchToolStripMenuItem
            // 
            zeilenumbruchToolStripMenuItem.BackColor = SystemColors.Control;
            zeilenumbruchToolStripMenuItem.CheckOnClick = true;
            zeilenumbruchToolStripMenuItem.Name = "zeilenumbruchToolStripMenuItem";
            resources.ApplyResources(zeilenumbruchToolStripMenuItem, "zeilenumbruchToolStripMenuItem");
            zeilenumbruchToolStripMenuItem.CheckStateChanged += Zeilenumbruch_CheckStateChanged;
            // 
            // darkModeToolStripMenuItem
            // 
            darkModeToolStripMenuItem.CheckOnClick = true;
            darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            resources.ApplyResources(darkModeToolStripMenuItem, "darkModeToolStripMenuItem");
            darkModeToolStripMenuItem.CheckStateChanged += DarkMode_CheckedChanged;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { infoToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            resources.ApplyResources(infoToolStripMenuItem, "infoToolStripMenuItem");
            infoToolStripMenuItem.Click += Info_Click;
            // 
            // textBox
            // 
            textBox.BorderStyle = BorderStyle.None;
            resources.ApplyResources(textBox, "textBox");
            textBox.Name = "textBox";
            textBox.TextChanged += TextBox_TextChanged;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(textBox);
            Controls.Add(mainMenu);
            MainMenuStrip = mainMenu;
            Name = "MainForm";
            FormClosing += MainForm_FormClosing;
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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