using System.Resources;

namespace csTexti {
    public partial class MainForm : Form {
        private readonly ResourceManager resourceManager = new("csTexti.LanguageStrings", typeof(MainForm).Assembly);
        private readonly IFileHelper fileHelper = new TextFileHelper();
        private readonly IConfiguration config;
        private bool textDidChange = false;
        private string filename = "";
        private string searchString = "";
        private string replaceString = "";
        private int lastFoundPosition = 0;

        private void MainForm_Load(object sender, EventArgs e) { config.Load(); }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) { config.Save(); }
        private void SaveAs_Click(object sender, EventArgs e) { SetFilename(SaveWithDialog()); }
        private void Close_Click(object sender, EventArgs e) { Close(); }
        private void Rückgängig_Click(object sender, EventArgs e) { if (textBox.CanUndo) textBox.Undo(); }
        private void Kopieren_Click(object sender, EventArgs e) { textBox.Copy(); }
        private void Ausschneiden_Click(object sender, EventArgs e) { textBox.Cut(); }
        private void Einfügen_Click(object sender, EventArgs e) { textBox.Paste(); }
        private void AllesMarkieren_Click(object sender, EventArgs e) { textBox.SelectAll(); }
        private void Zeilenumbruch_CheckStateChanged(object sender, EventArgs e) { textBox.WordWrap = zeilenumbruchToolStripMenuItem.Checked; }
        private void DarkMode_CheckedChanged(object sender, EventArgs e) { SetDarkMode(((ToolStripMenuItem)sender).Checked); }
        private void TextBox_TextChanged(object sender, EventArgs e) { textDidChange = true; }

        public TextBox GetTextBox() { return textBox; }
        public ToolStripMenuItem GetWordWrap() { return zeilenumbruchToolStripMenuItem; }
        public ToolStripMenuItem GetDarkMode() { return darkModeToolStripMenuItem; }

        public MainForm(string[] args) {
            //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            InitializeComponent();

            config = new XMLConfiguration(this);

            if (args.Length > 0) {
                textBox.Text = fileHelper.LoadFile(args[0]);
                SetFilename(args[0]);
                textBox.SelectionStart = 0;
                textBox.SelectionLength = 0;
            }
        }

        private void New_Click(object sender, EventArgs e) {
            if (textDidChange) {
                switch (DialogHelper.AskSaveChanges()) {
                    case DialogResult.Yes:
                        if (filename == "")
                            SetFilename(SaveWithDialog());
                        else
                            fileHelper.SaveFile(filename, textBox.Text);
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        return;
                    default:
                        break;
                }
            }
            SetupNewDocument();
        }

        private void Open_Click(object sender, EventArgs e) {
            if (textDidChange) {
                switch (DialogHelper.AskSaveChanges()) {
                    case DialogResult.Yes:
                        if (filename == "")
                            SetFilename(SaveWithDialog());
                        else
                            fileHelper.SaveFile(filename, textBox.Text);
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        return;
                    default:
                        break;
                }
            }

            string newFilename = DialogHelper.GetFilenameFromOpenDialog();
            if (newFilename != "") {
                textBox.Text = fileHelper.LoadFile(newFilename);
                SetFilename(newFilename);
            }
        }

        private void Save_Click(object sender, EventArgs e) {
            if (textDidChange) {
                if (filename == "") {
                    SetFilename(SaveWithDialog());
                } else {
                    fileHelper.SaveFile(filename, textBox.Text);
                    SetFilename(filename);
                }
            }
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (textDidChange) {
                switch (DialogHelper.AskSaveChanges()) {
                    case DialogResult.Yes:
                        //save file and close
                        if (filename == "")
                            SetFilename(SaveWithDialog());
                        else
                            fileHelper.SaveFile(filename, textBox.Text);
                        break;
                    case DialogResult.No:
                        //don't save and close -> do nothing here
                        break;
                    case DialogResult.Cancel:
                        //don't save and dont't close
                        e.Cancel = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void Suchen_Click(object sender, EventArgs e) {
            SearchForm searchForm = new(darkModeToolStripMenuItem.Checked);

            if (searchString != String.Empty) { searchForm.tbSearchString.Text = searchString; }

            if (searchForm.ShowDialog() == DialogResult.OK) {
                lastFoundPosition = -1;
                searchString = searchForm.tbSearchString.Text;
                SearchInTextBox();
            }
        }

        private void Weitersuchen_Click(object sender, EventArgs e) {
            if (searchString != String.Empty) {
                SearchInTextBox();
            }
        }

        private void Ersetzen_Click(object sender, EventArgs e) {
            ReplaceForm replaceForm = new(darkModeToolStripMenuItem.Checked);
            if (searchString != String.Empty) { replaceForm.tbSearch.Text = searchString; }
            if (replaceString != String.Empty) { replaceForm.tbReplace.Text = replaceString; }

            if (replaceForm.ShowDialog() == DialogResult.OK) {
                lastFoundPosition = -1;
                searchString = replaceForm.tbSearch.Text;
                replaceString = replaceForm.tbReplace.Text;
                ReplaceAllInTextBox();
            }
        }

        private void Font_Click(object sender, EventArgs e) {
            fontDialog.Font = textBox.Font;
            if (fontDialog.ShowDialog() == DialogResult.OK)
                textBox.Font = fontDialog.Font;
        }

        private void Info_Click(object sender, EventArgs e) {
            MessageBox.Show(resourceManager.GetString("InfoText"), resourceManager.GetString("InfoCaption"));
        }

        private void SetFilename(string newFilename) {
            filename = newFilename;
            textDidChange = false;
            Text = "csTexti - " + filename;
        }

        private string SaveWithDialog() {
            string newFilename = DialogHelper.GetFilenameFromSaveDialog();
            if (newFilename != "" && newFilename != filename) {
                fileHelper.SaveFile(newFilename, textBox.Text);
            }
            return newFilename;
        }

        private void SetupNewDocument() {
            textBox.Clear();
            SetFilename("");
        }

        private void SetDarkMode(bool dark) {
            Color foreColor;
            Color backColor;

            if (dark) {
                foreColor = Color.FromName("Control");
                backColor = Color.FromArgb(25, 25, 25);

                textBox.BackColor = Color.FromArgb(45, 45, 45);
                textBox.ForeColor = Color.LightGoldenrodYellow;
            } else {
                foreColor = Color.FromName("ControlText");
                backColor = Color.FromName("Control");

                textBox.BackColor = Color.FromName("Window");
                textBox.ForeColor = Color.FromName("WindowText");
            }
            SetMenuColors(foreColor, backColor);
        }

        private void SetMenuColors(Color foreColor, Color backColor) {
            mainMenu.BackColor = backColor;
            foreach (ToolStripMenuItem item in mainMenu.Items) {
                SetColors(foreColor, backColor, item);
                foreach (ToolStripMenuItem child in item.DropDownItems) {
                    SetColors(foreColor, backColor, child);
                }
            }
        }

        private static void SetColors(Color foreColor, Color backColor, ToolStripMenuItem item) {
            item.ForeColor = foreColor;
            item.BackColor = backColor;
        }

        private void SearchInTextBox() {
            int currentFoundPosition = textBox.Text.IndexOf(searchString, lastFoundPosition + 1);
            if (currentFoundPosition > -1) {
                lastFoundPosition = currentFoundPosition;
                textBox.SelectionStart = currentFoundPosition;
                textBox.SelectionLength = searchString.Length;
                textBox.ScrollToCaret();
            } else {
                string? message = resourceManager.GetString("NotFoundText");
                if (message != null)
                    MessageBox.Show(String.Format(message, searchString), resourceManager.GetString("NotFoundCaption"));
            }
        }

        private void ReplaceAllInTextBox() {
            textBox.Text = textBox.Text.Replace(searchString, replaceString, StringComparison.Ordinal);
        }

    }
}