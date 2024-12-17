

namespace Animals
{
    internal class Animals
    {

        public virtual void Speak()
        {
            Console.WriteLine("Звук животных");
        }
    }

    namespace Mammals
    {
        internal class Dog : Animals
        {
            //public string Name {  get; set; }
            //public int Age { get; set; }

            //public Dog(string name, int age)
            //{
            //    Name = name;
            //    Age = age;

            //}

            public override void Speak()
            {
                Console.WriteLine("Гав-Гав");
            }
        }

    }

    namespace Birds
    {
        internal class Parrot : Animals
        {
            //public string Name { get; set; }
            //public int Age { get; set; }

            //public Parrot(string name, int age)
            //{
            //    Name = name;
            //    Age = age;

            //}

            public override void Speak()
            {
                Console.WriteLine("Попугай");
            }
        }

    }



    
    //3.Создайте проект с тремя пространствами имен:

    //Animals.Mammals — класс Dog с методом Speak(), выводящим "Гав-гав".
    //Animals.Birds — класс Parrot с методом Speak(), выводящим "Попугай говорит".
    //Animals — основной класс Animal с виртуальным методом Speak().
    //Продемонстрируйте работу каждого класса, используя ключевые слова using и namespace





}






