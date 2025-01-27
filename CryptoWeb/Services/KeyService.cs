namespace CryptoWeb.Services
{
    public interface IKeyService
    {
        string GenerateKey(int length);
    }
    public class KeyService : IKeyService
    {
        private static readonly Random _random = new Random();
        public string GenerateKey(int length)
        {
            char[] key = new char[length];
            for (int i = 0; i < length; i++)
            {
                key[i] = (char)_random.Next(32, 127);
            }
            return new string(key);
        }
    }
}
