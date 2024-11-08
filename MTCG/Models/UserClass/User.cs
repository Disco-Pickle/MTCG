using MTCG.Models.CardClass;

namespace MTCG.Models.UserClass
{
    public class User
    {
        #region Constructors
        public User()
        {
            ID = S_NextID++;
            Username = "";
            Password = "";
            Token = "";
            Stack = [];
            Deck = [];
            Coins = 20;
            ELO = 100;
        }
        public User(string username, string password)
        {
            ID = S_NextID++;
            Username = username;
            Password = password;
            Token = "";
            Stack = [];
            Deck = [];
            Coins = 20;
            ELO = 100;
        }
        #endregion

        #region Credentials
        public int ID { get; }
        public static int S_NextID { get; set; } = 0; // Class-wide counter for IDs
        public string Username { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }

        public void Register()
        {
            // User is asked for username
            // User is asked for password
            // Credentials are sent to server, which saves them
        }
        public void Login()
        {
            // User is prompted for username
            // User is prompted for password
            // Credentials are compared to username-password pairs saved on server
            // Server sends a token, which is saved in their User object (implement logout which deletes token as well?)
        }
        #endregion

        #region Ressources
        public List<Card> Stack { get; } // Collections don't need setters, as they have functions to manage themselves
        public List<Card> Deck { get; }
        public int Coins { get; set; }

        public void AcquireCards()
        {
            // Initial set of random cards is put into user's Stack
        }
        public void TradeCards(Card givenCard, Card receivedCard)
        {
            // givenCard is traded for receivedCard
        }
        public void BuyPackage()
        {
            Coins -= 5;
            // 5 random cards are added to user's stack
        }
        public void BuildDeck()
        {
            // User selects 4 cards of their Stack, which are added to Deck
        }
        #endregion

        #region Competition
        public int ELO { get; set; }

        public void Battle()
        {
            // This user and an opponent battle
            // Opponent is decided by the server
            // Winnner: +3 ELO, loser: -5 ELO
            // Update both users on the server
        }
        #endregion

        #region Profile
        public void ViewProfile()
        {
            // Data is fetched from the server
            // A profile page is displayed in the console
        }
        public void EditProfile()
        {
            // User changes their username, password, or any other further properties
            // Changes are sent to the server
        }
        #endregion
    }
}