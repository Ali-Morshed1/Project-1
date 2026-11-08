using System;
using System.Formats.Asn1;
namespace ConsoleApp2;

class Program
{
    static void Main(string[] argv)
    {
        // Read_three_letters_and_display_them_in_reverse_order(); // 1
        // Read_a_number_and_a_width_then_print_a_descending_width_triangle_using_that_number(); // 2
        // Read_a_user_ID_and_password_reject_the_user_after_three_unsuccessful_attempts(); // 3
        // calculator(); // 4
        // The_Radius_Of_The_Circle(); // 5
        // Display_Values(); // 6
        // Speed_and_Time(); // 7
        // sphere_radius(); // 8
        // What_Is_This_Char(); // 9 
        // Odd_Or_Even(); // 10
        // Display_Binary(); // 11
    }
    // Question 1
    static void Read_three_letters_and_display_them_in_reverse_order()
    {
        string? ran;
        char test;
        do
        {
            System.Console.WriteLine("Enter A Random String");
            ran = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(ran));
        for (int i = ran.Length - 1; i >= 0; i--)
        {
            test = ran[i];
            System.Console.Write($"{test} ");
        }
        System.Console.WriteLine();
    }
    // Question 2
    static void Read_a_number_and_a_width_then_print_a_descending_width_triangle_using_that_number()
    {
        int x = 0;
        int y = 0;
        while (true)
        {
            try
            {
                System.Console.Write("x:");
                x = Convert.ToInt32(Console.ReadLine());
                System.Console.Write("y:");
                y = Convert.ToInt32(Console.ReadLine());
                for (int i = y; i > 0; i--)
                {
                    for (int o = 0; o < i; o++)
                        System.Console.Write(x);
                    System.Console.WriteLine();
                }
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }

        }
    }
    // Question 3
    static void Read_a_user_ID_and_password_reject_the_user_after_three_unsuccessful_attempts()
    {
        string UserID = "Admin";
        string Real_Password = "IAmCool";
        string? User;
        string? password;
        int attempt = 3;
        while (true)
        {
            System.Console.WriteLine("Enter The User's Name");
            User = Console.ReadLine();
            System.Console.WriteLine("Enter The Password");
            password = Console.ReadLine();
            if (attempt == 1)
            {
                System.Console.WriteLine("You Have 0 Attempts Left You Are Rejected");
                break;
            }
            else if (User != UserID || password != Real_Password)
            {
                attempt--;
                System.Console.WriteLine($"Incorrect Username/Password You Have {attempt} Attempts Left");
            }
            else if (User == UserID && password == Real_Password)
            {
                System.Console.WriteLine("Access Granted");
                System.Console.WriteLine("Welcome Back Admin");
                break;
            }
        }
    }
    // Question 4
    static void calculator()
    {
        string? op;
        double? num1;
        double? num2;
        double? result;
        System.Console.WriteLine("--------------------------");
        System.Console.WriteLine("Welcome To The Calculator!");
        System.Console.WriteLine("--------------------------");
        while (true)
        {
            System.Console.WriteLine("Please Enter What Kind Of Method You Want To Use {/,*,+,-}");
            op = Console.ReadLine();
            if (op != "/" && op != "*" && op != "+" && op != "-")
                System.Console.WriteLine("Please Enter {/,*,+,-} only!");
            else
                break;
        }
        while (true)
        {
            try
            {
                System.Console.Write("Enter Number One:");
                num1 = Convert.ToInt32(Console.ReadLine());
                System.Console.Write("Enter Number Two:");
                num2 = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        System.Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                        break;
                    case "-":
                        result = num1 - num2;
                        System.Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                        break;
                    case "*":
                        result = num1 * num2;
                        System.Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                        break;
                    case "/":
                        result = num1 / num2;
                        System.Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                        break;
                }
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
    }
    // Question 5
    static void The_Radius_Of_The_Circle()
    {
        double radius;
        while (true)
        {
            try
            {
                Console.Write("Enter the radius of the circle: ");
                radius = Convert.ToDouble(Console.ReadLine());
                double perimeter = 2 * Math.PI * radius;
                double area = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine($"Perimeter of Circle: {perimeter:F2}");
                Console.WriteLine($"Area of Circle: {area:F2}");
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
    }
    // Question 6
    static void Display_Values()
    {
        Console.WriteLine("y\t\tx = y^2 + 2y + 1");
        Console.WriteLine("-------------------------");
        for (int y = -5; y <= 5; y++)
        {
            int x = (y * y) + (2 * y) + 1;
            Console.WriteLine($"{y}               {x}");
        }
    }
    // Question 7
    static void Speed_and_Time()
    {
        double distance;
        double hours;
        double minutes;
        double seconds;
        double totalSeconds;
        double totalHours;
        double metersPerSec;
        double kmPerHour;
        double milesPerHour;
        while (true)
        {
            try
            {
                Console.Write("Input distance (in meters): ");
                distance = Convert.ToDouble(Console.ReadLine());

                Console.Write("Input time (hours): ");
                hours = Convert.ToDouble(Console.ReadLine());

                Console.Write("Input time (minutes): ");
                minutes = Convert.ToDouble(Console.ReadLine());

                Console.Write("Input time (seconds): ");
                seconds = Convert.ToDouble(Console.ReadLine());

                totalSeconds = (hours * 3600.0) + (minutes * 60.0) + seconds;
                totalHours = totalSeconds / 3600.0;

                metersPerSec = distance / totalSeconds;
                kmPerHour = (distance / 1000.0) / totalHours;
                milesPerHour = (distance / 1609.344) / totalHours;

                Console.WriteLine($"Your speed in metres/sec is {metersPerSec}");
                Console.WriteLine($"Your speed in km/h is {kmPerHour}");
                Console.WriteLine($"Your speed in miles/h is {milesPerHour}");
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Enter A Valid Number");
            }
        }
    }
    // Question 8
    static void sphere_radius()
    {
        double radius;
        double surfaceArea;
        double volume;
        while (true)
        {
            try
            {
                Console.Write("Enter the radius of the sphere: ");
                radius = Convert.ToDouble(Console.ReadLine());
                surfaceArea = 4.0 * Math.PI * Math.Pow(radius, 2);
                volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
                Console.WriteLine($"Surface Area of Sphere: {surfaceArea:F2}");
                Console.WriteLine($"Volume of Sphere: {volume:F2}");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
    }
    // Question 9
    static void What_Is_This_Char()
    {
        char symbol;
        char lowerSymbol;
        while (true)
        {
            try
            {
                Console.Write("Input any symbol: ");
                symbol = Convert.ToChar(Console.ReadLine());
                lowerSymbol = char.ToLower(symbol);
                if (char.IsWhiteSpace(symbol))
                    System.Console.WriteLine("Please Enter A Character/Letter");
                else if (lowerSymbol == 'a' || lowerSymbol == 'e' || lowerSymbol == 'i' || lowerSymbol == 'o' || lowerSymbol == 'u')
                {
                    Console.WriteLine("It's a lowercase or uppercase vowel.");
                    break;
                }
                else if (char.IsDigit(symbol))
                {
                    Console.WriteLine("It's a digit.");
                    break;
                }
                else
                {
                    Console.WriteLine("It's another symbol.");
                    break;
                }
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter Only 1 Character/Letter");
            }
        }
    }
    // Question 10
    static void Odd_Or_Even()
    {
        double? num1;
        double? num2;
        while (true)
        {
            try
            {
                System.Console.Write("Enter Number One:");
                num1 = Convert.ToDouble(Console.ReadLine());
                System.Console.Write("Enter Number two:");
                num2 = Convert.ToDouble(Console.ReadLine());

                if (num1 % 2 == 0 && num2 % 2 == 0)
                    System.Console.WriteLine("True");
                else if (num1 % 2 != 0 && num2 % 2 != 0)
                    System.Console.WriteLine("True");
                else
                    System.Console.WriteLine("False");
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
    }
    // Question 11 last one.
    static void Display_Binary()
    {
        int decimalNumber;
        string binaryString;
        while (true)
        {
            try
            {
                Console.Write("Input a decimal number: ");
                decimalNumber = Convert.ToInt32(Console.ReadLine());
                binaryString = Convert.ToString(decimalNumber, 2);
                Console.WriteLine($"Binary representation: {binaryString}");
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
    }
}