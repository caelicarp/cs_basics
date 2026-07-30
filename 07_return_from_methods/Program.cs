Console.WriteLine("How high should I count?");
int chosenNumber = ReadNumber();
Count(chosenNumber);

void Count(int numberToCount)
{
  for (int current = 1; current <= numberToCount; current++)
  {
    Console.WriteLine(current);
  }
}

int ReadNumber()
{
  string input = Console.ReadLine();
  int number = Convert.ToInt32(input);  
  return number;
}


