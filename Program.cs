
int numb;

Console.WriteLine("Plase enter the year");
string temp=Console.ReadLine();
bool is_valid=Int32.TryParse(temp, out numb);
if (is_valid)
{
    string[] zodiacAnimals = 
        { "Monkey","Rooster","Dog",
        "Pig", "Rat", "Ox",
        "Tiger","Rabbit","Dragon",  
        "Snake","Horse","Goat" };

    
    int pos = numb % 12;
    if (numb > 2023)
    {
        Console.WriteLine($"This will be {zodiacAnimals[pos]} year");
    }
    else if (numb==2023) {
        Console.WriteLine($"This is {zodiacAnimals[pos]} year");

    }
    else{
        Console.WriteLine($"This was {zodiacAnimals[pos]} year");
    }

}
else
{
    Console.WriteLine("Invalid Input");
}