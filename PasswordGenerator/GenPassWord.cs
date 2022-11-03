using System.Text;

namespace PasswordGenerator
{
    #region Method1
    /*
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
    public class GenPassWord
    {
        public string GeneratePassword(int length,PasswordType passwordType)
        {
            //if (length < 6)
            //    return "Password length cannot be less than 6!";
      
            Random random = new Random();
            StringBuilder str = new StringBuilder();

            int upperLength = 0;           
            int lowerLength = 0;
            int numericLength = 0;
            switch (passwordType)
            {
                case PasswordType.Numeric:
                    for(int i = 0; i < length; i++)
                    {
                        str.Append(randomInt());
                    }
                    break;
                case PasswordType.AlphaLower:
                    for(int i=0;i<length;i++)
                    {                 
                        str.Append(randomChar(true));
                    }
                    break;
                case PasswordType.AlphaUpper:
                    for (int i = 0; i < length; i++)
                    {                     
                        str.Append(randomChar(false));
                    }
                    break;
                case PasswordType.AlphaLowerUpper:
                    lowerLength = length / 2;
                    upperLength = length / 2 + length % 2;
                    for (int i = 0; i < length / 2; i++)
                    {
                        str.Append(randomChar(true));
                    }
                    for(int i=0;i<upperLength;i++)
                    {
                        str.Append(randomChar(false));
                    }
                    break;
                case PasswordType.AlphaNumericLower:
                    lowerLength = length / 2;
                    numericLength = length / 2 + length % 2;
                    for(int i=0;i<lowerLength;i++)
                    {
                        str.Append(randomChar(true));
                    }
                    for(int i=0;i<=numericLength;i++)
                    {
                        str.Append(randomInt());
                    }
                    break;

                case PasswordType.AlphaNumericUpper:
                    upperLength = length / 2;
                    numericLength =  length / 2 + length % 2;
                    for(int i=0;i<upperLength;i++)
                    {
                        str.Append(randomChar(false));
                    }
                    for(int i=0;i<numericLength;i++)
                    {
                        str.Append(randomInt());
                    }
                    break;
                case PasswordType.AlphaNumericLowerUpper:
                    numericLength = length / 3;
                    lowerLength = length / 3;
                    upperLength = length % 3 + length / 3;
                    for(int i = 0; i < numericLength; i++)
                    {
                        str.Append(randomInt());
                    }
                    for (int i = 0; i < lowerLength; i++)
                    {
                        str.Append(randomChar(true));
                    }
                    for(int i=0;i<upperLength;i++)
                    {
                        str.Append(randomChar(false));
                    }
                    break;

            }

            return ShufflePassword(str.ToString());
        }
        private string ShufflePassword(string password)
        {
            int length = password.Length;
            HashSet<int> index = new HashSet<int>();
            StringBuilder str = new StringBuilder();    
            Random random = new Random();
            while(index.Count != length)
            {
                int val = random.Next(0,length-1);
                if (!index.Contains(val))
                {
                    index.Add(val);
                    str.Append(password[val]);
                }
            }
            return str.ToString();
        }
        private int randomInt()
        {
            Random r = new Random();
            return r.Next(0, 9);
        }
        private char randomChar(bool isLower)
        {
            Random random = new Random();   
            int num = random.Next(0, 25);
            char ch = '.';
            if(isLower)
            {
                ch = (char)(97 + num);
            }
            else
            {
                ch = (char)(65 + num);
            }
            return ch;
        }
    }
    */
    #endregion

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