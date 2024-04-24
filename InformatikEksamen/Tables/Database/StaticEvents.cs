using informatikEksamen.Tables;
using InfomatikEksamen.Tables;
using System.Collections.Generic;
using System.Linq;

namespace informatikEksamen.Tables.Database;

public static partial class Database
{
    public static readonly List<Event> Events = new();

    public static Event? GetEventById(int id)
    {
        return Events.FirstOrDefault(Event => Event.Id == id);
    }
    
    public static List<Event> GetAllEvents()
    {
        return Events;
    }
}