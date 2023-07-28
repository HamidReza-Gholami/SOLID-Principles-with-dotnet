namespace InterfaceSegregationPrinciple_ISP_
{
    internal class GoodDesing
    {
        public interface IWorker
        {
            void Work();
        }

        public interface IHumanWorker : IWorker
        {
            void Eat();

            void Drink();

            void Sleep();
        }

        public interface IRobotWoker : IWorker
        {
        }

        public class Employee : IHumanWorker
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

        public class RobotWoker : IRobotWoker
        {
            public void Work()
            {
                throw new NotImplementedException("WokerRobot is working....");
            }
        }

    }
}
