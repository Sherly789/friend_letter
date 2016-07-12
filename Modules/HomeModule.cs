using Nancy;

namespace FriendLetter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>View["hello.html"];
        LetterVariables myLetterVariables = new LetterVariables();
        myLetterVariables.SetRecipient("Jessica");
        return View["hello.cshtml", myLetterVariables];
      Get["/favorite_photos"] = _ => View["favorite_photos.html"];

    }
  }
}
