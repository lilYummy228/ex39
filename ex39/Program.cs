using System;

namespace ex39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Себилла", "Эльф", "Вор", 6);

            player.ShowInfo();
        }
    }

    class Player
    {
        public string Name;
        public string Race;
        public string Classification;
        public int Level;

        public Player(string name, string race, string classification, int level)
        {
            Name = name;
            Race = race;
            Classification = classification;
            Level = level;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Имя: {Name}\nРаса: {Race}\nКласс: {Classification}\nУровень: {Level}");
        }
    }
}
