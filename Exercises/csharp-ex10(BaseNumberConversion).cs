using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace BaseNumberConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            /* binary: 101010
             * to octal, group by threes and convert
             * 101 = 5, 010 = 2 (52)
             * 
             * to hex, group by fours and convert
             * 0010 = 2, 1010 = a
             * 
             * to decimal, use powers of 2
             * 2^0 * 0 = 0
             * 2^1 * 1 = 2
             * 2^2 * 0 = 0
             * 2^3 * 1 = 8
             * 2^4 * 0 = 0
             * 2^5 * 1 = 32
             * -------------
             * total   = 42
             * 
             * test these with your binary calculator*/


            
            while (true)
            {
                //check to see if the user wishes to continue
                Console.Write("Do you wish to get started? Please enter [Y] - yes or [N] - no:  ");
                string exit = Console.ReadLine();
                if (exit == "N" || exit == "n")
                    Environment.Exit(0);

                //get the base to convert from
                Console.Write("Please enter the base to convert from [2 | 8 | 10 | 16]: ");
                string basenum = Console.ReadLine();
                int bn = int.Parse(basenum);

                //get the "number" to convert
                Console.Write("Please enter the integer to convert: ");
                string number = Console.ReadLine();
                bool success = Int32.TryParse(number, out int num);
                if (success)
                    Console.WriteLine($"Number: {num}, base: {bn} \n");
                else
                    Console.WriteLine($"Number: {number}, base: {bn}");

                int result = 0;
                string str_result = "";
                if (bn == 10)
                {
                    //decimal
                    str_result = Util.dec2bin(num);
                    Console.WriteLine($"Binary conversion is {str_result}");
                    str_result = Util.dec2oct(num);
                    Console.WriteLine($"Octal conversion is {str_result}");
                    str_result = Util.dec2hex(num);
                    Console.WriteLine($"Hex conversion is {str_result}");
                }
                else if (bn == 2)
                {
                    //binary
                    result = Util.bin2dec(num);
                    Console.WriteLine($"Decimal conversion is {result}");
                    str_result = Util.bin2oct(num);
                    Console.WriteLine($"Octal conversion is {str_result}");
                    str_result = Util.bin2hex(num);
                    Console.WriteLine($"Hex conversion is {str_result}");
                }
                else if (bn == 8)
                {
                    //octal
                    str_result = Util.oct2bin(num);
                    Console.WriteLine($"Binary conversion is {str_result}");
                    result = Util.oct2dec(num);
                    Console.WriteLine($"Decimal conversion is {result}");
                    str_result = Util.oct2hex(num);
                    Console.WriteLine($"Hex conversion is {str_result}");
                }
                else if (bn == 16)
                {
                    //hex
                    str_result = Util.hex2bin(number);
                    Console.WriteLine($"Binary conversion is {str_result}");
                    str_result = Util.hex2oct(number);
                    Console.WriteLine($"Octal conversion is {str_result}");
                    result = Util.hex2dec(number);
                    Console.WriteLine($"Decimal conversion is {result}");
                }
                else
                    Console.WriteLine("There was an error in conversion.");
            }
        }
    }
    static class Util
    {
        internal static int bin2dec(int bin)
        {
            int[] digits = bin.ToString().ToCharArray().Select(Convert.ToInt32).ToArray();
            Array.Reverse(digits);
            int sum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] == '1')
                    sum += (int)Math.Pow(2, i);
            }
            return sum;
        }

        internal static string bin2hex(int bin)
        {
            int dec = bin2dec(bin);
            string result = dec2hex(dec);
            return result;
        }

        internal static string bin2oct(int bin)
        {
            int dec = bin2dec(bin);
            string result = dec2oct(dec);
            return result;
        }

        internal static string dec2bin(int num)
        {
            string result = string.Empty;
            for (int i = 0; num > 0; i++)
            {
                result = num % 2 + result;
                num = num / 2;
            }
            return result;
        }

        internal static string dec2hex(int num)
        {
            List<string> hex = new List<string>();
            int tmp;
            for (int i = num; i > 0; i = i / 16)
            {
                tmp = i % 16;
                if (tmp < 10)
                    tmp = tmp + 48;
                else
                    tmp = tmp + 55;
                char ch = (char)tmp;
                hex.Add(ch.ToString());
            }
            hex.Reverse();
            StringBuilder builder = new StringBuilder();
            foreach (string hexChar in hex)
                builder.Append(hexChar);
            string result = builder.ToString();
            return result;
        }

        internal static string dec2oct(int num)
        {
            List<string> octal = new List<string>();
            do
            {
                int oct = num % 8;
                octal.Add(oct.ToString());
                num /= 8;
            }
            while (num != 0);
            octal.Reverse();
            StringBuilder builder = new StringBuilder();
            foreach (string octChar in octal)
                builder.Append(octChar);
            string result = builder.ToString();
            return result;
        }

        internal static string hex2bin(string number)
        {
            int dec = hex2dec(number);
            string result = dec2bin(dec);
            return result;
        }

        internal static int hex2dec(string number)
        {
            int len = number.Length;
            int base1 = 1;
            int dec_val = 0;

            for (int i = len - 1; i >= 0; i--)
            {
                if (number[i] >= '0' && number[i] <= '9')
                {
                    dec_val += (number[i] - 48) * base1;
                    base1 = base1 * 16;
                }
                else if (number[i] >= 'A' && number[i] <= 'F')
                {
                    dec_val += (number[i] - 55) * base1;
                    base1 = base1 * 16;
                }
            }
            return dec_val;
        }

        internal static string hex2oct(string number)
        {
            int dec = hex2dec(number);
            string result = dec2oct(dec);
            return result;
        }

        internal static string oct2bin(int num)
        {
            int dec = oct2dec(num);
            string result = dec2bin(dec);
            return result;
        }

        internal static int oct2dec(int num)
        {
            int currBase = num.ToString().Length - 1;
            int dec = 0;
            string octStr = num.ToString();
            foreach (char item in octStr)
            {
                dec += int.Parse(item.ToString()) * (int)Math.Pow(8, currBase);
                currBase--;
            }
            return dec;
        }

        internal static string oct2hex(int num)
        {
            int dec = oct2dec(num);
            string result = dec2hex(dec);
            return result;
        }
    }
}
