using informatikEksamen.Tables;
using InfomatikEksamen.Tables;
using System.Collections.Generic;
using System.Linq;

namespace informatikEksamen.Tables.Database;

public static partial class Database
{
    public static readonly List<EventItem> EventItems = new();

    public static EventItem? GetEventItemById(int id)
    {
        return EventItems.FirstOrDefault(EventItem => EventItem.Id == id);
    }
    
    public static List<EventItem> GetAllEventItems()
    {
        return EventItems;
    }
}