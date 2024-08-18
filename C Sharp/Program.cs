using System;

namespace C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); // printing to the console
            //Console.ReadLine();  //collecting input from the user, more like input() method in python

            int age;   // decalring a variable as an integer type
            age = 23;  // assigning a value to the variable

            int newVar = 23;  // doing variable assignment on one line
            long bigNumber = 90000000000L; // this is used to declare long number for integer, neaning it can take a larger number range, the L is actually optional

            /*
             * In C#, both long and int are data types used to represent integer values, but they differ in the range of values they can store due to their different sizes:

                int (System.Int32):

                Size: 32 bits (4 bytes)
                Range: -2,147,483,648 to 2,147,483,647
                Use: int is commonly used when you need to store integer values within this range.
                long (System.Int64):

                Size: 64 bits (8 bytes)
                Range: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
                Use: long is used when you need to store larger integer values that exceed the range of int.
             */


            Console.WriteLine(newVar);
            Console.WriteLine(bigNumber);

            int x, y, z;
            x = 50; y = 55; z = 3;


            float persistion = 4.3323F;  // Approximately 7 decimal digits
            decimal money = 43334.457474M; //Ideal for financial and monetary calculations where high precision is crucial and rounding errors must be minimized.
            double doubleNumber = 455.34445;  //Commonly used for general-purpose floating-point calculations, offering a good balance between range and precision.
            /*
             * 
             * In C#, float, double, and decimal are data types used to represent numbers with fractional parts, but they differ in precision, range, and intended use. Here's a breakdown:

                1. float (System.Single)
                Size: 4 bytes (32 bits)
                Precision: Approximately 7 decimal digits
                Range: ±1.5 × 10⁻⁴⁵ to ±3.4 × 10³⁸
                Suffix: f (e.g., 3.14f)
                Use: Suitable for scientific calculations where high precision is not critical, such as in graphics or games.
                2. double (System.Double)
                Size: 8 bytes (64 bits)
                Precision: Approximately 15-16 decimal digits
                Range: ±5.0 × 10⁻³²⁴ to ±1.7 × 10³⁰⁸
                Suffix: d (default, so it's often omitted; e.g., 3.14 is a double by default)
                Use: Commonly used for general-purpose floating-point calculations, offering a good balance between range and precision.
                3. decimal (System.Decimal)
                Size: 16 bytes (128 bits)
                Precision: 28-29 significant digits
                Range: ±1.0 × 10⁻²⁸ to ±7.9 × 10²⁸
                Suffix: m (e.g., 3.14m)
                Use: Ideal for financial and monetary calculations where high precision is crucial and rounding errors must be minimized.
             */


            //THE PART OF STRING ASSIGNMENT
            string name = "Nathaniel";   // string is used to store many string
            char letter = 'a';   // char can only store value
            char empty = '\0';  // default the char value to empty
            var unknown = 23;   // the compliar decide the type base on the data given

            Console.WriteLine("my name is:");
            Console.WriteLine(name);
            Console.WriteLine("my name is:");
            Console.WriteLine(letter);


            //converting strings to integers
            string textAge = "-23";
            int age1 = Convert.ToInt32(textAge);  // convert the string to interger

            Console.WriteLine(age1);



            // boolean datatype
            bool value = true;

            bool isMale = false;

            //Operator in c#

            int a = 23;
            Console.WriteLine(a);
            a++;
            Console.WriteLine(a)

            ;

            a += 10;
            Console.WriteLine(a);

            name += " Adeyinka";
            Console.WriteLine(name);


            // using const
            const int vat = 30; // this make it a constant

            Console.WriteLine(30 / 22D);



            int a1, a2;
            a1 = 23;
            a2 = 44;

            int remainder = a1 % a2;
            Console.WriteLine(remainder);

            // getting the input from the user using the console
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine(name);

            Console.Write("Enter your age: ");
            string nameAge = Console.ReadLine();

            //Console.Write("Your name is ");
            //Console.Write("name");
            //Console.Write(" and your age is ");
            //Console.Write(nameAge);

            Console.WriteLine("Your name is " + name + " and your age is " + nameAge);

            Console.ReadLine();



            // if and else statement

            if (name == "nathan")
                {
                    Console.WriteLine("the name is nathan");
                }
             else
                {
                    Console.WriteLine("the name is not nathan");
                }


            if (name == "nath")
                {
                    Console.WriteLine("the user name is nathan");
                }
            else if(name == "")
                {
                    Console.WriteLine("the name enter is empty");
                }
            else
                {
                    Console.WriteLine("your name is " + name);
                }

                Console.ReadLine();
        }

    }
}