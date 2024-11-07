using MTCG.CardClass;

namespace MTCG.UserClass
{
    public class User
    {
        #region Constructors
        public User()
        {
            Username = "";
            Password = "";
            Stack = [];
            Coins = 20;
            ELO = 100;
        }
        #endregion

        #region Credentials
        public string Username { get; private set; }
        public string Password { get; private set; }

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
            // Appropriate response is sent
        }
        #endregion

        #region Ressources
        public Card[] Stack { get; private set; }
        public Card[] Deck { get; private set; }
        public int Coins;

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
        public int ELO;

        public void Battle()
        {
            // This user and an opponent battle
            // Opponent is decided by the server
            // Winnner: +3 ELO, loser: -5 ELO
        }
        #endregion
    }
}