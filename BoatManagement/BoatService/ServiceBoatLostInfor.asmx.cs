using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace BoatService
{
    /// <summary>
    /// Summary description for BoatLostInfor1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]

    public class BoatLost
    {
        
    }
    public class BoatLostInfor1 : System.Web.Services.WebService
    {
        BoatLoadDataContext db = new BoatLoadDataContext();
        [WebMethod]
      
       public List< BoatLostInfor> AllBoatLoatInfor()
        {
           return db.BoatLostInfor.ToList();
        }

        [WebMethod]
        public bool Insert(DateTime Lastconnect, float lat,float Long,int ID_jouney,bool status,int ID_boat,string ocean)
        {
            BoatLostInfor BoatLostInfor = new BoatLostInfor();
            BoatLostInfor.IDBoat = ID_boat;
            BoatLostInfor.Latitude = lat;
            BoatLostInfor.Longitude = Long;
            BoatLostInfor.LastConnect= Lastconnect;
            BoatLostInfor.Ocean = ocean;
            BoatLostInfor.Status = status;
            BoatLostInfor.IDJourney = ID_jouney;
            try
            {
                db.BoatLostInfor.InsertOnSubmit(BoatLostInfor);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        [WebMethod]
        public bool Update(int ID,DateTime timeconnect, float lat, float Long, int ID_jouney, string ocean)
        {
           BoatLostInfor boatlost= db.BoatLostInfor.Where(p => p.ID == ID).FirstOrDefault();
            
            try
            {
                Position po = new Position();
                po.IDJourney = ID_jouney;
                po.Latitude = lat;
                po.Longitude = Long;
                po.Time = timeconnect;
                po.Oceans = ocean;
                db.Position.InsertOnSubmit(po);
                db.SubmitChanges();

                db.BoatLostInfor.DeleteOnSubmit(boatlost);
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
