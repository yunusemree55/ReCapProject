using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Message(); //Giriş mesajı verildi.

            int i = 1;
            Console.WriteLine("< Araba Listesi >");
            
            foreach (var car in carManager.GetAll())  // Database'teki arabaları listeler
            {

                Console.WriteLine("{0}) {1}",i ,car.CarDescription);
                i++;
            }
            i = 1;
            //------------------------------ADD KOMUTU---------------------------------------------------------
            Console.WriteLine();
            Console.WriteLine();

            


            carManager.Add(new Car { CarId = 7, CarBrandId = 5, CarColorId = 3, CarModelYear = 2015, DailyPrice = 1800, CarDescription = "BMW 5 Serisi Sedan" });
            //Siteye araba eklemesi yapıldı
            
            Console.WriteLine();

            
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0}){1}",i,car.CarDescription);
                i++;
            }

            Console.WriteLine();
            Console.WriteLine();

            //-----------------------------------------------------------------------------------------------------
            Console.WriteLine("--------Araç Modelleri--------");

            Console.WriteLine("1)Ford Modelleri\n2)Toyota Modelleri\n3)Volkswagen Modelleri");
           
            Console.WriteLine("Görmek istediğiniz modelin sıra numarasını yazınız: ");
            int option = Convert.ToInt32(Console.ReadLine());


            switch (option)
            {
                case 1:
                    foreach (var car in carManager.GetCarByBrandId(4))
                    {
                        Console.WriteLine("<< Ford Modelleri >>");
                        Console.WriteLine("Araç Adı : {0}\nGünlük ücreti: {1} TL\n\n",car.CarDescription,car.DailyPrice);
                    }
                    break;
                case 2:
                    Console.WriteLine("<< Toyota Modelleri >>");
                    foreach (var car in carManager.GetCarByBrandId(2))
                    {
                        Console.WriteLine("Araç Adı : {0}\nGünlük ücreti: {1} TL\n\n", car.CarDescription, car.DailyPrice);
                    }
                    break;
                case 3:
                    Console.WriteLine("<< Volkswagen Modelleri >>");
                    foreach (var car in carManager.GetCarByBrandId(1))
                    {
                        Console.WriteLine("Araç Adı : {0}\nGünlük ücreti: {1} TL\n\n", car.CarDescription, car.DailyPrice);
                    }
                    break;
                default:
                    Console.WriteLine("Hatalı giriş!"); break;

            }
            Console.WriteLine(); Console.WriteLine();


            //---------------------------------------------DELETE KOMUTU--------------------------------------------------------------

            Car car1 = new Car() { CarId = 10, CarDescription = "Traktör" };    //Delete komutunun çalışıp çalışmadığını test etmek için eklendi.
            carManager.Add(car1);


            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarDescription);          //Araç listesinde "Traktör"ün olup olmadığını kontrol etmek için yazıldı.
            }
            
            carManager.Delete(car1);
            
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarDescription);         //Traktörün silinip silinmediğini kontrol etmek içi yazıldı
            }




        }
        static void Message()
        {
            Console.WriteLine("--------------Araba Kiralama--------------");
        }
    }
    
}
