using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace BoatService
{
    /// <summary>
    /// Summary description for Journey1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Journey1 : System.Web.Services.WebService
    {
        BoatLoadDataContext db = new BoatLoadDataContext();
        [WebMethod]
       public List<Journey> LoadJourney()
       {
            return db.Journey.ToList();
       }
        [WebMethod]
        public List<Journey> LoadJourneyActive()
        {
            return db.Journey.Where(p=>p.Status==false).ToList();
        }
        [WebMethod]
        public List<Journey> GetTrip(int IDBoat)
        {
            return db.Journey.Where(p => p.IDBoat == IDBoat).ToList();
        }
        [WebMethod]
        public List<Port> GetAllPort()
        {
            return db.Port.ToList();
        }
        [WebMethod]
        public Journey GetTripId(int idtrip)
        {
            return db.Journey.ToList().Where(p => p.ID == idtrip).FirstOrDefault();
        }
        [WebMethod]
        public bool inserttrip(int Idboat, int beginposition, int endposition, float timeprovide, DateTime timebegin, DateTime timeend, bool status)
        {
            Journey trip = new Journey();
            trip.IDBoat = Idboat;
            trip.TimeBegin = timebegin;
            trip.TimeEnd = timeend;
            trip.TimeProvide = timeprovide;
            trip.Status = status;
            trip.EndPosition = endposition;
            trip.BeginPosition = beginposition;
            try
            {
                db.Journey.InsertOnSubmit(trip);
                db.SubmitChanges();
                return true;

            }
            catch
            {
                return false;
            }

        }
        [WebMethod]
        public bool UpdateTrip(int idTrip, int Idboat, int beginposition, int endposition, float timeprovide, DateTime timebegin, DateTime timeend, bool status)
        {
            try
            {

                Journey trip = GetTripId(idTrip);
                trip.IDBoat = Idboat;
                trip.TimeBegin = timebegin;
                trip.TimeEnd = timeend;
                trip.TimeProvide = timeprovide;
                trip.Status = status;
                trip.EndPosition = endposition;
                trip.BeginPosition = beginposition;
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
