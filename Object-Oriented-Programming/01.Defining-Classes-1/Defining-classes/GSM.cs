
namespace Defining_classes
{
    using System;

    class GSM
    {
        public string Make { get; set; }
        public string Model { get; }
        public int Price { get; set; }
        public string Owner { get; set; }

        private Battery battery;

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }
        public Display Display { get; private set; }

        public GSM(string make, string model)
        {
            this.Make = make;
            this.Model = model;
        }

        public GSM(string make, string model, int price, string owner, Battery battery)
        {
            this.Battery = battery;
            this.Make = make;
            this.Model = model;
            this.Price = price;
            this.Owner = owner;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Maker: {this.Make}, Model: {this.Model}, Price: {this.Price}, Owner: {this.Owner}, Battery: {this.Battery}");
        }
    }
}
