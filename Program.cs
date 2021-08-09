using System;
using System.Collections.Generic;

namespace WorldofDBCraft
{
    class GameCharacter
    {
        public string Name;
        public string Title;
        public int Strength;
        public int Intelligence;
        public virtual void Play()
        {
            Console.WriteLine("I am immortal! I have inside me blood of kings!");
        }
    }
    class MagicChar : GameCharacter
    {
        public int Mana;
    }

    class Wizard : MagicChar
    {
        public int numSpells;
        public override void Play()
        {
            Console.WriteLine($"Revel in the wisdom of {Name} the {Title}! {Name} has the base stats of {Intelligence} int, {Strength} strength and {Mana} magic capacity!! " +
                $"{Name} can fire off {numSpells} spells! ");
        }
    }
    class Warrior : GameCharacter
    {
        public string wepType;
        public override void Play()
        {
            Console.WriteLine($"All hail {Name} the {Title}! {Name} has the base stats of {Intelligence} int and {Strength} strength!" +
                $"{Name} wields {wepType}!");
        }
    }
        
    class Program
    {
        
        public static List<GameCharacter> generateCharList()
        {
            List<GameCharacter> allChars = new List<GameCharacter>();
            Wizard w1 = new Wizard();
            w1.Name = "Elminster";
            w1.Title = "Sage";
            w1.Strength = 2;
            w1.Intelligence = 200;
            w1.Mana = 9000;
            w1.numSpells = 50;

            Wizard w2 = new Wizard();
            w2.Name = "Mystra";
            w2.Title = "Goddess of magic";
            w2.Strength = 200;
            w2.Intelligence = 20000;
            w2.Mana = 900000000;
            w2.numSpells = 5000;

            Warrior f1 = new Warrior();
            f1.Name = "Kelemvor";
            f1.Title = "God of War";
            f1.Strength = 9000;
            f1.Intelligence = 2;
            f1.wepType = "Bastard Sword";

            Warrior f2 = new Warrior();
            f2.Name = "Cyric";
            f2.Title = "Theif";
            f2.Strength = 50;
            f2.Intelligence = 50;
            f2.wepType = "Twin Daggers";

            Warrior f3 = new Warrior();
            f3.Name = "Kull";
            f3.Title = "The Conqueror";
            f3.Strength = 200;
            f3.Intelligence = 50;
            f3.wepType = "Battle Axe";

            allChars.Add(w1);
            allChars.Add(w2);
            allChars.Add(f1);
            allChars.Add(f2);
            allChars.Add(f3);
            return allChars;
        }

        public static void gcListItteration(List<GameCharacter> gameCharacters)
        {
            foreach (GameCharacter Charry in gameCharacters)
            {
                Charry.Play();
            }
        }


        public static void Main(string[] args)
        {           
            Console.WriteLine("Welcome to the world of DevBuildCraft!");
            gcListItteration(generateCharList());

        }

        
    }
}
