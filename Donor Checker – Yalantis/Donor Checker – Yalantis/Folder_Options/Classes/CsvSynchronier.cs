using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folder_Options.Classes
{
   public class CsvSynchronier
    {
        string fileresultpath = "sync_result.csv";
        public void StartSynch(string savefilepath, string examplefilepath, 
            int index1, int index2, int index3, int index4, int index5, int index6, int index7)
        {
            List<string[]> result =  Synch(getSaveLines(savefilepath), getExampleLines(examplefilepath),
               index1, index2, index3, index4, index5, index6, index7);
            WriteResult(result);
        }
        private void WriteResult(List<string[]> result)
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
                            string line  = string.Join(";", item[0], item[1], item[2], item[3], item[4], item[5], item[6],item[7]);
                            writer.WriteLine(line);
                        }
                        writer.Flush();
                        MessageBox.Show("Done!");
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

        List<string[]> Synch(List<string[]> saves, List<string[]> examples, 
            int index1, int index2, int index3, int index4, int index5, int index6, int index7)
        {
            List<string[]> result = saves;
            foreach (var item in saves)
            {
                string[] examp =
                    examples.FirstOrDefault(mas => mas[0].ToLower().Trim() == item[0].ToLower().Trim());
                if (examp == null) continue;
                if (examp.Length >= index1 + 1 && index1 != 0)
                    item[1] = examp[index1];
                if (examp.Length >= index2 + 1 && index2 != 0)
                    item[2] = examp[index2];
                if (examp.Length >= index3 + 1 && index3 != 0)
                    item[3] = examp[index3];
                if (examp.Length >= index4 + 1 && index4 != 0)
                    item[4] = examp[index4];
                if (examp.Length >= index5 + 1 && index5 != 0)
                    item[5] = examp[index5];
                if (examp.Length >= index6 + 1 && index6 != 0)
                    item[6] = examp[index6];
                if (examp.Length >= index7 + 1 && index7 != 0)
                    item[7] = examp[index7];
            }
            return result;
        }

        List<string[]> getSaveLines(string filepath)
        {
            List<string[]> result = new List<string[]>();
            try
            {
                string[] Lines = File.ReadAllLines(filepath);
                foreach (var item in Lines)
                {
                    string[] resultline = new string[8];
                    resultline[0] = item;
                    result.Add(resultline);
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
            return result;
        }
        List<string[]> getExampleLines(string filepath)
        {
            List<string[]> result = new List<string[]>();
            try
            {
                string[] Lines = File.ReadAllLines(filepath);
                foreach (var item in Lines)
                {
                    string[] resultline = item.Split(';');
                    result.Add(resultline);
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
            return result;
        }

    }
}
