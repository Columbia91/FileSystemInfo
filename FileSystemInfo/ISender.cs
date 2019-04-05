using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemInfo
{
    public interface ISender
    {
        string Message { get; set; }

        void SendMessage(string to, string text);

    }
}
