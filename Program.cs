namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("Welcome to the calculator!");
      Console.WriteLine("--------------------");

      Console.WriteLine("Select an option:");
      Console.WriteLine("1 - Sum");
      Console.WriteLine("2 - Subtract");
      Console.WriteLine("3 - Multiply");
      Console.WriteLine("4 - Divide");
      Console.WriteLine("5 - Exit");

      Console.WriteLine("--------------------");
      short option = short.Parse(Console.ReadLine() ?? "0");

      switch (option)
      {
        case 1:
          {
            Sum();
            break;
          }
        case 2:
          {
            Subtract();
            break;
          }
        case 3:
          {
            Multiply();
            break;
          }
        case 4:
          {
            Divide();
            break;
          }
        case 5:
          {
            AppExit();
            break;
          }
        default:
          {
            Menu();
            break;
          }
      }
    }

    static void Sum() //Method
    {
      Console.Clear(); // Clear the console

      Console.WriteLine("Enter the first number:");
      float num01 = Convert.ToSingle(Console.ReadLine());

      Console.WriteLine("Enter the second number:");
      float num02 = Convert.ToSingle(Console.ReadLine());

      float result = num01 + num02;

      Console.WriteLine($"The result is: {result}!"); // Interpolation
      //Console.WriteLine("The result is:" + result + "!"); // Concatenation
      Console.ReadKey(); // Precionar qualquer tecla para continuar

      Menu();
    }

    static void Subtract()
    {
      Console.Clear();
      Console.WriteLine("Enter the first number:");
      float num01 = Convert.ToSingle(Console.ReadLine());

      Console.WriteLine("Enter the second number:");
      float num02 = Convert.ToSingle(Console.ReadLine());

      float result = num01 - num02;

      Console.WriteLine($"The result is: {result}!");
      Console.ReadKey();

      Menu();
    }

    static void Multiply()
    {
      Console.Clear();

      Console.WriteLine("Enter the first number:");
      float num01 = Convert.ToSingle(Console.ReadLine());

      Console.WriteLine("Enter the second number:");
      float num02 = Convert.ToSingle(Console.ReadLine());

      float result = num01 * num02;

      Console.WriteLine($"The result is: {result}!");
      Console.ReadKey();

      Menu();
    }

    static void Divide()
    {
      Console.Clear();

      Console.WriteLine("Enter the first number:");
      float num01 = Convert.ToSingle(Console.ReadLine());

      Console.WriteLine("Enter the second number:");
      float num02 = Convert.ToSingle(Console.ReadLine());

      if (num02 == 0)
      {
        Console.WriteLine("It is not possible to divide by zero!");
        Console.ReadKey();
        Divide();
      }
      else
      {
        float result = num01 / num02;
        Console.WriteLine($"The result is: {result}!");
      }
      Console.ReadKey();

      Menu();
    }

    static void AppExit()
    {
      Console.Clear();
      Console.WriteLine("Thank you for using our services!");
      Environment.Exit(0); // Close the application
    }
  }
}
