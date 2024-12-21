// olution foreach 1
string[] locations = new[] { "locations1", "locations2", "locations3" };

string[] location1 = new[] { "result-1", "result-2", "result-3" };
string[] location2 = new[] { "result-4", "result-5", "result-6" };
string[] location3 = new[]{"result-7", "result-8", "result-9"};


foreach (string location in locations)
{
    Console.WriteLine($"{location}");
    if (location == "locations1")
        foreach (string result in location1)
        {
            Console.WriteLine($"{result}");
        }
    else if (location == "locations2")
        foreach (string result2 in location2)
        {
            Console.WriteLine($"{result2}");
        }
    else if (location == "locations3")
        foreach (string result3 in location3)
        {
            Console.WriteLine($"{result3}");
        }
    Console.WriteLine();
}
