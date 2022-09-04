namespace GreetFunction;
public class Greet
{
  public string UserName { get; set; } = String.Empty;

  public static string Language { get; set; } = String.Empty;

  public static string? userCommand = Console.ReadLine();

  public Dictionary<string, int> names = new Dictionary<string, int>();
  public static string? userName = "";
  public static int counter = 1;
  //public static string answer = Console.ReadLine();

  public static string Greetings(string name, string Language)

  {
    if (Language == "Setswana")
    {
      return "Dumelang, le kae? " + name;
    }
    else if (Language == "IsiXhosa")
    {
      return "Molo, " + name;
    }
    else if (Language == "IsiZulu")
    {
      return "Sawubona, " + name;
    }
    else
    {
      return "Hello, " + name;
    }

  }
  public void AddUsers(string userName, int counter)
  {
    if (names.ContainsKey(userName))
    {
      names[userName]++;
    }
    else
    {
      names.Add(userName, counter);
    }
  }
  public Dictionary<string, int> GetList(Dictionary<string, int> names)
  {
    // foreach (KeyValuePair<string, int> kv in names)
    // {
    // return kv.Key + ":" + kv.Value;
    return names;

    //}

  }
  // public static string GreetedTimes(Dictionary<string, int> names)
  // {
  //   foreach (KeyValuePair<string, int> kv in names)
  //   {

  //     if (names.ContainsKey(userName))
  //     {
  //       return "This name was greeted:" + names[userName];
  //     }
  //     else
  //     {
  //       return "This name does not exist";
  //     }
  //   }
  //   return "";
  // }
  // public static int Counter(Dictionary<string, int> names)
  // {
  //   return names.Count();
  // }
  // public static int Remove(Dictionary<string, int> names, string answer)
  // {
  //   if (answer == "remove")
  //   {
  //     foreach (KeyValuePair<string, int> kv in names)
  //     {
  //       if (names.ContainsKey(userName))
  //       {
  //         names.Remove(userName);
  //         return (names.Count());
  //       }

  //     }
  //   }
  //   return 0;
  // }


}



