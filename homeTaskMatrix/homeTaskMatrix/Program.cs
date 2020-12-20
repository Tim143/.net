using System;

namespace homeTaskMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = true;
            string sizE1;
            string sizE2;
            int rows = 0;
            int colms = 0;
          
            Console.WriteLine("Hello. Let's create your first matrix.");
            bool check = true;


            Console.Write(" REMEMBER,it must be an integer number! Enter matrix's rows: ");

            //enter matrix rows
                 while (a)
                 {
                    sizE1 = Console.ReadLine();
                    bool checkMatrix = int.TryParse(sizE1, out rows);
                    {
                        if (checkMatrix)
                        {

                            if (rows > 0)
                            {
                                a = false;
                            }


                        }
                        else
                        {
                        Console.Clear();
                        Console.WriteLine("It is not an integer number");
                        }
                    }
                 }


            Console.Write(" REMEMBER,it must be an integer number! Enter matrix's colms: ");
          

                //enter matrix colms
                while (b)
                {
                    sizE2 = Console.ReadLine();
                    bool checkMatrix = int.TryParse(sizE2, out colms);
                    {
                        if (checkMatrix)
                        {
                            if (colms > 0)
                            {
                                b = false;
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("It is not an integer number");
                        }
                    }
                }

            
                Console.Clear();
               

            //showing our rows and colms of matrix
            Console.WriteLine($"Rows={rows}\tColumns={colms}");


            //creating arr for geting our matrix
            double[,] arr = checked(new double[rows, colms]);


            Console.WriteLine("============================");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colms; j++)
                {
                    Console.Write($"Enter [{i+1}][{j+1}]element: ");
                    bool stringCheck = true;
                    while (stringCheck)
                    {
                       
                        string val1 = Console.ReadLine().Replace(',', '.');
                        bool convertation = double.TryParse(val1, out arr[i, j]);
                        if (convertation)
                        {
                            val1 = null;
                            stringCheck = false;
                        }
                        else
                        {
                            Console.WriteLine("It'is not a number. Try again.");
                        }
                    }
                    
                }

            }


            Console.Clear();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colms; j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine("\n");
            }

            while (true)
            {
                

                Console.WriteLine("1)Sort ");
                Console.WriteLine("2)Amount of positive and negative el. ");
                Console.WriteLine("3)Inverse ");
                Console.WriteLine("4)Transpon");
                Console.WriteLine("5)End");

                int t=0;
                bool q = true;
               
                while (q)
                {
                    string choice = Console.ReadLine();
                    bool result = int.TryParse(choice, out t);
                    {
                        if (result)
                        {
                            q = false;
                        }
                        else
                        {
                            Console.WriteLine("It is not an integer number that you must enter.");
                        }
                    }
                }

                switch (t)
                {
                    case 1:
                        Console.Clear();

                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < colms; j++)
                            {
                                for (int k = colms - 1; k > j; k--)
                                    if (arr[i, k] < arr[i, k - 1])
                                    {
                                        double tmpp = arr[i, k];
                                        arr[i, k] = arr[i, k - 1];
                                        arr[i, k - 1] = tmpp;
                                    }

                            }
                        }

                        Console.WriteLine("Your matrix is:");

                        for (int i = 0; i < rows; i++)
                        {
                            for (int k = 0; k < colms; k++)
                            {
                                Console.Write($"{arr[i, k]}\t");
                            }
                            Console.WriteLine("\n");
                        }

                        break;
                    case 2:
                        Console.Clear();
                        int positiveN = 0;
                        int negativeN = 0;

                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < colms; j++)
                            {
                                if (arr[i, j] >= 0)
                                {
                                    positiveN++;
                                }
                                else
                                {
                                    negativeN++;
                                }
                            }

                        }

                        Console.WriteLine("Your matrix is:");
                        for (int i = 0; i < rows; i++)
                        {
                            for (int k = 0; k < colms; k++)
                            {
                                Console.Write($"{arr[i, k]}\t");
                            }
                            Console.WriteLine("\n");
                        }

                        Console.WriteLine($"In this array we have ({positiveN}) numbers that are > 0 and ({negativeN}) numbers that are < 0 . ");
                        
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Your matrix is:");
                        long arrayMiddle = colms / 2;
                        double fake;

                        for (int j = 0; j < rows; j++)
                        {
                            for (int i = 0; i < arrayMiddle; i++)
                            {
                                fake = arr[j, i];
                                arr[j, i] = arr[j, colms - i - 1];
                                arr[j, colms - i - 1] = fake;
                            }
                        }

                        for (int i = 0; i < rows; i++)
                        {
                            for (int k = 0; k < colms; k++)
                            {
                                Console.Write($"{arr[i, k]}\t");
                            }
                            Console.WriteLine("\n");
                        }

                        break;
                    case 4:
                        Console.Clear();
                        if (rows == colms)
                        {
                            Console.WriteLine("Your matrix is:");
                            double[,] arr1 = new double[colms, rows];
                            for (int i = 0; i < rows; i++)
                            {
                                for (int j = 0; j < colms; j++)
                                {
                                    arr1[i, j] = arr[j, i];
                                }

                            }

                            for (int i = 0; i < rows; i++)
                            {
                                for (int j = 0; j < colms; j++)
                                {
                                    arr[i, j] = arr1[i, j];
                                }
                                
                            }

                            for (int i = 0; i < rows; i++)
                            {
                                for (int j = 0; j < colms; j++)
                                {
                                    Console.Write($"{arr[i, j]}\t");
                                }
                                Console.WriteLine("\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("It's not a square matrix. You can not transpone it.");
                            break;
                        }
                        break;
                    case 5:
                        Console.Clear();
                        return;
                        break;

                    default:
                        Console.Clear();
                        break;
                        
                }

               



            }
                    
               
        }




       

        
    }
}





