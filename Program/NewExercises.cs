public class NewExercises

{
    public static void Main()
    {
        int leave = 0;
        int equal = 1;
        int eoo = 2;
        int pon = 3;
        int year = 4;
        int voteage = 5;
        int mandn = 6;
        int height = 7;
        Console.WriteLine("Equal Numbers: 1\nEven or Odd Numbers: 2\nPositive or Negative Numbers: 3\nLeap Year Checker: 4\nAge Verify for voting: 5\nValue of m and n: 6\nHeight Categorizer: 7");
        Console.Write("Pick: ");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x == equal){
            Console.Clear();
            equalNumbers();
        } else if (x == eoo){
            Console.Clear();
            evenOrOdd();
        } else if (x == pon){
            Console.Clear();
            PON();
        } else if (x == year) {
            Console.Clear();
            leapYear();
        } else if (x == voteage) {
            Console.Clear();
            ageVerify();
        } else if (x == mandn) {
            Console.Clear();
            mAndN();
        } else if (x == height){
            Console.Clear();
            heightDisc();
        } else if (x == leave) {

        } else {
            Console.Clear();
            Console.Write("Nope");
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }

    public static void leave()
    {
        Console.ReadKey();
        Console.Clear();
        Main();
    }

    public static void equalNumbers()
    {
        int x,y;
        Console.WriteLine("First Number: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Second Number: ");
        y = Convert.ToInt32(Console.ReadLine());
        if (x == y) {
        Console.Write("{0} and {1} are Equal",x,y);
        } else {
        Console.Write("{0} and {1} is not Equal",x,y);
        }
        leave();
    }

    public static void evenOrOdd()
    {
        int num1, rem1;
        Console.Write("\n\n");
        Console.Write("Check whether a number is even or odd :\n");
        Console.Write("---------------------------------------");
        Console.Write("\n\n");
        Console.Write("Input an integer : ");
        num1= Convert.ToInt32(Console.ReadLine()); 
        rem1 = num1 % 2;
        if (rem1 == 0){
            Console.WriteLine("{0} is an even integer.\n",num1);
        } else {
            Console.WriteLine("{0} is an odd integer.\n",num1);
        }
        leave();
    }

    public static void PON()
    {
        int num;
        Console.Write("\n\n");
        Console.Write("Check whether a number is positive or negative:\n");
        Console.Write("----------------------------------------------");
        Console.Write("\n\n");
        Console.Write("Input an integer : ");
        num = Convert.ToInt32(Console.ReadLine());
        if (num >= 0) {
            Console.WriteLine("{0} is a positive number.\n",num);
        } else {
            Console.WriteLine("{0} is a negative number. \n", num);
        }
        leave();
    }

    public static void leapYear()
    {
        int year;
        Console.Write("\n\n");
        Console.Write("Check whether a given year is leap year or not:\n");
        Console.Write("----------------------------------------------");
        Console.Write("\n\n");
        Console.Write("Input an year : ");
        year = Convert.ToInt32(Console.ReadLine());
        if ((year % 400) == 0) {
            Console.WriteLine("{0} is a leap year.\n",year);
        } else if ((year % 100) == 0) {
            Console.WriteLine("{0} is not a leap year.\n",year);
        } else if ((year % 4) == 0) {
            Console.WriteLine("{0} is a leap year.\n",year);
        } else {
            Console.WriteLine("{0} is not a leap year.\n",year);
        }
        leave(); 
    }

    public static void ageVerify()
    {
        int age;
        Console.Write("\n\n");
        Console.Write("Determine a specific age is eligible for casting the vote:\n");
        Console.Write("----------------------------------------------------------");
        Console.Write("\n\n");

        Console.Write("Input the age of the candidate : ");
        age = Convert.ToInt32(Console.ReadLine());

        if (age <= 18) {
            Console.Write("Sorry you're not eligible to vote.\n");
            Console.Write("You would be able to caste your vote after {0} year.\n\n",18-age);
        } else {
            Console.Write("Congratulations! You are eligible to vote.");
        }
        leave();
    }

    public static void mAndN()
    {
        int m,n;
        Console.Write("\n\n");
        Console.Write("Display the value of n is 1,0 and -1 for the value of er m:\n");
        Console.Write("----------------------------------------------------------");
        Console.Write("\n\n");

        Console.Write("Input Value for m: ");
        m = Convert.ToInt32(Console.ReadLine());

        if (m != 0) {
            if (m > 0) {
                n = 1;
            } else {
                n = -1;
            }
        } else {
            n = 0;
        }

        Console.Write("The value of m = {0} \n",m);
        Console.Write("The value of n = {0} \n\n",n);

        leave();

    }

    public static void heightDisc() 
    {
        float PerHeight;
        Console.Write("\n\n");
        Console.Write("Accept the height of a person in centimeter and categorize them:\n");
        Console.Write("----------------------------------------------------------------");
        Console.Write("\n\n");

        Console.Write("Input the height of the person (in centimetres):");
        PerHeight = Convert.ToInt32(Console.ReadLine());

        if (PerHeight < 150.0) {
            Console.Write("The person is Dwarf. \n\n");
            if (PerHeight < 160.00) {
                Console.Write("The person is  average heighted. \n\n");
                if (PerHeight < 190.00) {
                    Console.Write("The person is taller. \n\n");
                } 
            }
        } 
        leave();
    }

}