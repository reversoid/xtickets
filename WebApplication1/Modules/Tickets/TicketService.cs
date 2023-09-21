namespace XTickets.Modules.Tickets;

using System.Security.Cryptography;
using System.Text;
using TodoApi.Shared.Utils;

public interface ITicketService
{
    public (string TicketId, string Signature) SignTicket(string ticketId);
    public bool ValidateTicket(string ticketId, string signature);
}

public class TicketService : ITicketService
{
    private readonly (byte[] PublicKey, byte[] PrivateKey) _keys;

    private readonly HashAlgorithmName _hashAlgorythm = HashAlgorithmName.SHA256;

    public TicketService()
    {
        // ONLY FOR THE TEST PURPOSES
        KeyGenerator generator = new();
        _keys = generator.GetKeys();
    }

    public string CreateTicket()
    {
        Guid myUuid = Guid.NewGuid();
        string ticketId = myUuid.ToString();

        return ticketId;
    }

    public (string TicketId, string Signature) SignTicket(string ticketId)
    {
        byte[] ticketData = Encoding.UTF8.GetBytes(ticketId);

        using ECDsa ecdsa = ECDsa.Create();
        ecdsa.ImportPkcs8PrivateKey(_keys.PrivateKey, out _);

        byte[] signatureBytes = ecdsa.SignData(ticketData, _hashAlgorythm);

        return (ticketId, Convert.ToBase64String(signatureBytes));
    }

    public bool ValidateTicket(string ticketId, string signature)
    {
        byte[] ticketData = Encoding.UTF8.GetBytes(ticketId);
        byte[] signatureBytes = Convert.FromBase64String(signature);

        using ECDsa ecdsa = ECDsa.Create();
        ecdsa.ImportSubjectPublicKeyInfo(_keys.PublicKey, out _);

        return ecdsa.VerifyData(ticketData, signatureBytes, _hashAlgorythm);
    }

    public void SendTicket(int fromUserId, int toUserId, string ticketId)
    {
        throw new NotImplementedException();
    }
}
