namespace MyGame.Core
{
    public class Player
    {
        public int PlayerGold { get; private set; }
        public List<GameUnit> UnitsList { get; private set; }

        public Player(int playerGold)
        {
            this.UnitsList = new List<GameUnit>();
            this.PlayerGold = playerGold;
        }

        public void AddUnit(GameUnit gameUnit, int price)
        {
            this.UnitsList.Add(gameUnit);
            this.PlayerGold -= price;
        }
    }
}