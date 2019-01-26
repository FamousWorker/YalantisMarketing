using Folder_Options.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Folder_Options
{
    public partial class SearchResult : Form
    {
        string loadetfile = "loadetfile.csv";
        List<SearchResultRow> resultRows;
        public SearchResult(string filepath, string[] domains, bool load)
        {
            InitializeComponent();
            List<string> csvdomains = new List<string>();
            if(load)
            {
                LoadFile(filepath);
                csvdomains = GetCsvDomains(loadetfile);
            }                
            else
                csvdomains = GetCsvDomains(filepath);
            resultRows = Search(csvdomains, domains);
            List<SearchResultRow> Rows = new List<SearchResultRow>();
            foreach (var item in resultRows)
            {
                if (!item.Found)
                    Rows.Add(item);
            }
            foreach (var item in resultRows)
            {
                if (item.Found)
                    Rows.Add(item);
            }
            dataGridWithVScrool1.DataSource = Rows;
            dataGridWithVScrool1.Columns[2].Visible = false;
            File.Delete(loadetfile);
        }

        void LoadFile(string filepath)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFileAsync(new Uri(filepath), loadetfile);
            }
            catch (WebException) { MessageBox.Show("Ошибка загрузки файла!"); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }


        private List<SearchResultRow> Search(List<string> csvdomains, string[] domains)
        {
            List<SearchResultRow> Rows = new List<SearchResultRow>();
            foreach (var item in domains)
            {
                if (item == string.Empty) continue;
                SearchResultRow rr = new SearchResultRow();
                rr.Name = item;
                rr.Result = Folder_Options.Properties.Resources.found;
                rr.Found = false;
                foreach (var domain in csvdomains)
                {
                    if(domain.Contains(rr.Name))
                    {
                        rr.Result = Folder_Options.Properties.Resources.not_found;
                        rr.Found = true;
                        break;
                    }
                }
                Rows.Add(rr);
            }
            return Rows;
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

        private void dataGridWithVScrool1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }
    }
}
