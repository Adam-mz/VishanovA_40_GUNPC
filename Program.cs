internal class Program
{
   

public struct Interval
{
    private static Random random = new Random();

    public float Min { get; }
    public float Max { get; }

    public Interval(int minValue, int maxValue)
    {
        if (minValue < 0)
        {
            Console.WriteLine("Min value was negative, set to 0");
            minValue = 0;
        }

        if (maxValue < 0)
        {
            Console.WriteLine("Max value was negative, set to 0");
            maxValue = 0;
        }

        if (minValue > maxValue)
        {
            Console.WriteLine("Incorrect interval values, swapped");
            (minValue, maxValue) = (maxValue, minValue);
        }

        if (minValue == maxValue)
        {
            Console.WriteLine("Interval values are equal, max increased by 10");
            maxValue += 10;
        }

        Min = minValue;
        Max = maxValue;
    }

    public float Get()
    {
        return (float)(Min + random.NextDouble() * (Max - Min));
    }
}

public class Unit
{
    public string Name { get; }

    private float health;
    public float Health => health;

    public Interval Damage { get; }
    public float Armor { get; }

    public Unit() : this("Unknown Unit", 0, 10) { }

    public Unit(string name) : this(name, 0, 10) { }

    public Unit(string name, int minDamage, int maxDamage)
    {
        Name = name;
        health = 100f;
        Armor = 0.6f;
        Damage = new Interval(minDamage, maxDamage);
    }

    public float GetRealHealth()
    {
        return Health * (1f + Armor);
    }

    public bool SetDamage(float value)
    {
        health -= value * Armor;
        return health <= 0f;
    }

    public override string ToString()
    {
        return $"{Name} (Health: {Health})";
    }
}

public class Weapon
{
    public string Name { get; }
    public Interval Damage { get; private set; }
    public float Durability { get; }

    public Weapon(string name)
    {
        Name = name;
        Durability = 1f;
        Damage = new Interval(1, 10);
    }

    public Weapon(string name, int minDamage, int maxDamage) : this(name)
    {
        SetDamageParams(minDamage, maxDamage);
    }

    public void SetDamageParams(int minDamage, int maxDamage)
    {
        if (minDamage > maxDamage)
        {
            Console.WriteLine($"[{Name}] Incorrect damage values, swapped");
            (minDamage, maxDamage) = (maxDamage, minDamage);
        }

        if (minDamage < 1)
        {
            Console.WriteLine($"[{Name}] Min damage forced to 1");
            minDamage = 1;
        }

        if (maxDamage <= 1)
        {
            maxDamage = 10;
        }

        Damage = new Interval(minDamage, maxDamage);
    }

    public int GetDamage()
    {
        return (int)((Damage.Min + Damage.Max) / 2);
    }

    public override string ToString()
    {
        return $"{Name} (Damage: {Damage.Min}-{Damage.Max})";
    }
}

public struct Room
{
    public Unit Unit;
    public Weapon Weapon;

    public Room(Unit unit, Weapon weapon)
    {
        Unit = unit;
        Weapon = weapon;
    }
}

public class Dungeon
{
    private Room[] rooms;

    public Dungeon()
    {
        rooms = new Room[]
        {
            new Room(new Unit("Warrior", 2, 6), new Weapon("Sword", 3, 7)),
            new Room(new Unit("Mage", 1, 8), new Weapon("Staff", 2, 10)),
            new Room(new Unit("Rogue", 3, 5), new Weapon("Dagger", 4, 6))
        };
    }

    public void ShowRooms()
    {
        for (int i = 0; i < rooms.Length; i++)
        {
            var room = rooms[i];
            Console.WriteLine("Unit of room: " + room.Unit);
            Console.WriteLine("Weapon of room: " + room.Weapon);
            Console.WriteLine("—");
        }
    }
}



    static void Main()
    {
        Dungeon dungeon = new Dungeon();
        dungeon.ShowRooms();
    }
}

