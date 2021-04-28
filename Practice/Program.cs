using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            /*
            Console.WriteLine("Hello: Andrew");
            */
            // Exercise 2
            /*
            System.Console.WriteLine(15+15);
            */
            // Exercise 3
            /*
            System.Console.WriteLine(10 / 2);
            */
            // Exercise 4
            /*
            System.Console.WriteLine(-1 + (4*6));
            System.Console.WriteLine((35+5) % 7);
            System.Console.WriteLine(14+ (-4*6/11));
            System.Console.WriteLine(2 + (15/6*1-(7%2)));
            */
            // Exercise 5
            /*
            int num1, num2;
            num1 = 5;
            num2 = 6;
            System.Console.WriteLine(num1 + " " + num2);

            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            System.Console.WriteLine(num1 + " " + num2);
            */
            // Exercise 6
            /*
            double number1, number2, number3, result;
            System.Console.Write("Input your first number: ");
            number1 = Convert.ToDouble(Console.ReadLine());

            System.Console.Write("Input your second number: ");
            number2 = Convert.ToDouble(Console.ReadLine());

            System.Console.Write("Input your third number: ");
            number3 = Convert.ToDouble(Console.ReadLine());

            result = number1 * number2 * number3;

            System.Console.WriteLine("Result of " + number1 + " * " + number2 +
            " * " + number3 + " = " + result);
            */
            // Exercise 7
            /* wrong solution
            double number1, number2;
            double result;
            int op = 0;

            System.Console.Write("Input your first number: ");
            number1 = Convert.ToDouble(Console.ReadLine());

            System.Console.Write("Input your second number: ");
            number2 = Convert.ToDouble(Console.ReadLine());

            System.Console.Write("Plus is 0 /n Minus is = 1 /n Multiply is 2 /n " +
                "Divede is 3 /n Mod is 4 ");
            op = Convert.ToInt32(Console.ReadLine());
            if (op == 0)
            {
                result = number1 + number2;
            }
            else if(op == 1)
            {               
                result = number1 - number2;
            }
            else if (op == 2)
            {
                result = number1 * number2;
            }
            else if (op == 3)
            {
                result = number1 / number2;
            }
            else if (op == 4)
            {
                result = number1 % number2;
            }

            System.Console.WriteLine("Result is: " + result);
            */
            /* correct solution
            double number1, number2;

            System.Console.Write("Input your first number: ");
            number1 = Convert.ToDouble(Console.ReadLine());

            System.Console.Write("Input your second number: ");
            number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2);
            Console.WriteLine("{0} - {1} = {2}", number1, number2, number1 - number2);
            Console.WriteLine("{0} * {1} = {2}", number1, number2, number1 * number2);
            Console.WriteLine("{0} / {1} = {2}", number1, number2, number1 / number2);
            Console.WriteLine("{0} % {1} = {2}", number1, number2, number1 % number2);
            */
            // Exercise 8
            /*
            double number1;

            System.Console.Write("Input number for multiplication table: ");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("{0} *  0 = {1}", number1, number1 * 0);
            Console.WriteLine("{0} *  1 = {1}", number1, number1 * 1);
            Console.WriteLine("{0} *  2 = {1}", number1, number1 * 2);
            Console.WriteLine("{0} *  3 = {1}", number1, number1 * 3);
            Console.WriteLine("{0} *  4 = {1}", number1, number1 * 4);
            Console.WriteLine("{0} *  5 = {1}", number1, number1 * 5);
            Console.WriteLine("{0} *  6 = {1}", number1, number1 * 6);
            Console.WriteLine("{0} *  7 = {1}", number1, number1 * 7);
            Console.WriteLine("{0} *  8 = {1}", number1, number1 * 8);
            Console.WriteLine("{0} *  9 = {1}", number1, number1 * 9);
            Console.WriteLine("{0} * 10 = {1}", number1, number1 * 10);
            */
            // Exercise 9
            /*
            double number1, number2, number3, number4,avg;
            int op = 0;

            System.Console.Write("Input number for multiplication table: ");
            number1 = Convert.ToDouble(Console.ReadLine());
            op++;
            System.Console.Write("Input number for multiplication table: ");
            number2 = Convert.ToDouble(Console.ReadLine());
            op++;
            System.Console.Write("Input number for multiplication table: ");
            number3 = Convert.ToDouble(Console.ReadLine());
            op++;
            System.Console.Write("Input number for multiplication table: ");
            number4 = Convert.ToDouble(Console.ReadLine());
            op++;

            avg = (number1 + number2 + number3 + number4) / op; 

            Console.WriteLine("The average of {0}, {1}, {2}, {3} = {4}", 
                number1,number2, number3, number4, avg);
            */
            // Exercise 10
            /*
            int number1, number2, number3;

            System.Console.Write("Enter first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter third number: ");
            number3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result of specified numbers {0}, {1} and {2}," +
                " (x+y).z is {3} and x.y + y.z is {4}",
                number1, number2, number3, (number1+number2)*number3,
                (number1 * number2)+ (number2 * number3));
            */
            // Exercise 11
            /*
            int number1;
            System.Console.Write("Enter your age: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("You look older than {0}", number1);
            */
            // Exercise 12
            /*
            int num;

            Console.WriteLine("Enter a digit: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.WriteLine();

            Console.Write(num);
            Console.Write(num);
            Console.Write(num);
            Console.WriteLine(num);
            Console.WriteLine();

            Console.WriteLine("{0} {0} {0} {0}", num);

            Console.WriteLine("{0}{0}{0}{0}", num);
            */
            // Exercise 13
            /*
            int num;

            Console.WriteLine("Enter a digit: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}", num);
            Console.WriteLine("{0} {0}", num);
            Console.WriteLine("{0} {0}", num);
            Console.WriteLine("{0} {0}", num);
            Console.WriteLine("{0}{0}{0}", num);
            */
            // Exercise 14
            /*
            double num, kelvin, fahrenheit;

            Console.WriteLine("Enter the amount of celsius: ");
            num = Convert.ToDouble(Console.ReadLine());
            kelvin = num + 273;
            fahrenheit = (num * 1.8) + 32;

            Console.WriteLine("Kelvin = {0}", kelvin);
            Console.WriteLine("Fahrenheit = {0}", fahrenheit);
            */
            // Exercise 15
            /*
            Console.WriteLine(remove_char("w3resource", 1));
            Console.WriteLine(remove_char("w3resource", 9));
            Console.WriteLine(remove_char("w3resource", 0));
            Console.ReadLine();
            */
            //Exercise 16
            /*
            Console.WriteLine(first_last("w3resource"));
            Console.WriteLine(first_last("Python"));
            Console.WriteLine(first_last("x"));
            */
            // Exercise 17
            /*
            string text;
            Console.Write("Input a string: ");
            text = System.Console.ReadLine();
            if(text.Length>=1)
            {
                var s = text.Substring(0, 1); //Substring-position and how many chars
                Console.WriteLine(s + text + s); 
            }
            */
            // Exercise 18
            /*
            int number1, number2;
            bool pom;
            Console.Write("Input first integer: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input first integer: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 >= 0 && number2 < 0 || number2 >= 0 && number1 < 0)
            {
                pom = true;
            }
            else
                pom = false;
            Console.WriteLine("{0}", pom);
            */
            // Exercise 19
            /*
            int number1, number2;
            int sum;
            Console.Write("Input first integer: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input first integer: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 == number2)
            {
                Console.WriteLine("{0}", (number1+number2)*3);
            }
            else
                Console.WriteLine("Numbers {0} and {1} are not same",number1,number2);
            */
            // Exercise 20
            /*
            int number1, number2;
            int sum;
            Console.Write("Input first integer: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second integer: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(result(number1, number2));
            */
            // Exercise 21
            /*
            int number1, number2;
            Console.Write("Input first integer: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second integer: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 == 20 || number2 == 20 || number1 + number2 == 20)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            */
            // Exercise 22
            /*
            int number1;
            Console.Write("Input integer: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(result(number1));
            */
            // Exercise 23
            /*
            string line = "Write a C# Sharp Program to display the " +
                "following pattern using the alphabet.";
            Console.WriteLine(line.ToLower());
            Console.ReadLine();
            */
            // Exercise 24 more practice
            /*
            string line = "Write a C# Sharp Program to display the following pattern using the alphabet.";
            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            for (int i = 0; i < words.Length; i++)
            {
                string s = words[i];
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }
            Console.WriteLine(word);
            */
            // Exercise 25
            /*
            int number = 1;
            while (number < 100)
            {
                Console.WriteLine("{0}", number);
                number = number + 2;
            }
            */
            // Exercise 26
            /*
            int number = 2; 
            int sum = 0;
            int total = 0;
            while(total < 500)
            {

                if (isPrime(number))
                {
                    sum += number;
                    total++;
                }
                number++;
            }
            Console.WriteLine(sum.ToString());
            */
            // Exercise 27
            /*
            int number;
            int sum = 0;
            Console.Write("Input a number for digit checking: ");
            number = Convert.ToInt32(Console.ReadLine());
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
                Console.Write("{0} \n", number);
            }
            Console.WriteLine(sum.ToString());
            */
            // Exercise 28 practice practice practice
            /*
            string line = "Display the pattern like pyramid using the alphabet.";
            Console.WriteLine("\nOriginal String: " + line);
            string result = "";
            List<string> wordsList = new List<string>();
            string[] words = line.Split(new[] {
              " "
            }, StringSplitOptions.None);
            for (int i = words.Length - 1; i >= 0; i--)
            {
                result += words[i] + " ";
            }
            wordsList.Add(result);
            foreach (String s in wordsList)
            {

                Console.WriteLine("\nReverse String: " + s);
            }
            */
            // Exercise 29 System.IO
            /*
            FileInfo f = new FileInfo("/home/students/abc.txt");
            Console.WriteLine("\nSize of a file: " + f.Length.ToString());
            */
            // Exercise 30 
            /*
            string hexval = "4B0";
            Console.WriteLine("Hexadecimal number: " + hexval);
            int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine("Convert to-");
            Console.WriteLine("Decimal number: " + decValue);
            */
            // Exercise 31
            /*
            int[] array1 = new int[] { 1, 3, -5, 4};
            int[] array2 = new int[] { 1, 4, -5,-2 };
            Console.WriteLine("{0} {1} {2} {3}", array1[0] * array2[0], 
                array1[1] * array2[1], array1[2] * array2[2], array1[3] * array2[3]);
            // or
            for(int i=0;i<array1.Length;i++)
            {
                Console.WriteLine("{0}", array1[i] * array2[i]);
            }
            */
            // Exercise 32
            /*
            string str;
            int l = 0;
            Console.Write("Input a string : ");
            str = Console.ReadLine();
            if (str.Length > 4)
            {
                Console.WriteLine(str.Length < 4 ? str + str + str : str.Substring(str.Length - 4) + 
                    str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4));
            }
            */
            // Exercise 33
            /*
            Console.WriteLine("\nInput first integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x > 0)
            {
                Console.WriteLine(x % 3 == 0 || x % 7 == 0); // returning true if correct
            }
            */
            // Exercise 34
            /*
            string str;
            Console.Write("Input a string : ");
            str = Console.ReadLine();
            Console.WriteLine((str.Length < 6 && str.Equals("Hello")));
            */
            // Exercise 35
            /*
            int number1, number2;
            Console.Write("Input first integer: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second integer: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(result(number1, number2));
            */
            // Exercise 36
            /*
            int number1, number2;
            Console.Write("Input first integer: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second integer: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(result(number1, number2));
            */
            // Exercise 37
            /*
            string str = "PHP Tutorial";
            Console.WriteLine((str.Substring(1, 2).Equals("HP") ? str.Remove(1, 2) : str));
            */
            // Exercise 38
            /*
            string str = "PHP";
            Console.WriteLine(((str.Substring(0, 1).Equals("P")&& str.Substring(1, 1).Equals("H"))
                ? str.Substring(0, 2) : str));
            */
            // Exercise 39
            /*
            int number1, number2, number3;
            int max = 0;
            int min = 1000; 
            Console.Write("Input first integer: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second integer: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input third integer: ");
            number3 = Convert.ToInt32(Console.ReadLine());
            Console.Write(Max(number1, number2, number3));
            Console.WriteLine("\n");
            Console.Write(Min(number1, number2, number3));
            */
            // Exercise 40
            /*
            Console.WriteLine("\nInput first integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            int y = Convert.ToInt32(Console.ReadLine());
            int n = 20;
            var val1 = Math.Abs(x - n);
            var val2 = Math.Abs(y - n);
            Console.WriteLine(val1 == val2 ? 0 : (val1 < val2 ? x : y));
            */
            // Exercise 41
            /*
            Console.Write("Input a string (contains at least one 'w' char) : ");
            string str = Console.ReadLine();
            var count = str.Count(s => s == 'w');
            Console.WriteLine("Test the string contains 'w' character  between 1 and 3 times: ");
            Console.WriteLine(count >= 1 && count <= 3);
            */
            // Exercise 42
            /*
            string str = "w3r";
            if (str.Length < 4) {
                Console.WriteLine(str.ToUpper());
            }
            else
            {
                Console.WriteLine(str.Substring(0, 4).ToLower() + str.Substring(4, str.Length - 4));
            }
            */
            // Exercise 43
            /*
            Console.Write("Input a string : ");
            string str = Console.ReadLine();
            Console.WriteLine(test(str));
            */
            // Exercise 44 practice
            /*
            Console.Write("Input a string : ");
            string str = Console.ReadLine();
            var result = string.Empty;
            for (var i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0) result += str[i];
            }
            Console.WriteLine(result);
            */
            // Exercise 45
            /*
            Console.WriteLine("\nInput an integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
            Console.WriteLine("Number of " + x + " present in the said array:");
            Console.WriteLine(nums.Count(n => n == x));
            */
            // Exercise 46
            /*
            Console.WriteLine("\nInput an integer:");  
            int x = Convert.ToInt32(Console.ReadLine());
            int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9};
            Console.WriteLine( (nums[0] == x) || (nums[nums.Length - 1] == x));
            */
            // Exercise 47
            /*
            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine("{0}", sum);
            */
            // Exercise 48
            /*
            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            Console.WriteLine((nums.Length >= 1) && (nums[0].Equals(nums[nums.Length - 1])));
            */
            // Exercise 49
            /*
            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int[] nums2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };
            Console.WriteLine((nums.Length >= 1) && (nums2.Length >= 1) && 
            (nums[0].Equals(nums2[0])) || (nums[nums.Length - 1].Equals(nums2[nums2.Length - 1]))
                );
            */
            // Exercise 50
            /*
            int[] nums = { 1, 2, 8 };
            Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
            var temp = nums[0];
            for (var i = 0; i < nums.Length - 1; i++)
            {
                nums[i] = nums[i + 1];
            }
            nums[nums.Length - 1] = temp;
            Console.WriteLine("\nAfter rotating array becomes: [{0}]", string.Join(", ", nums));
            */
            // Exercise 51 
            /*
            int[] nums = { 1, 2, 5, 7, 8 };
            int max = nums[0];
            for (var i = 1; i < nums.Length; i++)
            {
                if(max < nums[i])
                {
                    max = nums[i];
                }
            }
            Console.WriteLine("{0}",max);
            */
            // Exercise 52
            /*
            int[] array1 = { 1, 2, 5 };
            Console.WriteLine("\nArray1: [{0}]", string.Join(", ", array1));
            int[] array2 = { 0, 3, 8 };
            Console.WriteLine("\nArray2: [{0}]", string.Join(", ", array2));
            int[] array3 = { -1, 0, 2 };
            Console.WriteLine("\nArray3: [{0}]", string.Join(", ", array3));
            int[] new_array = { array1[1], array2[1], array3[1] };
            Console.WriteLine("\nNew array: [{0}]", string.Join(", ", new_array));
            */
            // Exercise 53
            /*
            int[] nums = { 2, 4, 7, 8, 6 };
            Console.WriteLine("\nOriginal array: [{0}]", string.Join(", ", nums));
            Console.WriteLine("Check if an array contains an odd number? " + even_odd(nums));
            */
            // Exercise 54
            /*
            int year;
            int century;
            Console.Write("Get the century from year: ");
            year = Convert.ToInt32(Console.ReadLine());
            century = ((year / 100) + 1);
            Console.WriteLine("{0} century", century);
            */
            // Exercise 55 skip
            // Exercise 56
                
            Console.ReadLine();
        }

        // Exercise 15
        /*
        public static string remove_char(string str, int n)
        {
            return str.Remove(n, 1);
           
        }
        */
        //Exercise 16
        /*
        public static string first_last(string ustr)
        {
            return ustr.Length > 1
                ? ustr.Substring(ustr.Length - 1) + 
                ustr.Substring(1, ustr.Length - 2) + 
                ustr.Substring(0,1) : ustr;
        }
        */
        // Exercise 20
        /*
        public static int result(int a, int b)
        {
            if ((a - b) > 0)
            {
                return (a - b) * 2;
            }
            else
                return b - a;
        }
        */
        // Exercise 22
        /*
        public static bool result(int number)
        {
            if ((number-100)<= 20 || (number-200) <= 20)
            {
                return true;
            }
            else
                return false;
        }
        */
        // Exercise 26
        /*
        public static bool isPrime(int number)
        {

            if (number == 1) return false;
            if (number == 2) return true;
            for (int i = 2; i <= number-1; ++i) {

                    if (number % i == 0) return false;

            }
            return true;
        }
        */
        // Exercise 35
        /*
        public static bool result(int number1, int number2)
        {
            if ((number1 > 200) && (number2 < 100) || (number1 < 200) && (number2 > 100))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        */
        // Exercise 36
        /*
        public static bool result(int number1, int number2)
        {
            if ((number1 > -10) && (number1 < 10) || (number2 < 10) && (number2 > -10))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        */
        // Exercise 39
        /*
        public static int Max(int number1, int number2, int number3)
        {
            if (number1 >= number2 && number1 >= number3)
            {
                return number1;
            }
            else if(number2 >= number1 && number2 >= number3)
                return number2;
            else
            {
                return number3;
            }
        }
        public static int Min(int number1, int number2, int number3)
        {
            if (number1 <= number2 && number1 <= number3)
            {
                return number1;
            }
            else if (number2 <= number1 && number2 <= number3)
                return number2;
            else
            {
                return number3;
            }
        }
        */
        // Exercise 43
        /*
        public static bool test(string str)
        {
            var ctr = 0;
            for (var i = 0; i < str.Length - 1; i++)
            {
                if (str[i].Equals('w')) ctr++;
                if (str.Substring(i, 2).Equals("ww") && ctr > 2)
                    return true;
            }
            return false;
        }
        */
        // Exercise 53
        /*
        public static bool even_odd(int[] nums)
        {
            foreach (var n in nums)
            {
                if (n % 2 != 0)
                    return true;
            }
            return false;

        }
        */
    }
    }
