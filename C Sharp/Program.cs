for (int i = 0; i < 5; i++){
    Console.WriteLine("Hi");
}


//while loop


int j = 0;
while (j < 5){
    Console.WriteLine("this is the while loop");
    j++;
}


// making a game guesser
Console.Write("Enter the first number: ");
double num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
double num2 = Convert.ToInt32(Console.ReadLine());

double result = num1 * num2;

double value = 0;

//while (result != value)
//{
//    Console.Write("Enter the result of the mutiplication: ");
//    value = Convert.ToInt32(Console.ReadLine());

//    if (value != result)
//    {
//        Console.WriteLine ("Close but it is wrong");
//    }
//}

//Console.WriteLine("Well done");

//Console.ReadLine();

/*
// do while loop 

do
{
    Console.Write("Enter the result of the multiplication: ");
    value = Convert.ToInt32(Console.ReadLine());

    if (value != result)
    {
        Console.WriteLine("Close, but it is wrong.");
    }
} while (result != value);

Console.WriteLine("Correct! Well done.");



*/


// condtional opaterator

int age = 10;

Console.WriteLine(age > 10 ? "Valid" : "Invalid");
