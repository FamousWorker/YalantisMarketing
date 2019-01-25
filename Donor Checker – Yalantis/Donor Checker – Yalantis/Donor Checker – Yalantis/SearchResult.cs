using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Folder_Options
{
    public partial class SearchResult : Form
    {

        public SearchResult(string filepath, string[] domains)
        {
            InitializeComponent();

            List<string> csvdomains = GetCsvDomains(filepath);
            dataGridWithVScrool1.DataSource = search(csvdomains, domains);
        }

        private List<SearchResultRow> search(List<string> csvdomains, string[] domains)
        {
            List<SearchResultRow> resultRows = new List<SearchResultRow>();
            foreach (var item in domains)
            {
                if (item == string.Empty) continue;
                SearchResultRow rr = new SearchResultRow();
                rr.Name = item;
                rr.Result = Folder_Options.Properties.Resources.found;
                foreach (var domain in csvdomains)
                {
                    if(domain.Contains(rr.Name))
                    {
                        rr.Result = Folder_Options.Properties.Resources.not_found;
                        break;
                    }
                }
                resultRows.Add(rr);
            }
            return resultRows;
        }

        private List<string> GetCsvDomains(string FilePath)
        {
            List<string> res = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    while (!sr.EndOfStream) res.Add(sr.ReadLine());
                }
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show("Файл не найден.Проверьте правильность пути к файлу!", "Ошибка", MessageBoxButtons.OK);
                this.Close();
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Файл не найден.Проверьте правильность пути к файлу!", "Ошибка", MessageBoxButtons.OK);
                this.Close();
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Невозможно получить доступ к файлу, файл используется другим процессом!", "Ошибка", MessageBoxButtons.OK);
                this.Close();
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("Пустое имя файла не допускается!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.Close();
            }
            return res;
        }

    }
}
