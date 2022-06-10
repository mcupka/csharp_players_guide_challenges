replicator_of_dto();
laws_of_freach();

void replicator_of_dto()
{
    int[] array1 = new int[5];
    int[] array2 = new int[5];
    Console.WriteLine("Enter 5 numbers for the array:");
    for (int i = 0; i < 5; i++)
    {
        Console.Write($"array1[{i}] = ");
        array1[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("\n");
    Console.WriteLine("Copying array1 into array2...");
    for (int i = 0; i < array1.Length; i++)
    {
        array2[i] = array1[i];
    }
    Console.Write("Contents of array1:");
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($" {array1[i]}");
    }
    Console.Write("\n");
    Console.Write("Contents of array2:");
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write($" {array2[i]}");
    }
    Console.Write("\n");
    Console.WriteLine("BEHOLD MORTAL!!");
}

void laws_of_freach()
{
    int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
    //Computer minimum value of array
    int minimum = int.MaxValue;
    foreach(int i in array)
    {
        if (i < minimum) minimum = i;
    }
    Console.WriteLine($"The minimum value of the array is {minimum}");
    //Computer average value of array
    float average = 0; 
    foreach(int i in array)
    {
        average += i; 
    }
    average /= array.Length;
    Console.WriteLine($"The average value of the array is {average}");
}
