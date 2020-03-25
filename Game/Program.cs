using System;

namespace Game
{
    public class Ork
    {
        public static int count = 0;
        string name;
        int health;
        int damage;

        public Ork (string _name, int _health, int _damage)
        {
            name = _name;
            health = _health;
            damage = _damage;
            count++;
            Print();

        }
        public void Print()
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Здоровье:" + health);
            Console.WriteLine("Урон:" + damage);
            health -= damage;
            Console.WriteLine("У персонажа " + name + " осталось " + health + " ед. здоровья");
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя героя: ");
            string objeckt_name = Console.ReadLine();
            Console.WriteLine("Введите количесто злоровья героя: ");
            int objeckt_health = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество урона герою: ");
            int objeckt_damage = int.Parse(Console.ReadLine());
            Ork dude = new Ork(objeckt_name, objeckt_health, objeckt_damage);
            

            Console.WriteLine("Введите имя героя: ");
            objeckt_name = Console.ReadLine();
            Console.WriteLine("Введите количесто злоровья героя: ");
            objeckt_health = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество урона герою: ");
            objeckt_damage = int.Parse(Console.ReadLine());
            Ork dude1 = new Ork(objeckt_name, objeckt_health, objeckt_damage);

            Console.WriteLine("Всего орков "+Ork.count);

            Console.ReadKey();
        }
    }
}

//Console.WriteLine("Сколько персонажей будем создавать?");
//int n = int.Parse(Console.ReadLine());
//for (int i=0;i<=n;i++)
// {
//     string objeckt_name = Console.ReadLine();
//     int objeckt_health = int.Parse(Console.ReadLine());
//     int objeckt_damage = int.Parse(Console.ReadLine());
//     Ork dude = new Ork(objeckt_name, objeckt_health, objeckt_damage);
//     dude.health -= dude.damage;
//     Console.WriteLine("У персонажа " + dude.name + " осталось " + dude.health + " ед. здоровья");

//     i = int.Parse(Console.ReadLine());

// }
//for (int i=0; i<=n;i++)
// {

//     Console.WriteLine();
// }