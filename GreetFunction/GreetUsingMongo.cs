using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;


namespace GreetFunction;

public class GreetUsingMongo : IGreet
{
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
    var client = new MongoClient("mongodb://0.0.0.0:27017");
    var database = client.GetDatabase("friends");
    var collection = database.GetCollection<Friends>("greet");


    var item = collection.Find(x => x.FirstName == userName).CountDocuments();
    var na = collection.Find(x => x.FirstName == userName).FirstOrDefault();

    if (item == 1)
    {
      na.Counter = Convert.ToInt32(item + 1);
      collection.ReplaceOne(x => x.FirstName == userName, na);
    }
    else
    {

      Friends doc = new Friends()
      {

        FirstName = userName,
        Counter = counter

      };
      collection.InsertOne(doc);


    }
  }
  public Dictionary<string, int> GetList()
  {
    var client = new MongoClient("mongodb://0.0.0.0:27017");
    var database = client.GetDatabase("friends");
    var collection = database.GetCollection<Friends>("greet");

    Dictionary<string, int> names = new Dictionary<string, int>();

    var doc = new BsonDocument();
    foreach (var item in collection.Find(doc).ToList())
    {
      names.Add(item.FirstName, item.Counter);
    }

    return names;

  }
  public string GreetedTimes(string userName)
  {

    var client = new MongoClient("mongodb://0.0.0.0:27017");
    var database = client.GetDatabase("friends");
    var collection = database.GetCollection<Friends>("greet");

    Dictionary<string, int> names = new Dictionary<string, int>();

    var doc = new BsonDocument();
    foreach (var item in collection.Find(doc).ToList())
    {
      names.Add(item.FirstName, item.Counter);
    }

    foreach (KeyValuePair<string, int> kv in names)
    {
      if (names.ContainsKey(userName))
      {
        return userName + " was greeted " + GetList()[userName] + " time/s";
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
    var client = new MongoClient("mongodb://0.0.0.0:27017");
    var database = client.GetDatabase("friends");
    var collection = database.GetCollection<Friends>("greet");

    Dictionary<string, int> names = new Dictionary<string, int>();

    var doc = new BsonDocument();
    foreach (var item in collection.Find(doc).ToList())
    {
      names.Add(item.FirstName, item.Counter);
    }

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
    var client = new MongoClient("mongodb://0.0.0.0:27017");
    var database = client.GetDatabase("friends");
    var collection = database.GetCollection<Friends>("greet");
    var doc = new BsonDocument();
    collection.DeleteMany(doc);

    return "Your list is cleared";
  }
  public string Remove(string userName)
  {
    var client = new MongoClient("mongodb://0.0.0.0:27017");
    var database = client.GetDatabase("friends");
    var collection = database.GetCollection<Friends>("greet");
    collection.DeleteOne(x => x.FirstName == userName);


    return userName + " was removed";

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
