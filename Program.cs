internal class Program
{
    public class Unit
    {
        public string Name { get; }

        private float health;
        public float Health
        {
            get { return health; }
        }
        public int Damage { get; }
        public float Armor { get; }
        public Unit() : this("Unknown Unit")
        {
        }
        public Unit(string name)
        {
            Name = name;
            health = 100f;   
            Damage = 5;
            Armor = 0.6f;
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
    }

    private static void Main(string[] args)
    {
        Unit unit = new Unit("Knight");
        

        bool isDead = unit.SetDamage(50f);
        Console.WriteLine(unit.Name);
        Console.WriteLine(unit.Health);
        Console.WriteLine(unit.GetRealHealth());
        Console.WriteLine(isDead ? "Юнит погиб" : "Юнит жив");

    }
}