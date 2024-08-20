Console.Write("Enter a value: ");
string valueString = Console.ReadLine();

int num;
bool success = int.TryParse(valueString, out num);

string res = success ? $"a valid int was entered {num}" : "the int was not valid";

Console.WriteLine(res);

Console.ReadLine();