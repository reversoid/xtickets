using System;
using System.Security.Cryptography;

namespace TodoApi.Shared.Utils;

public interface IKeyGenerator
{
    public (byte[] PublicKey, byte[] PrivateKey) GetKeys();
}

public class KeyGenerator : IKeyGenerator
{
    public (byte[] PublicKey, byte[] PrivateKey) GetKeys()
    {
        using ECDsa ecdsa = ECDsa.Create();

        return (ecdsa.ExportSubjectPublicKeyInfo(), ecdsa.ExportPkcs8PrivateKey());
    }
}
