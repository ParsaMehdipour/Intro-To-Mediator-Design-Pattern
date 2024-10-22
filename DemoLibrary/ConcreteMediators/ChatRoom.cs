using DemoLibrary.BaseComponents;
using DemoLibrary.Interfaces;

namespace DemoLibrary.ConcreteMediators;

/// <summary>
/// Concrete Mediators implement cooperative behavior by coordinating several
/// components. 
/// </summary>
public class ChatRoom : IChatRoomMediator
{
    private List<User> users;

    public ChatRoom()
    {
        users = new List<User>();
    }

    public void AddUser(User user)
    {
        users.Add(user);
    }

    public void SendMessage(string message, User sender)
    {
        foreach (var user in users)
        {
            // Don't send the message to the sender
            if (user != sender)
            {
                user.ReceiveMessage(message, sender.Name);
            }
        }
    }
}
