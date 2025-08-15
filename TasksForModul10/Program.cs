using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksForModul10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NewMessager newMessager = new NewMessager();
            ((IWhatsApp)newMessager).SendMessage("Hello");
            ((IViber)newMessager).SendMessage("Hello, world");
        }

        public class NewMessager : IViber, IWhatsApp
        {
            void IViber.SendMessage(string message)
            {
                Console.WriteLine("{0} : {1}", "Viber", message);
            }

            void IWhatsApp.SendMessage(string message)
            {
                Console.WriteLine("{0} : {1}", "WhatsApp", message);
            }
        }

        public interface IViber
        {
            public void SendMessage (string message);
        }

        public interface IWhatsApp
        {
            public void SendMessage(string message);
        }

        public void SendMessage(string message)
        {

        }
    }
}
