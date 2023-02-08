using System;
public class Trim
{
  static void Main()
  {
    string songLyrics = "You say goodbye, and I say hello";
    Console.WriteLine(songLyrics.Contains("goodbye"));
    Console.WriteLine(songLyrics.Contains("greetings"));
    Console.WriteLine(songLyrics.StartsWith("You"));
    Console.WriteLine(songLyrics.EndsWith("goodbye"));
    Console.WriteLine(songLyrics.StartsWith("hello"));
    Console.WriteLine(songLyrics.EndsWith("goodbye"));
  }
}