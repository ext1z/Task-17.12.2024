


//Time 20:00

//3.Создайте проект с тремя пространствами имен:
// Success


//Animals.Mammals — класс Dog с методом Speak(), выводящим "Гав-гав".
//Animals.Birds — класс Parrot с методом Speak(), выводящим "Попугай говорит".
//Animals — основной класс Animal с виртуальным методом Speak().
//Продемонстрируйте работу каждого класса, используя ключевые слова using и namespace


Animals.Animals animals = new Animals.Animals();
Animals.Mammals.Dog dog = new Animals.Mammals.Dog();
Animals.Birds.Parrot parrot = new Animals.Birds.Parrot();


animals.Speak();
dog.Speak();
parrot.Speak();
