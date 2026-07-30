void RocketLauncher(int ignition)
{
  if (ignition <= 0)
  {
    Console.WriteLine("Ignition!");
    return; //return sin valor porque el método es void
  }

  Console.WriteLine(ignition);

  RocketLauncher(ignition - 1); //cuenta regresiva
}

RocketLauncher(3);