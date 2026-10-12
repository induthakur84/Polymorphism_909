using System;



namespace Polymorphism
{


    //Polymorphism : means one name, many forms
    // it allows us the same method or object can be behave differently


    // types of polymorphism

    // 1.Compile-Time polymorphism-- Method overloading(order , type, ,

    // 2. RunTime polymorphsim -- Method overrriding



    // Method Overloading
    //----------------------------------

    //Method overloading means having mutiple methods with the same name but
    // different parameter
    // 1. Number of parameter
    // 2.Type of parameter
    //3. order of parameters


    //Method overriding 

    // in which a child class provides itw own implementation of a method
    // that is already defined inside the parent class

    // parent method use 'Virtual'
    // Child method we can use 'override keyword'


    // class payment
    // makepayment("adasdf");

    //class gpaypayment: payment
    //makepayment("adsfadsg")

    //class creditcarpayment: payment
    //makepayment("cadgads")


    // payment = new creditcarpayment


    public class Animal
    {
        //'Virtual key'' means it allows the child class to the override the method.



        public virtual void Speak()
        {
            Console.WriteLine("Animal Speaks");
        }
    }
    class Dog : Animal {
        public override void Speak()
        {
            Console.WriteLine("Dog Speaks");
        }

    }

    /// Method overloading
    /// 

    public class Calucator
    {

        // in this add method we have 2 integer parameter
        public int Add(int a, int b)
        {
            return a + b;
        }
        // here add() we have 2 double parament
        // differnt parameter type
        public double Add(Double a, Double b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b+c;
        }

        public string Add(string a, string b, string c)
        {
            return a + b + c;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
           //MEthod overriding/ runtime

            //base class
            Animal animal = new Animal();
            //Calls aninal speak() method
            animal.Speak();



            //Derived class
             
            Dog dog= new Dog();
            dog.Speak();


            //method overloading

             Calucator cal= new Calucator();



            Console.WriteLine(cal.Add(2, 2));



            Console.WriteLine(cal.Add(2.2, 2.2));



            Console.WriteLine(cal.Add(2, 2,5));


            Console.WriteLine(cal.Add("hello", "world", "asdsfds"));
        }
    }



}