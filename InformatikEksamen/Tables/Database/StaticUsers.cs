using informatikEksamen.Tables;
using InfomatikEksamen.Tables;
using System.Collections.Generic;
using System.Linq;

namespace informatikEksamen.Tables.Database;

public static partial class Database
{
    public static readonly List<User> Users = new();

    public static User? GetUserById(int id)
    {
        return Users.FirstOrDefault(User => User.Id == id);
    }
    
    public static List<User> GetAllUsers()
    {
        return Users;
    }
}