namespace week10;

public class Event
{
    public int Turn { get; }
    public string Description { get; }
    public string EventType { get; }
    // public string CharacteristicChanges { get; }

    public Event(int turn, string description, string eventType)
    {
        Turn = turn;
        Description = description;
        EventType = eventType;
    }
}