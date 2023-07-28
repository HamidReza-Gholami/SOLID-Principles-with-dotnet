namespace OpenClosedPrinciple_OCP_
{
    internal class GoodDesing
    {
        public interface IBird
        {
            void Eat();

            void MakeSound();
        }

        public interface IFlyingBird : IBird
        {
            void Fly();
        }


        public class Duck : IFlyingBird
        {
            public void Eat()
            {
                Console.WriteLine("Duck is eating...");
            }

            public void Fly()
            {
                Console.WriteLine("Duck is Flying...");
            }

            public void MakeSound()
            {
                Console.WriteLine("Duck is Making Sound....");
            }
        }

        public class Penguen : IBird
        {
            public void Eat()
            {
                Console.WriteLine("penguen is eating...");
            }
            public void MakeSound()
            {
                Console.WriteLine("penguen making sound.....");
            }
        }
    }
}
