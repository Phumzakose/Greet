using GreetFunction;


Console.WriteLine("Enter your command to start");
string? userName = "";
string? Language = "";
string? userCommand = "";

Dictionary<string, int> names = new Dictionary<string, int>();

int counter = 1;

string[] validCommands = { "greet", "greeted", "greeted user", "counter", "clear", "delete", "remove", "exit", "help" };

while (userCommand != "exit")
{
  userCommand = Console.ReadLine().ToLower();

  if (!validCommands.Contains(userCommand))
  {
    Console.WriteLine("Invalid command");
  }


  if (userCommand == "greet")
  {
    Console.WriteLine("Please enter your name");
    userName = Console.ReadLine().ToLower();
    if (userName != "")
    {
      Console.WriteLine("Please select the language you want to be greeted with between IsiXhosa, Setswana and IsiZulu");
      Language = Console.ReadLine();
      Console.WriteLine(Greet.Greetings(userName, Language));
      if (names.ContainsKey(userName))
      {
        names[userName]++;
      }
      else
      {
        names.Add(userName, counter);
      }

      Console.WriteLine("Enter greet command to greet again");
    }
    else
    {
      Console.WriteLine("Please make sure you enter your name and use greet command to start again");
    }
  }

  else if (userCommand == "greeted")
  {
    // foreach (KeyValuePair<string, int> kv in names)
    // {
    //   Console.WriteLine(kv.Key + ":" + kv.Value);

    // }
    Console.WriteLine(Greet.GetList(names));
  }
  if (userCommand == "greeted user")
  {
    Console.WriteLine("Enter the name you want check");
    userName = Console.ReadLine();
    // if (names.ContainsKey(userName))
    // {
    //   Console.WriteLine("This name was greeted" + ":" + names[userName]);
    // }
    // else
    // {
    //   Console.WriteLine("This name does not exist");
    // }
    Console.WriteLine(Greet.GreetedTimes(names));
  }


  if (userCommand == "counter")
  {
    // Console.WriteLine(names.Count());
    Console.WriteLine(Greet.Counter(names));
  }
  if (userCommand == "clear")
  {
    Console.WriteLine("Do you want to delete the list or remove one person");
    string answer = Console.ReadLine();
    if (answer == "remove")
    {
      Console.WriteLine("Please enter the name you want to remove");
      userName = Console.ReadLine();
      foreach (KeyValuePair<string, int> kv in names)
      {
        if (names.ContainsKey(userName))
        {
          names.Remove(userName);
          Console.WriteLine(names.Count());
        }

      }
    }
    else if (answer == "delete")
    {
      names.Clear();
      Console.WriteLine(names.Count());
    }

  }

  if (userCommand == "help")
  {
    Console.WriteLine(">To greet people enter greet");
    Console.WriteLine(">To see people who in list enter greeted");
    Console.WriteLine(">To check how many times a user was greeted enter greeted user");
    Console.WriteLine(">To check how many people have been greeted enter counter");
    Console.WriteLine(">To delete and remove people in the list enter clear");
    Console.WriteLine(">To exit the application enter exit");
  }

}








