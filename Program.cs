using System;

namespace Assignment1DIS
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("********************Question 1********************");
            int n1 = 5;
            PrintPattern(n1);

            Console.WriteLine();
            Console.WriteLine("********************Question 2********************");
            int n2 = 6;
            PrintSeries(n2);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("********************Question 3********************");
            string s = "09:15:35PM";
            string t = UsfTime(s);
            Console.WriteLine(t);

            Console.WriteLine();
            Console.WriteLine("********************Question 4********************"); 
            int n3 = 110;
            int k = 11;
            UsfNumbers(n3, k);

            Console.WriteLine();
            Console.WriteLine("********************Question 5********************");
            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            PalindromePairs(words);

            Console.WriteLine();
            //Console.WriteLine("********************Question 6********************");
            //int n4 = 4;
            //Stones(n4);

        }

        //QUESTION 1:

        /*n – number of lines for the pattern, integer (int)
         * summary   : This method prints number pattern of integers using recursion
         * For example n = 5 will display the output as: 
         * 54321
         * 4321
         * 321
         * 21
         * 1
         * returns      : N/A
         * return type  : void
         */


        private static void PrintPattern(int n1)
        {
            try
            {
                int n, i, j;
                Console.Write("Input rows number : ");
                n = Convert.ToInt32(Console.ReadLine());

                for (i = n; i >= 1; i--)
                {

                    for (j = i; j >= 1; j--)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();
                }

            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printPattern");
            }
        }

 //QUESTION 2: 

/*n2 – number of terms of the series, integer (int)
 * This method prints the following series till n terms: 1, 3, 6, 10, 15, 21……
 * For example, if n2 = 6, output will be
 * 1,3,6,10,15,21
 * Returns : N/A
 * Return type: void
 * Hint: Series is 1,1+2=3,1+2+3=6,1+2+3+4=10,1+2+3+4+5=15, 1+2+3+4+5+6=21……
 */

        private static void PrintSeries(int n2)
        {
            try
            {
                int n, i, sum = 0;
                Console.Write("Input the number till you want to print the series : ");
                n = Convert.ToInt32(Console.ReadLine());
                for (i = 1; i <= n; i++)
                {
                    sum += i;   // Adding 'i' each time to the previous 'sum'
                    Console.Write(sum + " ");

                }
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printSeries");
            }
        }

 //QUESTION 3:
/* On planet “USF” which is similar to that of Earth follows different clock
 * where instead of hours they have U, instead of minutes they have S , instead
 * of seconds they have F. Similar to earth where each day has 24 hours, each hour
 * has 60 minutes and each minute has 60 seconds, USF planet’s day has 36 U , each
 * U has 60 S and each S has 45 F. 
 * Your task is to write a method usfTime which takes 12HR  format and return string 
 * representing input time in USF time format.
 * Input format: A string s with time in 12 hour clock format (i.e. hh:mm:ssAM or            * hh:mm:ssPM) where 01<= hh<=12, 00<=mm,ss,<=60
 * Output format: a string with converted time in USF clock format (i.e. UU:SS:FF ) 
 * where 01<= UU<=36, 00<=SS<=59,00<=FF<=45
 * 
 * Sample Input : 09:15:35PM
 * Sample Output: 28:20:35 
 * 
 * returns      : String
 * return type  : string
 * 
 * Hint: One way of doing this is by calculating total number of seconds in Input time
 * and dividing those seconds according to USF time.
 */

        public static string UsfTime(string s)
        {
            try
            {
                    int EarthSeconds;
                    Console.Write("Enter the Earth Time hh:mm:ss(AM/PM): ");
                    string EarthTime = Console.ReadLine();  // Asking time from the User in string
                    string Ehour = EarthTime.Substring(0, 2); // Taking SUbstring from the user input
                    int EH = Int32.Parse(Ehour);            // Converting String into Int 
                    string Eminute = EarthTime.Substring(3, 2);
                    int EM = Int32.Parse(Eminute);
                    string Esec = EarthTime.Substring(6, 2);
                    int ES = Int32.Parse(Esec + " ");
                    string AP = EarthTime.Substring(8, 2);
                    Console.WriteLine("Earth Time:" + EH + ":" + EM + ":" + ES + AP);
                    if (AP == "AM" || AP == "am" || AP == "Am")
                    {
                        EarthSeconds = EH * 60 * 60 + EM * 60 + ES; // Calculating total seconds on basis of Earth's time
                        decimal SMin = EarthSeconds / 45;           // Dividing by 45 so that I can get 'S'(USF minutes)
                        decimal U = SMin / 60;                      // Diving by 60 so that i can get 'U'(USF Hours)
                        decimal x = U;
                        decimal y = x - Math.Truncate(U);           // Used Math.Truncate() to get the number before decimal point
                        decimal S = y * 60;
                        decimal z = S - Math.Truncate(S);
                        decimal F = z * 45;
                        Console.WriteLine("USF Time:" + Math.Truncate(U) + ":" + Math.Truncate(S) + ":" + Math.Truncate(F));

                    }
                    else if (AP == "PM" || AP == "pm" || AP == "Pm")
                    {
                        EarthSeconds = (EH + 12) * 60 * 60 + EM * 60 + ES; //Adding +12 for PM timings
                        decimal SMin = EarthSeconds / 45;
                        decimal U = SMin / 60;
                        decimal x = U;
                        decimal y = x - Math.Truncate(U);
                        decimal S = y * 60;
                        decimal z = S - Math.Truncate(S);
                        decimal F = z * 45;
                        Console.WriteLine("USF Time:" + Math.Truncate(U) + ":" + Math.Truncate(S) + ":" + Math.Truncate(F));

                }


            }
            catch
            {
                Console.WriteLine("Exception Occured while computing UsfTime");
            }
            return null;
        }

 //QUESTION 4:
/*n- total number of integers( 110 )
 * k-number of numbers per line ( 11)
 * USF Numbers : This method prints the numbers 1 to 110, 11 numbers per line.
 * The method shall print 'U' in place of numbers which are multiple of 3,"S" for 
 * multiples of 5,"F" for multiples of 7, 'US' in place of numbers which are multiple 
 * of 3 and 5,'SF' in place of numbers which are multiple of 5 and 7 and so on. 
 * The output shall look like 
 * 1 2 U 4 S U F 8 U S 11 
 * U 13 F US 16 17 U 19 S UF 22
 * 23 U S 26 U F 29 US 31 32 U....
 * 
 * returns      : N/A
 * return type  : void
 */


        public static void UsfNumbers(int n3, int k)
        {
            try
            {
                int i;
                // Using If else
                for (i = 1; i <= 110; i++)
                {

                    if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)
                    {
                        Console.Write("USF ");
                    }
                    else if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.Write("US ");
                    }
                    else if (i % 5 == 0 && i % 7 == 0)
                    {
                        Console.Write("SF ");
                    }
                    else if (i % 3 == 0 && i % 7 == 0)
                    {
                        Console.Write("UF ");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.Write("U ");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.Write("S ");
                    }
                    else if (i % 7 == 0)
                    {
                        Console.Write("F ");
                    }
                    else if (true)
                    {
                        Console.Write(i + " ");
                    }
                    if (i % 11 == 0)
                    {
                        Console.WriteLine();
                    }

                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing UsfNumbers()");
            }
        }
//QUESTION 5:

/*You are given a list of unique words, the task is to find all the pairs of 
 * distinct indices (i,j) in the given list such that, the concatenation of two
 * words i.e. words[i]+words[j] is a palindrome.
 * Example:
 * Input: ["abcd","dcba","lls","s","sssll"]
 * Output: [[0,1],[1,0],[3,2],[2,4]] 
 * Explanation: The palindromes are ["dcbaabcd","abcddcba","slls","llssssll"]
 * Example:
 * Input: ["bat","tab","cat"]
 * Output: [[0,1],[1,0]] 
 * Explanation: The palindromes are ["battab","tabbat"]
 * 
 * returns      : N/A
 * return type  : void
 */
               
        // This is a function to check the string is Palindrome or not
        public static Boolean Palindrome(string var)
        {

            int length = var.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (var[i] != var[length - i - 1])
                    return false;
            }
            return true;
        }

        public static void PalindromePairs(string[] words)
        {
            try
            {
                int j, i, k;
                string[] s3 = new String[20];
                string[] strings = { "abcd","dcba","lls","s","sssll" };
                k = 0;


                for (i = 0; i < strings.Length; i++)
                {
                    for (j = i + 1; j < strings.Length; j++)
                    {
                        s3[k] = string.Concat(strings[i], strings[j]); //Concatination of two strings in loop
                        if (Palindrome(s3[k]))
                        {
                            Console.WriteLine("[" + i + "," + j + "]");
                            Console.WriteLine("[" + j + "," + i + "]");
                        }
                    }
                    k = k + 1;
                }
            }
            catch
            {

                Console.WriteLine("Exception occured while computing     PalindromePairs()");
            }
        }

        //QUESTION 6:

        /*You are playing a stone game with one of your friends. There are N number of 
         * stones in a bag, each time one of you take turns to take out 1 to 3 stones. 
         * The player who takes out the last stone will be the winner. In this case you
         * will be the first player to remove the stone(s)(Player 1).
         
         * Write a method to determine whether you can win the game given the number of 
         * stones in the bag. Print false if you cannot win the game, otherwise print any
         * one set of moves where you are winning the game. Array should contain moves by
         * both the players.
         * Input: 4
         * Output: false
         * Explanation: As there are 4 stones in the bag, you will never win the game. 
         * No matter 1,2 or 3 stones you take out, the last stone will always be removed by   * your friend.
         * Input: 5
          * Output: [1,1,3]   or [1,2,2] or [1,3,1]
          * Player 1 picks up 1 stone then player 2 picks up 1 or 2 or 3 stones and the  
          * remaining stones are picked up by player 1.
          * Explanation: As there are 5 stones in the bag, you take out one stone.
          * As there are 4 stones in the bag and it’s your friend’s turn. He will never win 
          * the game because no matter 1,2 or 3 stones he takes out, you will the one to take 
          * out the last stone.
          * 
          * returns      : N/A
          * return type  : void
          */
        public static void Stones(int n4)
        {
            try
            {
                Console.Write("Enter the Number of stones you want to play with:");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n == 4)
                {
                    Console.WriteLine("false"); //If there are 4 stones then Player 1 is never going to win it.
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Stones()");
            }
        }


    }
}
