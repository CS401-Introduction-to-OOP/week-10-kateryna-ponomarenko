namespace week10;

public class Character
{
    public string Name { get; }
    public string Role { get; }
    public int Level { get; }
    public double HP { get; }
    public string Status { get; }

    public Character(string name, string role, int level, double hp, string status)
    {
        Name = name;
        Role = role;
        Status = status;
        HP = hp;
        Level = level;
    }
}