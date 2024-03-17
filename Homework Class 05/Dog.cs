

namespace Homework_Class_05;
   
    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }

        public void Eat() { Console.WriteLine("The dog is now eating\n"); }
        public void Play() { Console.WriteLine("The dog is now playing\n"); }
        public void ChaseTail() { Console.WriteLine("The dog is now chasing its tail\n"); }
    }

