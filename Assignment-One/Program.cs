using System;

namespace Assignment1_Spring2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            PrintPattern(n);

            int n2 = 6;
            PrintSeries(n2);

            string s = "09:15:35PM";
            string t = UsfTime(s);
            Console.WriteLine(t);

            int n3 = 110;
            int k = 11;
            UsfNumbers(n3, k);

            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            PalindromePairs(words);


        }


        private static void PrintPattern(int n)
        {
            try
            {
                //Write your code here .!!
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printPattern");
            }
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
                  string[] time = s.Split(":");                            // split a string of list '09:15:35PM' for each colon found

                  string time_s = time[2].Substring(0, 2);                 // take 35PM and create substring with seconds
                  string time_ap = time[2].Substring(2, 2);                // take 35PM and create substring with value 'AM' or 'PM'

                  int earth_hour = Convert.ToInt32(time[0]);               // take '09' and convert it into an integer
                  int earth_minutes = Convert.ToInt32(time[1]);            // take '15' and convert it into an integer
                  int earth_seconds = Convert.ToInt32(time_s);             // take '35' and convert it into an integer
                  
                  Console.WriteLine(earth_hour + " " + earth_minutes + " " + earth_seconds);    // display the earth time
                  
                  if (time_ap == "PM")                                     // check if it is 'PM'
                      earth_hour += 12;                                    // add 12 to earth hour
                  
                  int earth_totalseconds = (earth_hour * 60 * 60) + (earth_minutes * 60) + (earth_seconds);     // earth time converted into total seconds
                  Console.WriteLine(earth_totalseconds);                   // display total seconds as per earth

                  int usf_hours = earth_totalseconds / (60 * 45);          // earth seconds into USF U
                  int usf_hours_mod = earth_totalseconds % (60 * 45);      // remainder earth seconds
                  int usf_min = usf_hours_mod / 45;                        // remainder seconds into usf S
                  int usf_sec = usf_hours_mod % 45;                        // remainder seconds into usf F

                  return (usf_hours + ":" + usf_min + ":" + usf_sec);      // return earth time (hh:mm:ssPM) converted into USF time (UU:SS:FF)

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
                
            }
            catch
            {
                Console.WriteLine("Exception occured while computing UsfNumbers()");
            }
        }



        public static void PalindromePairs(string[] words)
        {
            try
            {
                // Write your code here
            }
            catch
            {

                Console.WriteLine("Exception occured while computing     PalindromePairs()");
            }
        }

        public static void Stones(int n4)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Stones()");
            }
        }


    }
}
