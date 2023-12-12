// This is the beginning of the Exercise1 class
public class Exercises
{
    // This is the main method where the program execution starts
    public static void Main()
    {
        // Number thingy exercises
       /* Console.WriteLine("Hello");

        Console.WriteLine("Emil!");
        Console.WriteLine("Here are some numbers for you: ");
        int x = 1 + 2;
        Console.WriteLine("1 + 2 = " + x);
        int y = 2 / 1;
        Console.WriteLine("2 / 1 = " + y);
        int z = -1 + 4 * 6;
        Console.WriteLine("-1 + 4 * 6 = " + z);
        int a = 35 + 5;
        int b = 7;
        Console.WriteLine("(35 + 5) % 7 = " + a % b);
        int c = 14 + -4 * 6 / 11;
        Console.WriteLine("14 + -4 * 6 / 11 = " + c);
        int d = 2 + 15 / 6 * 1 - 7 % 2;
        Console.WriteLine("2 + 15 / 6 * 1 - 7 % 2 = " + d); */

        // swapping numbers Exercise
        /*
        int number1, number2, temp;
        Console.Write("Input a non decimal number: ");
        number1 = int.Parse(Console.ReadLine());
        Console.Write("\nInput a second non decimal number: ");
        number2 = int.Parse(Console.ReadLine());
        
        temp = number1;
        number1 = number2;
        number2 = temp;

        Console.Write("\nAfter Swapping: ");
        Console.WriteLine("\nFirst number: " + number1);
        Console.WriteLine("Second number: " + number2);
        */
        // multiplying numbers i input
        /*
        int number1, number2, number3;
        Console.Write("Input a number: ");
        number1 = int.Parse(Console.ReadLine());
        Console.Write("\nInput a second number: ");
        number2 = int.Parse(Console.ReadLine());
        Console.Write("\nInput a third number: ");
        number3 = int.Parse(Console.ReadLine());

        Console.Write("\nYour number is: " + number1 * number2 * number3); */

        // Calculator for everything
        /*
        Console.Write("Input a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nInput a second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nYour numbers are: ");  
        Console.WriteLine("\n{0} + {1} = {2}", num1, num2, num1 + num2);
        Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
        Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
        Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
        Console.WriteLine("{0} % {1} = {2}", num1, num2, num1 % num2); */

        //for statement with multiply
        /*
        Console.Write("Give me an number: ");
        int x = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < 11; i++)
        {
            Console.WriteLine("{0} * {1} = {2}", x, i, x * i);
        } */

        // average number
        /*
        Console.Write("first number: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nSecond number: ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nThird nubmer: ");
        int z = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nFourth number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The average of {0} {1} {2} {3} is {4}", x, y, z, a, (x + y + z + a) / 4); */

        // Result of input numbers7
        /*
        Console.Write("First number: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nSecond number: ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nThird number: ");
        int z = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nResult of these numbers {0}, {1}, {2} is ({0} + {1}) * {2} = {3} and {0} * {1} + {1} * {2} = {4}", x, y, z, ((x+y)*z), (x*y+y*z)); */

        // Age Descriminator
        /*
        Console.Write("What is your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write("You look older than {0}", age); */

        //numbers apart from eachother
        /*
        Console.Write("Enter a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("\n" + num1 + " " + num1 + " " + num1 + " " + num1);
        Console.Write("\n" + num1 + num1 + num1 + num1);
        Console.Write("\n{0} {0} {0} {0}",num1);
        Console.Write("\n{0}{0}{0}{0}",num1);
        */

        //Tower of numbers
        /*
        Console.Write("Enter a number: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("{0}{0}{0}",x);
        Console.WriteLine("{0} {0}",x);
        Console.WriteLine("{0} {0}",x);
        Console.WriteLine("{0}{0}{0}",x); */

        Console.Write("Give me a degree: ");
        int celcius = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Kelvin = {0}", celcius + 273);
        Console.WriteLine("Farenheit = {0}", celcius * 18 / 10 + 32);
    }
}