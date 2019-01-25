using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pars_tool.Class
{
    class CsvReaderWriter
    {
        List<string> Sources;
        List<ParsedResult> result;
        int nextposition;
        string fileresultpath;
        bool isdone = false;
        public CsvReaderWriter(string filepath, string resultpath)
        {
            Sources = GetCsvDomains(filepath);
            nextposition = 0;
            result = new List<ParsedResult>();
            result.Add(ParsedResult.getHeaders());
            fileresultpath = resultpath;
        }
        public int getMax()
        {
            return Sources.Count;
        }
        public string getNextSource()
        {
            if (nextposition == 10)//Sources.Count)
            {
                if(!isdone)
                {
                    WriteResult();
                    isdone = true;
                }                
                return null;
            }
            nextposition++;
            return Sources[nextposition - 1];
        }
        public void insertParsed(ParsedResult parsed)
        {
            result.Add(parsed);
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
            try
            {
                using (Stream stream = File.OpenWrite(fileresultpath))
                {
                    stream.SetLength(0);
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        string[] wrapped = new string[result.Count];
                        foreach (var item in result)
                        {
                            string line = null;
                            if (item.Rank != "Error 404")
                            {
                                line =
                               string.Join(";",
                               item.Url
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
                            }
                            else
                                line = string.Join(";", item.Url, item.Rank);

                            writer.WriteLine(line);
                        }
                        //File.AppendAllText(fileresultpath, wrapped.ToString(), Encoding.GetEncoding(1251));
                        writer.Flush();
                    }
                };
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Невозможно получить доступ к файлу, файл используется другим процессом!", "Ошибка", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
