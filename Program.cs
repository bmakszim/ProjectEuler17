using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler17
{
    class Program
    {
        static void Main(string[] args)
        {
            var alg = new Algorithm();
            alg.WriteNumbers();
            Console.WriteLine(alg.Run());
            Console.Read();
        }
    }
}
