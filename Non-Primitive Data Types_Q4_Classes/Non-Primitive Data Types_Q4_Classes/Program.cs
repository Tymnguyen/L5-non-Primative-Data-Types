using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Example usage
        Player player = new Player("Hero");
        Enemy enemy = new Enemy("Orc", 100, 20, 10);
        Potion potion = new Potion("Healing Potion", 50, 3);
        Quest quest = new Quest("Save the Village", "Defeat the goblins to save the village.", 100);
        Inventory inventory = new Inventory(5);
        Spell fireball = new Spell("Fireball", 40, 20, "A powerful ball of fire.");

        // Test Player
        player.GainXP(120); // Player gains XP and possibly levels up
        potion.Apply(player); // Heal the player
        fireball.Cast(player, enemy); // Cast a spell on the enemy

        // Test Inventory
        inventory.AddItem("Sword");
        inventory.AddItem("Shield");
        inventory.DisplayItems();

        // Test Quest
        quest.StartQuest();
        quest.CompleteQuest();
        int reward = quest.ClaimReward();
    }
}

//---------------------------------------------------------------------
// Question 1: Player Class
public class Player
{
    public string Name { get; set; }
    public int Level { get; private set; }
    public int HP { get; private set; }
    public int XP { get; private set; }

    public Player(string name)
    {
        Name = name;
        Level = 1;
        HP = 100;
        XP = 0;
    }

    public void LevelUp()
    {
        Level++;
        HP += 20; // Increase HP when leveling up
        Console.WriteLine($"{Name} leveled up! Now at level {Level}.");
    }

    public void Heal(int amount)
    {
        HP += amount;
        Console.WriteLine($"{Name} healed by {amount} points. Current HP: {HP}");
    }

    public void GainXP(int amount)
    {
        XP += amount;
        Console.WriteLine($"{Name} gained {amount} XP.");
        if (XP >= 100)
        {
            XP -= 100;
            LevelUp();
        }
    }
}

//---------------------------------------------------------------------
// Question 2: Enemy Class
public class Enemy
{
    public string Name { get; set; }
    public int HP { get; private set; }
    public int AttackPower { get; private set; }
    public int Defense { get; private set; }

    public Enemy(string name, int hp, int attackPower, int defense)
    {
        Name = name;
        HP = hp;
        AttackPower = attackPower;
        Defense = defense;
    }

    public int CalculateDamage(int playerAttack)
    {
        int damage = playerAttack - Defense;
        return damage > 0 ? damage : 0; // Prevent negative damage
    }

    public void TakeDamage(int damage)
    {
        HP -= damage;
        Console.WriteLine($"{Name} took {damage} damage. Current HP: {HP}");
    }
}

//---------------------------------------------------------------------
// Question 3: Potion Class
public class Potion
{
    public string Name { get; set; }
    public int HealingPower { get; set; }
    public int Quantity { get; set; }

    public Potion(string name, int healingPower, int quantity)
    {
        Name = name;
        HealingPower = healingPower;
        Quantity = quantity;
    }

    public void Apply(Player player)
    {
        if (Quantity > 0)
        {
            player.Heal(HealingPower);
            Quantity--;
            Console.WriteLine($"{Name} used. {Quantity} remaining.");
        }
        else
        {
            Console.WriteLine($"{Name} is out of stock.");
        }
    }
}

//---------------------------------------------------------------------
// Question 4: Quest Class
public class Quest
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Reward { get; set; }
    public bool IsCompleted { get; private set; }

    public Quest(string name, string description, int reward)
    {
        Name = name;
        Description = description;
        Reward = reward;
        IsCompleted = false;
    }

    public void StartQuest()
    {
        Console.WriteLine($"Quest '{Name}' started: {Description}");
    }

    public void CompleteQuest()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
            Console.WriteLine($"Quest '{Name}' completed!");
        }
        else
        {
            Console.WriteLine($"Quest '{Name}' has already been completed.");
        }
    }

    public int ClaimReward()
    {
        if (IsCompleted)
        {
            Console.WriteLine($"Reward claimed: {Reward} gold.");
            return Reward;
        }
        else
        {
            Console.WriteLine("Complete the quest to claim the reward.");
            return 0;
        }
    }
}

//---------------------------------------------------------------------
// Question 5: Inventory Class
public class Inventory
{
    public int Capacity { get; private set; }
    private List<string> Items;

    public Inventory(int capacity)
    {
        Capacity = capacity;
        Items = new List<string>();
    }

    public bool AddItem(string item)
    {
        if (Items.Count < Capacity)
        {
            Items.Add(item);
            Console.WriteLine($"{item} added to inventory.");
            return true;
        }
        else
        {
            Console.WriteLine("Inventory is full.");
            return false;
        }
    }

    public bool RemoveItem(string item)
    {
        if (Items.Contains(item))
        {
            Items.Remove(item);
            Console.WriteLine($"{item} removed from inventory.");
            return true;
        }
        else
        {
            Console.WriteLine($"{item} not found in inventory.");
            return false;
        }
    }

    public void DisplayItems()
    {
        Console.WriteLine("Inventory:");
        foreach (var item in Items)
        {
            Console.WriteLine($"- {item}");
        }
    }

    public bool HasItem(string item)
    {
        return Items.Contains(item);
    }
}

//---------------------------------------------------------------------
// Question 6: Spell Class
public class Spell
{
    public string Name { get; set; }
    public int Damage { get; set; }
    public int ManaCost { get; set; }
    public string Description { get; set; }

    public Spell(string name, int damage, int manaCost, string description)
    {
        Name = name;
        Damage = damage;
        ManaCost = manaCost;
        Description = description;
    }

    public void Cast(Player player, Enemy enemy)
    {
        Console.WriteLine($"{Name} cast on {enemy.Name}, dealing {Damage} damage.");
        enemy.TakeDamage(Damage);
        // Assuming player has mana tracking, you would decrease their mana by ManaCost here.
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"{Name}: {Description} (Damage: {Damage}, Mana Cost: {ManaCost})");
    }
}
