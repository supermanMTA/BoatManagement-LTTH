using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Services;

namespace BoatService
{
    /// <summary>
    /// Summary description for ServiceBoat
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServiceBoat : System.Web.Services.WebService
    {
        BoatLoadDataContext db = new BoatLoadDataContext();
        [WebMethod]
        public List<Boat> GetAllBoat()
        {
            return db.Boat.Where(p=>p.Status==true).ToList();
        }
        [WebMethod]
        public Boat GetBoat(int IdBoat)
        {
            return db.Boat.ToList().Where(p => p.ID == IdBoat).FirstOrDefault();
        }
        [WebMethod]
     
        public National GetNational(int IdNational)
        {
            return db.National.ToList().Where(p => p.ID == IdNational).FirstOrDefault();
        }
        [WebMethod]
        public List<National> GetAllNational()
        {
            return db.National.ToList();
        }
        [WebMethod]
        public List<TypeBoat> GetAllType()
        {
            return db.TypeBoat.ToList();
        }
        [WebMethod]
        public TypeBoat GetTypeBoat(int IdtypeBoat)
        {
            return db.TypeBoat.ToList().Where(p => p.ID == IdtypeBoat).FirstOrDefault();
        }
        public Position ListPosition(int ID_Journey)
        {
            var list = db.Position.Where(p => p.IDJourney == ID_Journey).ToList();
            var position = list.OrderByDescending(p => p.Time).FirstOrDefault();
            return position;
        }

        public struct BoatActive
        {
            public int ID
            {
                set;
                get;
            }
            public string Name
            {
                set;
                get;
            }
            public string IMO
            {
                set;
                get;
            }
            public float Longiude
            {
                set;
                get;
            }
            public float Latiude
            {
                set;
                get;
            }
            public string Ocean
            {
                set;
                get;
            }
            public int IDPosition
            {
                set;
                get;
            }
            public DateTime Time
            {
                set;
                get;
            }
            public int ID_Journey
            {
                set;
                get;
            }
        }

        public struct Statictics
        {
            public string name { get; set; }
        //    public int count { get; set; }
            public List<Boat> BoatOcean { get; set; }
        }

   //     [WebMethod]
        //public List<Statictics> GetBoatOcean()
        //{
        //    var x = from p in BoatAreActive()
        //            group p by p.Ocean into g
        //            select new Statictics()
        //            {
        //                name=g.Key,
        //                BoatOcean=g.ToList()
        //            };
        //}
        [WebMethod]
        
        public List<BoatActive> BoatAreActive()
        {
            var boat = GetAllBoat();
            var position = db.Position.ToList();
            var journey = db.Journey.Where(p=>p.Status==false).ToList();
            var BoatActive = (from a in journey
                              join b in boat
                              on a.IDBoat equals b.ID
                              select new
                              {
                                  ID = b.ID,
                                  Name = b.Name,
                                  IMO = b.IMO,
                                  ID_Journey = a.ID
                              }).ToList();

            List<BoatActive> ListBoatActive = (from p in BoatActive
                                               select new BoatActive
                                               {
                                                   ID = p.ID,
                                                   Name = p.Name,
                                                   IMO = p.IMO,
                                                   Latiude = (float)ListPosition(p.ID_Journey).Latitude,
                                                   Longiude = (float)ListPosition(p.ID_Journey).Longitude,
                                                   Ocean = ListPosition(p.ID_Journey).Oceans,
                                                   IDPosition = ListPosition(p.ID_Journey).ID,
                                                   Time = (DateTime)ListPosition(p.ID_Journey).Time,
                                                   ID_Journey = p.ID_Journey
                                        }).ToList();
            return ListBoatActive;
        }

        [WebMethod]

        public List<BoatLostInfor> AllBoatLostInfor()
        {
            return db.BoatLostInfor.ToList();
        }
        [WebMethod]
        public bool insertboat(string name, string imo, string mmsi, int idnational, int idtypeboat, float volume, float tonnage, float high, float length, bool status, byte[] image)
        {
            Boat boat = new Boat();
            boat.Name = name;
            boat.IMO = imo;
            boat.MMSI = mmsi;
            boat.IDNational = idnational;
            boat.Tonnage = tonnage;
            boat.Volume = volume;
            boat.IDTypeBoat = idtypeboat;
            boat.Length = length;
            boat.High = high;
            boat.Status = status;
            boat.Image = image;
            try
            {
                db.Boat.InsertOnSubmit(boat);
                db.SubmitChanges();
                return true;

            }
            catch
            {
                return false;
            }

        }
        [WebMethod]
        public bool UpdateBoat(int idBoat, string name, string imo, string mmsi, int idnational, int idtypeboat, float volume, float tonnage, float high, float length, bool status, byte[] image)
        {
            try
            {
                Boat boat = GetBoat(idBoat);
                boat.Name = name;
                boat.IMO = imo;
                boat.MMSI = mmsi;
                boat.IDNational = idnational;
                boat.Tonnage = tonnage;
                boat.Volume = volume;
                boat.IDTypeBoat = idtypeboat;
                boat.Length = length;
                boat.High = high;
                boat.Status = status;
                boat.Image = image;
                db.SubmitChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }
        [WebMethod]
        public bool DeleteBoat(int idBoat)
        {
            try
            {
                Boat boat = db.Boat.Where(p => p.ID == idBoat).FirstOrDefault();
                boat.Status = false;
               // db.Boat.DeleteOnSubmit(boat);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public struct Sati
        {
            public string National
            {
                set;
                get;
            }
            public int Quantity
            {
                set;
                get;
            }
        }

        [WebMethod]

        public List<Sati> CountBoat()
        {
            List<Sati> CB = new List<Sati>();
            foreach (var group in db.Boat.GroupBy(i => i.IDNational))
            {
                Sati sat = new Sati();
                int str = group.Key.GetValueOrDefault();
                var x = db.National.Where(p => p.ID == str).FirstOrDefault();
                sat.National = x.Name;
                sat.Quantity = group.Count();
                CB.Add(sat);

            }
            return CB;
        }

        
    }
}
