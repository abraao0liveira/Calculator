namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear(); // Clear the console
      Console.WriteLine("Welcome to the calculator!");

      Console.WriteLine("Enter the first number:");
      float num01 = Convert.ToSingle(Console.ReadLine());

      Console.WriteLine("Enter the second number:");
      float num02 = Convert.ToSingle(Console.ReadLine());

      float result = num01 + num02;

      Console.WriteLine($"The result is: {result}!"); // Interpolation
    }
  }
}
