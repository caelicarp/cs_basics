int[] scores = new int[10]; // creates an array with length 10
scores[0] = 9;
scores[1] = 5;
scores[2] = 99;

/* if the values type is clear enough to infer, you
 * don't even need to specify the type of the array.
 * length is specified as the number of listed items.
 */ 
int[] numbers = new [] {1, 2, 3, 4, 5};

Console.Write("Write a number hehe: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];

for (int index = 0; index < array.Length; index++)
{
  array[index] = index; // assigns index value to array on current position
  Console.WriteLine(array[index]);
}

int firstItem = array[0]; // selects the first item in the array
int lastItem = array[^1]; // selects the last item in the array
Console.WriteLine("The first item is: " + firstItem);
Console.WriteLine("The last item is: " + lastItem);