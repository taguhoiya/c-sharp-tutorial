// // Declaration only:
// float temperature;
// string name;
// // MyClass myClass;

// // Declaration with initializers (four examples):
// char firstLetter = 'C';
// var limit = 3;
// int[] source = { 0, 1, 2, 3, 4, 5 };

List<string> stringList = new List<string>{"hoge"};
stringList.Add("String example");
// compile time error adding a type other than a string:
// stringList.Add(4);
foreach (string s in stringList)
{
  Console.Write($"[{s}]");
};

class LowNums
{
  static void Query()
  {
    // A simple data source.
    int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

    // Create the query.
    // lowNums is an IEnumerable<int>
    var lowNums = from num in numbers
                  where num < 5
                  select num;

    // Execute the query.
    foreach (int i in lowNums)
    {
      Console.Write(i + " ");
    }
  }
}
// Output: 4 1 3 2 0