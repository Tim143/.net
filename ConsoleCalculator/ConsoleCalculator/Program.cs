using System;
using System.Threading.Tasks;
namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
           // System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("US");



            double value1 = 0, value2 = 0, result = 0;
            string val1, val2, choice;
            int index = 0;

            bool stringCheck = true;
            while (stringCheck)
            {
                //enter our first number. Using trypase to convert. Using replace () for using  ',' and  '.'
                Console.Write("Enter first number: ");
                val1 = Console.ReadLine().Replace(',', '.');
                bool convertation = double.TryParse(val1, out value1);
                if (convertation)
                {
                    //we cant enter our first number as 0
                    if (value1 != 0)
                    {
                        val1 = null;
                        stringCheck = false;
                    }
                    else
                    {
                        Console.WriteLine("Your number must be not a 0");
                    }

                }
                else
                {
                    Console.WriteLine("It'is not a number. Try again.");
                }

            }

            Console.Clear();

            //print our value1 (first number)
            Console.WriteLine($"X1={value1}");

            //creating arr for saving results of operations
            double[] arr = new double[5];

            bool processRun = true;
            while (processRun)
            {
                Console.WriteLine("===============================================");
                Console.WriteLine("Enter symbol of operation , that you determine:");
                Console.WriteLine("1) Sum: +");
                Console.WriteLine("2) Subtraction: -");
                Console.WriteLine("3) Multiplication: *");
                Console.WriteLine("4) Division: /");
                Console.WriteLine("5) Division with residue: %");
                Console.WriteLine("6) Square root: sqrt");
                Console.WriteLine("7) Close application: end");
                Console.WriteLine("8) Show history: show");
                Console.WriteLine("===============================================");
                Console.Write("Enter symbol: ");

                choice = Console.ReadLine();
                bool repeat = true;

                //switch case for choosing math.operation
                switch (choice.ToLower())
                {
                    case "+":

                        Console.Clear();

                        do
                        {
                            if (value1 == 0)
                            {
                                stringCheck = true;
                                while (stringCheck)
                                {
                                    Console.Write("Enter first number: ");
                                    val1 = Console.ReadLine().Replace(',', '.');
                                    bool convertation = double.TryParse(val1, out value1);
                                    if (convertation)
                                    {
                                        //we cant enter our first number as 0
                                        if (value1 != 0)
                                        {
                                            val1 = null;
                                            stringCheck = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Your number must be not a 0");
                                        }



                                    }
                                    else
                                    {
                                        Console.WriteLine("It'is not a number. Try again.");
                                    }
                                }
                                Console.Clear();
                            }


                            //enter our second number(value2)
                            //it can be 0
                            stringCheck = true;
                            while (stringCheck)
                            {
                                Console.Write("Enter second number: ");
                                val2 = Console.ReadLine().Replace(',', '.');
                                bool convertation = double.TryParse(val2, out value2);
                                if (convertation)
                                {

                                    val2 = null;
                                    stringCheck = false;

                                }
                                else
                                {
                                    Console.WriteLine("It'is not a number. Try again.");
                                }
                            }


                            Console.Clear();

                            //result of sum is a sum of two values 
                            result = value1 + value2;
                            Console.WriteLine($"X1={value1} && X2={value2}.");
                            Console.WriteLine($"X3=X1+X2={value1}+{value2}={result}");
                            Console.WriteLine("=========================================");
                            Console.WriteLine("Do you want to make one more operation? Y/N");

                            //adding result in arr for history
                            arr[index] = result;
                            index++;
                            //max val of our arr is 5. 
                            if (index == 5)
                            {
                                //if we have more res , we recreat it
                                index = 0; 
                            }

                            //asking user for a repead action
                            String answer = Console.ReadLine();
                            if (answer == "Yes" || answer == "yes" || answer == "YES" || answer == "yeS" || answer == "yEs" || answer == "lf" || answer == "If")
                            {
                                //delete values for free memory
                                value1 = 0;
                                value2 = 0;

                                stringCheck = true;
                                while (stringCheck)
                                {
                                    //if we want to do action again , we enter our values (value1,valu2)
                                    Console.Write("Enter first number: ");
                                    val1 = Console.ReadLine().Replace(',', '.');
                                    bool convertation = double.TryParse(val1, out value1);
                                    if (convertation)
                                    {
                                        //we cant enter our first number as 0
                                        if (value1 != 0)
                                        {
                                            val1 = null;
                                            stringCheck = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Your number must be not a 0");
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("It'is not a number. Try again.");
                                    }

                                }

                                Console.Clear();

                            }
                            else
                            {
                                repeat = false;
                            }


                        }
                        while (repeat);

                        value1 = 0;
                        Console.Clear();

                        break;


                    case "-":

                        Console.Clear();

                        do
                        {
                            if (value1 == 0)
                            {
                                stringCheck = true;
                                while (stringCheck)
                                {
                                    Console.Write("Enter first number: ");
                                    val1 = Console.ReadLine().Replace(',', '.');
                                    bool convertation = double.TryParse(val1, out value1);
                                    if (convertation)
                                    {
                                        //we cant enter our first number as 0
                                        if (value1 != 0)
                                        {
                                            val1 = null;
                                            stringCheck = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Your number must be not a 0");
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("It'is not a number. Try again.");
                                    }
                                }
                                Console.Clear();
                            }



                            stringCheck = true;
                            while (stringCheck)
                            {
                                Console.Write("Enter second number: ");
                                val2 = Console.ReadLine().Replace(',', '.');
                                bool convertation = double.TryParse(val2, out value2);
                                if (convertation)
                                {

                                    val2 = null;
                                    stringCheck = false;

                                }
                                else
                                {
                                    Console.WriteLine("It'is not a number. Try again.");
                                }
                            }




                            Console.Clear();


                            result = value1 - value2;
                            Console.WriteLine($"X1={value1} && X2={value2}.");
                            Console.WriteLine($"X3=X1-X2={value1}-{value2}={result}");
                            Console.WriteLine("=========================================");

                           

                            arr[index] = result;
                            index++;
                            if (index == 5)
                            { 
                                index = 0; 
                            }

                            Console.WriteLine("Do you want to make one more operation?");
                            String answer = Console.ReadLine();
                            if (answer == "Yes" || answer == "yes" || answer == "YES" || answer == "yeS" || answer == "yEs" || answer == "lf" || answer == "If")
                            {
                                value1 = 0;
                                value2 = 0;

                                stringCheck = true;
                                while (stringCheck)
                                {
                                    Console.Write("Enter first number: ");
                                    val1 = Console.ReadLine().Replace(',', '.');
                                    bool convertation = double.TryParse(val1, out value1);
                                    if (convertation)
                                    {
                                        //we cant enter our first number as 0
                                        if (value1 != 0)
                                        {
                                            val1 = null;
                                            stringCheck = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Your number must be not a 0");
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("It'is not a number. Try again.");
                                    }
                                }
                                Console.Clear();
                            }
                            else
                            {
                                repeat = false;
                            }


                        }
                        while (repeat);
                        value1 = 0;
                        Console.Clear();


                        break;

                    case "*":

                        Console.Clear();

                        do
                        {
                            if (value1 == 0)
                            {
                                stringCheck = true;
                                while (stringCheck)
                                {
                                    Console.Write("Enter first number: ");
                                    val1 = Console.ReadLine().Replace(',', '.');

                                    bool convertation = double.TryParse(val1, out value1);
                                    if (convertation)
                                    {
                                        //we cant enter our first number as 0
                                        if (value1 != 0)
                                        {
                                            val1 = null;
                                            stringCheck = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Your number must be not a 0");
                                        }


                                    }
                                    else
                                    {
                                        Console.WriteLine("It'is not a number. Try again.");
                                    }
                                }
                                Console.Clear();
                            }



                            stringCheck = true;
                            while (stringCheck)
                            {
                                Console.Write("Enter second number: ");
                                val2 = Console.ReadLine().Replace(',', '.');
                                bool convertation = double.TryParse(val2, out value2);
                                if (convertation)
                                {

                                    val2 = null;
                                    stringCheck = false;

                                }
                                else
                                {
                                    Console.WriteLine("It'is not a number. Try again.");
                                }
                            }










                            Console.Clear();


                            result = value1 * value2;
                            Console.WriteLine($"X1={value1} && X2={value2}.");
                            Console.WriteLine($"X3=X1*X2={value1}*{value2}={result}");
                            Console.WriteLine("=========================================");

                            arr[index] = result;
                            index++;
                            if (index == 5)
                            {
                                index = 0; 
                            }


                            Console.WriteLine("Do you want to make one more operation?");

                            String answer = Console.ReadLine();

                            if (answer == "Yes" || answer == "yes" || answer == "YES" || answer == "yeS" || answer == "yEs" || answer == "lf" || answer == "If")
                            {
                                value1 = 0;
                                value2 = 0;
                                stringCheck = true;
                                while (stringCheck)
                                {
                                    Console.Write("Enter first number: ");
                                    val1 = Console.ReadLine().Replace(',', '.');
                                    bool convertation = double.TryParse(val1, out value1);
                                    if (convertation)
                                    {
                                        //we cant enter our first number as 0
                                        if (value1 != 0)
                                        {
                                            val1 = null;
                                            stringCheck = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Your number must be not a 0");
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("It'is not a number. Try again.");
                                    }
                                }
                                Console.Clear();
                            }
                            else
                            {
                                repeat = false;
                            }


                        }
                        while (repeat);
                        value1 = 0;
                        Console.Clear();






                        break;
                    case "/":


                        Console.Clear();

                        do
                        {
                            if (value1 == 0)
                            {
                                stringCheck = true;
                                while (stringCheck)
                                {
                                    Console.Write("Enter first number: ");
                                    val1 = Console.ReadLine().Replace(',', '.');
                                    bool convertation = double.TryParse(val1, out value1);
                                    if (convertation)
                                    {
                                        //we cant enter our first number as 0
                                        if (value1 != 0)
                                        {
                                            val1 = null;
                                            stringCheck = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Your number must be not a 0");
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("It'is not a number. Try again.");
                                    }
                                }
                                Console.Clear();
                            }



                            stringCheck = true;
                            while (stringCheck)
                            {
                                Console.Write("Enter second number: ");
                                val2 = Console.ReadLine().Replace(',', '.');
                                bool convertation = double.TryParse(val2, out value2);
                                if (convertation)
                                {
                                    if (value2 != 0)
                                    {
                                        val2 = null;
                                        stringCheck = false;
                                    }
                                    else { Console.WriteLine("We can't delit na 0"); }
                                }
                                else
                                {
                                    Console.WriteLine("It'is not a number. Try again.");
                                }
                            }










                            Console.Clear();
                            result = value1 / value2;
                            Console.WriteLine($"X1={value1} && X2={value2}.");
                            Console.WriteLine($"X3=X1/X2={value1}/{value2}={result}");
                            Console.WriteLine("=========================================");

                            Console.WriteLine("Do you want to make one more operation?");

                            arr[index] = result;
                            index++;
                            if (index == 5)
                            {
                                index = 0;
                            }

                            String answer = Console.ReadLine();
                            if (answer == "Yes" || answer == "yes" || answer == "YES" || answer == "yeS" || answer == "yEs" || answer == "lf" || answer == "If")
                            {
                                value1 = 0;
                                value2 = 0;
                                stringCheck = true;
                                while (stringCheck)
                                {
                                    Console.Write("Enter first number: ");
                                    val1 = Console.ReadLine().Replace(',', '.');
                                    bool convertation = double.TryParse(val1, out value1);
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
                                Console.Clear();
                            }
                            else
                            {
                                repeat = false;
                            }


                        }
                        while (repeat);
                        value1 = 0;
                        Console.Clear();


                        break;

                    case "%":

                        Console.Clear();

                        do
                        {
                            if (value1 == 0)
                            {
                                stringCheck = true;
                                while (stringCheck)
                                {
                                    Console.Write("Enter first number: ");
                                    val1 = Console.ReadLine().Replace(',', '.');
                                    bool convertation = double.TryParse(val1, out value1);
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
                                Console.Clear();
                            }



                            stringCheck = true;
                            while (stringCheck)
                            {
                                Console.Write("Enter second number: ");
                                val2 = Console.ReadLine().Replace(',', '.');
                                bool convertation = double.TryParse(val2, out value2);
                                if (convertation)
                                {

                                    val2 = null;
                                    stringCheck = false;

                                }
                                else
                                {
                                    Console.WriteLine("It'is not a number. Try again.");
                                }
                            }



                            Console.Clear();

                            result = value1 % value2;
                            Console.WriteLine($"X1={value1} && X2={value2}.");
                            Console.WriteLine($"X3=X1%X2={value1}%{value2}={result}");
                            Console.WriteLine("=========================================");

                            Console.WriteLine("Do you want to make one more operation?");

                            arr[index] = result;
                            index++;
                            if (index == 5)
                            { 
                                index = 0;
                            }

                            String answer = Console.ReadLine();
                            if (answer == "Yes" || answer == "yes")
                            {
                                value1 = 0;
                                value2 = 0;

                                stringCheck = true;
                                while (stringCheck)
                                {
                                    Console.Write("Enter first number: ");
                                    val1 = Console.ReadLine().Replace(',', '.');
                                    bool convertation = double.TryParse(val1, out value1);
                                    if (convertation)
                                    {
                                        //we cant enter our first number as 0
                                        val1 = null;
                                        stringCheck = false;

                                    }
                                    else
                                    {
                                        Console.WriteLine("It'is not a number. Try again.");
                                    }
                                }
                                Console.Clear();
                            }
                            else
                            {
                                repeat = false;
                            }


                        }
                        while (repeat);
                        value1 = 0;
                        Console.Clear();

                        break;

                    case "sqrt":

                        Console.Clear();

                        do
                        {
                            if (value1 == 0)
                            {
                                stringCheck = true;
                                while (stringCheck)
                                {
                                    Console.Write("Enter first number: ");
                                    val1 = Console.ReadLine().Replace(',', '.');
                                    bool convertation = double.TryParse(val1, out value1);
                                    if (convertation)
                                    {
                                        //we cant enter our first number as 0(there is no sqrt of 0)
                                        if (value1 != 0)
                                        {
                                            val1 = null;
                                            stringCheck = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Your number must be not a 0");
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("It'is not a number. Try again.");
                                    }
                                }
                                Console.Clear();
                            }




                            Console.Clear();
                            result = Math.Sqrt(value1);
                           
                            Console.WriteLine($"X1={value1}.");
                            Console.WriteLine($"X3=sqrt({value1})={result}");
                            Console.WriteLine("=========================================");

                            arr[index] = result;
                            index++;
                            if (index == 5)
                            { 
                                index = 0;
                            }

                            Console.WriteLine("Do you want to make one more operation?");
                            String answer = Console.ReadLine();
                            if (answer == "Yes" || answer == "yes" || answer=="YES" || answer=="yeS" || answer=="yEs" || answer=="lf" || answer=="If")
                            {
                                value1 = 0;
                                value2 = 0;

                                stringCheck = true;
                                while (stringCheck)
                                {
                                    Console.Write("Enter first number: ");
                                    val1 = Console.ReadLine().Replace(',', '.');
                                    bool convertation = double.TryParse(val1, out value1);
                                    if (convertation)
                                    {

                                        if (value1 != 0)
                                        {
                                            val1 = null;
                                            stringCheck = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Your number must be not a 0");
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("It'is not a number. Try again.");
                                    }
                                }

                                Console.Clear();
                            }
                            else
                            {
                                repeat = false;
                            }


                        }
                        while (repeat);

                        value1 = 0;
                        Console.Clear();


                        break;

                    case "show":


                        //show our history of previos 5 operation
                        for (int i = 0; i < arr.Length; i++)
                        {
                            Console.WriteLine(arr[i]);
                        }

                        break;

                    case "end":

                        //close application
                        return;
                        break;


                    default:
                        Console.Clear();
                        Console.WriteLine("Please, try again.");
                        break;







                }
            }
        }
    }
}
