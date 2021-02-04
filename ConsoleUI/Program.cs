using System;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
            Console.WriteLine("1- Araba ekle");
            Console.WriteLine("2- Araba güncelle");
            Console.WriteLine("3- Araba sil");
            Console.WriteLine("4- Marka Ekle");
            Console.WriteLine("5- Marka Güncelle");
            Console.WriteLine("6- Marka Sil");
            Console.WriteLine("7- Renk Ekle");
            Console.WriteLine("8- Renk Güncelle");
            Console.WriteLine("9- Renk Sil");
            Console.WriteLine("10- Arabaları Listele");
            var selectedOperation = Convert.ToInt32(Console.ReadLine());

            switch (selectedOperation)
            {
                case 1:
                    var car = new Car();
                    Console.Write("Marka Id: ");
                    car.BrandId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Renk Id: ");
                    car.ColorId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Model yılı: ");
                    car.ModelYear = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Günlük fiyat: ");
                    car.DailyPrice = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Araba ismi: ");
                    car.Description = Console.ReadLine();
                    carManager.Add(car);
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    Console.Write("Marka adı:");
                    var brand = new Brand();
                    brand.Name = Console.ReadLine();
                    brandManager.Add(brand);
                    break;
                case 7:
                    Console.Write("Renk adı:");
                    var color = new Color();
                    color.Name = Console.ReadLine();
                    colorManager.Add(color);
                    break;
                case 10:
                    foreach (var c in carManager.GetCars())
                    {
                        Console.WriteLine("-----Arabalar-----");
                        Console.WriteLine(c.Description);
                    }
                    break;
            }


        }
    }
}
