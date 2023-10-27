
/// <summary>
/// This class represents a Axe. An Axe is 
/// considered to be a weapon.
/// </summary>
public class Axe : Weapon
{
    public const int InitialAxeMinDamage = 20;
    public const int InitialAxeMaxDamage = 50;

    #region Constructor
    public Axe(string description)
        : base(description, InitialAxeMinDamage, InitialAxeMaxDamage)
    {
    }
    #endregion

    #region Methods

    public int DamageFromAxe()
    {
        int _damage = base.CalculateDamage();
        base.MaxDamage -= 3; 
        base.MinDamage -= 3;
        return _damage;
    }

    public void Sharpen()
    {
        base.MaxDamage = InitialAxeMaxDamage; 
        base.MinDamage = InitialAxeMinDamage;
    }
    #endregion


}