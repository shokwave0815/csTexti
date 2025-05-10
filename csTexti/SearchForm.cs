namespace csTexti {
    public partial class SearchForm : Form {
        public SearchForm(bool darkMode) {
            InitializeComponent();
            SetDarkMode(darkMode);
        }

        private void SetDarkMode(bool darkMode) {
            Color foreColor;
            Color backColor;

            if (darkMode) {
                foreColor = Color.FromName("Control");
                backColor = Color.FromArgb(25, 25, 25);
                this.BackColor = Color.FromArgb(45, 45, 45);
            } else {
                foreColor = Color.FromName("ControlText");
                backColor = Color.FromName("Control");
                this.BackColor = backColor;
            }
            SetColors(foreColor, backColor, tbSearchString);
            SetColors(foreColor, this.BackColor, labSearchText);
            SetColors(foreColor, backColor, btnOK);
            SetColors(foreColor, backColor, btnCancel);
        }

        private void SetColors(Color foreColor, Color backColor, Control control) {
            control.ForeColor = foreColor;
            control.BackColor = backColor;
        }

        private void btnOK_Click(object sender, EventArgs e) {
            if (tbSearchString.Text != String.Empty) {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
