using System;
using System.Text.RegularExpressions;

namespace ConsoleTreining
{
  class Program
    {
     
        static void Main(string[] args)
        {

            bool e = true;
            int size1V = 0;
            int size2V = 0;
            
          
            //bool r = true;
            while (e)
            {
                bool r = true;
                while (r)
                {

                    Console.WriteLine("Enter rows");
                    try
                    {
                        string size1 = Console.ReadLine();
                        size1V = tryParse(size1);


                        r = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {

                    }
                }
                r = true;
                while (r)
                {
                    Console.WriteLine("Enter colms");
                    try
                    {
                        string size2 = Console.ReadLine();
                        size2V = tryParse(size2);


                        r = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {

                    }
                }
                int c = size1V * size2V;
                if((c>1000))
                {
                    Console.WriteLine("error");
                    size1V = size2V = 0;
                }
                else
                {
                    e = false;
                }

            }
                int[,] arr = new int[size1V, size2V];


                Random rnd = new Random();
                for (int i = 0; i < size1V; i++)
                {
                    for(int j=0;j<size2V;j++)
                    {
                        arr[i,j] = rnd.Next();
                    }
                    
                }
                for (int i = 0; i < size1V; i++)
                {
                    for (int j = 0; j < size2V; j++)
                    {
                        Console.Write($"{arr[i, j]}\t ");
                    }
                    Console.Write("\n");
                    e = false;
                }
              
            

            

     
        }
        public static int tryParse(string value)
        {
                bool tryParseMethodRun = true;
                bool tryparseAI;
                int number = 0;
                while (tryParseMethodRun)
                {
                    if (tryparseAI = int.TryParse(value, out number))
                    {

                        tryParseMethodRun = false;
                        Console.WriteLine("Your number is: " + number);

                    }
                    else
                    {
                        Console.WriteLine("Error.Try again.It's not an number.");
                        Console.WriteLine("Enter the number: ");
                        value = Console.ReadLine();

                    }


                }
                return number;
        }
      
    }

}
