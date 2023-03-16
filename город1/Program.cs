using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Cоздайте класс «Город». Необходимо хранить в полях класса: 
//    название города, название страны, 
//    количество жителей в городе, телефонный код города, название районов города. 
namespace город1
{
    class Program
    {
        static void Main(string[] args)
        {
            City myCity=new City("Kiev", 500000, "056", "Obolon");
            City myCity1 = new City();
            City myCity2 = new City(40000);
        }

    }
    
    class City
    {
        public string  CityName;
        public static  string CountryName;
        public double people;
        public string code;
        public string district;

        public static int Count;
        static City() //static constructor
        { Console.WriteLine("Static Constructor"); Count = 0; }

       
    public City(string CN, double p, string cod, string dis)//main constructor
        {
            Console.WriteLine("Main constructor");
        CityName = CN;
        people = p;
        code = cod;
        district = dis;
            Count++;

    }
        public City() { Console.WriteLine("default const"); }
        public City(double p):this ("Odessa", p, "048", "Kievskiy" )
        {
            Console.WriteLine("this constructor");
        }

        public void SetCity(string cit) { CityName = cit; }
        public string ShowCity()      {  return CityName; }
        public void SetCountry(string S) { CountryName = S; }
        public static string Country() { return CountryName; }
        public void SetPeople(double p) { people = p; }
        public double Population() { return people; }
        public void SetCode(string co) { code = co; }
        public string Code() { return code; }
        public void SetDistrict(string d) { district = d; }
        public string District() { return district; }
        public void Print() { }
    }

}
