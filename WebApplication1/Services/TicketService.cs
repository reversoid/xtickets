namespace TodoApi.Services;

using System.Security.Cryptography;
using System.Text;
using TodoApi.Shared.Utils;

public interface ITicketService
{
    public (string TicketId, string Signature) SignTicket(string ticketId);
    public bool ValidateSignature(string ticketId, string signature);
}

public class TicketService : ITicketService
{
    private readonly (byte[] PublicKey, byte[] PrivateKey) _keys;

    private readonly HashAlgorithmName HashAlgorythm = HashAlgorithmName.SHA256;

    public TicketService()
    {
        KeyGenerator generator = new();
        _keys = generator.GetKeys();
    }

    public (string TicketId, string Signature) SignTicket(string ticketId)
    {
        byte[] ticketData = Encoding.UTF8.GetBytes(ticketId);

        using ECDsa ecdsa = ECDsa.Create();
        ecdsa.ImportPkcs8PrivateKey(_keys.PrivateKey, out _);

        byte[] signatureBytes = ecdsa.SignData(ticketData, HashAlgorythm);
        
        return (ticketId, Convert.ToBase64String(signatureBytes));
    }

    public bool ValidateSignature(string ticketId, string signature)
    {
        byte[] ticketData = Encoding.UTF8.GetBytes(ticketId);
        byte[] signatureBytes = Convert.FromBase64String(signature);

        using ECDsa ecdsa = ECDsa.Create();
        ecdsa.ImportSubjectPublicKeyInfo(_keys.PublicKey, out _);

        return ecdsa.VerifyData(ticketData, signatureBytes, HashAlgorythm);
    }
}
