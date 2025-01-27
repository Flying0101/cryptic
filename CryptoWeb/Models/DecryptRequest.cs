namespace CryptoWeb.Models
{
    public class DecryptRequest
    {
        public required string EncryptedText { get; set; }
        public required string Key { get; set; }
    }
}
