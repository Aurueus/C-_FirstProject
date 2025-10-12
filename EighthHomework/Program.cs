using System;
using System.Collections.Generic;

public abstract class Weapon
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Damage { get; set; }

    public Weapon(string name, decimal price, int damage)
    {
        Name = name;
        Price = price;
        Damage = damage;
    }

    public abstract void Use();
}

public class Pistol : Weapon
{
    public Pistol(string name, decimal price, int damage) : base(name, price, damage) { }

    public override void Use()
    {
        Console.WriteLine($"{Name} fired fast but low damage");
    }
}

public class Rifle : Weapon
{
    public Rifle(string name, decimal price, int damage) : base(name, price, damage) { }

    public override void Use()
    {
        Console.WriteLine($"{Name} fired accurate and strong");
    }
}

public class Shotgun : Weapon
{
    public Shotgun(string name, decimal price, int damage) : base(name, price, damage) { }

    public override void Use()
    {
        Console.WriteLine($"{Name} fired heavy shot");
    }
}

public class Player
{
    public string NickName { get; set; }
    public decimal Money { get; set; }
    public Weapon CurrentWeapon { get; set; }

    public Player(string nickname, decimal money)
    {
        NickName = nickname;
        Money = money;
    }

    public void BuyWeapon(Weapon weapon)
    {
        if (weapon.Price > Money)
        {
            Console.WriteLine("Not enough money to buy this weapon");
            return;
        }
        Money -= weapon.Price;
        CurrentWeapon = weapon;
        Console.WriteLine($"{NickName} bought {weapon.Name}, money left: {Money}");
    }

    public void Attack()
    {
        if (CurrentWeapon == null)
        {
            Console.WriteLine("No weapon in hand");
            return;
        }
        CurrentWeapon.Use();
    }
}

public class Shop
{
    private List<Weapon> weapons;

    public Shop()
    {
        weapons = new List<Weapon>
        {
            new Pistol("Glock", 800, 20),
            new Rifle("AK-47", 2700, 45),
            new Shotgun("M4 Super", 2000, 60)
        };
    }

    public void DisplayWeapons()
    {
        Console.WriteLine("Available weapons:");
        for (int i = 0; i < weapons.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {weapons[i].Name} - {weapons[i].Price} - Damage: {weapons[i].Damage}");
        }
    }

    public Weapon GetWeapon(int choice)
    {
        if (choice < 1 || choice > weapons.Count)
        {
            Console.WriteLine("Invalid choice");
            return null;
        }
        return weapons[choice - 1];
    }
}

public class Program
{
    public static void Main()
    {
        Random random = new Random();
        Player player = new Player("Terrorist007", 3000);
        Shop shop = new Shop();

        shop.DisplayWeapons();
        Console.Write("Choose weapon number: ");
        int choice = int.Parse(Console.ReadLine());
        Weapon selected = shop.GetWeapon(choice);
        if (selected != null)
        {
            player.BuyWeapon(selected);
        }

        Console.WriteLine();
        for (int i = 0; i < 3; i++)
        {
            int chance = random.Next(0, 2);
            if (chance == 0)
            {
                Console.WriteLine("Enemy spotted");
                player.Attack();
            }
            else
            {
                Console.WriteLine("No enemy yet");
            }
        }
    }
}
