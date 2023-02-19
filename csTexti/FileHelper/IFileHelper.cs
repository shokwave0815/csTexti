namespace csTexti
{
    internal interface IFileHelper
    {
        public void SaveFile(string filename, string text);
        public string LoadFile(string filename);
    }
}
