Console.WriteLine("Enter the first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int res = 1;
for (int i = 1; i <= secondNumber; i++)
{
    res = res * firstNumber;
}
Console.WriteLine($"{firstNumber}, {secondNumber} -> {res}");