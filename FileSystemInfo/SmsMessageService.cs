using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemInfo
{
    public class SmsMessageService : ISender
    {
        public void SendMessage(string to, string text)
        {
            Console.WriteLine("Отправка сообщение завершена");
        }
    }
}
