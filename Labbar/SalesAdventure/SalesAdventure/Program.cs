using System;

public class Entity
{
    public int X { get; set; }
    public int Y { get; set; }
    public char Symbol { get; set; }

    public Entity(int x, int y, char symbol)
    {
        X = x;
        Y = y;
        Symbol = symbol;
    }

    public virtual void Draw()
    {
        Console.SetCursorPosition(X, Y);
        Console.Write(Symbol);
    }
}

public class Player : Entity
{
    public Player(int x, int y) : base(x, y, 'P')
    {
    }

    public void Move(int dx, int dy)
    {
        // Implementera rörelsebegränsningar här om det behövs
        X += dx;
        Y += dy;
    }

    public void Interact(Entity entity)
    {
        // Implementera interaktionslogik här
        if (entity is Creature)
        {
            Creature creature = (Creature)entity;
            // Implementera möteslogik mellan spelaren och varelsen här
            Console.WriteLine($"Du mötte en varelse av typen {creature.Symbol}!");
        }
        else if (entity is Item)
        {
            Item item = (Item)entity;
            // Implementera logik för att plocka upp föremål här
            Console.WriteLine($"Du plockade upp ett föremål av typen {item.Symbol}!");
        }
    }
}

public class Creature : Entity
{
    public Creature(int x, int y, char symbol) : base(x, y, symbol)
    {
    }
}

public class Item : Entity
{
    public bool Consumable { get; set; }
    public bool Equippable { get; set; }

    public Item(int x, int y, char symbol, bool consumable, bool equippable) : base(x, y, symbol)
    {
        Consumable = consumable;
        Equippable = equippable;
    }

    public void Use(Player player)
    {
        // Implementera effekterna av att använda föremålet här
        if (Consumable)
        {
            Console.WriteLine($"Du använder det förbrukningsbara föremålet {Symbol}.");
            // Implementera effekter för förbrukningsbara föremål här
        }
        else if (Equippable)
        {
            Console.WriteLine($"Du sätter på dig det bärbara föremålet {Symbol}.");
            // Implementera effekter för bärbara föremål här
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player(0, 0);
        Creature creature = new Creature(5, 5, 'M');
        Item item = new Item(10, 10, 'H', true, false); // Exempel på ett förbrukningsbart föremål

        while (true)
        {
            Console.Clear();
            player.Draw();
            creature.Draw();
            item.Draw();

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    player.Move(0, -1);
                    break;
                case ConsoleKey.DownArrow:
                    player.Move(0, 1);
                    break;
                case ConsoleKey.LeftArrow:
                    player.Move(-1, 0);
                    break;
                case ConsoleKey.RightArrow:
                    player.Move(1, 0);
                    break;
                case ConsoleKey.E:
                    player.Interact(creature);
                    break;
                case ConsoleKey.Spacebar:
                    player.Interact(item);
                    item.Use(player);
                    break;
            }
        }
    }
}
