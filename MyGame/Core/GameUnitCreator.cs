namespace MyGame.Core
{
    public class GameUnitCreator
    {
        public GameUnit Create()
        {
            string unitName = "";
            int health = -1;
            int speed = -1;
            int armor = -1;
            int damage = -1;

            Console.WriteLine("Please write Unit name:");
            unitName = Console.ReadLine();

            Console.WriteLine("write health:");
            health = int.Parse(Console.ReadLine());

            Console.WriteLine("write speed:");
            speed = int.Parse(Console.ReadLine());

            Console.WriteLine("write armor:");
            armor = int.Parse(Console.ReadLine());

            Console.WriteLine("write damage:");
            damage = int.Parse(Console.ReadLine());

            return new GameUnit(unitName, health, speed, armor, damage);
        }
    }
}