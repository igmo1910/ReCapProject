using System;
using Business.Abstract;
using Business.Concrete;
using Core.Entities;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

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
            Console.WriteLine("13- Kullanıcı Ekle");
            Console.WriteLine("14- Müşteri Ekle");
            Console.WriteLine("15- Araba Kirala");
            Console.Write("Yapmak istediğiniz işlemi seçin:");
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
                    var result = carManager.Add(carToAdd);
                    Console.WriteLine(result.Message);
                    break;
                case 2:
                    ListAllCars(carManager);
                    Console.Write("Güncellemek istediğiniz arabayı seçiniz: ");
                    var selectedId = Convert.ToInt32(Console.ReadLine());
                    var carToUpdate = carManager.GetCarById(selectedId);
                    Console.Write("Marka Id: ");
                    carToUpdate.Data.BrandId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Renk Id: ");
                    carToUpdate.Data.ColorId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Model yılı: ");
                    carToUpdate.Data.ModelYear = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Günlük fiyat: ");
                    carToUpdate.Data.DailyPrice = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Araba ismi: ");
                    carToUpdate.Data.Description = Console.ReadLine();
                    result = carManager.Update(carToUpdate.Data);
                    Console.WriteLine(result.Message);
                    break;
                case 3:
                    ListAllCars(carManager);
                    Console.Write("Silmek istediğiniz arabayı seçiniz:");
                    selectedId = Convert.ToInt32(Console.ReadLine());
                    var carToDelete = carManager.GetCarById(selectedId);
                    result = carManager.Delete(carToDelete.Data);
                    Console.WriteLine(result.Message);
                    break;
                case 4:
                    Console.Write("Marka adı:");
                    var brand = new Brand();
                    brand.Name = Console.ReadLine();
                    result = brandManager.Add(brand);
                    Console.WriteLine(result.Message);
                    break;
                case 5:
                    ListAllBrands(brandManager);
                    Console.Write("Güncellemek istediğiniz markayı seçiniz: ");
                    selectedId = Convert.ToInt32(Console.ReadLine());
                    var brandToUpdate = brandManager.GetBrandById(selectedId);
                    Console.Write("Marka Adı: ");
                    brandToUpdate.Data.Name = Console.ReadLine();
                    result = brandManager.Update(brandToUpdate.Data);
                    Console.WriteLine(result.Message);
                    break;
                case 6:
                    ListAllBrands(brandManager);
                    Console.Write("Silmek istediğiniz markayı seçiniz: ");
                    selectedId = Convert.ToInt32(Console.ReadLine());
                    var brandToDelete = brandManager.GetBrandById(selectedId);
                    result = brandManager.Delete(brandToDelete.Data);
                    Console.WriteLine(result.Message);
                    break;
                case 7:
                    Console.Write("Renk adı:");
                    var color = new Color();
                    color.Name = Console.ReadLine();
                    result = colorManager.Add(color);
                    Console.WriteLine(result.Message);
                    break;
                case 8:
                    ListAllColors(colorManager);
                    Console.Write("Güncellemek istediğiniz rengi seçiniz: ");
                    selectedId = Convert.ToInt32(Console.ReadLine());
                    var colorToUpdate = colorManager.GetColorById(selectedId);
                    Console.Write("Renk Adı: ");
                    colorToUpdate.Data.Name = Console.ReadLine();
                    result = colorManager.Update(colorToUpdate.Data);
                    Console.WriteLine(result.Message);
                    break;
                case 9:
                    ListAllColors(colorManager);
                    Console.Write("Silmek istediğiniz rengi seçiniz: ");
                    selectedId = Convert.ToInt32(Console.ReadLine());
                    var colorToDelete = colorManager.GetColorById(selectedId);
                    result = colorManager.Delete(colorToDelete.Data);
                    Console.WriteLine(result.Message);
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
                case 13:
                    var userToAdd = new User();
                    Console.Write("Kullanıcı adı: ");
                    userToAdd.FirstName = Console.ReadLine();
                    Console.Write("Kullanıcı soyadı: ");
                    userToAdd.LastName = Console.ReadLine();
                    Console.Write("E-posta adresi: ");
                    userToAdd.Email = Console.ReadLine();
                    Console.Write("Şifre: ");
                    userToAdd.Password = Console.ReadLine();
                    result = userManager.Add(userToAdd);
                    Console.WriteLine(result.Message);
                    break;
                case 14:
                    ListAllUsers(userManager);
                    Console.Write("Müşteri olacak kullanıcıyı seçiniz: ");
                    selectedId = Convert.ToInt32(Console.ReadLine());
                    var selectedUser = userManager.GetUserById(selectedId).Data;
                    var customerToAdd = new Customer();
                    customerToAdd.UserId = selectedUser.Id;
                    Console.Write("Şirket adı: ");
                    customerToAdd.CompanyName = Console.ReadLine();
                    result = customerManager.Add(customerToAdd);
                    Console.WriteLine(result.Message);
                    break;
                case 15:
                    ListAllCars(carManager);
                    Console.Write("Kiralanacak arabayı seçiniz: ");
                    var selectedCar = Convert.ToInt32(Console.ReadLine());
                    result = rentalManager.CheckCarRentalStatus(selectedCar);
                    if (result.Success)
                    {
                        Console.WriteLine(result.Message);
                    }
                    else
                    {
                        Console.WriteLine(result.Message);
                        break;
                    }
                    ListAllCustomers(customerManager);
                    Console.Write("Kiralayacak müşteriyi seçiniz: ");
                    var selectedCustomer = Convert.ToInt32(Console.ReadLine());
                    var rentalToAdd = new Rental();
                    rentalToAdd.CarId = selectedCar;
                    rentalToAdd.CustomerId = selectedCustomer;
                    rentalToAdd.RentDate = DateTime.Now;
                    var rentalResult = rentalManager.Add(rentalToAdd);
                    Console.WriteLine(rentalResult.Message);
                    break;
            }
        }

        private static void ListAllColors(ColorManager colorManager)
        {
            Console.WriteLine("-----Renkler-----");
            foreach (var color in colorManager.GetColors().Data)
            {
                Console.WriteLine("{0} / {1}", color.Id, color.Name);
            }
        }

        private static void ListAllCars(CarManager carManager)
        {
            Console.WriteLine("-----Arabalar-----");
            foreach (var c in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("{0} / {1} / {2} / {3} / {4} / {5}", c.CarId, c.CarName, c.BrandName, c.ColorName, c.ModelYear, c.DailyPrice);
            }
        }

        private static void ListAllBrands(BrandManager brandManager)
        {
            Console.WriteLine("-----Markalar-----");
            foreach (var brand in brandManager.GetBrands().Data)
            {
                Console.WriteLine("{0} / {1}", brand.Id, brand.Name);
            }
        }

        private static void ListAllUsers(UserManager userManager)
        {
            Console.WriteLine("-----Kullanıcılar-----");
            foreach (var user in userManager.GetUsers().Data)
            {
                Console.WriteLine("{0} / {1} / {2}", user.Id, user.FirstName, user.LastName);
            }
        }

        private static void ListAllCustomers(CustomerManager customerManager)
        {
            Console.WriteLine("-----Müşteriler-----");
            foreach (var customer in customerManager.GetCustomerDetails().Data)
            {
                Console.WriteLine("{0} / {1} / {2} / {3}", customer.CustomerId, customer.FirstName, customer.LastName, customer.CompanyName);
            }
        }
    }
}
