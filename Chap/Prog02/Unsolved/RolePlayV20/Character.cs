﻿
/// <summary>
/// This class implements a simple game character
/// 1) The character has a certain number of "hit points"
/// 2) The character can deal damage
/// 3) The character can receive damage, causing the hit points to decrease
/// </summary>
public class Character
{
    #region Instance fields
    private String _state;
    private int _hitPoints;
    private NumberGenerator _generator;
    private BattleLog _log;
    private int _minDamage;
    private int _maxDamage;
    #endregion

    #region Constructor
    /// <summary>
    /// Create a Hero, using references to a random number generator and a battle log
    /// </summary>
    public Character(String state, NumberGenerator generator, BattleLog log, int mindmg, int maxdmg, int hitpoints)
    {
        _state = state;
        _generator = generator;
        _log = log;
        _hitPoints = hitpoints;
        _minDamage = mindmg;
        _maxDamage = maxdmg;

        Reset();
    }
    #endregion

    #region Properties
    /// <summary>
    /// Checks if the Hero is dead, defined as having 0 or less hit points...
    /// </summary>
    public bool Dead
    {
        get { return (_hitPoints <= 0); }
    }
    #endregion

    #region Methods
    /// <summary>
    /// Reset the Hero's state to the original state
    /// </summary>
    public void Reset()
    {
        _hitPoints = 100;
    }

    /// <summary>
    /// Returns the amount of points a Hero deals in damage.
    /// This damage could then be received by another character
    /// </summary>
    public int DealDamage()
    {
        int damage = _generator.Next(_minDamage, _maxDamage);
        string message = $"{_state} dealt {damage} damage!";
        _log.Save(message);
        return damage;
    }

    /// <summary>
    /// The Hero receives the amount of damage specified in the parameter.
    /// The number of hit points will decrease accordingly
    /// </summary>
    public void ReceiveDamage(int points)
    {
        _hitPoints = _hitPoints - points;
        string message = $"{_state} receives {points} damage, and is down to {_hitPoints} hit points";
        _log.Save(message);

        if (Dead)
        {
            _log.Save($"{_state} died!");
        }
    }
    #endregion
}
