using Business.Concrete;
using DataAccess.Concrete.InMemory;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine( product.ProdactName);
            }
        }
    }
}