
public class CCombatStats 
{
    public int health;
    public int attack;
    public int defense;
    public int dexterity;
    public int magic;
    public int luck;

    public CCombatStats(int _health, int _attack, int _defense, int _dexterity, int _magic, int _luck)
    {
        health = _health;
        attack = _attack;
        defense = _defense;
        dexterity  = _dexterity;
        magic = _magic;
        luck = _luck;
    }

    public static CCombatStats operator +(CCombatStats a, CCombatStats b)
    => new CCombatStats(
        a.health + b.health,
        a.attack + b.attack,
        a.defense + b.defense,
        a.dexterity + b.dexterity,
        a.magic + b.magic,
        a.luck + b.luck);

    public static CCombatStats operator -(CCombatStats a, CCombatStats b)
    => new CCombatStats(
        a.health - b.health,
        a.attack - b.attack,
        a.defense - b.defense,
        a.dexterity - b.dexterity,
        a.magic - b.magic,
        a.luck - b.luck);

    public override string ToString()
    => $"health: {health} \n" +
       $"attack: {attack} \n" +
       $"defense: {defense} \n" +
       $"dexterity: {dexterity} \n" +
       $"magic: {magic} \n" +
       $"luck: {luck} \n";

}
