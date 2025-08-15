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
           Worker worker = new Worker();
            ((IWorker)worker).Build("Строим планы");

           
        }

        public class Worker : IWorker
        {
            public void Build(string message)
            {
                Console.WriteLine(message);
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
