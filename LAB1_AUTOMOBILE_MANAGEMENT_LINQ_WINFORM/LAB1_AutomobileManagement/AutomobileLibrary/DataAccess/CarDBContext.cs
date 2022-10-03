using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileLibrary.BussinessObject;
namespace AutomobileLibrary.DataAccess
{
    public class CarDBContext
    {
        //initialize car list 
        private static List<Car> Carlist = new List<Car>()
        {
            new Car { CarID =1, CarName="CRV", Manufacturer="Honda",
            Price = 30000, ReleaseYear=2012 },
            new Car { CarID =2, CarName="Ford Focus", Manufacturer="Ford",
            Price = 150000, ReleaseYear=20202 }

        };
        //using singleton pattern 
        private static CarDBContext instance = null;
        private static readonly object instanceLock = new object();
        private CarDBContext() { }
        //-----------------------------------//
        public static CarDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarDBContext();
                    }
                    return instance;
                }
            }
        }
        //-----------------------------------//
        public Car GetCarById (int carID)
        {
            //using LINQ to Object
            Car car = Carlist.SingleOrDefault(pro => pro.CarID == carID);
            return car;
        }
        //-----------------------------------//
        public List<Car> GetCarList => Carlist;
        //-----------------------------------//
        //add Car 
        public void AddNew (Car car)
        {
            Car pro = GetCarById(car.CarID);
            if(pro == null)
            {
                Carlist.Add(car);
            } else
            {
                throw new Exception("Car is already exists !!");
            }
        }
        //-----------------------------------//
        //update a car 
        public void Update(Car car)
        {
            Car c = GetCarById(car.CarID);
            if(c!= null)
            {
                var index = Carlist.IndexOf(c);
                Carlist[index] = car;
            } else
            {
                throw new Exception("Car does not already exists!!");
            }
        }
        //-----------------------------------//
        //remove a car 
        public void Remove (int carId)
        {
            Car p = GetCarById(carId);
            if (p != null)
            {
                Carlist.Remove(p);
            } else
            {
                throw new Exception("Car does not already exists!!!");
            }
        }
        //-----------------------------------//
    }//endclass
}//end namespace
