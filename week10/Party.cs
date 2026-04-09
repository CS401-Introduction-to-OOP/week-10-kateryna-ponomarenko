using System.Collections;

namespace week10;

public class Party : IEnumerable<Character>
{
    private readonly List<Character> _characters = new List<Character>();

    public void AddCharater(Character player)
    {
        _characters.Add(player);
    }

    public IEnumerator<Character> GetEnumerator()
    {
        foreach (var character in _characters)
        {
            yield return character;
        }
    }

    public IEnumerator<Character> GetEnumeratorActive()
    {
        foreach (var character in _characters.Where(player => player.Status.ToLower() == "active" ))
        {
            yield return character;
        }
    }

    public void PartyInfo()
    {
        foreach (var group in _characters.GroupBy(player => player.Role))
        {
            Console.WriteLine($"role has {group.Count()} - {group}");
           
            foreach (var names in group.Select( player => player.Name) )
            {
                Console.WriteLine(names);
            }
            
        }
    }
    

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _characters.GetEnumerator();
    }
}