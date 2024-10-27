namespace RentAToolWebApp.Services
{
    public class AuthService
    {
        private readonly Dictionary<string, string> _users = new()
        {
            { "sam", "123456" }//sample user
        };

        public void RegisterUser(string username, string password, string email)
        {
            //sample // store user in db later
            _users[username] = password;
        }

        public string? Authenticate(string username, string password)
        {
            string jwtToken = null;

            if(_users.TryGetValue(username,out var pwd) && pwd == password)
            {
                jwtToken = "jwt-token-sample123"; //sample jwt token
            }

            return jwtToken;
        }
    }
}
