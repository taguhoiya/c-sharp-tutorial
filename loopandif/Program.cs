// See https://aka.ms/new-console-template for more information

Practice();

void If()
{
  int a = 5;
  int b = 6;
  if (a + b > 10 || a + b <= 9)
    Console.WriteLine("The answer is greater than 10.");
  else
    Console.WriteLine("The answer is not greater than 10");

  for (char column = 'a'; column < 'k'; column++)
  {
    Console.WriteLine($"The column is {column}");
  }

}

// Now that you've seen the if statement and the looping constructs in the C# language, see if you can write C# code to find the sum of all integers 1 through 20 that are divisible by 3. Here are a few hints:
// The % operator gives you the remainder of a division operation.
// The if statement gives you the condition to see if a number should be part of the sum.
// The for loop can help you repeat a series of steps for all the numbers 1 through 20.
// Try it yourself. Then check how you did. As a hint, you should get 63 for an answer.

void Practice()
{
  int sum = 0;
  int num = 21;
  for (int i = 1; i < num; i++)
  {
    if (i % 3 == 0)
      sum = sum + i;
  }
  Console.WriteLine(sum);
}