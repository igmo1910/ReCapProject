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
            Console.WriteLine("11- Markaları Listele");
            Console.WriteLine("12- Renkleri Listele");
            var selectedOperation = Convert.ToInt32(Console.ReadLine());

            switch (selectedOperation)
            {
                case 1:
                    var carToAdd = new Car();
                    Console.Write("Marka Id: ");
                    carToAdd.BrandId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Renk Id: ");
                    carToAdd.ColorId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Model yılı: ");
                    carToAdd.ModelYear = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Günlük fiyat: ");
                    carToAdd.DailyPrice = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Araba ismi: ");
                    carToAdd.Description = Console.ReadLine();
                    carManager.Add(carToAdd);
                    break;
                case 2:
                    ListAllCars(carManager);
                    Console.Write("Güncellemek istediğiniz arabayı seçiniz: ");
                    var selectedId = Convert.ToInt32(Console.ReadLine());
                    var carToUpdate = carManager.GetCarById(selectedId);
                    Console.Write("Marka Id: ");
                    carToUpdate.BrandId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Renk Id: ");
                    carToUpdate.ColorId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Model yılı: ");
                    carToUpdate.ModelYear = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Günlük fiyat: ");
                    carToUpdate.DailyPrice = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Araba ismi: ");
                    carToUpdate.Description = Console.ReadLine();
                    carManager.Update(carToUpdate);
                    break;
                case 3:
                    ListAllCars(carManager);
                    Console.Write("Silmek istediğiniz arabayı seçiniz:");
                    selectedId = Convert.ToInt32(Console.ReadLine());
                    var carToDelete = carManager.GetCarById(selectedId);
                    carManager.Delete(carToDelete);
                    break;
                case 4:
                    Console.Write("Marka adı:");
                    var brand = new Brand();
                    brand.Name = Console.ReadLine();
                    brandManager.Add(brand);
                    break;
                case 5:
                    ListAllBrands(brandManager);
                    Console.Write("Güncellemek istediğiniz markayı seçiniz: ");
                    selectedId = Convert.ToInt32(Console.ReadLine());
                    var brandToUpdate = brandManager.GetBrandById(selectedId);
                    Console.Write("Marka Adı: ");
                    brandToUpdate.Name = Console.ReadLine();
                    brandManager.Update(brandToUpdate);
                    break;
                case 6:
                    ListAllBrands(brandManager);
                    Console.Write("Silmek istediğiniz markayı seçiniz: ");
                    selectedId = Convert.ToInt32(Console.ReadLine());
                    var brandToDelete = brandManager.GetBrandById(selectedId);
                    brandManager.Delete(brandToDelete);
                    break;
                case 7:
                    Console.Write("Renk adı:");
                    var color = new Color();
                    color.Name = Console.ReadLine();
                    colorManager.Add(color);
                    break;
                case 8:
                    ListAllColors(colorManager);
                    Console.Write("Güncellemek istediğiniz rengi seçiniz: ");
                    selectedId = Convert.ToInt32(Console.ReadLine());
                    var colorToUpdate = colorManager.GetColorById(selectedId);
                    Console.Write("Renk Adı: ");
                    colorToUpdate.Name = Console.ReadLine();
                    colorManager.Update(colorToUpdate);
                    break;
                case 9:
                    ListAllColors(colorManager);
                    Console.Write("Silmek istediğiniz rengi seçiniz: ");
                    selectedId = Convert.ToInt32(Console.ReadLine());
                    var colorToDelete = colorManager.GetColorById(selectedId);
                    colorManager.Delete(colorToDelete);
                    break;
                case 10:
                    ListAllCars(carManager);
                    break;
                case 11:
                    ListAllBrands(brandManager);
                    break;
                case 12:
                    ListAllColors(colorManager);
                    break;
            }
        }

        private static void ListAllColors(ColorManager colorManager)
        {
            foreach (var color in colorManager.GetColors())
            {
                Console.WriteLine("-----Renkler-----");
                Console.WriteLine("{0} / {1}", color.Id, color.Name);
            }
        }

        private static void ListAllCars(CarManager carManager)
        {
            foreach (var c in carManager.GeCarDetails())
            {
                Console.WriteLine("-----Arabalar-----");
                Console.WriteLine("{0} / {1} / {2} / {3} / {4} / {5}", c.CarId, c.CarName, c.BrandName, c.ColorName, c.ModelYear, c.DailyPrice);
            }
        }

        private static void ListAllBrands(BrandManager brandManager)
        {
            foreach (var brand in brandManager.GetBrands())
            {
                Console.WriteLine("-----Markalar-----");
                Console.WriteLine("{0} / {1}", brand.Id, brand.Name);
            }
        }
    }
}
