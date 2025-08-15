using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace TasksForModul10
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

           
        }

        public class FileManager : IBook, IDevice

        {
          

            public void Read()
            {
                throw new NotImplementedException();
            }

            public void TurnOff()
            {
                throw new NotImplementedException();
            }

            public void TurnOn()
            {
                throw new NotImplementedException();
            }
        }
    }

    public interface IBook
    {
        void Read();
    }

    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
    }
}
