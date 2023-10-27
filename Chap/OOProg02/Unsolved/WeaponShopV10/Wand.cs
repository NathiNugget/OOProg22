
/// <summary>
/// This class represents a Wand. A Wand is 
/// considered to be a weapon.
/// </summary>
public class Wand : Weapon
{
    public const int InitialWandMinDamage = 10;
    public const int InitialWandMaxDamage = 30;
    
    public bool IsEnchanted {  get; set; }

    public int DamageFromWand()
    {
        int _damage = 0;
        if (IsEnchanted)
        {
            _damage += 5; 
        }

        return _damage + base.CalculateDamage();
    }

    #region Constructor
    public Wand(string description)
        : base(description, InitialWandMinDamage, InitialWandMaxDamage)
    {
    }
    #endregion
}
