namespace MyGame.Core
{
    public class GameUnit
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int Speed { get; private set; }
        public int Armor { get; private set; }
        public int Damage { get; private set; }

        public GameUnit(string name, int health, int speed, int armor, int damage)
        {
            this.Name = name;
            this.Health = health;
            this.Speed = speed;
            this.Armor = armor;
            this.Damage = damage;
        }


        public void TakeDamage(int damage)
        {
            this.Health -= damage;
        }

        public string GetInfo()
        {
            return $"GameUnit -> Name: '{this.Name}', Health: '{this.Health}', Speed: '{this.Speed}', Armor: '{this.Armor}', Damage: '{this.Damage}'";
        }

    }
}