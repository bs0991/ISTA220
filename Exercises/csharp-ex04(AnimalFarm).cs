using System;

namespace AnimalFarm
{
    public class Animal
    {
        public string Name;
        public string Type;
        public string Food;
        public string Sound;

        public void Hello()
        {
            Console.WriteLine($"Hi! My name is {Name} and I am a {Type}!");
        }
        public void Eat()
        {
            Console.Write($"I like to eat {Food} ");
        }
        public void Speak()
        {
            Console.WriteLine($"and I say {Sound}");
        }
    }
    class Chicken : Animal
    {
        public Chicken()
        {
            Console.WriteLine("Welcome to my Animal Farm!");
            Console.WriteLine("Allow me to introduce you to my favorite chickens!");
        }

        public Chicken(string name, string type, string food, string sound)
        {
            Name = name;
            Type = type;
            Food = food;
            Sound = sound;
        }
    }

    class Horse : Animal
    {
        public Horse()
        {
            Console.WriteLine("And next I'll introduce you to some of my favorite horsies!");
        }

        public Horse(string name, string type, string food, string sound)
        {
            Name = name;
            Type = type;
            Food = food;
            Sound = sound;
        }
    }

    class Pig : Animal
    {
        public Pig()
        {
            Console.WriteLine("And next I'll introduce you to some of my favorite piggies!");
        }

        public Pig(string name, string type, string food, string sound)
        {
            Name = name;
            Type = type;
            Food = food;
            Sound = sound;
        }
    }

    class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("And finally I'll introduce you to some of my favorite doggos!");
        }

        public Dog(string name, string type, string food, string sound)
        {
            Name = name;
            Type = type;
            Food = food;
            Sound = sound;
        }
    }

    class Program
    {
        static void farmAnimals()
        {
            // Introduction
            Chicken Introduction = new Chicken();
            Console.ReadKey();

            // Chicken Class

            Chicken Foghorn = new Chicken("Foghorn", "manly rooster", "corn on the cob", "I say, I say what's the big idea. Don't stand there gawkin' son, speak up!");
            Foghorn.Hello();
            Console.ReadKey();
            Foghorn.Eat();
            Foghorn.Speak();
            Console.ReadKey();

            Chicken MissPrissy = new Chicken("Miss Prissy", "lovely spinster hen", "honeydew melons", "that I will find myself a rooster husband!");
            MissPrissy.Hello();
            Console.ReadKey();
            MissPrissy.Eat();
            MissPrissy.Speak();
            Console.ReadKey();

            Chicken LadyKluck = new Chicken("Lady Kluck", "Scottish chicken serving as the lady-in-waiting of Maid Marian", "leafy greens and fruits!", "absence makes the heart grow fonder.");
            LadyKluck.Hello();
            Console.ReadKey();
            LadyKluck.Eat();
            LadyKluck.Speak();
            Console.ReadKey();

            Chicken Ernie = new Chicken("Ernie", "giant chicken", "steak and drink beer", "that I hate Peter Griffin.");
            Ernie.Hello();
            Console.ReadKey();
            Ernie.Eat();
            Ernie.Speak();
            Console.ReadKey();
            Console.WriteLine();

            // Horse Class
            Horse Introduction1 = new Horse();
            Console.ReadKey();

            Horse Maximus = new Horse("Maximus", "palace horse", "only the finest apples and berries", "Flynn Rider is my best friend!");
            Maximus.Hello();
            Console.ReadKey();
            Maximus.Eat();
            Maximus.Speak();
            Console.ReadKey();

            Horse Spirit = new Horse("Spirit", "wild horse", "whatever I want, because I'm wild and free", "NEIGH!");
            Spirit.Hello();
            Console.ReadKey();
            Spirit.Eat();
            Spirit.Speak();
            Console.ReadKey();

            Horse Khan = new Horse("Khan", "horse of the Fa family", "ramen noodles", "that Mulan is my best friend!");
            Khan.Hello();
            Console.ReadKey();
            Khan.Eat();
            Khan.Speak();
            Console.ReadKey();

            Horse Pegasus = new Horse("Pegasus", "mythical divine horse", "Chick-fil-A", "that flying is the easiest way of travel.");
            Pegasus.Hello();
            Console.ReadKey();
            Pegasus.Eat();
            Pegasus.Speak();
            Console.ReadKey();
            Console.WriteLine();

            // Pig Class
            Pig Introduction2 = new Pig();
            Console.ReadKey();

            Pig Porky = new Pig("Porky","sylish pig with a bow-tie", "ribs", "th-th-th-that's all folks!");
            Porky.Hello();
            Console.ReadKey();
            Porky.Eat();
            Porky.Speak();
            Console.ReadKey();

            Pig MissPiggy = new Pig("Miss Piggy", "diva pig with attitude", "burgers", "never eat more than you can lift.");
            MissPiggy.Hello();
            Console.ReadKey();
            MissPiggy.Eat();
            MissPiggy.Speak();
            Console.ReadKey();

            Pig Piglet = new Pig("Piglet", "cute little pink piggie", "marshmellows", "if you have the courage to fail, you have the courage to succeed");
            Piglet.Hello();
            Console.ReadKey();
            Piglet.Eat();
            Piglet.Speak();
            Console.ReadKey();

            Pig Hamm = new Pig("Hamm", "plastic pig with a cork in my belly", "coins", "that Mr. Potato Head is my best friend!");
            Hamm.Hello();
            Console.ReadKey();
            Hamm.Eat();
            Hamm.Speak();
            Console.ReadKey();
            Console.WriteLine();

            // Dog Class
            Dog Introduction3 = new Dog();
            Console.ReadKey();

            Dog Snoopy = new Dog("Snoopy", "small pup with a happy dance", "peanuts", "the less you want the more you love.");
            Snoopy.Hello();
            Console.ReadKey();
            Snoopy.Eat();
            Snoopy.Speak();
            Console.ReadKey();

            Dog Droopy = new Dog("Droopy", "dog with a....you guessed it..a droopy face", "M&Ms", "don't worry be happy.");
            Droopy.Hello();
            Console.ReadKey();
            Droopy.Eat();
            Droopy.Speak();
            Console.ReadKey();

            Dog Odie = new Dog("Odie", "dog with yellow fur and brown ears", "cheetos", "that Garfield is my best friend!");
            Odie.Hello();
            Console.ReadKey();
            Odie.Eat();
            Odie.Speak();
            Console.ReadKey();

            Dog Pluto = new Dog("Pluto", "dog who just loves to play", "hotdogs", "that Micky is my best friend!");
            Pluto.Hello();
            Console.ReadKey();
            Pluto.Eat();
            Pluto.Speak();
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            try
            {
                farmAnimals();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
