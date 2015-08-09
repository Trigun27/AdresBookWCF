using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Address.Service.GetFind;


namespace Tests
{
    class Program
    {
        

        static void Main(string[] args)
        {
            try
            {
                ServiceHost host = new ServiceHost(typeof(AddBookGetFindService));
                host.Open();
                Console.WriteLine("Alright");
                Console.ReadKey();
                host.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
