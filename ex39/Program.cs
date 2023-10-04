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
        private string _name;
        private string _race;
        private string _classification;
        private int _level;

        public Player(string name, string race, string classification, int level)
        {
            _name = name;
            _race = race;
            _classification = classification;
            _level = level;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Имя: {_name}\nРаса: {_race}\nКласс: {_classification}\nУровень: {_level}");
        }
    }
}
