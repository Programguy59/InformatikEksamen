using Eksamen.Tables;
using InfomatikEksamen.Tables;
using System.Collections.Generic;
using System.Linq;

namespace Eksamen.Tables.Database;

public static partial class Database
{
    public static readonly List<Item> Items = new();

    public static Item? GetItemById(int id)
    {
        return Items.FirstOrDefault(Item => Item.Id == id);
    }
    
    public static List<Item> GetAllItems()
    {
        return Items;
    }
}