using SecureCalculatorConsoleClient.MyServiceReference;
using System;

namespace SecureCalculatorConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var client = new CalculatorClient();

                //If you want to manually specify windows user!
                //client.ClientCredentials.Windows.ClientCredential.UserName = "admin";
                //client.ClientCredentials.Windows.ClientCredential.Password = "something";

                var total = client.Add(1, 3);
                Console.WriteLine($"Total: {total}");

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
