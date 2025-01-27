namespace CryptoWeb.Services
{
    public interface ICryptoService
    {
        (string encryptedText, string key) EncryptMessage(string plainText);

        string DecryptMessage(string encryptedText, string key);

    }

    public class CryptService : ICryptoService
    {
        private readonly IKeyService _keyService;

        public CryptService(IKeyService keyService)
        {
            _keyService = keyService;
        }

        public (string encryptedText, string key) EncryptMessage(string plainText)
        {
            string key = _keyService.GenerateKey(plainText.Length);
            string encryptedText = Encrypt(plainText, key);
            return (encryptedText, key);

        }
        public string DecryptMessage(string encryptedText, string key)
        {
            return Decrypt(encryptedText, key);
        }

        public string Encrypt(string plainText, string key)
        {
            return new string(plainText.Select(c => (char)(c + key.Length)).ToArray());
        }

        public string Decrypt(string encryptedText, string key)
        {
            return new string(encryptedText.Select(c => (char)(c - key.Length)).ToArray());
        }

    }
}
