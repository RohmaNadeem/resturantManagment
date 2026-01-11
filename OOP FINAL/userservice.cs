using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class UserService
{
    public static List<User> LoadUsers()
    {
        string json = File.ReadAllText("users.json");
        return JsonConvert.DeserializeObject<List<User>>(json);
    }
}