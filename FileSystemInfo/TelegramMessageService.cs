using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemInfo
{
    public class TelegramMessageService : ISender
    {
        public void SendMessage(string to, string text)
        {
            Console.WriteLine($"Telegram. Кому: {to}, Сообщение: {text}");
        }
    }
}
