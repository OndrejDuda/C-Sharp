using System;
using System.Linq;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise b1 solution a
            /*
            int number1, number2, sum;
            Console.Write("Input first integer: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second integer: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            if(number1 != number2)
            {
                sum = number1 + number2;
            }
            else
            {
                sum = 3 * (number1 + number2);
            }
            Console.WriteLine(sum);
            */
            // Exercise b1 solution b
            //Write a C# Sharp program to compute the sum of the two given integer values.
            //If the two values are the same, then return triple their sum
            /*
                Console.WriteLine(test(1, 2));
                Console.WriteLine(test(3, 2));
                Console.WriteLine(test(2, 2));
                Console.ReadLine();
            */
            // Exercise b2 solution a
            //Write a C# Sharp program to get the absolute difference between n and 51.
            //If n is greater than 51 return triple the absolute difference.
            /*
            Console.WriteLine(test2(53));
            Console.WriteLine(test2(30));
            Console.WriteLine(test2(51));
            */
            // Exercise b3 solution a
            //Write a C# Sharp program to check two given integers, and return true if
            //one of them is 30 or if their sum is 30.
            /*
            Console.WriteLine(test3(30, 0));
            Console.WriteLine(test3(25, 5));
            Console.WriteLine(test3(20, 30));
            Console.WriteLine(test3(20, 25));
            */
            // Exercise b4 solution a
            //  Write a C# Sharp program to check a given integer and return true if
            //  it is within 10 of 100 or 200.
            /*
            Console.WriteLine(test4(103));
            Console.WriteLine(test4(90));
            Console.WriteLine(test4(89));
            */
            // Exercise b5 solution a
            // Write a C# Sharp program to create a new string where 'if' is added to the
            // front of a given string. If the string already begins with 'if', return the
            // string unchanged.
            /*
            Console.WriteLine(test5("if else"));
            Console.WriteLine(test5("else"));
            */
            // Exercise b6 solution a
            //Write a C# Sharp program to remove the character in a given position of a given string. 
            //The given position will be in the range 0.. string length -1 inclusive.
            /*
            Console.WriteLine(test6("Python", 1));
            Console.WriteLine(test6("Python", 0));
            Console.WriteLine(test6("Python", 4));
            */
            // Exercise b7 solution a
            //Write a C# Sharp program to exchange the first and last characters in a given string and return
            //the new string.
            /*
            Console.WriteLine(test7("abcd"));
            Console.WriteLine(test7("a"));
            Console.WriteLine(test7("xy"));
            */
            // Exercise b8 solution a
            /*Write a C# Sharp program to create a new string which is 4 copies of the 2 front characters of a given string.
             *If the given string length is less than 2 return the original string.*/
            /*
            Console.WriteLine(test8("C Sharp"));
            Console.WriteLine(test8("JS"));
            Console.WriteLine(test8("a"));
            */
            // Exercise b9 solution a
            /* Write a C# Sharp program to create a new string with the last char added at the front and back of a given string of 
             * length 1 or more.*/
            /*
            Console.WriteLine(test9("Red"));
            Console.WriteLine(test9("Green"));
            Console.WriteLine(test9("1"));
            */
            // Exercise b10 solution a
            /*Write a C# Sharp program to check if a given positive number is a multiple of 3 or a multiple of 7. */
            /*
            Console.WriteLine(test10(3));
            Console.WriteLine(test10(14));
            Console.WriteLine(test10(12));
            Console.WriteLine(test10(37));
            */
            // Exercise b11 solution a
            /*Write a C# Sharp program to create a new string taking the first 3 characters of a 
             * given string and return the string with the 3 characters added at both the front and back.
             * If the given string length is less than 3, 
             * use whatever characters are there.*/
            /*
            Console.WriteLine(test11("Python"));
            Console.WriteLine(test11("JS"));
            Console.WriteLine(test11("Code"));
            */
            // Exercise b12 solution a
            // Write a C# Sharp program to check if a given string starts with 'C#' or not.
            /*
            Console.WriteLine(test12("C# Sharp"));
            Console.WriteLine(test12("C#"));
            Console.WriteLine(test12("C++"));
            */
            // Exercise b13 solution a
            // Write a C# Sharp program to check if one given temperatures is less than 0 and the other is greater than 100.
            /*
            Console.WriteLine(test13(120, -1));
            Console.WriteLine(test13(-1, 120));
            Console.WriteLine(test13(2, 120));
            */
            // Exercise b14 solution a
            // Write a C# Sharp program to check two given integers whether either of them is in the range 100..200 inclusive.
            /*
            Console.WriteLine(test14(100, 199));
            Console.WriteLine(test14(250, 300));
            Console.WriteLine(test14(105, 190));
            */
            // Exercise b15 solution a
            /*Write a C# Sharp program to check whether three given integer values are in the range 20..50 inclusive. Return true if 1 or more of 
             * them are in the said range otherwise false. */
            /*
            Console.WriteLine(test15(11, 20, 12));
            Console.WriteLine(test15(30, 30, 17));
            Console.WriteLine(test15(25, 35, 50));
            Console.WriteLine(test15(15, 12, 8));
            */
            // Exercise b16 solution a
            /*Write a C# Sharp program to check whether two given integer values are in the range 20..50 inclusive. 
             * Return true if 1 or other is in the said range otherwise false.*/
            /*
            Console.WriteLine(test16(20, 84));
            Console.WriteLine(test16(14, 50));
            Console.WriteLine(test16(11, 45));
            Console.WriteLine(test16(25, 40));
            */
            // Exercise b17 solution a
            /* Write a C# Sharp program to check if a string 'yt' appears at index 1 in a given string. If it appears 
             * return a string without 'yt' otherwise return the original string.*/
            /*
            Console.WriteLine(test17("Python"));
            Console.WriteLine(test17("ytade"));
            Console.WriteLine(test17("jsues"));
            */
            // Exercise b18 solution a
            /* 
             * Write a C# Sharp program to check the largest number among three given integers. */
            /*
            Console.WriteLine(test18(1, 2, 3));
            Console.WriteLine(test18(1, 3, 2));
            Console.WriteLine(test18(1, 1, 1));
            Console.WriteLine(test18(1, 2, 2));
            */
            // Exercise b19 solution a
            /*Write a C# Sharp program to check which number nearest to the value 100 among two given integers.
             * Return 0 if the two numbers are equal.*/
            /*
            Console.WriteLine(test19(78, 95));
            Console.WriteLine(test19(95, 95));
            Console.WriteLine(test19(-1, 99));
            */
            // Exercise b20 solution a
            /* Write a C# Sharp program to check whether two given integers are in the range 40..50 inclusive, 
             * or they are both in the range 50..60 inclusive. */
            /*
            Console.WriteLine(test20(78, 95));
            Console.WriteLine(test20(25, 35));
            Console.WriteLine(test20(40, 50));
            Console.WriteLine(test20(55, 60));
            */
            // Exercise b21 solution a
            /* Write a C# Sharp program to find the larger value from two positive integer values 
             * that is in the range 20..30 inclusive, or return 0 if neither is in that range. */
            /*
            Console.WriteLine(test21(78, 95));
            Console.WriteLine(test21(20, 30));
            Console.WriteLine(test21(21, 25));
            Console.WriteLine(test21(28, 28));
            */
            // Exercise b22 solution a
            /* Write a C# Sharp program to check if a given string contains between 2 and 4 'z' 
             * character.*/
            /*
            Console.WriteLine(test22("frizz"));
            Console.WriteLine(test22("zane"));
            Console.WriteLine(test22("Zazz"));
            Console.WriteLine(test22("false"));
            */
            // Exercise b23 solution a
            /* Write a C# Sharp program to check if two given non-negative integers have the same last digit. */
            /*
            Console.WriteLine(test23(123, 456));
            Console.WriteLine(test23(12, 512));
            Console.WriteLine(test23(7, 87));
            Console.WriteLine(test23(12, 45));
            */
            // Exercise b24 solution a
            /* Write a C# Sharp program to convert the last 3 characters of a given string in upper case. 
             * If the length of the string has less than 3 then uppercase all the characters. */
            /*
            Console.WriteLine(test24("Python"));
            Console.WriteLine(test24("Javascript"));
            Console.WriteLine(test24("js"));
            Console.WriteLine(test24("PHP"));
            */
            // Exercise b25 solution a
            /* Write a C# Sharp program to create a new string which is n (non-negative integer) 
             * copies of a given string.*/
            /*
            Console.WriteLine(test25("JS", 2));
            Console.WriteLine(test25("JS", 3));
            Console.WriteLine(test25("JS", 1));
            */
            // Exercise b26 solution a
            /* Write a C# Sharp program to create a new string which is n (non-negative integer)
             * copies of the the first 3 characters of a given string. 
             * If the length of the given string is less than 3 then return n copies 
             * of the string. */
            /*
            Console.WriteLine(test26("Python", 2));
            Console.WriteLine(test26("Python", 3));
            Console.WriteLine(test26("JS", 3));
            */
            // Exercise b27 solution a
            /* Write a C# Sharp program to count the string "aa" in a given string and assume "aaa" contains two "aa". */
            /*
            Console.WriteLine(test27("bbaaccaag"));
            Console.WriteLine(test27("jjkiaaasew"));
            Console.WriteLine(test27("JSaaakoiaa"));
            */
            // Exercise b28 solution a
            /* Write a C# Sharp program to check if the first appearance of "a" in a given string is immediately followed by another "a". */
            /*
            Console.WriteLine(test28("caabb"));
            Console.WriteLine(test28("babaaba"));
            Console.WriteLine(test28("aaaaa"));
            */
            // Exercise b29 solution a
            /* Write a C# Sharp program to create a new string made of every other character 
             * starting with the first from a given string.*/
            /*
            Console.WriteLine(test29("Python"));
            Console.WriteLine(test29("PHP"));
            Console.WriteLine(test29("JS"));
            */
            // Exercise b30 solution a
            /* Write a C# Sharp program to create a string like "aababcabcd" 
             * from a given string "abcd".*/
            /*
            Console.WriteLine(test30("abcd"));
            Console.WriteLine(test30("abc"));
            Console.WriteLine(test30("a"));
            */
            // Exercise b31 solution a
            /* Write a C# Sharp program to count a substring of length 2 appears in a given string 
             * and also as the last 2 characters of the string. Do not count the end substring. */
            /*
            Console.WriteLine(test31("abcdsab"));
            Console.WriteLine(test31("abcdabab"));
            Console.WriteLine(test31("abcabdabab"));
            Console.WriteLine(test31("abcabd"));
            */
            // Exercise b32 solution a
            /* Write a C# Sharp program to check a specified number is present in a given array of integers. */
            /*
            Console.WriteLine(test32(new[] { 1,2,9,3}, 3));
            Console.WriteLine(test32(new[] { 1,2,2,3}, 2));
            Console.WriteLine(test32(new[] { 1,2,2,3}, 9));
            */
            // Exercise b33 solution a
            /* Write a C# Sharp program to check if one of the first 4 elements in an array of integers 
             * is equal to a given element. */
            /*
            Console.WriteLine(test33(new[] { 1, 2, 9, 3 }, 3));
            Console.WriteLine(test33(new[] { 1, 5, 3, 4, 5, 2 }, 2));
            Console.WriteLine(test33(new[] { 1, 2, 2, 3 }, 9));
            */
            // Exercise b34 solution a
            /* Write a C# Sharp program to check whether the sequence of numbers 1, 2, 3 appears in a given array of integers somewhere. */
            /*
            Console.WriteLine(test34(new[] { 1, 1, 2, 3, 1 }));
            Console.WriteLine(test34(new[] { 1, 1, 2, 4, 1 }));
            Console.WriteLine(test34(new[] { 1, 1, 2, 1, 2, 3 }));
            */
            // Exercise b35 solution a
            /* Write a C# Sharp program to compare two given strings and return the number of the positions 
             * where they contain the same length 2 substring.*/
            /*
            Console.WriteLine(test35("abcdefgh", "abijsklm"));
            Console.WriteLine(test35("abcde", "osuefrcd"));
            Console.WriteLine(test35("pqrstuvwx", "pqkdiewx"));
            */
            // Exercise b36 solution a
            /* Write a C# Sharp program to create a new string from a give string where a specified 
             * character have been removed except starting and ending position of the given string. */
            /*
            Console.WriteLine(test36("xxHxix", "x"));
            Console.WriteLine(test36("abxdddca", "a"));
            Console.WriteLine(test36("xabjbhtrb", "b"));
            */
            // Exercise b37 solution a
            /* Write a C# Sharp program to create a new string of the characters at indexes 0,1, 4,5, 8,9 ... from a given string. */
            /*
            Console.WriteLine(test37("Python"));
            Console.WriteLine(test37("JavaScript"));
            Console.WriteLine(test37("HTML"));
            */
            // Exercise b38 solution a
            /* Write a C# Sharp program to count the number of two 5's are next to each other in an array of integers. 
             * Also count the situation where the second 5 is actually a 6. */
            /*
            Console.WriteLine(test38(new[] { 5, 5, 2 }));
            Console.WriteLine(test38(new[] { 5, 5, 2, 5, 5 }));
            Console.WriteLine(test38(new[] { 5, 6, 2, 9 }));
            */
            // Exercise b39 solution a
            /* Write a C# Sharp program to check if a triple is presents in an array of integers or not. 
             * If a value appears three times in a row in an array it is called a triple. */
            /*
            Console.WriteLine(test39(new[] { 1, 1, 2, 2, 1 }));
            Console.WriteLine(test39(new[] { 1, 1, 2, 1, 2, 3 }));
            Console.WriteLine(test39(new[] { 1, 1, 1, 2, 2, 2, 1 }));
            */
            // Exercise b40 solution a
            /* Write a C# Sharp program to compute the sum of the two given integers. 
             * If the sum is in the range 10..20 inclusive return 30. */
            /*
            Console.WriteLine(test40(12, 17));
            Console.WriteLine(test40(2, 17));
            Console.WriteLine(test40(22, 17));
            Console.WriteLine(test40(20, 0));
            */
            // Exercise b41 solution a
            /* Write a C# Sharp program that accept two integers and return true 
             * if either one is 5 or their sum or difference is 5.*/
            /*
            Console.WriteLine(test41(5, 4));
            Console.WriteLine(test41(4, 3));
            Console.WriteLine(test41(1, 4));
            */
            // Exercise b42 solution a
            /* Write a C# Sharp program to test if a given non-negative number is a multiple of 13 
             * or it is one more than a multiple of 13.*/
            /*
            Console.WriteLine(test42(13));
            Console.WriteLine(test42(14));
            Console.WriteLine(test42(27));
            Console.WriteLine(test42(41));
            */
            // Exercise b43 solution a
            /* Write a C# Sharp program to check if a given non-negative 
             * given number is a multiple of 3 or 7, but not both.*/
            /*
            Console.WriteLine(test43(3));
            Console.WriteLine(test43(7));
            Console.WriteLine(test43(21));
            */
            // Exercise b44 solution a
            /* Write a C# Sharp program to check if a given number is within 2 of a multiple of 10. */
            /*
            Console.WriteLine(test44(3));
            Console.WriteLine(test44(7));
            Console.WriteLine(test44(8));
            Console.WriteLine(test44(21));
            */
            // Exercise b45 solution a
            /* Write a C# Sharp program to compute the sum of the two given integers. 
             * If one of the given integer value is in the range 10..20 inclusive return 18. */
            /*
            Console.WriteLine(test45(3, 7));
            Console.WriteLine(test45(10, 11));
            Console.WriteLine(test45(10, 20));
            Console.WriteLine(test45(21, 220));
            */
            // Exercise b46 solution a
            /* Write a C# Sharp program to check whether a given string starts with "F" 
             * or ends with "B". If the string starts with "F" return "Fizz" and return 
             * "Buzz" if it ends with "B" If the string starts with "F" and ends with "B" 
             * return "FizzBuzz". In other cases return the original string. */
            /*
            Console.WriteLine(test46("FizzBuzz"));
            Console.WriteLine(test46("Fizz"));
            Console.WriteLine(test46("Buzz"));
            Console.WriteLine(test46("Founder"));
            */
            // Exercise b47 solution a
            /* Write a C# Sharp program to check if it is possible to add two integers 
             * to get the third integer from three given integers.*/
            /*
            Console.WriteLine(test47(1, 2, 3));
            Console.WriteLine(test47(4, 5, 6));
            Console.WriteLine(test47(-1, 1, 0));
            */
            // Exercise b48 solution a
            /* Write a C# Sharp program to check if y is greater than x, and z is greater 
             * than y from three given integers x,y,z.*/
            /*
            Console.WriteLine(test48(1, 2, 3));
            Console.WriteLine(test48(4, 5, 6));
            Console.WriteLine(test48(-1, 1, 0));
            */
            // Exercise b49 solution a
            /* Write a C# Sharp program to check if three given numbers are in strict 
             * increasing order, such as 4 7 15, or 45, 56, 67, but not 4 ,5, 8 or 6, 6, 8.
             * However,if a fourth parameter is true, equality is allowed, such as 6, 6, 8 
             * or 7, 7, 7. */
            /*
            Console.WriteLine(test49(1, 2, 3, false));
            Console.WriteLine(test49(1, 2, 3, true));
            Console.WriteLine(test49(10, 2, 30, false));
            Console.WriteLine(test49(10, 10, 30, true));
            */
            // Exercise b50 solution a
            /* Write a C# Sharp program to check if two or more non-negative given 
             * integers have the same rightmost digit.*/
            /*
            Console.WriteLine(test50(11, 21, 31));
            Console.WriteLine(test50(11, 22, 31));
            Console.WriteLine(test50(11, 22, 33));
            */
            // Exercise b51 solution a
            /* Write a C# Sharp program to check three given integers and return true 
             * if one of them is 20 or more less than one of the others.*/
            /*
            Console.WriteLine(test51(11, 21, 31));
            Console.WriteLine(test51(11, 22, 31));
            Console.WriteLine(test51(10, 20, 15));
            */
            // Exercise b52 solution a
            /* Write a C# Sharp program to find the larger from two given integers. 
             * However if the two integers have the same remainder when divided by 7, 
             * then the return the smaller integer. If the two integers are the same,
             * return 0.*/
            /*
            Console.WriteLine(test52(11, 21));
            Console.WriteLine(test52(11, 20));
            Console.WriteLine(test52(10, 10));
            */
            // Exercise b53 solution a
            /* Write a C# Sharp program to check two given integers, each in the range 10..99. 
             * Return true if a digit appears in both numbers, such as the 3 in 13 and 33.*/
            /*
            Console.WriteLine(test53(11, 21));
            Console.WriteLine(test53(11, 20));
            Console.WriteLine(test53(10, 10));
            */
            // Exercise b54 solution a
            /* Write a C# Sharp program to compute the sum of two given non-negative integers x 
             * and y as long as the sum has the same number of digits as x. 
             * If the sum has more digits than x then return x without y. */
            /*
            Console.WriteLine(test54(4, 5));
            Console.WriteLine(test54(7, 4));
            Console.WriteLine(test54(10, 10));
            */
            Console.ReadLine();



        }
        // Exercise b1 solution b
        /*
        public static int test(int x, int y)
        {
            return x == y ? (x + y) * 3 : x + y;
        }
        */
        // Exercise b2 solution a
        /*
        public static int test2(int x)
        {
            int num = 51;
            if(x > num)
            {
                return 3 * (x - num);
            }
            else
            {
                return Math.Abs(x - num);
            }
        }
        */
        // Exercise b3 solution a
        /*
        public static bool test3(int x, int y)
        {
            return (x == 30 || y == 30 || x + y == 30);
        }
        */
        // Exercise b3 solution a
        /*
        public static bool test4(int x)
        {
            return ((x >= 90 && x <= 110) || (x <= 210 && x >= 190));
        }
        */
        // Exercise b5 solution a
        /*
        public static string test5(string x)
        {
            return (x.Length > 2 && x.Substring(0, 2).Equals("if") ? x : "if " + x);
        }
        */
        // Exercise b6 solution a
        /*
        public static string test6(string x, int y)
        {
            return (x.Substring(0, y)+ x.Substring(y+1, x.Length-(y+1)));
        }
        */
        // Exercise b7 solution a
        /*
        public static string test7(string x)
        {
            return x.Length>1 ? (x.Substring(x.Length-1, 1) + 
            x.Substring(1, x.Length-2)+ x.Substring(0,1)) : x;
        }
        */
        // Exercise b8 solution a
        /*
        public static string test8(string x)
        {
            return x.Length > 1 ? (x.Substring(0, 2) +
            x.Substring(0, 2) + x.Substring(0, 2) + x.Substring(0, 2)) : x;
        }
        */
        // Exercise b9 solution a
        /*
        public static string test9(string x)
        {
            return x.Length > 1 ? (x.Substring(x.Length-1, 1) +
            x.Substring(0, x.Length-1) + x.Substring(x.Length - 1, 1)) :
            (x.Substring(x.Length - 1, 1) +
            x.Substring(0, x.Length) + x.Substring(x.Length - 1, 1));
            //var s = str.Substring(str.Length-1);
            // return s + str + s;
        }
        */
        // Exercise b10 solution a
        /*
        public static bool test10(int x)
        {
            return (x % 3 == 0 || x % 7 == 0) ? true : false;
        }
        */
        // Exercise b11 solution a
        /*
        public static string test11(string x)
        {
            if (x.Length >= 3)
            {
                var str = x.Substring(0, 3);
                return str + x + str;
            }
            else
            {
                return x;
            }
        }
        */
        // Exercise b12 solution a
        /*
        public static bool test12(string x)
        {
            return (x.Substring(0,2).Equals("C#")) ? true : false;
        }
        */
        // Exercise b13 solution a
        /*
        public static bool test13(int x, int y)
        {
            return (x > 100 && y < 0) || (y > 100 && x < 0) ? true : false;
        }
        */
        // Exercise b14 solution a
        /*
        public static bool test14(int x, int y)
        {
            return (x >= 100 && x<= 200 && y >= 100 && y <= 200) ? true : false;
        }
        */
        // Exercise b15 solution a
        /*
        public static bool test15(int x, int y, int z)
        {
            return (x >= 20 && x <= 50) || ( y >= 20 && y <= 50) ||
                (z >= 20 && z <= 50)  ? true : false;
        }
        */
        // Exercise b16 solution a
        /*
        public static bool test16(int x, int y)
        {
            return !(x >= 20 && x <= 50 && y >= 20 && y <= 50) ? true : false;
        }
        */
        // Exercise b17 solution a
        /*
        public static string test17(string x)
        {
            string str = "yt";
            return (x.Substring(1, 2).Contains(str)) ? x.Substring(0,1) + 
                x.Substring(3, x.Length-3) : x;
        }
        */
        // Exercise b18 solution a
        /*
        public static int test18(int x, int y, int z)
        {
            int max = 0;
            int[] array = new int[] { x, y, z };
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] >= max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        */
        // Exercise b19 solution a
        /*
        public static int test19(int x, int y)
        {
            const int n = 100;
            var val = Math.Abs(x - n);
            var val2 = Math.Abs(y - n);

            return val == val2 ? 0 : (val < val2 ? x : y);
        }
        */
        // Exercise b20 solution a
        /*
        public static bool test20(int x, int y)
        {
            return ((x <= 50 && x >= 40) || (y <= 50 && y >= 40))
                || ((x <= 60 && x >= 50) || (y <= 60 && y >= 50))
                ? true : false;
        }
        */
        // Exercise b21 solution a
        /*
        public static int test21(int x, int y)
        {
            return !(x <= 30 && x >= 20) && !(y <= 30 && y >= 20) 
                ? 0 : (x > y ? x : y);
        }
        */
        // Exercise b22 solution a
        /*
        public static bool test22(string x)
        {
            return x.Substring(1, 3).Contains("z") ? true : false;
        }
        */
        // Exercise b23 solution a
        /*
        public static bool test23(int x, int y)
        {
            if (x >= 0 && y >= 0)
            {
                return (x % 10 == y % 10) ? true : false;
            }
            else
            {
                return false;
            }
        }
        */
        // Exercise b24 solution a
        /*
        public static string test24(string x)
        {
            return x.Length>2 ? x.Substring(0,x.Length-3)+
                x.Substring(x.Length - 3).ToUpper() : x.ToUpper();
        }
        */
        // Exercise b25 solution a
        /*
        public static string test25(string x, int y)
        {
            string str = x;
            for(int i = 1; i < y; i++)
            {
                str = str + x;
            }
            return str;
        }
        */
        // Exercise b26 solution a
        /*
        public static string test26(string x, int y)
        {
            string str;
            string result = "";

            if (x.Length > 2)
            {
                str = x.Substring(0, 3);
            }
            else
            {
                str = x;
            }

                for (int i = 1; i <= y; i++)
            {

                result += str;
            }
            return result;
        }
        */
        // Exercise b27 solution a
        /*
        public static int test27(string x)
        {
            string str = "aa";
            int count = 0;

            for(int i=0;i<x.Length-1;i++)
            {
                if (x.Substring(i, 2).Contains(str))
                {
                    count++;
                }
            }
            return count;
        }
        */
        // Exercise b28 solution a
        /*
        public static bool test28(string str)
        {
            int counter = 0;

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i].Equals('a')) counter++;
                if (str.Substring(i, 2).Equals("aa") && counter < 2)
                    return true;

            }
            return false;
        }
        */
        // Exercise b29 solution a
        /*
        public static string test29(string str)
        {
            string x = "";

            for (int i = 0; i < str.Length; i++)
            {
                if(i % 2 == 0)
                x += str[i];

            }
            return x;
        }
        */
        // Exercise b30 solution a
        /*
        public static string test30(string str)
        {
            string x = "";

            for (int i = 1; i < str.Length; i++)
            {
                x += str.Substring(0, i+1);

            }
            return x;
        }
        */
        // Exercise b31 solution a
        /*
        public static int test31(string str)
        {
            string x = str.Substring(str.Length-2,2);
            int count = 0;

            for (int i = 0; i < str.Length-2; i++)
            {
                if (str.Substring(i, 2)==x)
                {
                    count++;
                }
            }
            return count;
        }
        */
        //Exercise b32 solution a
        /*
        public static bool test32(int[] numbers, int n)
        {
            if (numbers.Contains(n))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        */
        // Exercise b33 solution a
        /*
        public static bool test33(int[] numbers, int n)
        {
            return numbers.Length < 4 ? numbers.Contains(n) : numbers.Take(4).Contains(n);
        }
        */
        // Exercise b34 solution a
        /*
        public static bool test34(int[] numbers)
        {
            for(int i=0; i < numbers.Length - 2; i++)
            {
                if(numbers[i]== 1 && numbers[i+1] == 2 && numbers[i+2] == 3)
                {
                    return true;
                }
            }
            return false;
        }
        */
        // Exercise b35 solution a
        /*
        public static int test35(string x, string y)
        {
            int count = 0;
            for(int i = 0; i < x.Length - 1; i++)
            {
                for(int j=0; j < y.Length-1; j++)
                {
                    if(x.Substring(i,2)== y.Substring(j, 2))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        */
        // Exercise b36 solution a
        /*
        public static string test36(string x, string y)
        {
            string str = "";
            for (int i = 1; i < x.Length - 1; i++)
            {
                if(x.Substring(i,1) == y)
                {
                    x= x.Remove(i,1);
                }

            }
            return x;
        }
        */
        // Exercise b37 solution a
        /*
        public static string test37(string x)
        {
            string str = "";
            for (int i = 0; i < x.Length; i++)
            {
                if (i % 4 == 0)
                {
                    str += x.Substring(i, 2);
                }

            }
            return str;
        }
        */
        // Exercise b38 solution a
        /*
        public static int test38(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if ((numbers[i] == 5 || numbers[i] == 6)&& (numbers[i+1] == 5 || numbers[i+1] == 6))
                {
                    count++;
                }
            }
            return count;
        }
        */
        // Exercise b39 solution a
        /*
        public static bool test39(int[] numbers)
        {

            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i]== numbers[i + 1] && numbers[i] == numbers[i + 2])
                {
                    return true;
                }
            }
            return false;
        }
        */
        // Exercise b40 solution a
        /*
        public static int test40(int x, int y)
        {
            int sum = x + y;
            if(sum>=10 && sum <= 20)
            {
                return 30;

            }
            else
            {
                return sum;
            }
            
        }
        */
        // Exercise b41 solution a
        /*
        public static bool test41(int x, int y)
        {
            int sum = x + y;
            if (sum == 5 || x == 5 || y == 5 || x-y == 5 || y-x == 5)
            {
                return true;

            }
            else
            {
                return false;
            }
           // b return x == 5 || y == 5 || x + y == 5 || Math.Abs(x - y) == 5;
        }
        */
        // Exercise b42 solution a
        /*
        public static bool test42(int x)
        {
            return x > 0 ? (x % 13 == 0 || x % 13 == 1 || x % 13 == 12) : false;
        }
        */
        // Exercise b43 solution a
        /*
        public static bool test43(int x)
        {
            return x % 3 == 0 ^ x % 7 == 0;
        }
        */
        // Exercise b44 solution a
        /*
        public static bool test44(int x)
        {
            return x % 10 <= 2 || x % 10 >= 8;
        }
        */
        // Exercise b45 solution a
        /*
        public static int test45(int x, int y)
        {
            if ((x <= 20 && x >= 10) || (y <= 20 && y >= 10))
            {
                return 18;
            }
            else
            {
                return x + y;
            }

        }
        */
        // Exercise b46 solution a
        /*
        public static string test(string str)
        {
            if (str.StartsWith("F") && str.EndsWith("B"))
            {
                return "FizzBuzz";
            }
            else if (str.StartsWith("F"))
            {
                return "Fizz";
            }
            else if (str.EndsWith("B"))
            {
                return "Buzz";
            }
            else
            {
                return str;
            }
        }
        */
        // Exercise b47 solution a
        /*
        public static bool test47(int x, int y, int z)
        {
            return (x == y + z || y == x + z || z == x + y) ? true : false;
        }
        */
        // Exercise b48 solution a
        /*
        public static bool test48(int x, int y, int z)
        {
            return (y>x && z > y) ? true : false;
        }
        */
        // Exercise b49 solution a
        /*
        public static bool test49(int x, int y, int z, bool xy)
        {
            if(xy == false)
            {
                if (x<y && y<z){
                    return true;
                }
                else
                {
                    return false;
                }
            }else
            {
                if(x<=y && y <= z)
                {
                    return true;
                } 
                else
                {
                    return false;
                }
            }
        */
        // Exercise b50 solution a
        /*
        public static bool test50(int x, int y, int z)
        {
            if(((x%10)==(y%10) || (x%10)==(z%10))|| (y % 10 == z%10))
            {
                return true;
            }else
            {
                return false;
            }
        }
        */
        // Exercise b51 solution a
        /*
        public static bool test(int x, int y, int z)
        {
            return Math.Abs(x - y) >= 20 || Math.Abs(x - z) >= 20 ||
                     Math.Abs(y - z) >= 20;
        }
        */
        // Exercise b52 solution a
        /*
        public static int test52(int x, int y)
        {
            if (x == y) return 0;
            if (x % 7 == y % 7) return (x < y) ? x : y;
            return (x > y) ? x : y;
        }
        */
        // Exercise b53 solution a
        /*
        public static bool test53(int x, int y)
        {
            return x / 10 == y / 10 || 
                x / 10 == y % 10 || 
                x % 10 == y / 10 || x % 10 == y % 10;
        }
        */
        // Exercise b54 solution a
        /*
        public static int test54(int x, int y)
        {
            return (x + y).ToString().Length > x.ToString().Length ? x : x + y;
        }
        */
    }
}



