using System;

class Program
{
  static void Main()
  {
    // program code goes here
    
    
    Console.WriteLine("Please provide an integer greater than 1:");
    int inputNumber = int.Parse(Console.ReadLine());

    for (int i = 1; i <= inputNumber; i++)
    {
      if (i % 3 == 0 && i % 5 == 0)
      {
        Console.WriteLine("Ping-Pong");
      }
      else if (i % 3 == 0)
      {
        Console.WriteLine("Ping");
      }
      else if (i % 5 == 0)
      {
        Console.WriteLine("Pong");
      }
      else
      {
        Console.WriteLine(i);
      }
    }
  }
}