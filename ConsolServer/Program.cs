using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsolServer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(EasyWcfChat.ServiceChat)))
            {
                host.Open();
                Console.WriteLine("Сервер запущен!");
                Console.ReadLine();
            }
        }
    }
}
