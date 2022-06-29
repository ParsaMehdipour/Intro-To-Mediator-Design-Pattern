using Demo_Library.Infra.Concrete;
using Demo_Library.Infra.Concrete.Mediator;

NetworkMediator mediator = new();

DesktopComputer Computer = new("Computer-1", mediator);
Server server = new("Server-1", mediator);

mediator.Register("computer-1", Computer);
mediator.Register("server-1", server);

Computer.SendCommand("server-1", "reboot");
server.SendCommand("computer-1", "trigger-updates");

Console.ReadKey();
