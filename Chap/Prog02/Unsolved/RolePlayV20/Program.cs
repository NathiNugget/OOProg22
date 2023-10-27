
NumberGenerator theNumberGenerator = new NumberGenerator();
BattleLog theLog = new BattleLog();

Character theHero = new Character("Hero", theNumberGenerator, theLog, 10, 30, 100);
Character theBeast = new Character("Beast", theNumberGenerator, theLog, 10, 30, 100);

// Now battle...How do we do that (Hint: You need a loop)
while(!theHero.Dead && !theBeast.Dead)
{

    theBeast.ReceiveDamage(theHero.DealDamage()); 
    theHero.ReceiveDamage(theBeast.DealDamage());
}
theLog.PrintLog();
