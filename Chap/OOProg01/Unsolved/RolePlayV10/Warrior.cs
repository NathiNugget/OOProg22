
public class Warrior
{
    private string _name;
    private int _level; 

    public Warrior(string name)
    {
        _name = name;
        _level = 1; 
    }

    public void IncreaseLevel() { _level++; }


    public string Name
    {
        get { return _name; }
    }

    public int Level
    {
        get { return _level; }
    }

}
