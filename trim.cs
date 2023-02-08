using System;
public class Trim
{
  static void Main()
  {
    string greeting = "      Hello World!       ";
    Console.WriteLine($"[{greeting}]");

    string trimmedGreeting = greeting.TrimStart();
    Console.WriteLine($"[{trimmedGreeting}]");

    trimmedGreeting = greeting.TrimEnd();
    Console.WriteLine($"[{trimmedGreeting}]");

    trimmedGreeting = greeting.Trim();
    Console.WriteLine($"[{trimmedGreeting}]");

    string sayHello = "Hello World!";
    Console.WriteLine(sayHello);
    sayHello = sayHello.Replace("Hello", "Greetings");
    Console.WriteLine(sayHello);
  }
}