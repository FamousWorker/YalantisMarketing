using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using YalantisMarketing.Classes.CsvReadWrite;

namespace YalantisMarketing.Classes.OutreachPackage
{
    public class WebReader : IReader
    {
        string _filename;
        ICsvReaderWriter _csvReaderWriter;

        public WebReader()
        {
            _csvReaderWriter = new CsvReaderWriter();
            _filename = "loadetfile.txt";
        }
        public List<string> Read(string filepath)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFileAsync(new Uri(filepath), _filename);
            }
            catch (WebException) { MessageBox.Show("Ошибка загрузки файла!"); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); };
            List<string> result =  _csvReaderWriter.ReadFile(_filename);
            File.Delete(_filename);
            return result;
        }
    }
}
