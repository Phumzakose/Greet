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
  string[] command = userCommand.Split(" ");
  string userName = "";
  if (command.Length > 1)
  {
    userName = command[1];
  }

  if (command[0] == "greet" && command[2] != "")
  {
    command[1] = userName;
    Console.WriteLine(Greet.Greetings(command));
    user.AddUsers(userName, counter);


  }
  else if (userCommand == "greeted")
  {
    foreach (KeyValuePair<string, int> kv in Greet.GetList(user.names))
    {
      Console.WriteLine(kv.Key + ":" + kv.Value);
    }
  }

  else if (command[0] == "greeted" && command[1] != "")
  {
    if (user.names.ContainsKey(userName))
    {
      Console.WriteLine("This name was greeted" + ":" + user.names[userName]);
    }
    else
    {
      Console.WriteLine("This name does not exist");
    }
    //Console.WriteLine(user.GreetedTimes(user.names));

  }


  else

  if (userCommand == "counter")
  {
    Console.WriteLine(user.names.Count());

  }
  else if (userCommand == "clear")
  {
    user.names.Clear();
    Console.WriteLine(user.Clear(user.names));
  }
  else if (command[0] == "clear")
  {

    foreach (KeyValuePair<string, int> kv in user.names)
    {
      command[1] = userName;
      if (user.names.ContainsKey(userName))
      {
        user.names.Remove(userName);
        Console.WriteLine(userName + " was removed");
      }
    }
  }


  if (userCommand == "help")
  {
    user.Help();
  }
}











