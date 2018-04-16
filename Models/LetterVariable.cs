namespace FriendLetter.Models
{
  public class LetterVariable
  {
    private string _recipient;
    private string _sender;
    private string _location;
    private string _items;

    public string GetLocation();
    {
      return _location;
    }
    public void SetLocation(string newLocation)
    {
      _location = newLocation;
    }
    public string GetItems()
    {
      return _items;
    }
    public void SetItems(string newItems)
    {
      _items = newItems
    }

    public string GetRecipient()
    {
      return _recipient;
    }

    public void SetRecipient(string newRecipient)
    {
      _recipient = newRecipient;
    }
    public string GetSender()
    {
      return _sender;
    }
    public void SetSender(string newSender)
    {
      _sender = newSender;
    }
  }
}
