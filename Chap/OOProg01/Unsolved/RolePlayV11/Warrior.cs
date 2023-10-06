
public class Warrior
{
    #region Instance fields
    private string _name;
    private int _level;
    private int _hitpoints;
    private bool _dead;
    #endregion

    #region Constructor
    public Warrior(string name, int hitpoints)
    {
        _name = name;
        _level = 1;
        _hitpoints = hitpoints;
        _dead = false;
    }
    #endregion

    #region Properties
    public string Name
    {
        get { return _name; }
    }

    public int Level
    {
        get { return _level; }
    }

    public int Hitpoints { 
        get { return _hitpoints; }
    }

    
    #endregion

    #region Methods
    public void LevelUp()
    {
        _level = _level + 1;
    }

    public void ReceiveDamage(int dmg)
    {
            _hitpoints -=  dmg;
    }

    public bool Dead() {
            if (_hitpoints <= 0) return true;
        return false; }

    public int DamageToDeal() {
        Random rnd = new Random();
        return rnd.Next(10, 30);
        
    }
    
    #endregion
}
