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

        public class FileManager : IWriter, IReader, IMailer

        {
            public void Read()
            {
                throw new NotImplementedException();
            }

            public void SendMail()
            {
                throw new NotImplementedException();
            }

            public void Write()
            {
                throw new NotImplementedException();
            }
        }
    }

    internal interface IMailer
    {
    }

    internal interface IReader
    {
    }

    public interface IWriter
    {
    }
}
