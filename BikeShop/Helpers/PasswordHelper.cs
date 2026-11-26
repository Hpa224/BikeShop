using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;


namespace BikeShop.Helpers
{
    internal static class PasswordHelper
    {
        private const int SaltSize = 16;
        private const int HashSize = 32;
        private const int Iterations = 600000;

        internal static (string Hash, string Salt) HashPassword(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(SaltSize);
            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
                password,
                salt,
                Iterations,
                HashAlgorithmName.SHA256,
                HashSize);
            return (Convert.ToBase64String(hash),
                    Convert.ToBase64String(salt));
        }

        internal static bool VerifyPassword(string password,
                                            string storedHash,
                                            string storedSalt)
        {
            byte[] salt = Convert.FromBase64String(storedSalt);
            byte[] originalHash = Convert.FromBase64String(storedHash);

            byte[] computedHash = Rfc2898DeriveBytes.Pbkdf2(
                password,
                salt,
                Iterations,
                HashAlgorithmName.SHA256,
                HashSize);

            return CryptographicOperations.FixedTimeEquals(
                computedHash, originalHash);
        }
    } 
}
