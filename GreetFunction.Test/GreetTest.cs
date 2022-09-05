
namespace GreetFunction.Test;
public class GreetTest
{
  Greet user = new Greet();

  [Fact]
  public void ItShouldbeAbleToGreetUserWithIsiXhosa()
  {
    Assert.Equal("Molo, Phumza", Greet.Greetings(new string[] { "greet", "Phumza", "isixhosa" }));

  }
  [Fact]
  public void ItShouldbeAbleToGreetUserWithSetswana()
  {
    Assert.Equal("Dumelang, le kae? Thembi", Greet.Greetings(new string[] { "greet", "Thembi", "setswana" }));
  }
  [Fact]
  public void ItShouldbeAbleToGreetUserWithIsizulu()
  {
    Assert.Equal("Sawubona, Lukho", Greet.Greetings(new string[] { "greet", "Lukho", "isizulu" }));
  }
  [Fact]
  public void ItShouldbeAbleToGreetUserWithEnglishIfNoLanguageIsEntered()
  {
    Assert.Equal("Hello, Zikho", Greet.Greetings(new string[] { "greet", "Zikho", "" }));
  }
  [Fact]
  public void ItShouldBeAbleToReturnTheListOfPeopleGreeted()
  {
    Greet.Greetings(new string[] { "greet", "Lulo", "IsiZulu" });
    Greet.Greetings(new string[] { "greet", "Lulo", "IsiZulu" });
    Greet.Greetings(new string[] { "greet", "Phumza", "IsiZulu" });
    Greet.Greetings(new string[] { "greet", "Lakhe", "IsiZulu" });

    Dictionary<string, int> people = new Dictionary<string, int>() { { "Phumza", 1 }, { "Lakhe:", 1 }, { "Lulo", 2 } };
    Assert.Equal(people, Greet.GetList(people));

    Greet.Greetings(new string[] { "greet", "Phumza", "IsiZulu" });
    Greet.Greetings(new string[] { "greet", "Lakhe", "IsiZulu" });
    Dictionary<string, int> names = new Dictionary<string, int>() { { "Phumza", 1 }, { "Lakhe:", 1 } };
    Assert.Equal(names, Greet.GetList(names));

  }
  // [Fact]
  // public void ItShouldBeAbleToReturnHowManyTimesTheUserWasGreeted()
  // {
  //   Greet.Greetings(new string[] { "greet", "Lulo", "isizulu" });
  //   Greet.Greetings(new string[] { "greet", "Lulo", "isixhosa" });
  //   Dictionary<string, int> people = new Dictionary<string, int>() { { "Lulo", 2 } };
  //   Assert.Equal("Lulo was greeted 2 time/s", user.GreetedTimes(people));

  // }
  // [Fact]
  // public void ItShouldBeAbleToReturnErrorMessageIfTheUserDoesNotExist()
  // {
  //   Assert.Equal("This names was not greeted", user.GreetedTimes(user.names));

  // }

  [Fact]
  public void ItShouldBeAbleToReturnTheNumberOfUsersGreeted()
  {
    Greet.Greetings(new string[] { "greet", "Lulo", "IsiZulu" });
    Greet.Greetings(new string[] { "greet", "Lulo", "IsiZulu" });
    Greet.Greetings(new string[] { "greet", "Phumza", "IsiZulu" });
    Greet.Greetings(new string[] { "greet", "Lakhe", "IsiZulu" });
    Dictionary<string, int> people = new Dictionary<string, int>() { { "Phumza", 1 }, { "Lakhe:", 1 }, { "Lulo", 2 } };
    Assert.Equal(3, user.Counter(people));

  }
  [Fact]
  public void ItShouldBeAbleToClearAllThePeopleInTheList()
  {
    Greet.Greetings(new string[] { "greet", "Lulo", "IsiZulu" });
    Greet.Greetings(new string[] { "greet", "Phumza", "IsiZulu" });
    Greet.Greetings(new string[] { "greet", "Lakhe", "IsiZulu" });
    Dictionary<string, int> people = new Dictionary<string, int>() { { "Phumza", 1 }, { "Lakhe:", 1 }, { "Lulo", 2 } };
    Assert.Equal("Your list is cleared", user.Clear(people));

  }
  // [Fact]
  // public void ItShouldBeAbleToRemoveOnePersonFromTheList()
  // {
  //   Greet.Greetings(new string[] { "greet", "Lulo", "IsiZulu" });
  //   Greet.Greetings(new string[] { "greet", "Phumza", "IsiZulu" });
  //   Greet.Greetings(new string[] { "greet", "Lakhe", "IsiZulu" });
  //   Dictionary<string, int> people = new Dictionary<string, int>() { { "Lakhe:", 1 }, { "Lulo", 2 } };
  //   Assert.Equal("Phumza was removed", user.Remove(people));

  // }


}