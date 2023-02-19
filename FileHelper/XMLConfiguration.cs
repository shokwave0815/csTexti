using System.Text;
using System.Xml;

namespace csTexti
{
    public class XMLConfiguration : IConfiguration
    {
        private readonly MainForm form;
        private readonly string filename = Application.UserAppDataPath + "\\config.xml";

        public XMLConfiguration(MainForm form) { this.form = form; }

        public void Load()
        {
            if (File.Exists(filename))
            {
                XmlTextReader xml = new(filename);
                while (xml.Read())
                {
                    if (xml.NodeType == XmlNodeType.Element && xml.AttributeCount > 0)
                    {
                        switch (xml.Name)
                        {
                            case "Window":
                                ReadWindowConfig(xml);
                                break;
                            case "Font":
                                ReadFontConfig(xml);
                                break;
                            case "Options":
                                ReadOptionsConfig(xml);
                                break;
                            default:
                                break;
                        }
                    }
                }
                xml.Close();
            }
        }

        private void ReadWindowConfig(XmlTextReader xml)
        {
            xml.MoveToAttribute("Top");
            if (int.TryParse(xml.Value, out int x))
            {
                xml.MoveToAttribute("Left");
                if (int.TryParse(xml.Value, out int y))
                    form.SetDesktopLocation(x, y);
            }

            xml.MoveToAttribute("Width");
            if (int.TryParse(xml.Value, out int width))
            {
                xml.MoveToAttribute("Height");
                if (int.TryParse(xml.Value, out int height))
                    form.Size = new Size(width, height);
            }
        }

        private void ReadFontConfig(XmlTextReader xml)
        {
            TextBox tb = form.GetTextBox();
            xml.MoveToAttribute("Name");
            string name = xml.Value;
            xml.MoveToAttribute("Size");
            if (int.TryParse(xml.Value, out int size) && name != "")
                tb.Font = new Font(name, size);
        }

        private void ReadOptionsConfig(XmlTextReader xml)
        {
            xml.MoveToAttribute("WordWrap");
            if (bool.TryParse(xml.Value, out bool wordWrap))
                form.GetWordWrap().Checked = wordWrap;

            xml.MoveToAttribute("DarkMode");
            if (bool.TryParse(xml.Value, out bool darkMode))
                form.GetDarkMode().Checked = darkMode;
        }

        public void Save()
        {
            XmlTextWriter xml = new(filename, new UnicodeEncoding());
            xml.WriteStartDocument();
            xml.WriteStartElement("Configuration");

            WriteWindowConfig(xml);
            WriteFontConfig(xml);
            WriteOptions(xml);

            xml.WriteEndElement();
            xml.WriteEndDocument();
            xml.Close();
        }

        private void WriteWindowConfig(XmlTextWriter xml)
        {
            xml.WriteStartElement("Window");
            xml.WriteAttributeString("Top", form.Location.X.ToString());
            xml.WriteAttributeString("Left", form.Location.Y.ToString());
            xml.WriteAttributeString("Width", form.Size.Width.ToString());
            xml.WriteAttributeString("Height", form.Size.Height.ToString());
            xml.WriteEndElement();
        }

        private void WriteFontConfig(XmlTextWriter xml)
        {
            TextBox tb = form.GetTextBox();
            xml.WriteStartElement("Font");
            xml.WriteAttributeString("Name", tb.Font.Name);
            xml.WriteAttributeString("Size", tb.Font.Size.ToString());
            xml.WriteEndElement();
        }

        private void WriteOptions(XmlTextWriter xml)
        {
            xml.WriteStartElement("Options");
            xml.WriteAttributeString("WordWrap", form.GetWordWrap().Checked.ToString());
            xml.WriteAttributeString("DarkMode", form.GetDarkMode().Checked.ToString());
            xml.WriteAttributeString("Width", form.Size.Width.ToString());
            xml.WriteAttributeString("Height", form.Size.Height.ToString());
            xml.WriteEndElement();
        }

    }
}
