using System;
using System.Collections.Generic;
using MSAcademy.Math;
namespace MSAcademy
{
    public class Person
    {
        public int age;
    }
    public enum ShippingMethod
    {
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
            /////////////////////////////////////////////////
            ///> > > P u n t o  1 < < <///
            byte number;
            System.Console.WriteLine("Ingrese un numero: ");
            number = Convert.ToByte(System.Console.ReadLine());

            if (number < 11)
            {
                System.Console.WriteLine("Valid");
            }
            else
            {
                System.Console.WriteLine("Invalid");
            }

            ///////////////////////////////////////////////////
            ///> > > P u n t o  2 < < <///
            int a, b;
            System.Console.WriteLine("Ingrese el primer numero: ");
            a = Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Ingrese el segundo numero: ");
            b = Convert.ToInt32(System.Console.ReadLine());

            if (a > b)
            {
                System.Console.WriteLine("El número " + a + " es el mayor entre los dos.");
            }
            else if (b > a)
            {
                System.Console.WriteLine("El número " + b + " es el mayor entre los dos.");
            }
            else
            {
                System.Console.WriteLine("Ambos números ingresados son iguales.");
            }

            ////////////////////////////////////////////////////////
            ///> > > P u n t o  3 < < <///

            float height, width;
            System.Console.WriteLine("Ingrese el ancho: ");
            width = Convert.ToSingle(System.Console.ReadLine());
            System.Console.WriteLine("Ingrese el alto: ");
            height = Convert.ToSingle(System.Console.ReadLine());

            if (width > height)
            {
                System.Console.WriteLine("The image is a landscape");
            }
            else
            {
                System.Console.WriteLine("The image is a portrait");
            }

            ////////////////////////////////////////////////////////
            ///> > > P u n t o  4 < < <///

            int demeritPoints=0; 
            float speedLimit, carSpeed; 
            System.Console.WriteLine("Please enter the speed limit: ");
            speedLimit = Convert.ToSingle(System.Console.ReadLine());
            for(int i = 0; i<5; i++){
                 System.Console.WriteLine(".\n");
             }
            System.Console.WriteLine("Please enter the speed of the car: ");
            carSpeed = Convert.ToSingle(System.Console.ReadLine());
            if(carSpeed < speedLimit)
            {
                System.Console.WriteLine("Ok.");
            }
            else
            {
                while(carSpeed-5>=speedLimit){
                    demeritPoints++;
                    carSpeed -= 5;  
                }
            }
            if(demeritPoints<=12){
                System.Console.WriteLine("You have "+demeritPoints+" demerit points");

            }
            else
            {
                System.Console.WriteLine("You have "+demeritPoints+" demerit points. Licence Suspended.");
            }

            ////////////////////////////////////////////////////////
            /// > > > D E M O :  A R R A Y S  < < < 

            var numbers = new int[] { 3, 7, 9, 2, 14, 6 };
            // Length
            System.Console.WriteLine("Length: " + numbers.Length);
            // IndexOf()
            var index = Array.IndexOf(numbers, 9);
            System.Console.WriteLine("Index of 9: " + index);
            // Clear() --> set to 0
            Array.Clear(numbers, 0, 2);
            foreach (var n in numbers)
            {
                System.Console.WriteLine(n);
            }
            //Copy
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            System.Console.WriteLine("Effect of Copy(): ");
            foreach (var m in another)
                System.Console.WriteLine(m);

            // Sort()
            Array.Sort(numbers); 
            System.Console.WriteLine("Effect of Sort(): ");
            foreach(var ñ in numbers)
                System.Console.WriteLine(ñ);

            // Reverse()
            Array.Reverse(numbers); 
            System.Console.WriteLine("Effect of Reverse(): ");
            foreach(var n in numbers)
                System.Console.WriteLine(n);
            var numbers = new List<int>(){1, 2, 3, 4}; 
            numbers.Add(1); 
            numbers.AddRange(new int[3]{5, 6, 7}); 
            foreach(var number in numbers)
                System.Console.WriteLine(number);
            System.Console.WriteLine("Index of 1: " +numbers.IndexOf(1));
            System.Console.WriteLine("Last Index of 1: " +numbers.LastIndexOf(1));
            System.Console.WriteLine("Count: "+numbers.Count);
            numbers.Remove(1); 

            for(var i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] == 1)
                    numbers.Remove(numbers[i]); 

            }           
            foreach(var number in numbers)
                System.Console.WriteLine(number);

            numbers.Clear(); 
             ////////////////////////////////////////////////////////
            /// > > > E X E R C I S E :  A R R A Y S  < < < 
            //2.
            string name, reversedName; 
            System.Console.WriteLine("Enter your name: ");
            name = System.Console.ReadLine(); 
            char[] cArray = name.ToCharArray();
            Array.Reverse(cArray);  
            reversedName = new string (cArray); 
            System.Console.WriteLine("Name: " + name);
            System.Console.WriteLine("Reversed Name: " + reversedName);

            //3.
            List<int> iList = new List<int>(); 
            int i = 0; 
            while(i<5)
            {
              int number; 
              System.Console.WriteLine("Enter a number: ");
              number = Convert.ToInt32(System.Console.ReadLine()); 
              if(iList.Exists(elem => elem == number))
              {
                System.Console.WriteLine("The number is repeated. Please enter a new number.");  
              }  
              else
              {
                iList.Add(number); 
                i++; 
              }
            }
            iList.Sort(); 
            System.Console.WriteLine("///////////////");
            foreach(int elem in iList)
            {
                System.Console.WriteLine(elem);
            }
            var jList = new List<int>(); 
            while(true)
            {
                System.Console.WriteLine("Enter a number or quite to exit");
                var quit = Console.ReadLine(); 

                if(quit.CompareTo("quit") == 0)
                    break; 
                else
                {
                    var number = Convert.ToInt32(quit); 
                    if(jList.Contains(number))
                        continue; 
                    else
                        jList.Add(number); 
                }
            }
            foreach(var a in jList)
                System.Console.WriteLine(a);
            var list = new List<int>(); 
            while(true)
            {
                System.Console.WriteLine("Write a list of numbers: ");
                var input = Console.ReadLine(); 
                var array = input.Split(','); 
                if((array.Length == 0) || (array.Length < 5))
                {
                    System.Console.WriteLine("Invalid list. Try again.");
                }
                else
                {
                    foreach(var arrayNumber in array)
                        list.Add(Convert.ToInt32(arrayNumber)); 
                        break; 
                }
            }
            list.Sort(); 
        
            foreach(var a in list)
                System.Console.WriteLine(a);        
            */

            //1.
            List<string> names = new List<string>();
            int quantity = 0; 
            char c  = 's'; 
            while(c != 'n')
            {
                System.Console.WriteLine("Enter a name: ");
                var name = Console.ReadLine(); 
                names.Add(name); 
                System.Console.WriteLine("Do you want to continue? s/n");
                c = Convert.ToChar(Console.ReadLine()); 
            }
            quantity = names.Count;
            if(quantity == 0)
            {
                System.Console.WriteLine("---");
            } else if(quantity == 1)
            {
                System.Console.WriteLine(names[0]+" likes yout post");
            }else if(quantity == 2)
            {
                 System.Console.WriteLine(names[0]+" and "+names[1]+ " likes yout post");
            }else 
            {
                System.Console.WriteLine(names[0]+" and "+names[1] +" and "+ (quantity-2) +" others likes yout post");
            }
            

        }
    }
}