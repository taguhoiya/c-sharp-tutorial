// // Declaration only:
// float temperature;
// string name;
// // MyClass myClass;

// // Declaration with initializers (four examples):
// char firstLetter = 'C';
// var limit = 3;
// int[] source = { 0, 1, 2, 3, 4, 5 };

class LowNums
{
  static void Main()
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