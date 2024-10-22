using DemoLibrary.BaseComponents;
using DemoLibrary.Interfaces;

namespace DemoLibrary.ConcreteComponents;

/// <summary>
/// Concrete Components implement various functionality. They don't depend on
/// other components. They also don't depend on any concrete mediator
/// classes.
/// </summary>
public class ChatUser : User
{
    public ChatUser(IChatRoomMediator mediator, string name) : base(mediator, name)
    {
    }

    public override void Send(string message)
    {
        Console.WriteLine($"{Name} sends: {message}");
        mediator.SendMessage(message, this);
    }

    public override void ReceiveMessage(string message, string sender)
    {
        Console.WriteLine($"{Name} receives: {message} (from {sender})");
    }
}
