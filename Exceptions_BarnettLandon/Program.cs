using System;

namespace Exceptions_BarnettLandon
{
    class Program
    {
        static void Main(string[] args)
        {
           
            float myFloat = 65.4f;
            float myOtherFloat = 0.0f;
            float result = 0;

            Random rand = new Random();
            int myInt = rand.Next(2, 30);
            
            //tries to divide and will catch and error
            try
            {
                result = Divide(myFloat,myOtherFloat);
            }
            //spits back read line
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter a number other than zero");
                

                //Re tries 
                try
                {
                    
                    myOtherFloat = (float) Convert.ToDouble(Console.ReadLine());
                    result = Divide(myFloat, myOtherFloat);
                }
                catch (Exception e2)
                {
                    Console.WriteLine(e2.Message);

                }
            }
            //runs again 
            finally
            {
                Console.WriteLine($"Calculations completed with a result of {result}");
            }

            //checks if you're old enough
            try
            {
                CheckAge(myInt);
            }
            //if you aren't then this happens
            catch
            {
                Console.WriteLine($"Ya ain't {myInt}, not old nuff");
            }
        }

        static float Divide(float x, float y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return x / y;
            }
        }

        //if you are old enough,then this happens
        static void CheckAge(int age)
        {
            if (age >= 17)
            {
                Console.WriteLine($"Age {age}, you can play mature games!");
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
