namespace DecoratorDesignPattern.Computers
{
    public class Computer
    {
        public void Start()
        {
            Console.WriteLine($"{GetType().Name} is starting");
        }

        public void ShutDown()
        {
            Console.WriteLine($"{GetType().Name} is shutting down");
        }
    }

    public class Laptop : Computer
    {
        public void OpenLid()
        {
            Console.WriteLine($"{GetType().Name}`s lid is opening");
        }

        public void CloseLid()
        {
            Console.WriteLine($"{GetType().Name}`s lid is closing");
        }
    }


    public class LaptopDecorator : Laptop
    {
        public virtual void OpenLidExtended()
        {
            Console.WriteLine($"{GetType().Name}`s lid is opening");
        }
        public virtual void CloseLidExtended()
        {
            Console.WriteLine($"{GetType().Name}`s lid is closing");
        }
    }

    public class DellLaptop : LaptopDecorator
    {
        public override void OpenLidExtended()
        {
            base.CloseLid();
            Console.WriteLine("Dell Laptop is sleeping");
        }



}
