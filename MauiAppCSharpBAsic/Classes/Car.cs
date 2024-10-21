using System;

namespace MauiAppCSharpBAsic.Classes
{
    public  class Car
    {
        public string Model;
        public string Color;
        public double Speed;
        public double Fuel;
        public double TotalMile;
        public double UseFuelRate; /// xxx liter per mile


        public Car(string model , double speed , double fuel)
        {
            this.Model = model;
            this.Speed = speed;
            this.Fuel = fuel;
        }
        public void Run(double  Mile)
        {
            //this.TotalDistance = this.TotalDistance + distance;
            this.TotalMile += Mile;
            var ues_fuel = Mile * this.UseFuelRate;
            this.Fuel = this.Fuel - ues_fuel;
        }
        public uint TimeUseForRun(double Mile)
        {
            var timeuse = Mile/Speed;
            this.Run(Mile);
            return Convert.ToUInt16(timeuse);
        }

        public string ShowInfo()
        {
            var info = $"Model : {this.Model} \nTotal Mile : {this.TotalMile} \nFuel : {this.Fuel}";
            return info;
                
        }
    }

}
