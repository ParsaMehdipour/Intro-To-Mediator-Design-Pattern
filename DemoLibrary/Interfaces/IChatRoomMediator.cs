using DemoLibrary.BaseComponents;

namespace DemoLibrary.Interfaces;

/// <summary>
/// The Mediator interface declares a method used by components to notify the
/// mediator about various events. The Mediator may react to these events and
/// pass the execution to other components.
/// </summary>
public interface IChatRoomMediator
{
    void SendMessage(string message, User sender);
    void AddUser(User user);
}
