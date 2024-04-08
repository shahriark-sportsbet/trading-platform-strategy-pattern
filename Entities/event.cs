using Simulator.Enum;

namespace Simulator.Event;

public class Event
{
    public Competation competation;
    public int line;
    public Event(Competation competation, int line)
    {
        this.competation = competation;
        this.line = line;
    }
}