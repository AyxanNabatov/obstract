using System;

namespace Obstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Sound();
            dog.Eat();

            Bird bird = new Bird();
            bird.Sound();
            bird.Eat();

        }
    }
}
