//repairing_clocktower();
watchtower();

// Repairing the Clocktower
void repairing_clocktower()
{
    Console.Write("Enter a number: ");
    int input_number = Convert.ToInt32(Console.ReadLine());
    if (input_number % 2 == 0) Console.WriteLine("Tick");
    else Console.WriteLine("Tock");
}

// Watchtower
void watchtower()
{
    Console.WriteLine("Enter X Coordinate");
    int x_coordinate = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Y Coordinate");
    int y_coordinate = Convert.ToInt32(Console.ReadLine());

    if (x_coordinate < 0 && y_coordinate > 0) Console.WriteLine("The enemy is to the northwest!");
    else if (x_coordinate == 0 && y_coordinate > 0) Console.WriteLine("The enemy is to the north!");
    else if (x_coordinate > 0 && y_coordinate > 0) Console.WriteLine("The enemy is to the northeast!");
    else if (x_coordinate < 0 && y_coordinate == 0) Console.WriteLine("The enemy is to the west!");
    else if (x_coordinate == 0 && y_coordinate == 0) Console.WriteLine("The enemy is here!");
    else if (x_coordinate > 0 && y_coordinate == 0) Console.WriteLine("The enemy is to the east!");
    else if (x_coordinate < 0 && y_coordinate < 0) Console.WriteLine("The enemy is to the southwest!");
    else if (x_coordinate == 0 && y_coordinate < 0) Console.WriteLine("The enemy is to the south!");
    else if (x_coordinate > 0 && y_coordinate < 0) Console.WriteLine("The enemy is to the southeast!");
    else Console.WriteLine("THE ENEMY HAS TRANSCENDED THIS DIMENSION");
}