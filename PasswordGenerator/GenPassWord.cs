using System.Text;

namespace PasswordGenerator
{
    public enum PasswordType
    {
        Numeric,
        AlphaLower,
        AlphaUpper,
        AlphaLowerUpper,
        AlphaNumericLower,
        AlphaNumericUpper,
        AlphaNumericLowerUpper
    }
    public class GenPassword
    {
        public string GeneratePassword(int length,PasswordType passwordType)
        {
            if (length < 6)
                throw new Exception("Password length should be atleast 6");
            string allowedChars = "";
            string password = "";
            switch (passwordType)
            {
                case PasswordType.Numeric:
                    allowedChars = "0123456789";
                    password = GenerateRandomPassword(length, allowedChars);
                    break;
                case PasswordType.AlphaLower:
                    allowedChars = "abcdefghijklmnopqrstuvwxyz";
                    password = GenerateRandomPassword(length, allowedChars);
                    break;
                case PasswordType.AlphaUpper:
                    allowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    password = GenerateRandomPassword(length, allowedChars);
                    break;
                case PasswordType.AlphaLowerUpper:
                    allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    password = GenerateRandomPassword(length, allowedChars);
                    break;
                case PasswordType.AlphaNumericLower:
                    allowedChars = "abcdefghijklmnopqrstuvwxyz0123456789";
                    password = GenerateRandomPassword(length, allowedChars);
                    break;
                case PasswordType.AlphaNumericUpper:
                    allowedChars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    password = GenerateRandomPassword(length, allowedChars);
                    break;
                case PasswordType.AlphaNumericLowerUpper:
                    allowedChars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                    password = GenerateRandomPassword(length, allowedChars);
                    break;
                default:
                    break;
            }
            return password;
        }

        private string GenerateRandomPassword(int length, string allowedChars)
        {
            Random random = new Random();
            StringBuilder sb = new StringBuilder(); 
            for(int i = 0; i < length; i++)
            {
                int index = random.Next(0, allowedChars.Length-1);
                sb.Append(allowedChars[index]);
            }
            return sb.ToString();
        }
    }
}