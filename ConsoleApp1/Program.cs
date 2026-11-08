using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration.Assemblies;
using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace ConsoleApp1;

class Program
{
    static void Main(string[] argv)
    {
        // C# Basic Declarations and Expressions
        // Print_Hello_and_Name(); // 1
        // Sum_of_Two_Numbers(); // 2
        // Divide_Two_Numbers(); //3
        // Specified_Operations_Results(); // 4
        // Swap_Two_Numbers(); // 5
        // Multiply_Three_Numbers(); // 6
        // Arithmetic_Operations();  // 7
        // Multiplication_Table(); // 8
        // Average_of_Four_Numbers(); // 9
        // Specified_Formula_with_Three_Numbers(); // 10
        // Print_Age_Message(); // 11
        // Repeat_Number_in_Rows(); // 12
        // Rectangle_Pattern_with_Number(); // 13
        // Celsius_to_Kelvin_and_Fahrenheit(); // 14
        // Remove_Character_by_Index(); // 15
        // Swap_First_and_Last_Characters(); // 16
        // Add_First_Character_to_Front_and_Back(); // 17
        // Check_Positive_and_Negative_Pair(); // 18
        // Sum_or_Triple_Sum_of_Integers(); // 19
        // Absolute_Difference_or_Double_It(); // 20
        // Check_for_20_or_Sum_Equals_20(); // 21
        // Check_Within_20_of_100_or_200(); // 22
        // Convert_String_to_Lowercase(); // 23
        // Find_Longest_Word_in_String(); // 24
        // Print_Odd_Numbers_1_to_99(); // 25
        // Sum_of_First_500_Primes(); // 26
        // Sum_of_Digits_in_Integer(); // 27
        // Reverse_Words_in_Sentence(); // 28
        // File_Size_in_Bytes(); // 29
        // Hexadecimal_to_Decimal(); // 30
        // Multiply_Two_Arrays(); // 31
        // Four_Copies_of_Last_Four_Characters(); // 32
        // Check_Multiple_of_3_or_7(); // 33
        // Check_String_Starts_with_Word(); // 34
        // Check_Numbers_Less_than_100_and_Greater_than_200(); // 35
        // Check_Integer_in_Range_minus_10_to_10(); // 36
        // Remove_HP_from_String(); // 37
        // Extract_PH_from_String(); // 38
        // Largest_and_Lowest_of_Three_Integers(); // 39
        // Nearest_to_20_or_Return_0(); // 40
        // Check_w_Appears_1_3_Times(); // 41
        // First_4_Chars_Lowercase_Rest_Uppercase(); // 42
        // Check_String_Starts_with_www(); // 43
        // Every_Other_Character_in_String(); // 44
        // Count_Specific_Number_in_Array(); // 45
        // Check_Number_First_or_Last_in_Array(); // 46
        // Sum_of_Array_Elements(); // 47
        // First_and_Last_Element_Equal_in_Array(); // 48
        // First_or_Last_Element_Equal_in_Two_Arrays(); // 49
        // Rotate_Array_Left(); // 50
        // Max_of_First_and_Last_in_Array(); // 51
        // Middle_Elements_of_Three_Arrays(); // 52
        // Check_Odd_Number_in_Array(); // 53
        // Find_Century_of_Year(); // 54
        // Max_Product_of_Adjacent_Elements(); // 55 same question?
        // Check_Palindrome_String(); // 56
        // Max_Product_of_Adjacent_Integers(); // 57 same question?
        // Complete_Missing_Numbers_in_Range(); // 58
        // Check_Strictly_Increasing_Sequence(); // 59
        // Sum_of_Matrix_with_Zero_Condition(); // 60
        // Sort_Integers_Keeping_Minus5_Fixed(); // 61
        // Reverse_Strings_in_Parentheses(); // 62
        // Check_Number_in_Array(); // 63
        // Get_File_Name_from_Path(); // 64
        // Multiply_Array_Elements_by_Length(); // 65
        // Min_Value_from_Two_String_Numbers(); // 66
        // Coded_String_Conversion(); // 67
        // Count_Specific_Character_in_String(); // 68
        // Check_All_Uppercase_or_Lowercase(); // 69
        // Remove_First_and_Last_Characters(); // 70
        // Check_Consecutive_Similar_Letters(); // 71
        // Check_Array_Average_as_Whole_Number(); // 72
        // Alphabetical_Order_of_String_Letters(); // 73
        // Odd_or_Even_Length_of_String(); // 74
        // Nth_Odd_Number(); // 75
        // Get_ASCII_Value_of_Character(); // 76
        // Check_Word_Plural(); // 77
        // Sum_of_Squares_in_Array(); // 78
        // Integer_to_String_and_Vice_Versa(); // 79
        // Convert_Array_Elements_to_Strings(); // 80
        // Check_Swapped_Two_Digit_Number(); // 81
        // Remove_Non_Letter_Characters(); // 82
        // Remove_Vowels_from_String(); // 83
        // Indices_of_Lowercase_Letters(); // 84
        // Cumulative_Sum_of_Array(); // 85
        // Count_Letters_and_Digits_in_String(); // 86
        // Reverse_Boolean_Value(); // 87
        // Sum_of_Interior_Angles_in_Polygon(); // 88
        // Count_Positives_and_Negatives_in_Array(); // 89
        // Count_Ones_and_Zeros_in_Binary(); // 90
        // Remove_Non_Integer_Values_from_Array(); // 91
        // Find_Next_Prime_Number(); // 92
        // Square_Root_Without_Built_In_Functions(); // 93
        // Find_Longest_Common_Prefix(); // 94
        // Validate_Brackets_in_String(); // 95
        // Check_All_Characters_Same_in_String(); // 96
        // static void Check_Numeric_String(); // 97
        // Primes_in_Descending_Order(); // 98
        // Primes_in_Ascending_Order(); // 99
        // Equality_of_Value_and_Type(); // 100
        // Calculate_Eulers_Number(); // 101
        // Create_Identity_Matrix(); // 102
        // Sort_Characters_in_String(); // 103
        // Compare_Equality_of_Three_Integers(); // 104
    }
    // Question 1
    static void Print_Hello_and_Name()
    {
        string? name;
        while (true)
        {
            System.Console.WriteLine("What's Your Name?");
            name = Console.ReadLine();
            if (name == "")
                System.Console.WriteLine("Enter A Valid Name");
            else
                break;
        }
        System.Console.WriteLine($"Hello, {name}");
    }
    // Question 2
    static void Sum_of_Two_Numbers()
    {
        int? num1;
        int? num2;
        while (true)
        {
            try
            {
                System.Console.Write("Enter The First Number:");
                num1 = Convert.ToInt32(Console.ReadLine());
                System.Console.Write("Enter The Second Number:");
                num2 = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
    }
    // Question 3
    static void Divide_Two_Numbers()
    {
        double? num11;
        double? num22;
        while (true)
        {
            try
            {
                System.Console.Write("Enter The First Number:");
                num11 = Convert.ToDouble(Console.ReadLine());
                System.Console.Write("Enter The Second Number:");
                num22 = Convert.ToDouble(Console.ReadLine());
                System.Console.WriteLine($"{num11} / {num22} = {num11 / num22}");
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
    }
    // Question 4? (this is the last Question I did I left it for last)
    static void Specified_Operations_Results()
    {
        int result1 = -1 + 4 * 6;
        int result2 = (35 + 5) % 7;
        int result3 = 14 + -4 * 6 / 11;
        int result4 = 2 + 15 / 6 * 1 - 7 % 2;

        System.Console.WriteLine($"Result 1: {result1}");
        System.Console.WriteLine($"Result 2: {result2}");
        System.Console.WriteLine($"Result 3: {result3}");
        System.Console.WriteLine($"Result 4: {result4}");
    }
    // Question 5
    static void Swap_Two_Numbers()
    {
        double? x;
        double? y;
        double? doubleswap;
        while (true)
        {
            try
            {
                System.Console.Write("x:");
                x = Convert.ToDouble(Console.ReadLine());
                System.Console.Write("y:");
                y = Convert.ToDouble(Console.ReadLine());
                doubleswap = x;
                x = y;
                y = doubleswap;
                System.Console.WriteLine($"x:{x}");
                System.Console.WriteLine($"y:{y}");
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
    }
    // Question 6
    static void Multiply_Three_Numbers()
    {
        double? number1;
        double? number2;
        double? number3;
        while (true)
        {
            try
            {
                System.Console.Write("Number1:");
                number1 = Convert.ToDouble(Console.ReadLine());
                System.Console.Write("Number2:");
                number2 = Convert.ToDouble(Console.ReadLine());
                System.Console.Write("Number3:");
                number3 = Convert.ToDouble(Console.ReadLine());
                System.Console.WriteLine($"{number1} * {number2} * {number3} = {number1 * number2 * number3}");
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
    }
    // Question 7
    static void Arithmetic_Operations()
    {
        double o = 5;
        double i = 20;
        System.Console.WriteLine($"{o} + {i} = {o + i}");
        System.Console.WriteLine($"{o} - {i} = {o - i}");
        System.Console.WriteLine($"{o} * {i} = {o * i}");
        System.Console.WriteLine($"{o} / {i} = {o / i}");
        System.Console.WriteLine($"{o} % {i} = {o % i}");
    }
    // Question 8
    static void Multiplication_Table()
    {
        for (int i = 0; i <= 10; i++)
        {
            System.Console.WriteLine($"5 * {i} = {5 * i}");
        }
    }
    // Question 9
    static void Average_of_Four_Numbers()
    {
        double? number1;
        double? number2;
        double? number3;
        double? number4;
        double? total;
        while (true)
        {
            try
            {
                System.Console.Write("Number1:");
                number1 = Convert.ToDouble(Console.ReadLine());
                System.Console.Write("Number2:");
                number2 = Convert.ToDouble(Console.ReadLine());
                System.Console.Write("Number3:");
                number3 = Convert.ToDouble(Console.ReadLine());
                System.Console.Write("Number4:");
                number4 = Convert.ToDouble(Console.ReadLine());
                total = number1 + number2 + number3 + number4;
                System.Console.WriteLine($"total = {number1} + {number2} + {number3} = {number1 + number2 + number3 + number4}");
                System.Console.WriteLine($"Average = {total} / 4 = {total / 4}");
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
    }
    // Question 10
    static void Specified_Formula_with_Three_Numbers()
    {
        double? x;
        double? y;
        double? z;
        while (true)
        {
            try
            {
                System.Console.Write("x:");
                x = Convert.ToDouble(Console.ReadLine());
                System.Console.Write("y:");
                y = Convert.ToDouble(Console.ReadLine());
                System.Console.Write("z:");
                z = Convert.ToDouble(Console.ReadLine());

                System.Console.WriteLine($"({x} + {y}) * {z} = {(x + y) * z}");
                System.Console.WriteLine($"{x} * {y} + {y} * {z} = {x * y + y * z}");
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
    }
    // Question 11
    static void Print_Age_Message()
    {
        int? age;
        while (true)
        {
            try
            {
                System.Console.WriteLine("How Old Are You?");
                age = Convert.ToInt32(Console.ReadLine());
                if (age >= 18)
                {
                    System.Console.WriteLine($"You Are An Adult Since Adults Are Above 17 And Your {age}");
                    break;
                }
                else
                {
                    System.Console.WriteLine($"You Are A Minor Since Minors Are Yonger Than 18 And Your {age}");
                    break;
                }
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
    }
    // Question 12
    static void Repeat_Number_in_Rows()
    {
        double? x;
        while (true)
        {
            try
            {
                System.Console.Write("x:");
                x = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < 4; i++)
                    System.Console.Write($"{x} ");
                System.Console.WriteLine();

                for (int i = 0; i < 4; i++)
                    System.Console.Write(x);
                System.Console.WriteLine();

                for (int i = 0; i < 4; i++)
                    System.Console.Write($"{x} ");
                System.Console.WriteLine();

                for (int i = 0; i < 4; i++)
                    System.Console.Write(x);
                System.Console.WriteLine();

                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
    }
    // Question 13
    static void Rectangle_Pattern_with_Number()
    {
        int? x;
        while (true)
        {
            try
            {
                System.Console.Write("x:");
                x = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < 5; i++)
                {
                    for (int z = 0; z < 3; z++)
                    {
                        System.Console.Write(x);
                    }
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
    //Question 14
    static void Celsius_to_Kelvin_and_Fahrenheit()
    {
        double? C;
        while (true)
        {
            try
            {
                System.Console.Write("°C:");
                C = Convert.ToDouble(Console.ReadLine());
                System.Console.WriteLine($"Kelvin = {C} + 273.15 = {C + 273.15}K");
                System.Console.WriteLine($"Fahrenheit = ({C} * 1.8) + 32 = {(C * 1.8) + 32}F");
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
    }
    // Question 15
    static void Remove_Character_by_Index()
    {
        string name;
        int index;
        do
        {
            System.Console.Write("Please Enter A Random Name:");
            name = Console.ReadLine();
        } while (name == "");
        while (true)
        {
            try
            {
                System.Console.Write("Enter The Index Of The Number You Want To Remove:");
                index = Convert.ToInt32(Console.ReadLine());
                name = name.Remove(index, 1);
                System.Console.WriteLine(name);
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
    }
    // Question 16
    static void Swap_First_and_Last_Characters()
    {
        string name;
        do
        {
            System.Console.Write("Enter A Random Name:");
            name = Console.ReadLine();
        } while (name == "");
        name = name[name.Length - 1] + name.Substring(1, name.Length - 2) + name[0];
        System.Console.WriteLine("Swapped result: " + name);
    }
    // Question 17
    static void Add_First_Character_to_Front_and_Back()
    {
        string name;
        do
        {
            System.Console.Write("Enter A Random Name:");
            name = Console.ReadLine();
        } while (name == "");
        name = name.Insert(0, name[0].ToString());
        name = name.Insert(name.Length, name[0].ToString());
        System.Console.WriteLine(name);
    }
    // Question 18
    static void Check_Positive_and_Negative_Pair()
    {
        double? num2;
        double? num1;
        while (true)
        {
            try
            {
                System.Console.Write("Enter The First Number:");
                num1 = Convert.ToDouble(Console.ReadLine());
                System.Console.Write("Enter The Sec Number:");
                num2 = Convert.ToDouble(Console.ReadLine());

                if (num1 < 0 && num2 > 0 || num1 > 0 && num2 < 0)
                {
                    System.Console.WriteLine("true");
                    break;
                }
                else
                {
                    System.Console.WriteLine("false");
                    break;
                }
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
    }
    // Question 19
    static void Sum_or_Triple_Sum_of_Integers()
    {
        double? x;
        double? y;
        while (true)
        {
            try
            {
                System.Console.Write("x:");
                x = Convert.ToDouble(Console.ReadLine());
                System.Console.Write("y:");
                y = Convert.ToDouble(Console.ReadLine());

                if (x == y)
                {
                    System.Console.WriteLine($"{x} + {y} = {x + y} , {x + y} * 3 = {(x + y) * 3}");
                    break;
                }
                else
                {
                    System.Console.WriteLine($"{x} + {y} = {x + y}");
                    break;
                }
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }


        }
    }
    // Question 20
    static void Absolute_Difference_or_Double_It()
    {
        int? x;
        int? y;
        while (true)
        {
            try
            {
                System.Console.Write("x:");
                x = Convert.ToInt32(Console.ReadLine());
                System.Console.Write("y:");
                y = Convert.ToInt32(Console.ReadLine());

                if (x > y)
                {
                    System.Console.WriteLine($"({x} - {y})*2 = {(x - y) * 2}");
                    break;
                }
                else
                {
                    System.Console.WriteLine($"{y} - {x} = {y - x}");
                    break;
                }
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
    }
    // Question 21
    static void Check_for_20_or_Sum_Equals_20()
    {
        double? x;
        double? y;
        while (true)
        {
            try
            {
                System.Console.Write("x:");
                x = Convert.ToDouble(Console.ReadLine());
                System.Console.Write("y:");
                y = Convert.ToDouble(Console.ReadLine());
                if (x + y == 20 || x == 20 || y == 20)
                {
                    System.Console.WriteLine("true");
                    break;
                }
                else
                {
                    System.Console.WriteLine("false");
                    break;
                }
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
    }
    // Question 22
    static void Check_Within_20_of_100_or_200()
    {
        double? x;
        while (true)
        {
            try
            {
                System.Console.Write("x:");
                x = Convert.ToDouble(Console.ReadLine());
                if ((x >= 80 && x <= 120) || (x >= 180 && x <= 220))
                {
                    System.Console.WriteLine("True");
                    break;
                }
                else
                {
                    System.Console.WriteLine("False");
                    break;
                }
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }

    }
    // Question 23
    static void Convert_String_to_Lowercase()
    {
        string? name;
        do
        {
            System.Console.WriteLine("Enter A Random Name");
            name = Console.ReadLine().ToLower();
            System.Console.WriteLine(name);
        } while (name == "");
    }
    // Question 24
    static void Find_Longest_Word_in_String()
    {
        string name;
        do
        {

            System.Console.Write("Enter a sentence: ");
            name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new Exception();
            }
            string[] letters = name.Split(' ');
            string longestWord = "";
            int max = 0;
            foreach (string letter in letters)
            {
                if (letter.Length > max)
                {
                    max = letter.Length;
                    longestWord = letter;
                }
            }
            System.Console.WriteLine($"The longest word is: {longestWord}");
        } while (name == "");
    }
    // Question 25
    static void Print_Odd_Numbers_1_to_99()
    {
        for (int i = 1; i < 100; i += 2)
        {
            System.Console.WriteLine(i);
        }
    }
    // Question 26
    static void Sum_of_First_500_Primes()
    {
        long total = 0;
        int primeCount = 0;
        int number = 2;

        while (primeCount < 500)
        {
            bool isPrime = true;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime == true)
            {
                total += number;
                primeCount++;
            }

            number++;
        }

        System.Console.WriteLine(total);

    }
    // Question 27
    static void Sum_of_Digits_in_Integer()
    {
        int num = 0;
        int sum = 0;
        while (true)
        {
            try
            {
                System.Console.Write("Enter A Long Number:");
                num = Convert.ToInt32(Console.ReadLine());
                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                System.Console.WriteLine(sum);
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
    }
    // Question 28
    static void Reverse_Words_in_Sentence()
    {
        string? PEAK;
        string REVERSED;
        do
        {
            System.Console.Write("Enter A Random Sentence:");
            PEAK = Console.ReadLine();
        } while (PEAK == "" && PEAK.Length < 5);
        string[] words = PEAK.Split(' ');
        Array.Reverse(words);
        REVERSED = string.Join(" ", words);
        System.Console.WriteLine(REVERSED);
    }
    // Question 29
    static void File_Size_in_Bytes()
    {
        string? path;
        while (true)
        {
            System.Console.Write("Please Enter A File Path:");
            path = Console.ReadLine();
            if (File.Exists(path))
            {
                FileInfo x = new FileInfo(path);
                long size = x.Length;
                System.Console.WriteLine($"The Size In Bytes Is {size}");
                break;
            }
            else
                System.Console.WriteLine("File Not Found!");
        }
    }
    // Question 30
    static void Hexadecimal_to_Decimal()
    {
        string? hex;
        double result = 0;
        int total = 0;

        do
        {
            System.Console.Write("Enter A Hex Number:");
            hex = Console.ReadLine();
        } while (hex == "");

        for (int i = 0; i <= hex.Length - 1; i++)
        {
            switch (hex[i])
            {
                case 'A':
                    total = 10;
                    break;
                case 'B':
                    total = 11;
                    break;
                case 'C':
                    total = 12;
                    break;
                case 'D':
                    total = 13;
                    break;
                case 'E':
                    total = 14;
                    break;
                case 'F':
                    total = 15;
                    break;
                default:
                    total = hex[i] - '0';
                    break;
            }
            result += total * Math.Pow(16, hex.Length - 1 - i);
        }
        System.Console.WriteLine(result);
    }
    // Question 31
    static void Multiply_Two_Arrays()
    {
        int[] ints = [1, 2, 3, 4];
        int[] ints1 = [2, 3, 4, 5];
        int[] x = new int[ints.Length];
        for (int i = 0; i < 4; i++)
        {
            x[i] += ints[i] * ints1[i];
        }
        foreach (int z in x)
        {
            System.Console.Write($"{z} ");
        }
    }
    // Question 32
    static void Four_Copies_of_Last_Four_Characters()
    {
        string? whatever;
        do
        {
            System.Console.WriteLine("Enter A Random Name That's Bigger Than 4 Letters:");
            whatever = Console.ReadLine();
        } while (whatever.Length < 4);
        for (int i = whatever.Length - 1; i >= 0; i--)
        {
            System.Console.Write(whatever[i]);
        }
    }
    // Question 33
    static void Check_Multiple_of_3_or_7()
    {
        int x = 0;
        while (true)
        {
            try
            {
                System.Console.Write("x:");
                x = Convert.ToInt32(Console.ReadLine());

                if (x % 3 == 0 || x % 7 == 0)
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
    // Question 34
    static void Check_String_Starts_with_Word()
    {
        string? idk;
        do
        {
            System.Console.WriteLine("Enter A Random Sentence AND it has to start with 'Hello' ");
            idk = Console.ReadLine().ToLower();
        } while (string.IsNullOrWhiteSpace(idk)); // just learned this like 2 hours ago
        if (idk.StartsWith("hello"))
            System.Console.WriteLine("True");
        else
            System.Console.WriteLine("False");
    }
    // Question 35
    static void Check_Numbers_Less_than_100_and_Greater_than_200()
    {
        double x = 0;
        double y = 0;
        while (true)
        {
            try
            {
                System.Console.Write("x:");
                x = Convert.ToDouble(Console.ReadLine());
                System.Console.Write("y:");
                y = Convert.ToDouble(Console.ReadLine());

                if (x < 100 && y > 200 || x > 200 && y < 100)
                    System.Console.WriteLine("true");
                else
                    System.Console.WriteLine("false");
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
    }
    // Question 36
    static void Check_Integer_in_Range_minus_10_to_10()
    {
        double x = 0;
        double y = 0;
        while (true)
        {
            try
            {
                System.Console.Write("x:");
                x = Convert.ToDouble(Console.ReadLine());
                System.Console.Write("y:");
                y = Convert.ToDouble(Console.ReadLine());

                if (x <= 10 && x >= -10 || y <= 10 && y >= -10)
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
    // Question 37
    static void Remove_HP_from_String()
    {
        string? HP;
        do
        {
            System.Console.WriteLine("Enter A Word With 'HP' At The Index 1");
            HP = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(HP));
        if (HP[1] == 'H' && HP[2] == 'P')
        {
            HP = HP.Remove(1, 2);
            System.Console.WriteLine(HP);
        }
        else
            System.Console.WriteLine(HP);
    }
    // Question 38
    static void Extract_PH_from_String()
    {
        string? PH;
        do
        {
            System.Console.WriteLine("Enter A Word That Has PH On EachOther");
            PH = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(PH));

        if (PH.Contains("PH"))
            System.Console.WriteLine("PH");
        else
            System.Console.WriteLine(PH);
    }
    // Question 39
    static void Largest_and_Lowest_of_Three_Integers()
    {
        double x = 0;
        double y = 0;
        double z = 0;
        double largest = 0;
        while (true)
        {
            try
            {
                System.Console.Write("x:");
                x = Convert.ToDouble(Console.ReadLine());
                System.Console.Write("y:");
                y = Convert.ToDouble(Console.ReadLine());
                System.Console.Write("z:");
                z = Convert.ToDouble(Console.ReadLine());

                largest = Math.Max(x, Math.Max(y, z));
                System.Console.WriteLine($"Largest: {largest}");
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }


        }
    }
    // Question 40
    static void Nearest_to_20_or_Return_0()
    {
        double x = 0;
        double y = 0;
        double distance_of_y = 0;
        double distance_of_x = 0;
        while (true)
        {
            try
            {
                System.Console.Write("x:");
                x = Convert.ToDouble(Console.ReadLine());
                System.Console.Write("y:");
                y = Convert.ToDouble(Console.ReadLine());

                distance_of_x = Math.Abs(x - 20);
                distance_of_y = Math.Abs(y - 20);
                if (distance_of_x > distance_of_y)
                    System.Console.WriteLine($"{y} is closer to 20 than {x}");
                else if (distance_of_x < distance_of_y)
                    System.Console.WriteLine($"{x} is closer to 20 than {y}");
                else
                    System.Console.WriteLine(0);
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }


        }
    }
    // Question 41
    static void Check_w_Appears_1_3_Times()
    {
        string? w;
        int count = 0;
        do
        {
            System.Console.WriteLine("Enter A Sentence/word that has w more than 3 times");
            w = Console.ReadLine().ToLower();
        } while (string.IsNullOrWhiteSpace(w));
        for (int i = 0; i < w.Length; i++)
        {
            if (w[i] == 'w')
                count++;
        }
        if (count >= 1 && count <= 3)
            System.Console.WriteLine("True");
        else
            System.Console.WriteLine("false");
    }
    // Question 42
    static void First_4_Chars_Lowercase_Rest_Uppercase()
    {
        string? HELP;
        do
        {
            System.Console.WriteLine("Enter A Random Word Larger Than 4 Letters");
            HELP = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(HELP));

        if (HELP.Length < 4)
        {
            System.Console.WriteLine(HELP.ToUpper());
        }
        else
        {
            string result = HELP.Substring(0, 4).ToLower() + HELP.Substring(4).ToUpper();
            System.Console.WriteLine(result);
        }
    }
    // Question 43
    static void Check_String_Starts_with_www()
    {
        string? www;
        do
        {
            System.Console.WriteLine("Enter A Word That Starts With 'www' ");
            www = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(www));
        if (www.Length > 3 && www[0] == 'w' && www[1] == 'w' && www[2] == 'w')
            System.Console.WriteLine("True");
        else
            System.Console.WriteLine("False");
    }
    // Question 44
    static void Every_Other_Character_in_String()
    {
        string? idk_man;
        string result = "";
        do
        {
            System.Console.WriteLine("Enter A Random Word");
            idk_man = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(idk_man));
        for (int i = 0; i < idk_man.Length; i += 2)
            result += idk_man[i];
        System.Console.WriteLine(result);
    }
    // Question 45
    static void Count_Specific_Number_in_Array()
    {
        int[] numbers = { 1, 5, 2, 5, 3, 5, 4 };
        int target = 0;
        bool isValid = false;

        do
        {
            try
            {
                System.Console.WriteLine("Enter a number to count in the array { 1, 5, 2, 5, 3, 5, 4 }");
                target = Convert.ToInt32(Console.ReadLine());
                isValid = true;
            }
            catch
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        } while (!isValid);

        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == target)
            {
                count++;
            }
        }

        System.Console.WriteLine(count);
    }
    // Question 46
    static void Check_Number_First_or_Last_in_Array()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        int? num = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter A Number In The Array:{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }");
                num = Convert.ToInt32(Console.ReadLine());
                if (num == numbers[0] || num == numbers[numbers.Length - 1])
                    System.Console.WriteLine("TRUE");
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
    // Question 47
    static void Sum_of_Array_Elements()
    {
        int length = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter the size of the array");
                length = Convert.ToInt32(Console.ReadLine());
                if (length > 0) break;
                System.Console.WriteLine("Please enter a number greater than 0");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }

        int[] ints = new int[length];

        for (int i = 0; i < ints.Length; i++)
        {
            while (true)
            {
                try
                {
                    System.Console.WriteLine($"Enter element for index [{i}]");
                    ints[i] = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Please Enter A Valid Number");
                }
            }
        }

        int sum = 0;
        for (int i = 0; i < ints.Length; i++)
        {
            sum += ints[i];
        }

        System.Console.WriteLine($"Sum: {sum}");
    }
    // Question 48
    static void First_and_Last_Element_Equal_in_Array()
    {
        int length = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter the size of the array");
                length = Convert.ToInt32(Console.ReadLine());
                if (length > 0) break;
                System.Console.WriteLine("Please enter a number greater than 0");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }

        int[] ints = new int[length];

        for (int i = 0; i < ints.Length; i++)
        {
            while (true)
            {
                try
                {
                    System.Console.WriteLine($"Enter element for index [{i}]");
                    ints[i] = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Please Enter A Valid Number");
                }
            }
        }
        if (ints[0] == ints[ints.Length - 1])
            System.Console.WriteLine("true");
        else
            System.Console.WriteLine("false");
    }
    // Question 49
    static void First_or_Last_Element_Equal_in_Two_Arrays()
    {
        int length = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter the size of the first array");
                length = Convert.ToInt32(Console.ReadLine());
                if (length > 0) break;
                System.Console.WriteLine("Please enter a number greater than 0");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }

        int[] ints = new int[length];

        for (int i = 0; i < ints.Length; i++)
        {
            while (true)
            {
                try
                {
                    System.Console.WriteLine($"Enter element for index [{i}]");
                    ints[i] = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Please Enter A Valid Number");
                }
            }
        }

        int lengths = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter the size of the second array");
                lengths = Convert.ToInt32(Console.ReadLine());
                if (lengths > 0) break;
                System.Console.WriteLine("Please enter a number greater than 0");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }

        int[] intss = new int[lengths];

        for (int i = 0; i < intss.Length; i++)
        {
            while (true)
            {
                try
                {
                    System.Console.WriteLine($"Enter element for index [{i}]");
                    intss[i] = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Please Enter A Valid Number");
                }
            }
        }
        if (ints[0] == intss[0] || ints[ints.Length - 1] == intss[intss.Length - 1])
            System.Console.WriteLine("True");
        else
            System.Console.WriteLine("False");
    }
    // Question 50 
    static void Rotate_Array_Left()
    {
        int[] ints = new int[3];

        for (int i = 0; i < ints.Length; i++)
        {
            while (true)
            {
                try
                {
                    System.Console.WriteLine($"Enter element for index [{i}]");
                    ints[i] = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Please Enter A Valid Number");
                }
            }
        }

        int[] rotated = { ints[1], ints[2], ints[0] };

        System.Console.WriteLine("Rotated Array:");
        for (int i = 0; i < rotated.Length; i++)
        {
            System.Console.Write(rotated[i] + " ");
        }
        System.Console.WriteLine();
    }
    // Question 51
    static void Max_of_First_and_Last_in_Array()
    {
        int length = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter the size of the array");
                length = Convert.ToInt32(Console.ReadLine());
                if (length > 0) break;
                System.Console.WriteLine("Please enter a number greater than 0");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }

        int[] ints = new int[length];

        for (int i = 0; i < ints.Length; i++)
        {
            while (true)
            {
                try
                {
                    System.Console.WriteLine($"Enter element for index [{i}]");
                    ints[i] = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Please Enter A Valid Number");
                }
            }
        }
        if (ints[0] < ints[ints.Length - 1])
            System.Console.WriteLine($"{ints[0]} < {ints[ints.Length - 1]}");
        else if (ints[0] > ints[ints.Length - 1])
            System.Console.WriteLine($"{ints[ints.Length - 1]} < {ints[0]}");
        else
            System.Console.WriteLine($"Both Are Equal! {ints[0]} = {ints[ints.Length - 1]}");
    }
    // Question 52 Half Way There ...
    static void Middle_Elements_of_Three_Arrays()
    {
        int[] int0 = { 1, 2, 3 };
        int[] int1 = { 2, 3, 4 };
        int[] int2 = { 3, 4, 5 };
        int[] middle = { int0[1], int1[1], int2[1] };
        foreach (int x in middle)
            System.Console.Write($"{x} ");
    }
    // Question 53
    static void Check_Odd_Number_in_Array()
    {
        int length = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter the size of the array");
                length = Convert.ToInt32(Console.ReadLine());
                if (length > 0) break;
                System.Console.WriteLine("Please enter a number greater than 0");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }

        int[] ints = new int[length];

        for (int i = 0; i < ints.Length; i++)
        {
            while (true)
            {
                try
                {
                    System.Console.WriteLine($"Enter element for index [{i}]");
                    ints[i] = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Please Enter A Valid Number");
                }
            }
        }
        bool ISIT = false;
        for (int i = 0; i < ints.Length; i++)
        {
            if (ints[i] % 2 != 0)
            {
                ISIT = true;
                break;
            }
        }
        if (ISIT)
            System.Console.WriteLine("True");
        else if (!ISIT)
            System.Console.WriteLine("False");
    }
    // Question 54
    static void Find_Century_of_Year()
    {
        int year = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter A Random Year");
                year = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
        int century = (int)Math.Ceiling((double)year / 100);
        System.Console.WriteLine($"The Century Of {year} is {century}");
    }
    // Question 55 same question?
    static void Max_Product_of_Adjacent_Elements()
    {
        int length = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter the size of the array");
                length = Convert.ToInt32(Console.ReadLine());
                if (length > 0) break;
                System.Console.WriteLine("Please enter a number greater than 0");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }

        int[] ints = new int[length];

        for (int i = 0; i < ints.Length; i++)
        {
            while (true)
            {
                try
                {
                    System.Console.WriteLine($"Enter element for index [{i}]");
                    ints[i] = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Please Enter A Valid Number");
                }
            }
        }
        int maxed = ints[0] * ints[1];
        for (int i = 0; i < ints.Length - 1; i++)
        {
            int PlaceHOLDER1 = ints[i] * ints[i + 1];
            if (PlaceHOLDER1 > maxed)
            {
                maxed = PlaceHOLDER1;
            }
        }
        System.Console.WriteLine(maxed);
    }
    // Question 56
    static void Check_Palindrome_String()
    {
        string? PEAK;
        do
        {
            System.Console.Write("Enter A Random Word/Sentence: ");
            PEAK = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(PEAK));
        char[] charArray = PEAK.ToCharArray();
        Array.Reverse(charArray);
        string REVERSED = new string(charArray);
        if (REVERSED == PEAK)
            System.Console.WriteLine("True");
        else
            System.Console.WriteLine("False");
    }
    // Question 57 same question?
    static void Max_Product_of_Adjacent_Integers()
    {
        int length = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter the size of the array");
                length = Convert.ToInt32(Console.ReadLine());
                if (length > 0) break;
                System.Console.WriteLine("Please enter a number greater than 0");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }

        int[] ints = new int[length];

        for (int i = 0; i < ints.Length; i++)
        {
            while (true)
            {
                try
                {
                    System.Console.WriteLine($"Enter element for index [{i}]");
                    ints[i] = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Please Enter A Valid Number");
                }
            }
        }
        int maxed = ints[0] * ints[1];
        for (int i = 0; i < ints.Length - 1; i++)
        {
            int PlaceHOLDER1 = ints[i] * ints[i + 1];
            if (PlaceHOLDER1 > maxed)
            {
                maxed = PlaceHOLDER1;
            }
        }
        System.Console.WriteLine(maxed);
    }
    // Question 58
    static void Complete_Missing_Numbers_in_Range()
    {
        int length = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter the size of the array");
                length = Convert.ToInt32(Console.ReadLine());
                if (length > 0) break;
                System.Console.WriteLine("Please enter a number greater than 0");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }

        int[] ints = new int[length];

        for (int i = 0; i < ints.Length; i++)
        {
            while (true)
            {
                try
                {
                    System.Console.WriteLine($"Enter element for index [{i}]");
                    ints[i] = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Please Enter A Valid Number");
                }
            }
        }

        int min = ints[0];
        int max = ints[0];

        for (int i = 1; i < ints.Length; i++)
        {
            if (ints[i] < min) min = ints[i];
            if (ints[i] > max) max = ints[i];
        }

        int missingCount = 0;

        for (int current = min; current <= max; current++)
        {
            bool found = false;
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] == current)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                missingCount++;
            }
        }

        System.Console.WriteLine($"Missing count: {missingCount}");
    }
    // Question 59
    static void Check_Strictly_Increasing_Sequence()
    {
        int length = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter the size of the array");
                length = Convert.ToInt32(Console.ReadLine());
                if (length > 0) break;
                System.Console.WriteLine("Please enter a number greater than 0");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }

        int[] ints = new int[length];

        for (int i = 0; i < ints.Length; i++)
        {
            while (true)
            {
                try
                {
                    System.Console.WriteLine($"Enter element for index [{i}]");
                    ints[i] = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Please Enter A Valid Number");
                }
            }
        }

        int count = 0;

        for (int i = 0; i < ints.Length - 1; i++)
        {
            if (ints[i] >= ints[i + 1])
            {
                count++;
                if (count > 1)
                {
                    break;
                }

                // Check if removing ints[i] or ints[i + 1] leaves the sequence valid
                bool canRemoveCurrent = (i == 0 || ints[i - 1] < ints[i + 1]);
                bool canRemoveNext = (i + 2 >= ints.Length || ints[i] < ints[i + 2]);

                if (!canRemoveCurrent && !canRemoveNext)
                {
                    count++;
                    break;
                }
            }
        }

        if (count <= 1)
            System.Console.WriteLine("True");
        else
            System.Console.WriteLine("False");
    }
    // Question 60
    static void Sum_of_Matrix_with_Zero_Condition()
    {
        int rows = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter number of rows:");
                rows = Convert.ToInt32(Console.ReadLine());
                if (rows > 0) break;
                System.Console.WriteLine("Please enter a number greater than 0");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
        int cols = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter number of columns:");
                cols = Convert.ToInt32(Console.ReadLine());
                if (cols > 0) break;
                System.Console.WriteLine("Please enter a number greater than 0");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
        int[,] matrix = new int[rows, cols];
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                while (true)
                {
                    try
                    {
                        System.Console.WriteLine($"Enter element for row [{r}], col [{c}]");
                        matrix[r, c] = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        System.Console.WriteLine("Please Enter A Valid Number");
                    }
                }
            }
        }
        int totalSum = 0;
        for (int c = 0; c < cols; c++)
        {
            for (int r = 0; r < rows; r++)
            {
                if (matrix[r, c] == 0)
                {
                    break;
                }
                totalSum += matrix[r, c];
            }
        }

        System.Console.WriteLine($"Total Sum: {totalSum}");
    }
    // Question 61
    static void Sort_Integers_Keeping_Minus5_Fixed()
    {
        int length = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter the size of the array");
                length = Convert.ToInt32(Console.ReadLine());
                if (length > 0) break;
                System.Console.WriteLine("Please enter a number greater than 0");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }

        int[] ints = new int[length];

        for (int i = 0; i < ints.Length; i++)
        {
            while (true)
            {
                try
                {
                    System.Console.WriteLine($"Enter element for index [{i}]");
                    ints[i] = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Please Enter A Valid Number");
                }
            }
        }
        for (int i = 0; i < ints.Length - 1; i++)
        {
            if (ints[i] == -5) continue;

            for (int j = i + 1; j < ints.Length; j++)
            {
                if (ints[j] == -5) continue;

                if (ints[i] > ints[j])
                {
                    int temp = ints[i];
                    ints[i] = ints[j];
                    ints[j] = temp;
                }
            }
        }

        System.Console.WriteLine("Sorted Array:");
        for (int i = 0; i < ints.Length; i++)
        {
            System.Console.WriteLine($"index [{i}]: {ints[i]}");
        }
    }
    // Question 62
    static void Reverse_Strings_in_Parentheses()
    {
        string? normalText;
        do
        {
            System.Console.WriteLine("Enter A Random Sentence with () to flip it:");
            normalText = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(normalText));
        while (normalText.Contains("(") && normalText.Contains(")"))
        {
            int openIndex = normalText.LastIndexOf('(');
            int closeIndex = normalText.IndexOf(')', openIndex);
            string insideText = normalText.Substring(openIndex + 1, closeIndex - openIndex - 1);
            char[] chars = insideText.ToCharArray();
            Array.Reverse(chars);
            string reversedText = new string(chars);
            normalText = normalText.Substring(0, openIndex) + reversedText + normalText.Substring(closeIndex + 1);
        }
        System.Console.WriteLine($"Result: {normalText}");
    }
    // Question 63
    static void Check_Number_in_Array()
    {
        int[] array = { 1, 2, 3, 4, 5, 6 };
        int? given = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter A Number Inside The Array { 1, 2, 3, 4, 5, 6 } ");
                given = Convert.ToInt32(Console.ReadLine());
                bool isgiven = false;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == given)
                        isgiven = true;
                }
                if (isgiven)
                    System.Console.WriteLine("true");
                else
                    System.Console.WriteLine("false");
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
    }
    // Question 64
    static void Get_File_Name_from_Path()
    {
        string? path;
        while (true)
        {
            System.Console.Write("Please Enter A File Path: ");
            path = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(path) && File.Exists(path))
            {
                string fileName = Path.GetFileName(path);
                System.Console.WriteLine($"File Name: {fileName}");
                break;
            }
            else
            {
                System.Console.WriteLine("File Not Found!");
            }
        }
    }
    // Question 65
    static void Multiply_Array_Elements_by_Length()
    {
        int length = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter the size of the array");
                length = Convert.ToInt32(Console.ReadLine());
                if (length > 0) break;
                System.Console.WriteLine("Please enter a number greater than 0");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }

        int[] ints = new int[length];

        for (int i = 0; i < ints.Length; i++)
        {
            while (true)
            {
                try
                {
                    System.Console.WriteLine($"Enter element for index [{i}]");
                    ints[i] = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Please Enter A Valid Number");
                }
            }
        }
        for (int i = 0; i < length; i++)
            ints[i] = ints[i] * length;
        for (int i = 0; i < length; i++)
            System.Console.WriteLine($"Index[{i}] = {ints[i]}");
    }
    // Question 66
    static void Min_Value_from_Two_String_Numbers()
    {
        string? num1;
        string? num2;
        int num11 = 0;
        int num22 = 0;
        do
        {
            System.Console.WriteLine("Enter First Number");
            num1 = Console.ReadLine();
            System.Console.WriteLine("Enter Second Number");
            num2 = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(num1) && string.IsNullOrWhiteSpace(num2));
        num11 = Convert.ToInt32(num1);
        num22 = Convert.ToInt32(num2);
        if (num11 > num22)
            System.Console.WriteLine($"Minimum Value:{num22}");
        else
            System.Console.WriteLine($"Minimum Value:{num11}");
    }
    // Question 67
    static void Coded_String_Conversion()
    {
        string? path;
        do
        {
            System.Console.WriteLine("Enter The Code");
            path = Console.ReadLine().ToLower();
        } while (string.IsNullOrWhiteSpace(path));
        string result = path.Replace("p", "7")
        .Replace("t", "0")
        .Replace("s", "5")
        .Replace("h", "5")
        .Replace("a", "4");
        System.Console.WriteLine(result);
    }
    // Question 68
    static void Count_Specific_Character_in_String()
    {
        string? text;
        do
        {
            System.Console.WriteLine("Enter a string:");
            text = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(text));

        char targetChar;
        while (true)
        {
            System.Console.WriteLine("Enter character to count:");
            string? inputChar = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(inputChar) && inputChar.Length == 1)
            {
                targetChar = inputChar[0];
                break;
            }
            System.Console.WriteLine("Please enter a single character.");
        }

        int count = 0;
        string lowerText = text.ToLower();
        char lowerChar = char.ToLower(targetChar);

        for (int i = 0; i < lowerText.Length; i++)
        {
            if (lowerText[i] == lowerChar)
            {
                count++;
            }
        }

        System.Console.WriteLine($"The character '{targetChar}' appears {count} times.");
    }
    // Question 69
    static void Check_All_Uppercase_or_Lowercase()
    {
        string? normal;
        do
        {
            System.Console.WriteLine("Enter A Sentence in Lowercase or Uppercase");
            normal = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(normal));
        if (normal == normal.ToUpper())
            System.Console.WriteLine("true it's all Uppercases");
        else if (normal == normal.ToLower())
            System.Console.WriteLine("true it's all Lowercases");
        else
            System.Console.WriteLine("false they are not lowercases/uppercases");
    }
    // Question 70
    static void Remove_First_and_Last_Characters()
    {
        string? name;
        do
        {
            System.Console.WriteLine("Enter A Random String:");
            name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name) || name.Length < 2)
            {
                System.Console.WriteLine("Please enter a string with at least 2 characters.");
            }
        } while (string.IsNullOrWhiteSpace(name) || name.Length < 2);
        name = name.Remove(0, 1);
        name = name.Remove(name.Length - 1, 1);
        System.Console.WriteLine($"Result: {name}");
    }
    // Question 71
    static void Check_Consecutive_Similar_Letters()
    {
        string? text;
        do
        {
            System.Console.WriteLine("Enter a string:");
            text = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(text));

        bool hasConsecutive = false;

        for (int i = 0; i < text.Length - 1; i++)
        {
            if (char.ToLower(text[i]) == char.ToLower(text[i + 1]))
            {
                hasConsecutive = true;
                break;
            }
        }

        System.Console.WriteLine($"Contains consecutive identical letters: {hasConsecutive}");
    }
    // Question 72
    static void Check_Array_Average_as_Whole_Number()
    {
        int length = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter the size of the array");
                length = Convert.ToInt32(Console.ReadLine());
                if (length > 0) break;
                System.Console.WriteLine("Please enter a number greater than 0");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }

        int[] ints = new int[length];

        for (int i = 0; i < ints.Length; i++)
        {
            while (true)
            {
                try
                {
                    System.Console.WriteLine($"Enter element for index [{i}]");
                    ints[i] = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Please Enter A Valid Number");
                }
            }
        }
        double total = 0;
        for (int i = 0; i < length; i++)
            total += ints[i];
        System.Console.WriteLine($"The Sum Of The Array:{total}");
        System.Console.WriteLine($"The Average Of The Array:{total / length}");
        if (total / length % 2 == 0)
            System.Console.WriteLine("Is Average a Whole Number: True");
        else
            System.Console.WriteLine("Is Average a Whole Number: False");
    }
    // Question 73
    static void Alphabetical_Order_of_String_Letters()
    {
        string? text;
        do
        {
            System.Console.WriteLine("Enter a string to sort alphabetically:");
            text = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(text))
                System.Console.WriteLine("Please enter a valid string.");
        } while (string.IsNullOrWhiteSpace(text));
        char[] chars = text.ToCharArray();
        Array.Sort(chars);
        string sortedText = new string(chars);
        System.Console.WriteLine($"Sorted String: {sortedText}");
    }
    // Question 74
    static void Odd_or_Even_Length_of_String()
    {
        string? e;
        do
        {
            System.Console.WriteLine("Enter A String To See If It Has An Odd/Even Amount of Letters");
            e = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(e));
        if (e.Length % 2 == 0)
            System.Console.WriteLine("It's Even!");
        else
            System.Console.WriteLine("It's Odd!");
    }
    // Question 75
    static void Nth_Odd_Number()
    {
        int odd = 0;
        while (true)
        {
            try
            {
                System.Console.Write("Num:");
                odd = Convert.ToInt32(Console.ReadLine());

                if (odd <= 0)
                {
                    System.Console.WriteLine("Please enter a number greater than 0");
                    continue;
                }
                int count = 0;
                int currentOdd = 0;
                for (int i = 1; count < odd; i++)
                {
                    if (i % 2 != 0)
                    {
                        currentOdd = i;
                        count++;
                    }
                }

                System.Console.WriteLine($"The {odd} th odd number is {currentOdd}");
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("please Enter A Valid Number");
            }
        }
    }
    // Question 76
    static void Get_ASCII_Value_of_Character()
    {
        char character;
        while (true)
        {
            System.Console.Write("Enter a single character: ");
            string? input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input) && input.Length == 1)
            {
                character = input[0];
                break;
            }
            else
                System.Console.WriteLine("Please enter exactly one character.");
        }
        int asciiValue = Convert.ToInt32(character);
        System.Console.WriteLine($"ASCII value of '{character}' is: {asciiValue}");
    }
    // Question 77
    static void Check_Word_Plural()
    {
        string? Send_Help;
        while (true)
        {
            System.Console.WriteLine("Enter A Word Thats Plural");
            Send_Help = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(Send_Help) && Send_Help[Send_Help.Length - 1] == 's' || !string.IsNullOrWhiteSpace(Send_Help) && Send_Help[Send_Help.Length - 1] == 'S')
            {
                System.Console.WriteLine($"Is '{Send_Help}' plural: True");
                break;
            }
            else if (!string.IsNullOrWhiteSpace(Send_Help) && Send_Help[Send_Help.Length - 1] != 's' || !string.IsNullOrWhiteSpace(Send_Help) && Send_Help[Send_Help.Length - 1] != 'S')
            {
                System.Console.WriteLine($"Is '{Send_Help}' plural: False");
                break;
            }
            else
                System.Console.WriteLine("Please Enter A Valid Word");
        }
    }
    // Question 78
    static void Sum_of_Squares_in_Array()
    {
        int length = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter the size of the array");
                length = Convert.ToInt32(Console.ReadLine());
                if (length > 0) break;
                System.Console.WriteLine("Please enter a number greater than 0");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }

        int[] ints = new int[length];

        for (int i = 0; i < ints.Length; i++)
        {
            while (true)
            {
                try
                {
                    System.Console.WriteLine($"Enter element for index [{i}]");
                    ints[i] = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Please Enter A Valid Number");
                }
            }
        }
        double total = 0;
        for (int i = 0; i < ints.Length; i++)
            total += Math.Pow(ints[i], 2);
        System.Console.WriteLine($"Sum of Squares: {total}");
    }
    // Question 79
    static void Integer_to_String_and_Vice_Versa()
    {
        string? IDK;
        int? convertedInt = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter a number as a string:");
                IDK = Console.ReadLine();
                convertedInt = Convert.ToInt32(IDK);
                System.Console.WriteLine("\n--- String to Integer Conversion ---");
                System.Console.WriteLine($"Converted Value: {convertedInt}");
                System.Console.WriteLine($"Data Type: {convertedInt.GetType()}");

                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
    }
    // Question 80
    static void Convert_Array_Elements_to_Strings()
    {
        object[] randoms = { 1, true, "Test", 'L', 1.2 };
        string[] STRINGS = new string[randoms.Length];
        for (int i = 0; i < randoms.Length; i++)
            STRINGS[i] += Convert.ToString(randoms[i]);
        foreach (string z in STRINGS)
            System.Console.Write($"{z} ");
        System.Console.WriteLine();
        System.Console.WriteLine(STRINGS.GetType());
    }
    // Question 81
    static void Check_Swapped_Two_Digit_Number()
    {
        string? IDK;
        string swapped;
        int? convertedInt = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter a two-digit number (10-99):");
                IDK = Console.ReadLine();
                convertedInt = Convert.ToInt32(IDK);
                if (convertedInt >= 100 || convertedInt <= 9)
                    System.Console.WriteLine("Please Enter A Two Digit Number");
                else if (convertedInt < 100 && convertedInt > 9)
                {
                    char[] chars = IDK.ToCharArray();
                    Array.Reverse(chars);
                    swapped = new string(chars);
                    convertedInt = Convert.ToInt32(swapped);
                    System.Console.WriteLine($"Original:{IDK}");
                    System.Console.WriteLine($"Swapped:{swapped}");
                    break;
                }
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
    }
    // Question 82
    static void Remove_Non_Letter_Characters()
    {
        string? man;
        string cleaned = "";
        do
        {
            System.Console.WriteLine("Enter a string:");
            man = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(man));
        for (int i = 0; i < man.Length; i++)
            if (char.IsLetter(man[i]))
                cleaned += man[i];
        System.Console.WriteLine($"Before:{man}");
        System.Console.WriteLine($"After :{cleaned}");
    }
    // Question 83
    static void Remove_Vowels_from_String()
    {
        string? Vowels;
        string bad_words = "aeiouAEIOU";
        string cleaned = "";
        do
        {
            System.Console.WriteLine("Enter A String:");
            Vowels = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(Vowels));
        for (int i = 0; i < Vowels.Length; i++)
            if (!bad_words.Contains(Vowels[i]))
                cleaned += Vowels[i];
        System.Console.WriteLine($"No Vowels:{cleaned}");
    }
    // Question 84
    static void Indices_of_Lowercase_Letters()
    {
        string? Perchance;
        do
        {
            System.Console.WriteLine("Enter A String And I will Tell You What Index Has Lowercases In it");
            Perchance = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(Perchance));
        List<int> index = new List<int>();
        for (int i = 0; i < Perchance.Length; i++)
            if (char.IsLower(Perchance[i]))
                index.Add(i);
        foreach (int idx in index)
            System.Console.Write($"{idx} ");
        System.Console.WriteLine();
    }
    // Question 85
    static void Cumulative_Sum_of_Array()
    {
        int length = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter the size of the array:");
                length = Convert.ToInt32(Console.ReadLine());
                if (length > 0) break;
                System.Console.WriteLine("Please enter a number greater than 0");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }

        int[] numbers = new int[length];
        for (int i = 0; i < numbers.Length; i++)
        {
            while (true)
            {
                try
                {
                    System.Console.WriteLine($"Enter element for index [{i}]:");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Please Enter A Valid Number");
                }
            }
        }

        int[] cumulative = new int[length];
        int runningSum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            runningSum += numbers[i];
            cumulative[i] = runningSum;
        }

        System.Console.WriteLine($"Original Array: [{string.Join(", ", numbers)}]");
        System.Console.WriteLine($"Cumulative Sum Array: [{string.Join(", ", cumulative)}]");
    }
    // Question 86
    static void Count_Letters_and_Digits_in_String()
    {
        string? input;
        do
        {
            System.Console.WriteLine("Enter a string:");
            input = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(input));
        int letterCount = 0;
        int digitCount = 0;
        foreach (char c in input)
        {
            if (char.IsLetter(c))
                letterCount++;
            else if (char.IsDigit(c))
                digitCount++;
        }
        System.Console.WriteLine($"Letters count: {letterCount}");
        System.Console.WriteLine($"Digits count: {digitCount}");
    }
    // Question 87
    static void Reverse_Boolean_Value()
    {
        string? input;
        bool perchance = false;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter True/False");
                input = Console.ReadLine().ToLower();
                if (input != "true" && input != "false")
                    System.Console.WriteLine("Please Enter 'True' or 'False'");
                else if (input == "true" || input == "false")
                {
                    if (input == "true")
                        perchance = false;
                    else if (input == "false")
                        perchance = true;
                    System.Console.WriteLine($"Before Reverse:{input}");
                    System.Console.WriteLine($"After  Reverse:{perchance}");
                    break;
                }
            }
            catch (Exception)
            {
                System.Console.WriteLine("Invalid Input");
            }
        }
    }
    // Question 88
    static void Sum_of_Interior_Angles_in_Polygon()
    {
        int? sides;
        int? sum = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter the number of sides (minimum 3):");
                sides = Convert.ToInt32(Console.ReadLine());
                if (sides < 3)
                    System.Console.WriteLine("Please Enter A Number Bigger Than 3");
                else
                {
                    sum = (sides - 2) * 180;
                    System.Console.WriteLine($"Sides:{sides}");
                    System.Console.WriteLine($"Sum of interior angles: {sum} degrees");
                    break;
                }
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
    }
    // Question 89
    static void Count_Positives_and_Negatives_in_Array()
    {
        int length = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter the size of the array");
                length = Convert.ToInt32(Console.ReadLine());
                if (length > 0) break;
                System.Console.WriteLine("Please enter a number greater than 0");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }

        int[] ints = new int[length];

        for (int i = 0; i < ints.Length; i++)
        {
            while (true)
            {
                try
                {
                    System.Console.WriteLine($"Enter element for index [{i}]");
                    ints[i] = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Please Enter A Valid Number");
                }
            }
        }
        int Odd = 0;
        int Even = 0;
        for (int i = 0; i < ints.Length; i++)
        {
            if (ints[i] % 2 == 0)
                Even++;
            else if (ints[i] % 2 != 0)
                Odd++;
        }
        System.Console.WriteLine($"This Array Contains:{Even} Even Numbers");
        System.Console.WriteLine($"This Array Contains:{Odd} Odd Numbers");
    }
    // Question 90
    static void Count_Ones_and_Zeros_in_Binary()
    {
        int number = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter an integer:");
                number = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }

        string binaryStr = Convert.ToString(number, 2);
        int onesCount = 0;
        int zerosCount = 0;

        foreach (char c in binaryStr)
        {
            if (c == '1')
            {
                onesCount++;
            }
            else if (c == '0')
            {
                zerosCount++;
            }
        }

        System.Console.WriteLine($"Binary Representation: {binaryStr}");
        System.Console.WriteLine($"Ones count: {onesCount}");
        System.Console.WriteLine($"Zeros count: {zerosCount}");
    }
    // Question 91
    static void Remove_Non_Integer_Values_from_Array()
    {
        object[] mixedArray = { 10, "Hello", true, 25, 3.14, 'A', 42 };
        int count = 0;
        foreach (object item in mixedArray)
            if (item is int)
                count++;
        int[] resultArray = new int[count];
        int index = 0;
        foreach (object item in mixedArray)
            if (item is int value)
            {
                resultArray[index] = value;
                index++;
            }
        System.Console.Write("Filtered Integers: ");
        foreach (int num in resultArray)
            System.Console.Write($"{num} ");
        System.Console.WriteLine();
    }
    // Question 92
    static void Find_Next_Prime_Number()
    {
        int number = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter an integer:");
                number = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }
        int candidate = number;
        while (true)
        {
            bool isPrime = true;
            if (candidate < 2)
                isPrime = false;
            else
                for (int i = 2; i * i <= candidate; i++)
                    if (candidate % i == 0)
                    {
                        isPrime = false;
                        break;
                    }

            if (isPrime)
            {
                System.Console.WriteLine($"The smallest prime >= {number} is: {candidate}");
                break;
            }

            candidate++;
        }
    }
    // Question 93
    static void Square_Root_Without_Built_In_Functions()
    {
        int number = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter a non-negative integer:");
                number = Convert.ToInt32(Console.ReadLine());
                if (number >= 0)
                    break;
                System.Console.WriteLine("Please enter a number greater than or equal to 0.");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }

        int result = 0;
        while ((result + 1) * (result + 1) <= number)
            result++;
        System.Console.WriteLine($"Integer Square Root of {number} is: {result}");
    }
    // Question 94
    static void Find_Longest_Common_Prefix()
    {
        int length = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter the number of strings:");
                length = Convert.ToInt32(Console.ReadLine());
                if (length > 0)
                    break;
                System.Console.WriteLine("Please enter a number greater than 0");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }

        string[] words = new string[length];
        for (int i = 0; i < words.Length; i++)
            do
            {
                System.Console.WriteLine($"Enter string at index [{i}]:");
                words[i] = Console.ReadLine()!;
                if (string.IsNullOrWhiteSpace(words[i]))
                    System.Console.WriteLine("Please enter a valid string.");
            } while (string.IsNullOrWhiteSpace(words[i]));

        string prefix = words[0];

        for (int i = 1; i < words.Length; i++)
            while (!words[i].StartsWith(prefix))
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (string.IsNullOrEmpty(prefix))
                    break;
            }

        if (string.IsNullOrEmpty(prefix))
            System.Console.WriteLine("Longest Common Prefix: \"\" (No common prefix)");
        else
            System.Console.WriteLine($"Longest Common Prefix: \"{prefix}\"");
    }
    // Question 95
    static void Validate_Brackets_in_String()
    {
        string? input;
        do
        {
            System.Console.WriteLine("Enter a string containing brackets:");
            input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                System.Console.WriteLine("Please enter a valid string.");
            }
        } while (string.IsNullOrWhiteSpace(input));

        Stack<char> stack = new Stack<char>();
        bool isValid = true;

        foreach (char c in input)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else if (c == ')' || c == '}' || c == ']')
            {
                if (stack.Count == 0)
                {
                    isValid = false;
                    break;
                }

                char top = stack.Pop();
                if ((c == ')' && top != '(') ||
                    (c == '}' && top != '{') ||
                    (c == ']' && top != '['))
                {
                    isValid = false;
                    break;
                }
            }
        }

        if (stack.Count > 0)
        {
            isValid = false;
        }

        if (isValid)
        {
            System.Console.WriteLine("The brackets are valid and properly nested.");
        }
        else
        {
            System.Console.WriteLine("The brackets are invalid or improperly nested.");
        }
    }
    // Question 96
    static void Check_All_Characters_Same_in_String()
    {
        string? input;
        do
        {
            System.Console.WriteLine("Enter a string:");
            input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                System.Console.WriteLine("Please enter a valid string.");
            }
        } while (string.IsNullOrWhiteSpace(input));

        char firstChar = input[0];
        bool allSame = true;

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != firstChar)
            {
                allSame = false;
                break;
            }
        }

        System.Console.WriteLine($"All characters are identical: {allSame}");
    }
    // Question 97
    static void Check_Numeric_String()
    {
        string? input;
        do
        {
            System.Console.WriteLine("Enter a string:");
            input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                System.Console.WriteLine("Please enter a valid string.");
        } while (string.IsNullOrWhiteSpace(input));

        bool isNumeric = true;
        try
        {
            Convert.ToDouble(input);
        }
        catch (Exception)
        {
            isNumeric = false;
        }

        System.Console.WriteLine($"Is numeric string: {isNumeric}");
    }
    // Question 98
    static void Primes_in_Descending_Order()
    {
        int limit = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter maximum limit:");
                limit = Convert.ToInt32(Console.ReadLine());
                if (limit >= 2) break;
                System.Console.WriteLine("Please enter a number >= 2");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }

        System.Console.WriteLine($"Primes with strictly descending digits up to {limit}:");

        for (int candidate = 2; candidate <= limit; candidate++)
        {

            bool isPrime = true;
            for (int i = 2; i * i <= candidate; i++)
            {
                if (candidate % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (!isPrime) continue;

            string s = candidate.ToString();
            bool isDescending = true;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] <= s[i + 1])
                {
                    isDescending = false;
                    break;
                }
            }

            if (isDescending)
            {
                System.Console.Write($"{candidate} ");
            }
        }
        System.Console.WriteLine();
    }
    // Question 99
    static void Primes_in_Ascending_Order()
    {
        int limit = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter maximum limit:");
                limit = Convert.ToInt32(Console.ReadLine());
                if (limit >= 2) break;
                System.Console.WriteLine("Please enter a number >= 2");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }

        System.Console.WriteLine($"Primes with strictly ascending digits up to {limit}:");

        for (int candidate = 2; candidate <= limit; candidate++)
        {

            bool isPrime = true;
            for (int i = 2; i * i <= candidate; i++)
            {
                if (candidate % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (!isPrime) continue;


            string s = candidate.ToString();
            bool isAscending = true;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] >= s[i + 1])
                {
                    isAscending = false;
                    break;
                }
            }

            if (isAscending)
            {
                System.Console.Write($"{candidate} ");
            }
        }
        System.Console.WriteLine();
    }
    // QUESTION 100!!!!! This Was A Long Journey & A Tiring One ...
    static void Equality_of_Value_and_Type()
    {
        object first = 5;
        object second = 5.0;

        bool typeMatch = first.GetType() == second.GetType();
        bool valueMatch = first.ToString() == second.ToString();
        bool result = typeMatch && valueMatch;

        System.Console.WriteLine($"First Value: {first} (Type: {first.GetType()})");
        System.Console.WriteLine($"Second Value: {second} (Type: {second.GetType()})");
        System.Console.WriteLine($"Result: {result}");
    }
    // Question 101 e (ه)
    static void Calculate_Eulers_Number()
    {
        int terms = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter number of terms for approximation:");
                terms = Convert.ToInt32(Console.ReadLine());
                if (terms > 0) break;
                System.Console.WriteLine("Please enter a number greater than 0");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }

        double e = 1.0;
        double factorial = 1.0;

        for (int i = 1; i < terms; i++)
        {
            factorial *= i;
            e += 1.0 / factorial;
        }

        System.Console.WriteLine($"Approximation of e: {e}");
    }
    // Question 102
    static void Create_Identity_Matrix()
    {
        int size = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter the size of the identity matrix:");
                size = Convert.ToInt32(Console.ReadLine());
                if (size > 0) break;
                System.Console.WriteLine("Please enter a number greater than 0");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }

        int[,] matrix = new int[size, size];

        for (int r = 0; r < size; r++)
        {
            for (int c = 0; c < size; c++)
            {
                if (r == c)
                {
                    matrix[r, c] = 1;
                }
                else
                {
                    matrix[r, c] = 0;
                }
            }
        }

        for (int r = 0; r < size; r++)
        {
            for (int c = 0; c < size; c++)
            {
                System.Console.Write($"{matrix[r, c]} ");
            }
            System.Console.WriteLine();
        }
    }
    // Question 103
    static void Sort_Characters_in_String()
    {
        string? input;
        do
        {
            System.Console.WriteLine("Enter a string:");
            input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                System.Console.WriteLine("Please enter a valid string.");
            }
        } while (string.IsNullOrWhiteSpace(input));

        List<char> lower = new List<char>();
        List<char> upper = new List<char>();
        List<char> digits = new List<char>();

        foreach (char c in input)
        {
            if (char.IsLower(c))
            {
                lower.Add(c);
            }
            else if (char.IsUpper(c))
            {
                upper.Add(c);
            }
            else if (char.IsDigit(c))
            {
                digits.Add(c);
            }
        }

        char[] lowerArr = lower.ToArray();
        char[] upperArr = upper.ToArray();
        char[] digitsArr = digits.ToArray();

        Array.Sort(lowerArr);
        Array.Sort(upperArr);
        Array.Sort(digitsArr);

        string result = new string(lowerArr) + new string(upperArr) + new string(digitsArr);

        System.Console.WriteLine($"Original: {input}");
        System.Console.WriteLine($"Sorted: {result}");
    }
    // Question 104 it was so peak ...
    static void Compare_Equality_of_Three_Integers()
    {
        int num1 = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter first integer:");
                num1 = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }

        int num2 = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter second integer:");
                num2 = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }

        int num3 = 0;
        while (true)
        {
            try
            {
                System.Console.WriteLine("Enter third integer:");
                num3 = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Please Enter A Valid Number");
            }
        }

        int matchCount = 0;

        if (num1 == num2 && num2 == num3)
        {
            matchCount = 3;
        }
        else if (num1 == num2 || num2 == num3 || num1 == num3)
        {
            matchCount = 2;
        }
        else
        {
            matchCount = 0;
        }

        System.Console.WriteLine($"Matching integers count: {matchCount}");
    }
}