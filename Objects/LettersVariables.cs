namespace FriendLetter.Objects
{
  public class LetterVariables
  {
    private string _recipient;

    public string GetRecipient()
    {
      return _recipient;
    }

    public void SetRecipient(string newRecipient)
    {
      _recipient = newRecipient;
    }
  }
}
