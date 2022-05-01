using System;
namespace LearnToFly.SolidPrinciples
{
    // this principle states that if S is the subtype of type T, then object of type T should be able to
    // substituted/replaced by object of type S without affecting the behaviour of T.
    public class LiskovSubstitution
    {
        public LiskovSubstitution()
        {
        }
        public void Call()
        {
            Fruits o = new Orange();
            o.Print();
            Fruits o2 = new Apple();
            o2.Print();
        }
    }

    public abstract class Fruits
    {
        public abstract void Print();
    }

    public class Apple: Fruits
    {
        public override void Print()
        {
            Console.WriteLine("Apple is red");
        }
    }
    public class Orange: Fruits
    {
        public override void Print()
        {
            Console.WriteLine("Orange is orange");
        }
    }
}
