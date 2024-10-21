using System.Text;
using Jose;
using Newtonsoft.Json;

namespace TicketManagementUI.Security;

public class EncryptionHelper<T>(IConfiguration config) where T : class
{
    private byte[] GetSecretKey()
    {
        var encryptionKey =
            config["JWEKey"] ?? throw new InvalidOperationException("Secret key not found");

        return Encoding.UTF8.GetBytes(encryptionKey);
    }

    #region Public methods declaration

    public T? Decode(string token)
    {
        var result = JWT.Decode(token, GetSecretKey(), JweAlgorithm.A256KW, JweEncryption.A256CBC_HS512);
        return JsonConvert.DeserializeObject<T>(result);
    }

    public string Encode(object obj)
    {
        return JWT.Encode(obj, GetSecretKey(), JweAlgorithm.A256KW, JweEncryption.A256CBC_HS512);
    }

    #endregion
}