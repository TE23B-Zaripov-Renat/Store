int Kronor = 100;

Console.WriteLine("Välommen till min affär!");
Console.WriteLine($"Du har {Kronor} kronor");

Console.WriteLine("Vad skulle du vilja köpa?\n 1)Ett äplle (10kr)\n 2)En banan (15kr)\n 3)En vattenmelon (50kr)");

string tall = Console.ReadLine();
tall = tall.ToLower();

if (tall == "1")
{
    Console.WriteLine("Hur många vill du köpa?");
    string a = Console.ReadLine();
    int antal;
    int.TryParse(a, out antal);
    int totalKostnad = antal * 10;

if (totalKostnad > 100)
{

    Console.WriteLine($"Allt detta kommer kosta {totalKostnad}kr");
    Console.WriteLine("Tyvärr har du inte råd!");
    // Läs in från användaren en string
    // Gör om stringen till en int
    // Kolla om inten * 10 > Kronor
}
if (totalKostnad <100)
    
}




















    // int i = 0;
    // while (i < 10)
    // {
    //     Console.WriteLine("hej");
    //     i++;
    // }

    // for (int j = 0; j < 10; j++)
    // {
    //     Console.WriteLine("hej");
    // }



    // bool success = false;
    // int ageNum = 0;

    // while (success != true)
    // {


    //     Console.WriteLine("Ålder:");
    //     string age = Console.ReadLine();

    //     success = int.TryParse(age, out ageNum);

    //     if (success == false)
    //     {
    //         Console.WriteLine("Skriv en siffra, dumhuve!");
    //     }
    // }

    // if (ageNum >= 18)
    // {
    //     Console.WriteLine("Välkommen");
    // }

    Console.ReadLine();