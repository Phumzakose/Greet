using GreetFunction;
Greet user = new Greet();
Console.WriteLine("Welcome to the greetings App");
Console.WriteLine("Enter help for the available Commands");

string? userCommand = "";
int counter = 1;

string[] validCommands = { "greet username language", "greeted username", "greeted ", "counter", "clear", "exit", "help" };
while (userCommand != "exit")
{
  Console.WriteLine("****************************************************");
  Console.WriteLine(">Enter your Command:");

  userCommand = Console.ReadLine().ToLower();
  string[] command = userCommand.Trim().Split(" ");
  string userName = "";
  if (command.Length > 1)
  {
    userName = char.ToUpper(command[1][0]) + command[1].Substring(1);

  }

  if (command[0] == "greet" && command[1] != "" && command.Length == 3)
  {
    command[1] = userName;
    Console.WriteLine(Greet.Greetings(command));
    user.AddUsers(userName, counter);


  }
  else if (command[0] == "greet" && command.Length == 2)
  {
    command[1] = userName;
    Console.WriteLine(Greet.Greetings(command));
    user.AddUsers(userName, counter);
  }
  else if (userCommand == "greeted")
  {
    if (user.names.Count != 0)
    {
      foreach (KeyValuePair<string, int> kv in Greet.GetList(user.names))
      {
        Console.WriteLine(kv.Key + ":" + kv.Value);
      }
    }
    else
    {
      Console.WriteLine("You did not greet anyone");
    }
  }

  else if (command[0] == "greeted" && command[1] != "")
  {
    Console.WriteLine(user.GreetedTimes(user.names, userName));

  }
  else if (userCommand == "counter")
  {
    Console.WriteLine(user.Counter(user.names));

  }
  else if (userCommand == "clear")
  {
    Console.WriteLine(user.Clear(user.names));
  }
  else if (command[0] == "clear")
  {

    foreach (KeyValuePair<string, int> kv in user.names)
    {
      Console.WriteLine(user.Remove(user.names, userName));

    }
  }
  else if (userCommand == "help")
  {
    user.Help();
  }
  else if (!validCommands.Contains(userCommand))
  {
    Console.WriteLine("Invalid command");
  }
}











