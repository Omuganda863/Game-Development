namespace SimpleCalc;

class Program
{
    static void Main(string[] args)
    {
        int num1, num2 , result;
        Console.Write("Enter First number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        result = num1 + num2;
        Console.WriteLine("The Result is: \n" + result);

    }
}
