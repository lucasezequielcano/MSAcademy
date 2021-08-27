using System;

using MSAcademy.Math;
namespace MSAcademy
{
    public class Person{
        public int age; 
    }
    public enum ShippingMethod{
        RegularAirMail = 1, 
        RegisteredAirMail = 2, 
        Express = 3
    }

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
            /// > > > D E M O : O P E R A T O R S  < < < 
            var a = 1; 
            var b = 2; 
            var c = 3; 


            System.Console.WriteLine(!(c > b || c == a));
            Person lucas = new Person(); 
            lucas.firstName = "Lucas"; 
            lucas.lastName = "Cano"; 
            lucas.introduce(); 

            //------------------------------//

            Calculator calculator = new Calculator(); 
            var result = calculator.add(1,2); 
            System.Console.WriteLine(result);

            //------------------------------// 

            /// > > > D E M O : A R R A Y S   < < < 
          
            int[] numbers = new int[3]; //we can use var instead of int[]
            numbers[0] = 1; 
            System.Console.WriteLine(numbers[0]);
            System.Console.WriteLine(numbers[1]);
            System.Console.WriteLine(numbers[2]);

            //------------------------------//

            var flags = new bool[3]; 
            flags[0] = true; 
            System.Console.WriteLine(flags[0]);
            System.Console.WriteLine(flags[1]);
            System.Console.WriteLine(flags[2]);

            //------------------------------//

            /// > > > D E M O : S T R I N G S < < < 

            var names = new string[3]{"Jack", "John", "Mary"}; 
            System.Console.WriteLine(names[0]);
            System.Console.WriteLine(names[1]);
            System.Console.WriteLine(names[2]);
            var firstName = "Lucas"; //or var firstName = "Lucas"; 
            var lastName = "Cano"; 
            var fullName = firstName + " " + lastName; 
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName); 
            var names = new String[3]{"John", "Jack", "Mary"}; 
            var formattedNames = string.Join(",", names);
            System.Console.WriteLine(formattedNames); 
            var text = @"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4"; 
            System.Console.WriteLine(text);

            //------------------------------//

            /// > > > D E M O : E N U M < < < 

             var method = ShippingMethod.Express; 
             System.Console.WriteLine((int)method);

             var methodId = 3; 
             System.Console.WriteLine((ShippingMethod)methodId);
             System.Console.WriteLine(method);
             var methodName = "Express"; 
             var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName); 

            /// > > > D E M O : T Y P E S  A N D  V A L U E  T Y P E S < < < 

            var a = 10; 
            var b = a; 
            b++; 
            System.Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            var array1 = new int[3]{1, 2, 3};
            var array2 = array1; 
            array2[0] = 0; 
            System.Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));
            */
            int number = 1; 
            increment(number); 
            System.Console.WriteLine(number);

            var person = new Person(){age = 20}; 
            makeOld(person); 
            System.Console.WriteLine(person.age);
        }
        public static void increment(int number){
            number += 10; 
        }
        public static void makeOld (Person person){
            person.age += 10; 
        }
    }
}
