Console.WriteLine("enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumber(int number)
{

    int size = Convert.ToString(number).Length;
    int temp = 0;
    int res = 0;

    for (int i = 0; i <= number; i++)
    {
        temp = number - number % 10;
        res = res + (number - temp);
        number = number / 10;
    }
    return res;
}
int sum = SumNumber(number);
Console.WriteLine($"The sum of the digits in a {number} -> {sum}");