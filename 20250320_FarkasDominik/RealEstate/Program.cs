using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Category(int catId, string catName) 
        { 
            Id = catId;
            Name = catName;
        }
    }

     class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Phone { get; set; }

        public Seller(int sellerId, string sellerName, string sellerPhone) 
        {
            Id = sellerId;
            Name = sellerName;
            Phone = sellerPhone;

        }
    }

    class Ad
    {
       
        //id;rooms;latlong;floors;area;description;freeOfCharge;imageUrl;createAt;sellerId;sellerName;sellerPhone;categoryId;categoryName
        public int Id;
        public int Rooms;
        public string LatLong;
        public int Floors;
        public int Area;
        public string Description;
        public bool FreeOfCharge;
        public string ImageUrl;
        public DateTime CreateAt;
        public Seller Seller;
        public Category Cathegory;

        public Ad(string lines)
        {
            string[] strings = lines.Split(';');//.Skip(1).ToArray();
            this.Id = int.Parse(strings[0]);
            this.Rooms = int.Parse(strings[1]);
            this.LatLong = strings[2];
            this.Floors = int.Parse(strings[3]);
            this.Area = int.Parse(strings[4]);
            this.Description = strings[5];
            if (strings[6] == "0")
            {
                this.FreeOfCharge = false;
            }
            this.ImageUrl = strings[7];
            this.CreateAt = DateTime.Parse(strings[8]);

            int sellerId = int.Parse(strings[9]);
            string sellerName = strings[10];
            string sellerPhone = strings[11];

            this.Seller = new Seller(sellerId, sellerName, sellerPhone);

            int catId = int.Parse(strings[12]);
            string catName = strings[13];

            this.Cathegory = new Category(catId, catName);
        }

        public static List<Ad> LoadFromCsv(string filename) 
        { 
            List<Ad> list = new List<Ad>();
            StreamReader sr = new StreamReader(filename);
            string line = sr.ReadLine();
            while (!sr.EndOfStream) 
            { 
               
                list.Add(new Ad(sr.ReadLine()));
            }
            sr.Close();
            return list;
        }


    }

    

    internal class Program
    {
        public static double DistanceTo(string latLong, string gps)
        {
            string[] split = latLong.Split(',');
            long gps1 = long.Parse(split[0]);
            long gps2 = long.Parse(split[1]);

            string[] split2 = gps.Split(',');
            long gps3 = long.Parse(split2[0]);
            long gps4 = long.Parse(split2[1]);

            double tavolsag = Math.Sqrt(Math.Pow(gps1-gps3, 2) + Math.Pow(gps2-gps4, 2));

            return tavolsag;

        }
        static void Main(string[] args)
        {
            List<Ad> adatok = Ad.LoadFromCsv("realestates.csv");

            #region 6. feladat
            int összeg = 0;
            int db = 0;

            for (int i = 0; i < adatok.Count; i++) 
            {
                if (adatok[i].Floors == 0)
                {
                    összeg += adatok[i].Area;
                    db++;
                }
            }
            double átlag = Math.Round(((double)összeg) / db, 2);
            Console.WriteLine($"6. feladat: A földszinti ingatlanok áltagterülete: {átlag} m2");


            #endregion
            int mintav = 0;

            #region 8.feladat
            for (int i = 0;i < adatok.Count; i++)
            {
                
            }


            #endregion
            Console.ReadKey();
        }
    }
}
