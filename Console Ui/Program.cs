using DemoLibrary.BaseComponents;
using DemoLibrary.ConcreteComponents;
using DemoLibrary.ConcreteMediators;
using DemoLibrary.Interfaces;

IChatRoomMediator chatroom = new ChatRoom();

User alice = new ChatUser(chatroom, "Alice");
User bob = new ChatUser(chatroom, "Bob");
User charlie = new ChatUser(chatroom, "Charlie");

chatroom.AddUser(alice);
chatroom.AddUser(bob);
chatroom.AddUser(charlie);

alice.Send("Hello, everyone!");
bob.Send("Hi Alice, how are you?");
charlie.Send("Hey folks, what's up?");