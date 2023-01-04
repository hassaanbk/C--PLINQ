using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hassaan_Khalil_Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var list = new List<int>();

            for(int i=0; i<10; i++)
                list.Add(random.Next(1,100));

            list.ForEach(x => Console.Write(x + "\t"));
            Console.WriteLine();

            Console.WriteLine("Answer: ");
            var answer = list.Where(x => x < 50)
                             .Select(x => x + 10)
                             .OrderBy(x => x);
            foreach(int i in answer)
                Console.Write(i + "\t");
        }
        
        public void Display()
        {
            Console.WriteLine();
        }

    }
}
