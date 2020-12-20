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

            while (check)
            {

               // enter matrix rows
                while (a)
                {
                    try
                    {
                        Console.Write("Enter matrix's rows: ");
                        sizE1 = Console.ReadLine();
                        rows = tryParse(sizE1);
                        if (rows > 0)
                        {
                            a = false;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("It is 0. We can't creatre matrix with zero amount of rows.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {

                    }
                }

               // enter matrix colms
                while (b)
                {
                    try
                    {
                        Console.Write("Enter matrix's colms: ");
                        sizE2 = Console.ReadLine();
                        colms = tryParse(sizE2);
                        if (colms > 0)
                        {
                            b = false;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("It is 0. We cant creatre matrix with zero amount of colms.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {

                    }
                }

                int notCrossBorder = rows * colms;
                if ((notCrossBorder) > 1000|| notCrossBorder ==1000)
                {
                    Console.WriteLine("error");
                   
                }
                else
                {
                    check = false;
                }
            }

            Console.Clear();


           // showing our rows and colms of matrix
            Console.WriteLine($"Rows={rows}\tColumns={colms}");

           // creating arr for geting our matrix
            double[,] arr = new double[rows, colms];
            Console.WriteLine("============================");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colms; j++)
                {
                    Console.Write($"Enter [{i + 1}][{j + 1}]element: ");
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
            print(rows, colms, arr);

            while (true)
            {
                printMenu();            
                string choice = Console.ReadLine();
                int caseNumber= tryParse(choice);

                switch (caseNumber)
                {
                    case 1:
                        Console.Clear();
                        sortArray(rows, colms, arr);
                        print(rows, colms, arr);
                        break;

                    case 2:
                        Console.Clear();
                        int positiveN = 0;
                        int negativeN = 0;
                       
                        DefinePositiveAndNegative(rows, colms, ref positiveN, ref negativeN, arr);
                        print(rows, colms, arr);
                        Console.WriteLine($"In this array we have ({positiveN}) numbers that are > 0 and ({negativeN}) numbers that are < 0 . ");
                        break;

                    case 3:
                        Console.Clear();
                        InversArray(rows, colms, arr);
                        print(rows, colms, arr);
                        break;

                    case 4:
                        Console.Clear();
                        transponMatrix(rows, colms, arr);
                        print(rows, colms, arr);
                        break;

                    case 5:
                        Console.Clear();
                        return;
                        
                    default:
                        Console.Clear();
                        break;

                }
            }
        }

        static void print(int rows,int colms,double[,] arr)
        {
            Console.WriteLine("Your matrix is:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colms; j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine("\n");
            }
        }

        static void DefinePositiveAndNegative(int rows,int colms,ref int positiveN,ref int negativeN,double[,] arr)
        {
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

        }

        static void sortArray(int rows,int colms,double[,] arr)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < colms; k++)
                {
                    for (int j = colms - 1; j > k; j--)
                    {
                        if (arr[i, j] < arr[i, j - 1])
                        {
                            double tmpp = arr[i, j];
                            arr[i, j] = arr[i, j - 1];
                            arr[i, j - 1] = tmpp;

                        }
                    }
                }
            }
        }

       public static void printMenu()
        {
            Console.WriteLine("1)Sort ");
            Console.WriteLine("2)Amount of positive and negative el. ");
            Console.WriteLine("3)Inverse ");
            Console.WriteLine("4)Transpon");
            Console.WriteLine("5)End");
        }

        static void transponMatrix(int rows,int colms,double [,] arr)
        {
            if (rows == colms)
            {
                
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
                
            }
            else
            {
                Console.WriteLine("It's not a square matrix. You can not transpone it.");
                
            }           
        }

        static public void InversArray(int rows,int colms,double[,] arr)
        {
            
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
        }

        public static int tryParse(string value)
        {
            bool tryParseMethodRepeat = true;
            bool tryParseRun;
            int number = 0;
            while (tryParseMethodRepeat)
            {
                if (tryParseRun = int.TryParse(value, out number))
                {

                    tryParseMethodRepeat = false;
                    Console.WriteLine("Your number is: " + number);

                }
                else
                {
                    Console.WriteLine("Error.Try again.It's not an number, that we expect.");
                    Console.WriteLine("Enter the number: ");
                    value = Console.ReadLine();

                }
            }
            return number;
        }
    }
}
