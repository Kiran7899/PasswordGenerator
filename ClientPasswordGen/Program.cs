// See https://aka.ms/new-console-template for more information
using PasswordGenerator;

Console.WriteLine("Hello, World!");
GenPassword password = new GenPassword();
Console.WriteLine(password.GeneratePassword(41, PasswordType.Numeric));
Console.WriteLine(password.GeneratePassword(33, PasswordType.AlphaLower));
Console.WriteLine(password.GeneratePassword(41, PasswordType.AlphaUpper));
Console.WriteLine(password.GeneratePassword(32, PasswordType.AlphaLowerUpper));
Console.WriteLine(password.GeneratePassword(19, PasswordType.AlphaNumericUpper));
Console.WriteLine(password.GeneratePassword(18, PasswordType.AlphaNumericLower));
Console.WriteLine(password.GeneratePassword(16, PasswordType.AlphaNumericLowerUpper));
Console.WriteLine(password.GeneratePassword(1, PasswordType.AlphaNumericLowerUpper));
