//TriangleFarmer();
FourSistersDuckbear();
//DominionOfKings();

//The Triangle Farmer
void TriangleFarmer()
{
    Console.WriteLine("Enter the base length of the triangle: ");
    float triangleBaseLength = Convert.ToSingle(Console.ReadLine());
    Console.WriteLine("Enter the height of the triangle");
    float triangleHeight = Convert.ToSingle(Console.ReadLine());
    float triangleArea = (triangleBaseLength * triangleHeight) / (float)2.0;
    Console.WriteLine($"Area of Triangle = {triangleArea}");
}

//The Four Sisters and the Duckbear
void FourSistersDuckbear()
{
    Console.WriteLine("How many chocolate eggs were gathered for the day?");
    uint eggsGatheredToday = Convert.ToUInt32(Console.ReadLine());
    Console.WriteLine("How many chocolate eggs were gathered for the day?");
    uint eggsForEachSister = eggsGatheredToday / 4;
    uint eggsForDuckBear = eggsGatheredToday % 4;
    Console.WriteLine($"Each sister gets {eggsForEachSister} eggs for the day\nThe Duckbear gets {eggsForDuckBear} eggs for the day.");
    //Three counts where the duckbear gets more than each of the sisters are 6, 7, and 3 (Also, 1 and 2)
}

void DominionOfKings()
{
    uint userScore = 0;
    Console.WriteLine("Enter Number of Estates: ");
    userScore += Convert.ToUInt32(Console.ReadLine());
    Console.WriteLine("Enter Number of Duchies: ");
    userScore += Convert.ToUInt32(Console.ReadLine()) * 3;
    Console.WriteLine("Enter Number of Provinces: ");
    userScore += Convert.ToUInt32(Console.ReadLine()) * 6;
    Console.WriteLine($"Total Score: {userScore}");
}
