
Warrior warriorA = new Warrior("Ragnar", 100);
Warrior warriorB = new Warrior("Lagertha", 120);
int att1 = 0; 
int att2 = 0;


Console.WriteLine($"Two warriors stand up to fight.\nWarrior A: {warriorA.Name} and Warrior B: {warriorB.Name}\n"); 
while (!warriorA.Dead() && !warriorB.Dead())
{
    att1 = warriorA.DamageToDeal(); 
    att2 = warriorB.DamageToDeal();
    warriorA.ReceiveDamage(att2); 
    warriorB.ReceiveDamage(att1);
    Console.WriteLine($"Warrior A deals: {att1} and Warrior B deals: {att2}"); 
}
if (warriorB.Dead() && !warriorA.Dead())
{
    Console.WriteLine("Warrior A won");
} else if (warriorA.Dead() && !warriorB.Dead()) {
    Console.WriteLine("Warrior B won");
}
else if (warriorB.Dead() && warriorA.Dead()) {
    if (warriorA.Hitpoints > warriorB.Hitpoints)
    {
        Console.WriteLine($"The battle ended in equilateral death. But Warrior A dealt more than Warrior B.\n" +
            $"The terminal hitpoints of Warrior A is: {warriorA.Hitpoints} and the terminal hitpoints of Warrior B is {warriorB.Hitpoints}"); 
    }
    else if (warriorA.Hitpoints < warriorB.Hitpoints)
    {
        Console.WriteLine($"The battle ended in equilateral death. But Warrior B dealt more than Warrior A.\n" +
            $"The terminal hitpoints of Warrior A is: {warriorA.Hitpoints} and the terminal hitpoints of Warrior B is {warriorB.Hitpoints}");
    }
    else
    {
        Console.WriteLine("The battle ended in a draw."); 
    }
}

