namespace week10;

class Program
{
    static void Main(string[] args)
    {
        Party heroParty = new Party();
        
        var pl1 = new Character("Arthas", "Warrior", 80, 5000, "Active");
        var pl3 = new Character("Jaina", "Mage", 82, 3200, "Offline");
        var pl4 = new Character("Khadgar", "Mage", 90, 3500, "Active");
        var pl5 = new Character("Sylvanas", "Archer", 88, 3800, "Active");
        var pl9 = new Character("Garrosh", "Warrior", 75, 5500, "Offline");
        
        heroParty.AddCharater(pl1);
        heroParty.AddCharater(pl9);
        heroParty.AddCharater(pl3);
        heroParty.AddCharater(pl4);
        heroParty.AddCharater(pl5);

        Event ev1 = new Event(1,"sm happened", "incursion");
        Event ev2 = new Event(2,"sm happened", "attak");
        Event ev3 = new Event(3,"sm happened", "incursion");

        EventLog log = new EventLog();
        
        log.AddEvent(ev1);
        log.AddEvent(ev2);
        log.AddEvent(ev3);

        log.GetChronological();
        log.GetIncursionEvents();
        







    }
}