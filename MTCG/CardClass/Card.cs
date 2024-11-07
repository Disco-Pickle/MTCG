namespace MTCG.CardClass
{
    public abstract class Card
    {
        #region Constructors
        public Card()
        {
            name = "";
            damage = 0;
            element = "";
        }
        public Card(string name, int damage, string element)
        {
            this.name = name;
            this.damage = damage;
            this.element = element;
        }
        #endregion

        #region Attributes
        public string name { get; private set; }
        public int damage { get; private set; }
        public string element { get; private set; }
        #endregion
    }
}