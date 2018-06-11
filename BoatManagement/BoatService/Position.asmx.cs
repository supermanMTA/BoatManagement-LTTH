using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace BoatService
{
    /// <summary>
    /// Summary description for Position1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Position1 : System.Web.Services.WebService
    {
        BoatLoadDataContext db = new BoatLoadDataContext();
        [WebMethod]
        public Position ListPosition(int ID_Journey)
        {          
                var list = db.Position.Where(p => p.IDJourney == ID_Journey).ToList();
                var position = list.OrderByDescending(p => p.Time).FirstOrDefault();
                return position;                                     
        }


   
        [WebMethod]
        public List<Position> GetPosition()
        {
            return db.Position.ToList();
        }

        [WebMethod]
        public Position GetPo(int IDPo)
        {
            return db.Position.ToList().Where(p => p.ID == IDPo).FirstOrDefault();
        }
        [WebMethod]
        public List<Position> GetAllPo(int idTrip)
        {
            return db.Position.Where(p => p.IDJourney == idTrip).OrderBy(p=>p.Time).ToList();
        }
        [WebMethod]
        public bool UpdatePosition(int idtrip, float longitude, float latitude, DateTime time, string ocean)
        {
            try
            {

                //  Journey trip = GetTripId(idTrip);
                Position po = new Position();
                po.IDJourney = idtrip;
                po.Latitude = latitude;
                po.Longitude = longitude;
                po.Time = time;
                po.Oceans = ocean;
                db.Position.InsertOnSubmit(po);
                db.SubmitChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }
    }
}
