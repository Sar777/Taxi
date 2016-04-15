namespace TaxiSystem.Auth
{
    public class AuthToken
    {
        public string Username { get; private set; }
        public string PasswordHash { get; private set; }

        public AuthToken(string username, string passwordHash)
        {
            this.Username = username;
            this.PasswordHash = passwordHash;
        }
    }
}
