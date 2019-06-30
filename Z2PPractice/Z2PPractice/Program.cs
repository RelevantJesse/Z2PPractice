using System;

namespace Z2PPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Database.GetAllUsers());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
