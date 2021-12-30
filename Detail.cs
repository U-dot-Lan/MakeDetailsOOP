using System;
using System.Collections.Generic;
using System.Text;

namespace MakeDetailsOOP
{
    public abstract class Detail
    {
        public string material { get; }
        public TimeSpan time { get; }
        public Detail(string m, TimeSpan t)
        {
            material = m;
            time = t;
            PrintProductDetail();
        }
        public abstract void PrintProductDetail();

    }

    public class CarDetail : Detail
    {
        public CarDetail(TimeSpan time) : base("железо", time) { }
        public override void PrintProductDetail()
        {
            Console.WriteLine($"Деталь для машины изготовлена.\nВремя для изготовления заняло: {time.Hours} часов {time.Minutes} минут.\nМатериал изделия: {material}"); 
        }
    }

    public class ShipDetail : Detail
    {
        public ShipDetail(TimeSpan time) : base("сталь", time) { }
        public override void PrintProductDetail()
        {
            Console.WriteLine($"Деталь для корабля изготовлена.\nВремя для изготовления заняло: {time.Hours} часов {time.Minutes} минут.\nМатериал изделия: {material}");
        }
    }

    public class PlaneDetail : Detail
    {
        public PlaneDetail(TimeSpan time) : base("аллюминий", time) { }
        public override void PrintProductDetail()
        {
            Console.WriteLine($"Деталь для самолета изготовлена.\nВремя для изготовления заняло: {time.Hours} часов {time.Minutes} минут.\nМатериал изделия: {material}");
        }
    }
}
