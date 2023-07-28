namespace InterfaceSegregationPrinciple_ISP_
{
    internal class BadDesing
    {
        public interface IWorker
        {
            void Eat();

            void Drink();

            void Sleep();
            void Work();
        }


        public class Employee : IWorker
        {
            public void Drink()
            {
                Console.WriteLine("Employee is drinking....");
            }

            public void Eat()
            {
                Console.WriteLine("Employee is Eating...");
            }

            public void Sleep()
            {
                Console.WriteLine("Employee is sleeping...");
            }

            public void Work()
            {
                Console.WriteLine("Employee is working...");
            }
        }

        public class WokerRobot : IWorker
        {
            public void Drink()
            {
                throw new NotImplementedException();
            }

            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void Sleep()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException("WokerRobot is working....");
            }
        }

    }
}
