using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace UserInterface
{
   public class AppSettings
    {
        private static readonly string sr_FileLocation = @"C:\Users\Public\Documents\";
        private static readonly string sr_FileName = @"appSettings.xml";
        private readonly Size m_DefaultWindowSize = new Size(728, 560);
        private readonly Point m_DefaultWindowLocation = new Point(30, 50);

        public Point LastWindowLocation { get; set; }

        public Size LastWindowSize { get; set; }

        public bool RemeberUser { get; set; }

        public string LastAccessToken { get; set; }

        public AppSettings()
        {
            RemeberUser = false;
            LastAccessToken = null;
            LastWindowSize = m_DefaultWindowSize;
            LastWindowLocation = m_DefaultWindowLocation;
        }
        
        public static AppSettings LoadFromFile()
        {
            AppSettings obj = new AppSettings();

            if (File.Exists(string.Format("{0}{1}", sr_FileLocation, sr_FileName)))
            {
                using (Stream stream = new FileStream(string.Format("{0}{1}", sr_FileLocation, sr_FileName), FileMode.Open))
                {
                    XmlSerializer serielizer = new XmlSerializer(typeof(AppSettings));
                    obj = serielizer.Deserialize(stream) as AppSettings;
                }
            }

            return obj;
        }

        public void SaveToFile()
        {
            if (File.Exists(string.Format("{0}{1}", sr_FileLocation, sr_FileName)))
                {
                using (Stream stream = new FileStream(string.Format("{0}{1}", sr_FileLocation, sr_FileName), FileMode.Truncate))
                {
                    XmlSerializer serielizer = new XmlSerializer(this.GetType());
                    serielizer.Serialize(stream, this);
                }
            }
            else
            {
                using (Stream stream = new FileStream(string.Format("{0}{1}", sr_FileLocation, sr_FileName), FileMode.CreateNew))
                {
                    XmlSerializer serielizer = new XmlSerializer(this.GetType());
                    serielizer.Serialize(stream, this);
                }
            }
        }
    }
}
