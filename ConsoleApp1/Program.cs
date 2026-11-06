using System;
using System.Collections.Concurrent;
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
        // placeholder(); // ???
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
    // Question 50 FINALLYYYYYYYYY
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
    // Question 52
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

}


