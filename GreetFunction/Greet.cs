namespace GreetFunction;
public class Greet : IGreet
{
  private string UserName { get; set; } = String.Empty;

  private static string Language { get; set; } = String.Empty;

  private Dictionary<string, int> names = new Dictionary<string, int>();
  public static string? userName = "";
  public static int counter = 1;

  public string Greetings(string[] command)
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
  public Dictionary<string, int> GetList()
  {

    return names;

  }

  public string GreetedTimes(string userName)
  {


    foreach (KeyValuePair<string, int> kv in names)
    {
      if (names.ContainsKey(userName))
      {
        return userName + " was greeted " + names[userName] + " time/s";
      }
      else
      {
        return "This name was not greeted";
      }

    }
    return "";

  }
  public string Counter()
  {
    if (names.Count != 0)
    {
      return "You have greeted " + names.Count() + " people";
    }
    else
    {
      return "There are no people greeted";
    }
  }
  public string Clear()
  {

    names.Clear();
    return "Your list is cleared";
  }
  public string Remove(string userName)
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



