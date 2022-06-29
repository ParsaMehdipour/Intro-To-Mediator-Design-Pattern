using Demo_Library.Interface;

namespace Demo_Library.Infra.Concrete.Mediator;

public class NetworkMediator : IMediator
{
    private Dictionary<string, IParticipant> participants;

    public NetworkMediator()
    {
        participants = new Dictionary<string, IParticipant>();
    }

    public void Register(string key, IParticipant participant)
    {
        participants[key] = participant;
    }

    public void SendCommand(string receiver, string sender, string command)
    {
        if (participants.ContainsKey(receiver))
        {
            participants[receiver].ReceiveCommand(sender, command);
        }
    }
}
