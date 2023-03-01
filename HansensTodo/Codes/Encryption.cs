using Microsoft.AspNetCore.DataProtection;

namespace HansensTodo.Codes
{
    public class Encryption
    {
        private readonly IDataProtector _dataProtector;

        public Encryption(IDataProtectionProvider protector)
        {
            _dataProtector = protector.CreateProtector("HansensTodo.Codes.Encryption.MichaelGilbertHansen");
        }

        public string Protect(string valueToEncrypt) => _dataProtector.Protect(valueToEncrypt);

        public string UnProtect(string valueToDecrypt) => _dataProtector.Unprotect(valueToDecrypt);
    }
}
