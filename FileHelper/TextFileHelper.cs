namespace csTexti
{
    internal class TextFileHelper : IFileHelper
    {
        public string LoadFile(string filename)
        {
            string result = "";
            if (File.Exists(filename))
            {
                try
                {
                    FileStream fileStream = new(filename, FileMode.Open);
                    StreamReader streamReader = new(fileStream);
                    result += streamReader.ReadToEnd();
                    streamReader.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return result;
        }

        public void SaveFile(string filename, string text)
        {
            try
            {
                FileStream fileStream = new(filename, FileMode.Create);
                StreamWriter streamWriter = new(fileStream);
                streamWriter.Write(text);
                streamWriter.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
