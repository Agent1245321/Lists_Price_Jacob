// See https://aka.ms/new-console-template for more information


// In the Main method, Create a string list called games and initialize it with some game titles.
List<string> games = new List<string> { "Octopath Traveller II", "Breath of the Wild", "Tears of the Kingdom", "SSBU" };
//Create an array of strings, called otherGames, and initialize it with a couple more game titles.
List<string> otherGames = new List<string> {"Uncharted", "Sly Cooper", "Rachet & Clank", "Jak & Daxter" };
//Use a foreach loop to print each game in the games list.
foreach (string game in games)
{
    Console.WriteLine(game);
}
//Print to console the number of items in the list.
Console.WriteLine(games.Count);
//Add a range to the list using the array you made.
games.AddRange(otherGames);
//Print to console the number of items in the list.
Console.WriteLine(games.Count);
//If the list contains "Halo", then print to console, "MASTER CHIEF is in the house!".
if(games.Contains("Halo"))
{
    Console.WriteLine("MASTER CHIEF is in the house!");
}
//Else, add "Halo" to the games list.
else
{
    games.Add("Halo");
}
//Create an int and assign it the value of 6.
int num = 6;
//If the int value is less than the number of games in the games list, then remove the game at index 6 of the games list.
if(games.Count >= num)
{
    games.RemoveRange(num, 1);
}
//Else, print out, "Game not found!".
else
{
    Console.WriteLine("Game not found!");
}
//Print to console, "All games in the list:"
Console.WriteLine("\n All games in the list:");
//Loop through the games list and print each game to console again.
foreach(string game in games)
{
    Console.WriteLine($"{game}");
}
//Sort the games list.
games.Sort();
//Print to console, "Sorted Games List:".
Console.WriteLine("\n Sorted Games List:");
//Print each game to console again.
foreach (string game in games)
{
    Console.WriteLine($"{game}");
}
//Create a string array called newList and initialize it to the same size as the games list.
string[] newList = new string[games.Count];
//Copy the games list to the string array newList.
games.CopyTo(newList, 0);
//Clear the games list.
games.Clear();
Console.WriteLine("\n");
//Print each of the strings in the new list.
foreach (string game in newList)
{
    Console.WriteLine(game);
}