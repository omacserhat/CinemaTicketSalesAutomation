using CinemaTicketSalesAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSalesAutomation.Helpers
{
    public class Helper
    {
        public static List<Movie> CreateMovies()
        {
            string basePath = "C:/Users/serha/source/repos/CinemaTicketSalesAutomation/CinemaTicketSalesAutomation/Pictures/";
            return new List<Movie>
            {
                new Movie()
                {
                    movieName = "Yıldızlararası",
                    category = Enum.Category.BilimKurgu,
                    minute = "2 Saat 49 Dakika",
                    price = 50,
                    picturePath = basePath + "yildizlararasi.jpg"
                },
                new Movie()
                {
                    movieName = "Hızlı ve Öfkeli 3",
                    category = Enum.Category.Macera,
                    minute = "2 Saat 20 Dakika",
                    price = 60,
                    picturePath = basePath + "hizliveofkeli3.jpeg"
                },
                new Movie()
                {
                    movieName = "Nefesini Tut 2",
                    category = Enum.Category.Gerilim,
                    minute = "2 Saat 35 Dakika",
                    price = 45,
                    picturePath = basePath + "nefesini_tut2.jpg"
                },
                new Movie()
                {
                    movieName = "Üç Aptal",
                    category = Enum.Category.Komedi,
                    minute = "3 Saat 15 Dakika",
                    price = 40,
                    picturePath = basePath + "uc_aptal.jpg"
                },
                new Movie()
                {
                     movieName = "Örümcek Adam",
                    category = Enum.Category.Fantastik,
                    minute = "2 Saat 30 Dakika",
                    price = 50,
                    picturePath = basePath + "orumcek_adam.jpg"
                },
                new Movie()
                {
                     movieName = "Geleceğe Dönüş",
                    category = Enum.Category.Fantastik,
                    minute = "1 Saat 55 Dakika",
                    price = 30,
                    picturePath = basePath + "gelecege_donus.jpg"
                }
            };
        }
    }
}
