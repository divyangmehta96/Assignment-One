using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1_Spring2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example Solution - https://github.com/divyangmehta96/Assignment-One/blob/master/Assignment-One/Assignment%2001.PNG \n");
            int n = 5;
            Console.WriteLine("Question 1\n");
            PrintPattern(n);

            int n2 = 6;
            Console.WriteLine("\nQuestion 2\n");
            PrintSeries(n2);

            string s = "09:15:35PM";
            Console.WriteLine("\nQuestion 3\n");
            string t = UsfTime(s);
            Console.WriteLine(t);

            int n3 = 110;
            int k = 11;
            Console.WriteLine("\nQuestion 4\n");
            UsfNumbers(n3, k);

            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            Console.WriteLine("\nQuestion 5\n");
            PalindromePairs(words);

            int num = 4;
            Console.WriteLine("\nQuestion 6\n");
            Stones(num);
            Console.WriteLine();
        }
        private static void PrintPattern(int n)
        {
            try                             // try the following code
            {
                if (n == 0)                 // stop when n is 0
                {
                    return;
                }
                displayAllLines(n);         // call the method Print Each Line
                Console.WriteLine();    
                PrintPattern(n - 1);        // recursion - call the same method with a decremented values of one
            }
            catch                           // execute the code below if the try block fails
            {
                Console.WriteLine("Exception Occured while computing printPattern");
            }
        }
        private static void displayAllLines(int l)
        {
            if (l == 0)                     // stop when l is 0 
            {
                return;
            }
            Console.Write(l + " ");         // display numbers starting from l to 1 
            displayAllLines(l - 1);         // call the same function with decremented value
        }
        private static void PrintSeries(int n2)
          {
              try                                     // try the code below 
              {
                  int term = 0;                       // set variable 'terms' to 0 (integer)
                  for (int n = 1; n <= n2; n++)       // traverse through the length mentioned by the user i.e. 0 to n2 = 6
                  {
                      term = term + n;                // add each incremented value of n ranging from 1 to 6
                      Console.Write(term + ", ");     // display the value of 'term' separated by a comma ','
                  }
                Console.WriteLine();
              }
              catch                                   
              {
                  Console.WriteLine("Exception Occured while computing printSeries"); // display the message if the try code fails
              }
          }
        public static string UsfTime(string s)
          {
              try
              {
                  // time is 09:15:35PM --> indexes --> [0] = 09, [1] = 15, [2] = 35PM
                  string[] time     = s.Split(":");                        // split a string of list '09:15:35PM' for each colon found

                  string time_s     = time[2].Substring(0, 2);             // take 35PM and create substring with seconds
                  string time_ap    = time[2].Substring(2, 2);             // take 35PM and create substring with value 'AM' or 'PM'

                  int earth_hour    = Convert.ToInt32(time[0]);            // take '09' and convert it into an integer
                  int earth_minutes = Convert.ToInt32(time[1]);            // take '15' and convert it into an integer
                  int earth_seconds = Convert.ToInt32(time_s);             // take '35' and convert it into an integer
                  
                  Console.WriteLine("Planet Earth --> " + earth_hour + ":" + earth_minutes + ":" + earth_seconds + time_ap);    // display the earth time
                  
                  if (time_ap == "PM")                                     // check if it is 'PM'
                      earth_hour += 12;                                    // add 12 to earth hour
                  
                  int earth_totalseconds = (earth_hour * 60 * 60) + (earth_minutes * 60) + (earth_seconds);     // earth time converted into total seconds
                  Console.WriteLine("Total earth seconds --> " + earth_totalseconds);                           // display total seconds as per earth

                  int usf_hours     = earth_totalseconds / (60 * 45);      // earth seconds into USF U
                  int usf_hours_mod = earth_totalseconds % (60 * 45);      // remainder earth seconds
                  int usf_min       = usf_hours_mod / 45;                  // remainder seconds into usf S
                  int usf_sec       = usf_hours_mod % 45;                  // remainder seconds into usf F

                  return ("Planet USF--> "+ usf_hours + ":" + usf_min + ":" + usf_sec);      // return earth time (hh:mm:ssPM) converted into USF time (UU:SS:FF)

              }
              catch
              {
                  Console.WriteLine("Exception Occured while computing UsfTime");
              }
              return null;
          }
        public static void UsfNumbers(int n3, int k)
        {
            try
            {
                int a = 1;                      // initialize variable a to 1 and it will go from 1 to 11
                for (int x = 1; x <= n3; x++)   // traverse the loop with x = 1 to n3 i.e. 110
                {
                    if (x % 3 == 0 & x % 5 == 0 & x % 7 == 0) { Console.Write("USF "); }    // if multiple of 3,5 AND 7 --> display "USF"
                    else if (x % 3 == 0 & x % 5 == 0) { Console.Write("US "); }             // if multiple of 3 AND 5 --> display "US"
                    else if (x % 5 == 0 & x % 7 == 0) { Console.Write("SF "); }             // if multiple of 5 AND 7 --> display "SF"
                    else if (x % 3 == 0 & x % 7 == 0) { Console.Write("UF "); }             // if multiple of 3 AND 7 --> display "UF"
                    else if (x % 3 == 0) { Console.Write("U "); }                           // if multiple of 3 --> display "U"
                    else if (x % 5 == 0) { Console.Write("S "); }                           // if multiple of 5 --> display "S"
                    else if (x % 7 == 0) { Console.Write("F "); }                           // if multiple of 7 --> display "F"
                    else { Console.Write(x + " "); }                                        // otherwise display the value of x

                    a = a + 1;                    // increment the value of a by 1
                    
                    if (a > k)                    // if a is more than 11
                    {
                        a = 1;                    // set a back to 1
                        Console.WriteLine();    
                    }
                }
                Console.WriteLine();

            }
            catch
            {
                Console.WriteLine("Exception occured while computing UsfNumbers()");
            }
        }
        static Boolean palindromeYesNo(string a)
        {
            int varlen = a.Length;                      // initialize the variable to have the length of the element
            for (int i = 0; i < varlen / 2; i++)        // traverse through the loop from 0 to half the length
            {
                if (a[i] != a[varlen - i - 1])          // if 'i'th element is not equal to the mirrored index element
                    return false;                       // return false
            }
            return true;                                // else return true
        }
        public static void PalindromePairs(string[] words)
        {

            try                                                 // try the above block of code
            {
                string str = "";                                // initialize an empty string 
                for (int p = 0; p < words.Length; p++)          // traverse through the loop from 0 to half the length of the word
                {
                    for (int q = 0; q < words.Length; q++)      // traverse through the loop from 0 to half the length of the word
                    {
                        if (p != q)                             // if p and q are not equal
                        {

                            String a = words[p] + words[q];     // concat the words
                            if (palindromeYesNo(a))             // call method 'palindromeYesNo'
                            {
                                str = str + ("[" + p + "," + q + "]" + ",");    // display the position of palindrome words
                                
                            }
                        }
                    }
                }
                Console.WriteLine(str);
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Exception occured while computing PalindromePairs()");
            }
        }
        public static void Stones(int num)
        {
            try
            {
                if (num % 4 == 0)                           // check if num is a multiple of 4
                {
                    Console.WriteLine("False");             // if yes, game over. Player 1 lost.
                }
                else                                        // if not, 
                {
                    List<int> integers = new List<int>();   // initialize a new list
                    {
                        int s = 0;                          // initialize int variable s
                        Random choice = new Random();
                        int player1 = num % 4;              // number of stones picked up by player 1
                        integers.Add(player1);              // add all the player 1 values into the list
                        int player2 = num - player1;        // remaining values are assigned to player 2
                        for (int x = 1; x <= player2; x++)  // to display the remaining stones
                        {
                            integers.Add(choice.Next(1,4));                // add 1 or 2 or 3 into list until player 2 value
                        }
                        foreach (int element in integers)   // traverse through each element in the list
                        {
                            s = integers.Sum();             // Add all values of the list
                        }
                        if (s == num)                               // if s is equal to num
                        {
                            int[] terms = integers.ToArray();       // Put values of list to array
                            Console.WriteLine("Values - ");             // Printing '[' as required for output
                            for (int i = 0; i < terms.Length; i++)  // Traverse through each value from 0 to the length of the array
                            {
                                Console.Write("{0}", terms[i]);         // display array values
                                if (i != (terms.Length - 1))            // for removing the comma after last element
                                {
                                    Console.Write(",");
                                }
                                else
                                {
                                    break;
                                }
                            
                            }
                        }
                    }

                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing Stones()");
            }
        }
    }
}
