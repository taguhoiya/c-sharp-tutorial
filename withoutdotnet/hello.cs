using System;
public class HelloWorld
{
  static public void Main()
  {
    Console.WriteLine("Hello Mono World");
    string aFriend = "Bill";
    Console.WriteLine("Hello " + aFriend);
    aFriend = "Maira";
    Console.WriteLine($"Hello {aFriend}");
    Console.WriteLine($"Hello {aFriend} and the length of it is {aFriend.Length}");
  }
}