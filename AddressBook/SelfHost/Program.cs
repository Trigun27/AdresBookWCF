using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Address.Service.Codes;

namespace SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(AddBookService));
            
            try
            {
                host.Open();
                Console.WriteLine("Hit any key to shut down");
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Hit any key to exit");
                Console.ReadKey();
            }
            finally
            {
                host.Close();
            }
        }
    }
}
