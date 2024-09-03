
Odreidar odreidar = new Odreidar();
Androis androis = new Androis();

Console.WriteLine($"{odreidar.name} has {odreidar.health} heatlhs");
Console.WriteLine($"{androis.name} has {androis.health} healths");
Console.WriteLine("Bullseye!?!?!");
androis.health -=50;

Console.WriteLine($"{androis.name} has {androis.health} health");
Console.WriteLine("Press any key to continue");
Console.ReadKey();
Console.WriteLine("Bullseye!!");
androis.health -= 100;

Console.WriteLine("Perished");

Console.ReadKey();