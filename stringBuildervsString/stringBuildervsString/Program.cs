using System;
using System.Diagnostics;
using System.Text;

namespace stringBuildervsString
{
    class Program
    {
        static void Main(string[] args)
        {


            //string is immutable. 
            //Performance wise string is slow because every time it will create new instance. 
            //In string we don’t have append keyword. 
            //String belongs to System namespace

            //StringBuilder is mutable.
            //Performance wise stringbuilder is high because it will use same instance of object to perform any action.
            //In StringBuilder we can use append keyword. 
            //Stringbuilder belongs to System.Text namespace.

            Stopwatch timer = new Stopwatch();

            //StringBuilder for very small set 
            StringBuilder builder1 = new StringBuilder();
            timer.Start();
        
            for (int i = 0; i < 10; i++)
            {

                builder1.Append(i).Append(" ");
            }
            timer.Stop();

            Console.WriteLine("Time taken using StringBuilder (small dataset): " + timer.Elapsed);

            timer.Reset();

            //string for very small set 
            string sampleString1 = "";
            timer.Start();
           
            for (int i = 0; i < 10; i++)
            {
                sampleString1 +=  i + " ";
                
            }
            timer.Stop();

            Console.WriteLine("Time taken using string (small dataset): " + timer.Elapsed);

            timer.Reset();

            //StringBuilder for medium data set 
            StringBuilder builder2 = new StringBuilder();
            timer.Start();

            for (int i = 0; i < 1000; i++)
            {

                builder2.Append(i).Append(" ");
            }
            timer.Stop();

            Console.WriteLine("Time taken using StringBuilder (medium dataset): " + timer.Elapsed);

            timer.Reset();

            //string for medium data set
            string sampleString2 = "";
            timer.Start();

            for (int i = 0; i < 1000; i++)
            {
                sampleString2 += i + " ";

            }
            timer.Stop();

            Console.WriteLine("Time taken using string (medium dataset): " + timer.Elapsed);



            
            timer.Reset();

            //StringBuilder for ver large data set
            StringBuilder builder3 = new StringBuilder();
            timer.Start();
            
            for (int i = 0; i < 100000; i++)
            {
                
                builder3.Append(i).Append(" ");
            }
            timer.Stop();
           
            Console.WriteLine("Time taken using StringBuilder (very large dataset): " + timer.Elapsed);

            timer.Reset();

            //String for ver large data set
            string sampleString3 ="";
            timer.Start();
           
            for (int i = 0; i < 100000; i++)
            {
                sampleString3 +=  i + " ";
               
            }
            timer.Stop();

            
            

            Console.WriteLine("Time taken using string (very large dataset): " + timer.Elapsed);

            //Output
            //Time taken using StringBuilder(small dataset): 00:00:00.0001068
            //Time taken using string (small dataset): 00:00:00.0000464
            //Time taken using StringBuilder(medium dataset): 00:00:00.0003677
            //Time taken using string (medium dataset): 00:00:00.0036546
            //Time taken using StringBuilder(very large dataset): 00:00:00.0260334
            //Time taken using string (very large dataset): 00:00:49.3400857


            //Conculsion 
            // Stringbuilder can be used where we have large number of operation or unknown number of operations at runtime on same string (more than 100)
            //string can be used where we have small number of operation on same string (less than 100)



        }
    }
}
