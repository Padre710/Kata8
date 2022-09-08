using System;
using System.Collections.Generic;
using System.Linq;


//The rgb function is incomplete.
//Complete it so that passing in RGB decimal values will result in a hexadecimal representation being returned.
//Valid decimal values for RGB are 0 - 255. Any values that fall out of that range must be rounded to the closest valid value.

//Note: Your answer should always be 6 characters long, the shorthand with 3 will not work here.

//The following are examples of expected output values:

//Rgb(255, 255, 255) # returns FFFFFF
//Rgb(255, 255, 300) # returns FFFFFF
//Rgb(0, 0, 0) # returns 000000
//Rgb(148, 0, 211) # returns 9400D3


namespace Kata8
{
    public class Kata
    {
       
        public static string Hexadecimal(int dec)
        {
            int i;
            int[] a = new int[10];
            List<string> Hex_no = new List<string>();
            if (dec > 255)
            {
                Hex_no.Add("FF");


            }
            else if (dec == 0 || dec < 0)
            {
                Hex_no.Add("00");

            }
            else

            {
                if (dec < 16)
                {
                    Hex_no.Add("0");
                }

                for (i = 0; dec > 0; i++)
                {
                    a[i] = dec % 16;
                    dec = dec / 16;
                }



                for (i = i - 1; i >= 0; i--)
                {


                    if (a[i] == 10)
                    {
                        Hex_no.Add("A");
                    }
                    else if (a[i] == 11)
                    {
                        Hex_no.Add("B");
                    }
                    else if (a[i] == 12)
                    {
                        Hex_no.Add("C");
                    }
                    else if (a[i] == 13)
                    {
                        Hex_no.Add("D");
                    }
                    else if (a[i] == 14)
                    {
                        Hex_no.Add("E");
                    }
                    else if (a[i] == 15)
                    {
                        Hex_no.Add("F");
                    }
                    else if (a[i] == 9)
                    {
                        Hex_no.Add("9");
                    }
                    else if (a[i] == 8)
                    {
                        Hex_no.Add("8");
                    }
                    else if (a[i] == 7)
                    {
                        Hex_no.Add("7");
                    }
                    else if (a[i] == 6)
                    {
                        Hex_no.Add("6");
                    }
                    else if (a[i] == 5)
                    {
                        Hex_no.Add("5");
                    }
                    else if (a[i] == 4)
                    {
                        Hex_no.Add("4");
                    }
                    else if (a[i] == 3)
                    {
                        Hex_no.Add("3");
                    }
                    else if (a[i] == 2)
                    {
                        Hex_no.Add("2");
                    }
                    else if (a[i] == 1)
                    {
                        Hex_no.Add("1");
                    }
                    else
                    {
                        Hex_no.Add("0");
                    }
                }
            }             
            string hex = String.Join("", Hex_no);
            return hex;
            
        }

        public static string rgb(int r, int g, int b)
        {
            string q = Hexadecimal(r) + Hexadecimal(g) + Hexadecimal(b);
            return q;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Kata.rgb(-148, 0, 211));
        }
    }
}
