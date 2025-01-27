namespace CryptoWeb.Models
{
    public class EncryptRequest
    {
        public required string PlainText { get; set; }
        public required string Key { get; set; }
    }
}
