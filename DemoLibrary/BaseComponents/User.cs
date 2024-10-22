using DemoLibrary.Interfaces;

namespace DemoLibrary.BaseComponents;

/// <summary>
/// The Base Component provides the basic functionality of storing a
/// mediator's instance inside component objects.
/// All users in the chat room will inherit from this.
/// </summary>
public abstract class User
{
    protected IChatRoomMediator mediator;
    public string Name { get; }

    public User(IChatRoomMediator mediator, string name)
    {
        this.mediator = mediator;
        this.Name = name;
    }

    public abstract void Send(string message);
    public abstract void ReceiveMessage(string message, string sender);
}

