
Warrior warriorA = new Warrior("Ragnar");
Warrior warriorB = new Warrior("Lagertha");

Console.WriteLine($"Warrior A is called {warriorA.Name}");
Console.WriteLine($"Warrior B is called {warriorB.Name}");

warriorA.IncreaseLevel(); 
warriorB.IncreaseLevel();

Console.WriteLine($"Warrior A has level {warriorA.Level}");
Console.WriteLine($"Warrior B has level {warriorB.Level}");

