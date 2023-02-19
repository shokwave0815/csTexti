using System.Resources;

namespace csTexti
{
    internal class DialogHelper
    {
        private readonly static ResourceManager resourceManager = new("csTexti.LanguageStrings", typeof(MainForm).Assembly);
        public static string GetFilenameFromOpenDialog() { return OpenDialog(new OpenFileDialog()); }
        public static string GetFilenameFromSaveDialog() { return OpenDialog(new SaveFileDialog()); }

        private static string OpenDialog(FileDialog dialog)
        {
            try
            {
                dialog.Filter = resourceManager.GetString("FilterText");
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }

            dialog.InitialDirectory = Directory.GetCurrentDirectory();
            dialog.CheckFileExists = false;
            dialog.CheckPathExists = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.FileName;
            }
            return "";
        }

        public static DialogResult AskSaveChanges()
        {
            return MessageBox.Show(
                resourceManager.GetString("CloseText"),
                resourceManager.GetString("CloseCaption"),
                MessageBoxButtons.YesNoCancel
                );
        }

    }
}
