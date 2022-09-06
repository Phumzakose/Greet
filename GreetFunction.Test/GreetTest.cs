
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
    Assert.Equal("Hello, Zikho", Greet.Greetings(new string[] { "greet", "Zikho" }));
  }
  [Fact]
  public void ItShouldbeAbleToReturnErrorMesssage()
  {
    Assert.Equal("sepedi is not recognised", Greet.Greetings(new string[] { "greet", "Zikho", "sepedi" }));
  }
  [Fact]
  public void ItShouldBeAbleToReturnTheListOfPeopleGreeted()
  {
    Greet.Greetings(new string[] { "greet", "Lulo", "IsiZulu" });
    Greet.Greetings(new string[] { "greet", "Lulo", "IsiZulu" });
    Greet.Greetings(new string[] { "greet", "Phumza", "IsiZulu" });
    Greet.Greetings(new string[] { "greet", "Lakhe", "IsiZulu" });

    Dictionary<string, int> greeted = new Dictionary<string, int>() { { "Phumza", 1 }, { "Lakhe:", 1 }, { "Lulo", 2 } };
    Assert.Equal(greeted, Greet.GetList(greeted));

    Greet.Greetings(new string[] { "greet", "Phumza", "IsiZulu" });
    Greet.Greetings(new string[] { "greet", "Lakhe", "IsiZulu" });
    Dictionary<string, int> names = new Dictionary<string, int>() { { "Phumza", 1 }, { "Lakhe:", 1 } };
    Assert.Equal(names, Greet.GetList(names));

  }
  [Fact]
  public void ItShouldBeAbleToReturnHowManyTimesTheUserWasGreeted()
  {
    Greet.Greetings(new string[] { "greet", "Lulo", "isizulu" });
    Greet.Greetings(new string[] { "greet", "Lulo", "isixhosa" });
    Dictionary<string, int> names = new Dictionary<string, int>() { { "Lulo", 2 } };
    Assert.Equal("Lulo was greeted 2 time/s", user.GreetedTimes(names, "Lulo"));

  }
  [Fact]
  public void ItShouldBeAbleToReturnErrorMessageIfTheUserDoesNotExist()
  {
    Greet.Greetings(new string[] { "greet", "Lulo", "isizulu" });
    Greet.Greetings(new string[] { "greet", "Lulo", "isixhosa" });
    Dictionary<string, int> names = new Dictionary<string, int>() { { "Lulo", 2 } };
    Assert.Equal("This names was not greeted", user.GreetedTimes(names, "Thuso"));

  }

  [Fact]
  public void ItShouldBeAbleToReturnTheNumberOfUsersGreeted()
  {
    Greet.Greetings(new string[] { "greet", "Lulo", "IsiZulu" });
    Greet.Greetings(new string[] { "greet", "Lulo", "IsiZulu" });
    Greet.Greetings(new string[] { "greet", "Phumza", "IsiZulu" });
    Greet.Greetings(new string[] { "greet", "Lakhe", "IsiZulu" });
    Dictionary<string, int> names = new Dictionary<string, int>() { { "Phumza", 1 }, { "Lakhe:", 1 }, { "Lulo", 2 } };
    Assert.Equal("You have greeted 3 people", user.Counter(names));

  }
  [Fact]
  public void ItShouldBeAbleToReturnErrorMessageIfThereAreNoUsersGreeted()
  {
    Dictionary<string, int> names = new Dictionary<string, int>() { };
    Assert.Equal("There are no people greeted", user.Counter(names));

  }
  [Fact]
  public void ItShouldBeAbleToClearAllThePeopleInTheList()
  {
    Greet.Greetings(new string[] { "greet", "Lulo", "IsiZulu" });
    Greet.Greetings(new string[] { "greet", "Phumza", "IsiZulu" });
    Greet.Greetings(new string[] { "greet", "Lakhe", "IsiZulu" });
    Dictionary<string, int> names = new Dictionary<string, int>() { { "Phumza", 1 }, { "Lakhe:", 1 }, { "Lulo", 2 } };
    Assert.Equal("Your list is cleared", user.Clear(names));

  }
  [Fact]
  public void ItShouldBeAbleToRemoveOnePersonFromTheList()
  {
    Greet.Greetings(new string[] { "greet", "Lulo", "IsiZulu" });
    Greet.Greetings(new string[] { "greet", "Phumza", "IsiZulu" });
    Greet.Greetings(new string[] { "greet", "Lakhe", "IsiZulu" });
    Dictionary<string, int> names = new Dictionary<string, int>() { { "Lakhe:", 1 }, { "Lulo", 1 }, { "Phumza", 1 } };
    Assert.Equal("Phumza was removed", user.Remove(names, "Phumza"));

  }


}