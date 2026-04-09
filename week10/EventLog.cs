
using System.Collections;

namespace week10;

public class EventLog : IEnumerable<Event>
{
    private readonly List<Event> _events = new List<Event>();

    public void AddEvent(Event ev)
    {
        _events.Add(ev);
    }
    
    public IEnumerator<Event> GetEnumerator()
    {
        foreach (var ev in _events)
        {
            yield return ev;
        }
    }
    
    public IEnumerator<Event> GetChronological()
    {
        foreach (var action in _events.OrderBy(action => action.Turn)) // сортування (`OrderBy`)
        {
            yield return action;
        }
    }

    public IEnumerator<Event> GetIncursionEvents()
    {
        foreach (var action in _events.Where(action => action.EventType.ToLower() == "incursion"))
        {
            yield return action;
        }
    }
    

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _events.GetEnumerator();
    }
}