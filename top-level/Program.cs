MyClass.TestMethod();
MyNamespace.MyClass.MyMethod();

if (args.Length > 0)
{
  foreach (var arg in args)
  {
    Console.WriteLine($"Argument={arg}");
  }
}
else
{
  Console.WriteLine("No arguments");
}

string? s = Console.ReadLine();

int returnValue = int.Parse(s ?? "-1");
Console.WriteLine($"Argument={returnValue}");
return returnValue;

public class MyClass
{
  public static void TestMethod()
  {
    Console.WriteLine("Hello World!");
  }

}

namespace MyNamespace
{
  class MyClass
  {
    public static void MyMethod()
    {
      Console.WriteLine("Hello World from MyNamespace.MyClass.MyMethod!");
    }
  }
}