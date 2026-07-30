string GetUserName()
{
  while (true)
  {
    Console.WriteLine("What's your name?");
    string name = Console.ReadLine();

    if (name != "")
    {
      return name;
    }

    Console.WriteLine("Let's try again");
  }
}

GetUserName();