
string[] snacks = { "pitsa", "burks", "sushi" };

Random rnd = new Random();
int randomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine(snacks[randomIndex]);
