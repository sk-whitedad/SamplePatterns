namespace MyPolly
{
    class Programm
    {
        static void Main()
        {
            Animal[] animals = new Animal[4];
            Cat cats = new Cat();
            cats.Name = "Barsik";
            Dog dog = new Dog();
            dog.Name = "Tuzik";
            Rat rat = new Rat();
            rat.Name = "Georg";

            //тут вся суть
            Animal animal = new Boozer
            {
                Name = "дядя Вася"
            };

            animals[0] = cats;
            animals[1] = dog;
            animals[2] = rat;
            animals[3] = animal;
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine($"Животное {animals[i].Name} говорит:");
                animals[i].GetRoar();
            }
        }
    }

    class Animal
    {
        public string Name { get; set; }
        public virtual void GetRoar()
        {
            Console.WriteLine($"Абстрактный клич");
        }
    }

    class Boozer : Animal
    {
        public override void GetRoar()
        {
            Console.WriteLine($"Привет!");
        }
    }

    class Cat : Animal
    {
        public override void GetRoar()
        {
            Console.WriteLine($"Мяу мяу");
        }
    }

    class Dog : Animal
    {
        public override void GetRoar()
        {
            Console.WriteLine($"Гав гав");
        }
    }

    class Rat : Animal
    {
        public override void GetRoar()
        {
            Console.WriteLine($"Фр фр");
        }
    }











}