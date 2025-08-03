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

        public interface IManager
        {
            void Create();
            void Read();
            void Update();
            void Delete();
        }
    }
}
