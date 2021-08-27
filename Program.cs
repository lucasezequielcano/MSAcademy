using System;

namespace MSAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            /// > > > D E M O :  V A R I A B L E S  A N D  C O N S T A N T S < < <
            /*
            var number = 2; 
            var count = 10; 
            var totalPrice = 20.95f; 
            var character = 'A'; 
            var firstName = "Lucas";
            var isWorking = true; 
            Console.WriteLine(number);
            System.Console.WriteLine(count);
            System.Console.WriteLine(totalPrice);
            System.Console.WriteLine(character);
            System.Console.WriteLine(firstName);
            System.Console.WriteLine(isWorking);

            //------------------------------//

            System.Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            System.Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            //-----------------------------//

            const float Pi= 3.14f; */

            /// > > > D E M O :  T Y P E  C O N V E R S I O N < < < 

            /*
            byte b = 1; 
            int i = b;
            System.Console.WriteLine(i);

            //------------------------------//

            int i = 1; 
            byte b = (byte)i;  
            System.Console.WriteLine(b);

            //------------------------------//

            var number = "1234";
            int i = Convert.ToInt32(number);
            System.Console.WriteLine(i);

            //------------------------------//

            ///            E X C E P T I O N 
            ///            var number ="1234"; 
            ///            byte b = Convert.ToByte(number);
            ///            System.Console.WriteLine(b); 

            //------------------------------//

            try
            {
                var number = "1234";
                byte b = Convert.ToByte(number);
                System.Console.WriteLine(b);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("The number could not be converted to a byte!!");
            }

            //------------------------------//

            try
            {
                string str ="true"; 
                bool b = Convert.ToBoolean(str); 
                System.Console.WriteLine(b);
            }
            catch (System.Exception)
            {   
                throw;
            }
            */
            /// > > > D E M O : O P E R A T O R S  < < < 
            var a = 1; 
            var b = 2; 
            var c = 3; 


            System.Console.WriteLine(!(c > b || c == a));



        }
    }
}
