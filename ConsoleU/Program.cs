using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager( new InMemoryProductDall);   
        }
    }
}
