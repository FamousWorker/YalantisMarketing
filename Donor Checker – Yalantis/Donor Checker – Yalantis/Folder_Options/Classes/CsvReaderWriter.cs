using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Folder_Options.Classes
{
    class CsvReaderWriter
    {
        List<string> Sources;
        List<ParsedResult> result;
        int nextposition;
        string fileresultpath;
        bool isdone = false;
        bool da_pa, cf_tf, headers, dateparse;
        public CsvReaderWriter(string filepath, string resultpath, bool dp, bool ct, bool write_headers,bool dateparsing)
        {
            Sources = GetCsvDomains(filepath);
            nextposition = 0;
            result = new List<ParsedResult>();
            result.Add(ParsedResult.getHeaders());
            fileresultpath = resultpath;
            da_pa = dp;
            cf_tf = ct;
            headers = write_headers;
            dateparse = dateparsing;
        }
        public int getMax()
        {
            return Sources.Count;
        }
        public void endProcess()
        {
            WriteResult();
            isdone = true;
            nextposition = Sources.Count;
        }
        public string getNextSource()
        {
            if (nextposition == Sources.Count)
            {                               
                return null;
            }
            nextposition++;
            return Sources[nextposition - 1];
        }
        public void insertParsed(ParsedResult parsed)
        {
            result.Add(parsed);
            if (result.Count == 1 + Sources.Count)
            {
                WriteResult();
                //isdone = true;
            }
        }
        List<string> GetCsvDomains(string FilePath)
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
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Файл не найден.Проверьте правильность пути к файлу!", "Ошибка", MessageBoxButtons.OK);
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Невозможно получить доступ к файлу, файл используется другим процессом!", "Ошибка", MessageBoxButtons.OK);               
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("Пустое имя файла не допускается!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return res;
        }

        private void WriteResult()
        {
            writing:
            try
            {               
                using (Stream stream = File.OpenWrite(fileresultpath))
                {
                    stream.SetLength(0);
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        foreach (var item in result)
                        {
                            item.SetJSONvalues();
                            string line = null;
                            if (item.Rank != "-")
                            {
                                line = item.Url;
                               if(headers) line =
                               string.Join(";",
                               line
                               , item.Rank
                               , item.Overall_Visits
                               , item.Time_On_Site
                               , item.Pages_per_Visit
                               , item.Bounce_Rate
                               , item.Organic_Search
                               , item.Country_1
                               , item.Country_1_Procent
                               , item.Country_2
                               , item.Country_2_Procent
                               , item.Country_3
                               , item.Country_3_Procent
                               , item.Country_4
                               , item.Country_4_Procent
                               , item.Country_5
                               , item.Country_5_Procent                               
                               );
                                if (da_pa)
                                    line = string.Join(";", line,item.da, item.pa);
                                if (cf_tf)
                                    line = string.Join(";",line, item.cf,item.tf);
                                if(dateparse)
                                    line = string.Join(";", line, item.expiridate, item.creationdate);
                            }
                            else
                                line = string.Join(";", item.Url, item.Rank);

                            writer.WriteLine(line);
                        }
                        //File.AppendAllText(fileresultpath, wrapped.ToString(), Encoding.GetEncoding(1251));
                        writer.Flush();
                        MessageBox.Show("Done!");
                    }
                };
            }
            catch (System.IO.IOException)
            {
                if(MessageBox.Show("Невозможно получить доступ к файлу, файл используется другим процессом! Попробовать еще раз?", "Ошибка", MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                    goto writing;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
