using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folder_Options.Classes
{
    public static class LinkCutter
    {

        public static void CutLinks(string filepath)
        {
            result = new List<string>();
            List<string> preresult = GetNames(filepath);
            Cut(preresult);
            Writte();
        }
        static List<string> result;
        static string savepath = "cutter_result.csv";

        static void Writte()
        {
            writing:
            try
            {
                using (StreamWriter writer = new StreamWriter(savepath))
                {
                    foreach (var item in result)
                    {
                        writer.WriteLine(item);
                    }
                    writer.Flush();
                }
                MessageBox.Show("Done!");
            }
            catch (System.IO.IOException)
            {
                if (MessageBox.Show("Невозможно получить доступ к файлу, файл используется другим процессом! Попробовать еще раз?", "Ошибка", MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                    goto writing;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        static void Cut(List<string> preresult)
        {
            foreach (var item in preresult)
            {
                string addetstring = item;
                if (addetstring.Contains("https://"))
                {
                    addetstring = addetstring.Remove(0, 8);
                }
                if (addetstring.Contains("http://"))
                {
                    addetstring = addetstring.Remove(0, 7);
                }
                if (addetstring.Contains("www."))
                {
                    addetstring = addetstring.Remove(0, 4);
                }
                addetstring = addetstring.Remove(addetstring.IndexOf('/'));
                result.Add(addetstring);
            }
        }

        static List<string> GetNames(string FilePath)
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
    }
}
