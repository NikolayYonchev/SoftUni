using System;

Random random = new Random();

Console.WriteLine($"{Phrases()} {Event()} {Authors()} - {Cities()}");

string Cities()
{
    List<string> cities = new List<string> { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

    int index = random.Next(cities.Count);


    return cities[index];
}

string Authors()
{
    List<string> authors = new List<string> { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

    int index = random.Next(authors.Count);


    return authors[index];
}

string Event()
{
    List<string> @event = new List<string> { "Now I feel good.",
        "I have succeeded with this product.",
        "Makes miracles. I am happy of the results!",
        "I cannot believe but now I feelawesome.",
        "Try it yourself, I am very satisfied.", "I feel great!" };

    int index = random.Next(@event.Count);


    return @event[index];
}

string Phrases()
{
    List<string> phrases = new List<string> { "Excellent product.",
        "Such a great product.",
        "I always use that product",
        "Best product of its category.",
        "Exceptional product.",
        "I can't live without this product." };

    int index = random.Next(phrases.Count);


    return phrases[index];
}