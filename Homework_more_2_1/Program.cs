namespace HW_2
{
    class Automobile
    {
        private string brand;
        private int maxSpeed;
        public void SetBrand(string brand) { this.brand = brand; }
        public void SetMaxSpeed(int maxSpeed) { this.maxSpeed = maxSpeed < 0 ? maxSpeed * (-1) : maxSpeed; }
        public string GetBrand() { return brand; }
        public int GetMaxSpeed() { return maxSpeed; }
        public virtual void PrintInfo() { Console.WriteLine($"brand = {brand}; maxSpeed = {maxSpeed}"); }
    }

    class Car : Automobile
    {
        private int passNumber;
        public void SetNumber(int passNumber) { this.passNumber = passNumber; }
        public int GetNumber() { return passNumber; }
        public override void PrintInfo() { Console.WriteLine($"brand = {base.GetBrand()}; maxSpeed = {base.GetMaxSpeed()}; number = {passNumber}"); }
    }

    class Vehicle : Automobile
    {
        private int weight;
        public void SetWeight(int weight) { this.weight = weight; }
        public int GetWeight() { return weight; }
        public override void PrintInfo() { Console.WriteLine($"brand = {base.GetBrand()}; maxSpeed = {base.GetMaxSpeed()}; weight = {weight}"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Automobile[] automobiles = new Automobile [4];

            Car car1 = new Car();
            car1.SetBrand("Chevrolet");
            car1.SetMaxSpeed(150);
            car1.SetNumber(4);
            automobiles[0] = car1;

            Car car2 = new Car();
            car2.SetBrand("Mazda");
            car2.SetMaxSpeed(200);
            car2.SetNumber(5);
            automobiles[1] = car2;

            Vehicle vehicle1 = new Vehicle();
            vehicle1.SetBrand("Mersedes");
            vehicle1.SetMaxSpeed(120);
            vehicle1.SetWeight(1000);
            automobiles[2] = vehicle1;

            Vehicle vehicle2 = new Vehicle();
            vehicle1.SetBrand("Volvo");
            vehicle1.SetMaxSpeed(100);
            vehicle1.SetWeight(1500);
            automobiles[3] = vehicle2;

            Automobile superCar = automobiles[0];

            foreach (var item in automobiles)
            {
                if (superCar.GetMaxSpeed() < item.GetMaxSpeed())
                {
                    superCar = item;
                }
            }
            superCar.PrintInfo();
        }
    }
}