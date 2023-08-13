using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{


    public interface FlyBehaivor
    {
        void Fly();
    }

    public interface QuackBehavior
    {
        void quck();
    }

    public class Quack : QuackBehavior
    {
        public void quck()
        {
            Console.WriteLine("Quack !");
        }
    }
    public class MuteQuack : QuackBehavior
    {
        public void quck()
        {
            Console.WriteLine("Silence");
        }
    }
    public class Squeak : QuackBehavior
    {
        public void quck()
        {
            Console.WriteLine("Squeak");
        }
    }

    internal class FlyWings : FlyBehaivor
    {
        public void Fly()
        {
            Console.WriteLine("i'm flying !");
        }
    }

    internal class NoFlyWings : FlyBehaivor
    {
        public void Fly()
        {
            Console.WriteLine("i can't fly !");
        }


    }
    public abstract class Duck
    {
      public  QuackBehavior quackBehavior;
      public   FlyBehaivor flyBehaivor;

        public  Duck()
        {}

        public abstract void Display();

        public void performQuack()
        {
            quackBehavior.quck();
        }

        public void performFly()
        {
            flyBehaivor.Fly();
        }

        public void swim()
        {
            Console.WriteLine("all ducks float,even decoys!");
        }

    }


    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehaivor = new FlyWings();
            Display();
        }
        public override void Display()
        {
            Console.WriteLine("Im Mallard duck");
            Console.ReadLine();
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();

            Console.ReadLine() ;
        }
    }
   
}
