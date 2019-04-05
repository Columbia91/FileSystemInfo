using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Работа с директивами
            //string fullPath = string.Empty;
            //List<DriveInfo> drives = DriveInfo.GetDrives().ToList();

            //try
            //{
            //    for (int i = 0; i < drives.Count; i++)
            //    {
            //        if(drives[i].IsReady)
            //            Console.WriteLine($"имя: {drives[i].Name}" +
            //                $"\nПолный размер: {drives[i].TotalSize} \nСвободное место: {drives[i].TotalFreeSpace}" +
            //                $"\n******************************");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.WriteLine("Выберите порядковый номер диска:");
            //int drivePosition = int.Parse(Console.ReadLine());

            //fullPath += drives[drivePosition].Name;
            //Console.Clear();

            //DirectoryInfo directoryInfo = new DirectoryInfo(fullPath);
            //var systemFiles = directoryInfo.GetFileSystemInfos();

            //for (int i = 0; i < systemFiles.Length; i++)
            //{
            //    string extension = string.IsNullOrEmpty(systemFiles[i].Extension) ? "---" : systemFiles[i].Extension;
            //    Console.WriteLine($"{i}. Имя: {systemFiles[i].Name} " +
            //        $"Расширение: {extension}");
            //}

            //Console.WriteLine("Выберите порядковый номер файла или папки:");
            //int systemInfoPosition = int.Parse(Console.ReadLine());
            //fullPath += systemFiles[systemInfoPosition].Name;

            //if (!string.IsNullOrEmpty(systemFiles[systemInfoPosition].Extension))
            //{
            //    Process.Start(fullPath);
            //}
            #endregion

            #region Запись файла
            //File.Create(@"C:\1\data.txt").Close();

            //using(StreamWriter writer = new StreamWriter(@"C:\1\data.txt"))
            //{
            //    string data = "Какой-то текст";
            //    writer.WriteLine(data);
            //}
            //using(var reader = new StreamReader(@"C:\1\data.txt"))
            //{
            //    string result = reader.ReadToEnd();
            //    Console.WriteLine(result);
            //}
            #endregion

            #region Запись и считывание побайтно
            string path = @"C:\1\data.txt";
            using (var stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                string data = "123asd";
                byte[] array = Encoding.UTF8.GetBytes(data);
                stream.Write(array, 0, array.Length);
            }

            using (var stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                byte[] array = new byte[stream.Length];
                stream.Read(array, 0, array.Length);
                string result = Encoding.UTF8.GetString(array);
            }
            #endregion

            ISender service = new TelegramMessageService();
            service.SendMessage("+77777777777", "Смени номер, придурок");


        }

        static ISender GetSender()
        {
            return new SmsMessageService();
        }
    }
}