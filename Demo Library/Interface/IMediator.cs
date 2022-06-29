namespace Demo_Library.Interface;
public interface IMediator
{
    void Register(string key, IParticipant participant);
    void SendCommand(string receiver, string sender, string command);
}
