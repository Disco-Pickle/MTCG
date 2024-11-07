namespace MTCG.CardClass
{
    public abstract class Card
    {
        #region Constructors
        public Card()
        {
            Name = "";
            Damage = 0;
            Element = "";
        }
        public Card(string name, int damage, string element)
        {
            Name = name;
            Damage = damage;
            Element = element;
        }
        #endregion

        #region Attributes
        public string Name { get; private set; }
        public int Damage { get; } // No setter = read only property (keyword readonly is only allowed for fields), https://stackoverflow.com/questions/3917796/how-to-implement-a-read-only-property
        public string Element { get; private set; }
        #endregion
    }
}