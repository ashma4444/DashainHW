// See https://aka.ms/new-console-template for more information

// Asking user to choose an option



using Dashain_Task.Arrays;
using Dashain_Task.Calculator;
using Dashain_Task.Interpolation;

int num1, num2;
string answer;
do
{
    Console.WriteLine("Choose an option from the following list:");
    Console.WriteLine("Press 1 for Addition");
    Console.WriteLine("Press 2 for Subtraction");
    Console.WriteLine("Press 3 for Multiplication");
    Console.WriteLine("Press 4 for Division");
    Console.WriteLine("Press 5 for Jagged Arrays");
    Console.WriteLine("Press 6 for SingleDimensional Arrays");
    Console.WriteLine("Press 7 for ImplicitlyTyped Arrays");
    Console.WriteLine("Press 8 for MultiDimensional Arrays");
    Console.Write("Your option? ");

    string option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Console.WriteLine("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Calculator.Addition(num1, num2);
            break;

        case "2":
            Console.WriteLine("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Calculator.Subtraction(num1, num2);
            break;

        case "3":
            Console.WriteLine("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Calculator.Multiplication(num1, num2);
            break;

        case "4":
            Console.WriteLine("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Calculator.Division(num1, num2);
            break;

        case "5":
            Arrays.JaggedArray();
            break;

        case "6":
            Arrays.SingleDimensionalArray();
            break;
        case "7":
            Arrays.ImplicitlyTypedArray();
            break;
        case "8":
            Arrays.MultiDimensionalArray();
            break;

        default:
            Interpolation.StringInterpolation();
            break;
    }

    Console.WriteLine("---------------------------------------------------------");
    Console.WriteLine("Do you want to continue?");
    Console.WriteLine("Press y or Y to continue.");
    Console.WriteLine("Press any other key to end.");
    answer = Console.ReadLine();

} while (answer == "y" || answer == "Y");

