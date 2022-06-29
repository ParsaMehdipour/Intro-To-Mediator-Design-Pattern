namespace Demo_Library.Interface;
public interface IParticipant
{
    void SendCommand(string receiver, string command);
    void ReceiveCommand(string sender, string command);
}
