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
           
           
        }

        public class Worker : IWorker
        {
            public void Build(string message)
            {
                throw new NotImplementedException();
            }
        }

        public interface IWorker
        {
            public void Build(string message);
        }

        public void Build(string message)
        {

        }
    }
}
