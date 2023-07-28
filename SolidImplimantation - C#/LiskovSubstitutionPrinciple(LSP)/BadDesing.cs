namespace OpenClosedPrinciple_OCP_
{
    internal class BadDesing
    {
        public interface IBird
        {
            void Fly();

            void MakeSound();

            void Eat();
        }

        public class Duck : IBird
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

            public void Fly()
            {
                throw new Exception("Pengen can not fly....!");
            }

            public void MakeSound()
            {
                Console.WriteLine("penguen making sound.....");
            }
        }
    }
}
