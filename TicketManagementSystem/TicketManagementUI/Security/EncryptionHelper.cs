using System.Text;
using System.Text.Json.Serialization;
using Jose;
using Microsoft.AspNetCore.DataProtection;
using Newtonsoft.Json;

namespace TicketManagementUI.Security;

public class EncryptionHelper<T>(IConfiguration config) where T : class
{
    private readonly byte[] m_SecretKey = Encoding.UTF8.GetBytes(config["JWEKey"]);

    public string Encode(object obj)
    {
        return JWT.Encode(obj, m_SecretKey, JweAlgorithm.A256KW, JweEncryption.A256CBC_HS512);
    }

    public T Decode(string token)
    {
        var result = JWT.Decode(token, m_SecretKey, JweAlgorithm.A256KW, JweEncryption.A256CBC_HS512);
        return JsonConvert.DeserializeObject<T>(result);
    }
}