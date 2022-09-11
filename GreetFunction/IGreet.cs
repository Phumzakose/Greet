namespace GreetFunction;
interface IGreet
{
  string Greetings(string[] command);
  void AddUsers(string userName, int counter);
  Dictionary<string, int> GetList();
  string GreetedTimes(string userName);
  string Counter();
  string Clear();
  string Remove(string userName);
  void Help();
}