using System.Security.Cryptography.X509Certificates;

namespace MTCG
{
    public class User
    {
        #region Constructors
        public User() 
        {
            username = "default";
            password = "password";
        }
        public User(string username, string password)
        {
            this.username = username;
            this.password = password; // Hash here, hash somewhere else?
        }
        #endregion

        #region Credentials
        public string username { get; private set; }
        public string password { get; private set; }
        #endregion
    }
}