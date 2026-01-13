using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

public class UserService
{
    private static string filePath = "users.json";

    public static List<User> LoadUsers()
    {
        if (!File.Exists(filePath))
            return new List<User>();

        string json = File.ReadAllText(filePath);
        return JsonConvert.DeserializeObject<List<User>>(json)
               ?? new List<User>();
    }

    public static void SaveUsers(List<User> users)
    {
        string json = JsonConvert.SerializeObject(users, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }
}