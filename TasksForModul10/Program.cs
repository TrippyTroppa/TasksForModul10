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
            ((IWriter)newMessager).Write("Hello");
           
        }

        public class NewMessager : IWriter
        {
            void IWriter.Write(string message)
            {
                Console.WriteLine("{0} : {1}", "Viber", message);
            }

            
        }

        public interface IWriter
        {
            void Write(string message);
        }

        public void Write(string message)
        {

        }
    }
}
