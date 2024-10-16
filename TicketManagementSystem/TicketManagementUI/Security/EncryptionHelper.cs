using System.Text;
using Jose;
using Newtonsoft.Json;

namespace TicketManagementUI.Security;

public class EncryptionHelper<T>(IConfiguration config) where T : class
{
    #region Private fields declaration

    private readonly byte[] m_SecretKey = Encoding.UTF8.GetBytes(config["JWEKey"]);

    #endregion

    #region Public methods declaration

    public T Decode(string token)
    {
        var result = JWT.Decode(token, m_SecretKey, JweAlgorithm.A256KW, JweEncryption.A256CBC_HS512);
        return JsonConvert.DeserializeObject<T>(result);
    }

    public string Encode(object obj)
    {
        return JWT.Encode(obj, m_SecretKey, JweAlgorithm.A256KW, JweEncryption.A256CBC_HS512);
    }

    #endregion
}