namespace GreetFunction;
public class Greet
{
  public string UserName { get; set; } = String.Empty;

  public static string Language { get; set; } = String.Empty;

  public static string? userCommand = Console.ReadLine();

  public Dictionary<string, int> names = new Dictionary<string, int>();
  public static string? userName = "";
  public static int counter = 1;


  public static string Greetings(string[] command)
  {
    if (command[0] == "greet" && command.Length == 3)
    {
      if (command[2] == "setswana" && command[0] == "greet")
      {
        return "Dumelang, le kae? " + command[1];
      }
      else if (command[2] == "isixhosa" && command[0] == "greet")
      {
        return "Molo, " + command[1];
      }
      else if (command[2] == "isizulu" && command[0] == "greet")
      {
        return "Sawubona, " + command[1];
      }
      else
      {
        return command[2] + " is not recognised";
      }
    }
    else if (command[0] == "greet" && command.Length == 2)
    {
      return "Hello, " + command[1];
    }
    return "";
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
  public static Dictionary<string, int> GetList(Dictionary<string, int> names)
  {
    return names;

  }

  public string GreetedTimes(Dictionary<string, int> names, string userName)
  {
    foreach (KeyValuePair<string, int> kv in names)
    {
      if (names.ContainsKey(userName))
      {
        return userName + " was greeted " + names[userName] + " time/s";
      }
      else
      {
        return "This names was not greeted";
      }

    }
    return "";

  }
  public int Counter(Dictionary<string, int> names)
  {
    return names.Count();
  }
  public string Clear(Dictionary<string, int> names)
  {
    names.Clear();
    return "Your list is cleared";
  }
  public string Remove(Dictionary<string, int> names, string userName)
  {
    if (names.ContainsKey(userName))
    {
      names.Remove(userName);
      return userName + " was removed";
    }
    return "";
  }
  public void Help()
  {
    Console.WriteLine(">To greet people enter greet, name and language");
    Console.WriteLine(">To see greeted people enter greeted");
    Console.WriteLine(">To check how many times a user was greeted enter greeted and name");
    Console.WriteLine(">To check how many people have been greeted enter counter");
    Console.WriteLine(">To remove someone in the list enter clear and the name");
    Console.WriteLine(">To delete all the people you have greeted enter clear");
    Console.WriteLine(">To exit the application enter exit");
  }

}



