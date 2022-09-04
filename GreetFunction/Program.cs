using GreetFunction;
Greet user = new Greet();
Console.WriteLine("Enter help for the available Commands");
string userName = "";
string? Language = "";
string? userCommand = "";

//Dictionary<string, int> names = new Dictionary<string, int>();
int counter = 1;

string[] validCommands = { "greet", "greeted", "greeted user", "counter", "clear", "delete", "remove", "exit", "help" };

while (userCommand != "exit")
{
  Console.WriteLine("****************************************************");
  Console.WriteLine(">Enter your Command:");

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
      // if (user.names.ContainsKey(userName))
      // {
      //   user.names[userName]++;
      // }
      // else
      // {
      //   user.names.Add(userName, counter);
      // }
      user.AddUsers(userName, counter);
    }
    else
    {
      Console.WriteLine("Please make sure you enter your name and use greet command to start again");
    }
  }



  else if (userCommand == "greeted")
  {
    foreach (KeyValuePair<string, int> kv in user.GetList(user.names))
    {
      Console.WriteLine(kv.Key + ":" + kv.Value);

    }
    //Console.WriteLine(user.GetList(user.names));

  }
  if (userCommand == "greeted user")
  {
    Console.WriteLine("Enter the name you want check");
    userName = Console.ReadLine();
    if (user.names.ContainsKey(userName))
    {
      Console.WriteLine("This name was greeted" + ":" + user.names[userName]);
    }
    else
    {
      Console.WriteLine("This name does not exist");
    }
    //Console.WriteLine(Greet.GreetedTimes(names));
  }


  if (userCommand == "counter")
  {
    Console.WriteLine(user.names.Count());

  }
  if (userCommand == "clear")
  {
    Console.WriteLine("Do you want to delete the list or remove one person");
    string answer = Console.ReadLine();
    if (answer == "remove")
    {
      Console.WriteLine("Please enter the name you want to remove");
      userName = Console.ReadLine();
      foreach (KeyValuePair<string, int> kv in user.names)
      {
        if (user.names.ContainsKey(userName))
        {
          user.names.Remove(userName);
          Console.WriteLine(user.names.Count());
        }
      }
    }
    else if (answer == "delete")
    {
      user.names.Clear();
      Console.WriteLine("You have cleared your list");
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









