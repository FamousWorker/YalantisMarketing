using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace YalantisMarketing.Classes.CsvReadWrite
{
    public class CsvReaderWriter : ICsvReaderWriter
    {
        public List<string> ReadFile(string filepath)
        {
            List<string> res = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(filepath))
                {
                    while (!sr.EndOfStream) res.Add(sr.ReadLine());
                }
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show("Файл не найден.Проверьте правильность пути к файлу!", "Ошибка");
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Файл не найден.Проверьте правильность пути к файлу!", "Ошибка");
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Невозможно получить доступ к файлу, файл используется другим процессом!", "Ошибка");
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
