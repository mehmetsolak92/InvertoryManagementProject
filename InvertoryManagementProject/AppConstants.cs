using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertoryManagementProject
{
    public static class GlobalVariables
    {
        public static string SQLPath = "Data Source=(local);Initial Catalog=InventoryManagement;User Id=mehmet;Password=57781123;TrustServerCertificate=True;";
        public static string LogPath = @"c:\Odslabdata\Log\log.txt";
        public static List<string> cargoTypes = new List<string>();
        public static List<string> paymentTypes = new List<string>();
        public static List<City> Cities = new List<City>();
        public static List<District> Districts = new List<District>();
        public static List <string> Brands = new List<string>();
        public static List <string> Suppliers = new List<string>();
        public static List<Category> Categories = new List<Category>();
        public static List<SubCategory> SubCategories = new List<SubCategory>();

        public static List<string> CurrencyUnits = new List<string>
        {
            "Seçiniz..",
            " ",
            "TL",
            "EUR",
            "USD"
        };

        public static List<string> ProductUnits = new List<string>
        {
            "Seçiniz..",
            " ",
            "Adet",
            "Metre",
            "Kg",
            "Set",
            "Gün"
        };

        public static List<string> ProductTypes = new List<string>
        {
            "Seçiniz..",
            " ",
            "Ürün",
            "Servis"
        };



    }

    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int PlateNumber { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class District
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CityPlateNumber { get; set; }
        public override string ToString()
        {
            return Name; 
        }
    }

    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }

    public class SubCategory
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }











}
