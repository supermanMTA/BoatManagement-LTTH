using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace BoatService
{
    /// <summary>
    /// Summary description for ServicePortNational
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicePortNational : System.Web.Services.WebService
    {
        BoatLoadDataContext db = new BoatLoadDataContext();
        #region Lấy dữ liệu
        [WebMethod]
        public List<National> ListNational()
        {
            return db.National.ToList();
        }
        [WebMethod]
        public List<Port> ListPort()
        {
            return db.Port.ToList();
        }

        [WebMethod]
        public List<Port> ListPortOfNational(int ID_Nationnal)
        {
            return db.Port.Where(p => p.ID_Nation == ID_Nationnal).ToList();
        }
        [WebMethod]
        public National GetNational(int ID)
        {
            return db.National.Where(p => p.ID == ID).FirstOrDefault();
        }

        [WebMethod]
        public Port GetPortByID(int ID_port)
        {
            return db.Port.Where(p => p.ID == ID_port).FirstOrDefault();
        }
        #endregion

        #region Dịch vụ của National
        [WebMethod]       
        public bool InsertNational(string name, byte[] image)
        {
            National national = new National();
            national.Name = name;
            national.Image = image;
            try
            {
                db.National.InsertOnSubmit(national);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        [WebMethod]
        public bool UpdateNational(int id,string name, byte[] image)
        {
           
            try
            {
                National national = GetNational(id);
                national.Name = name;
                national.Image = image;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        [WebMethod]
        public bool DeleteNational(int id)
        {
            try
            {
                National boat = db.National.Where(p => p.ID == id).FirstOrDefault();
                db.National.DeleteOnSubmit(boat);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Dịch vụ của Port
        [WebMethod]
        public bool InsertPort(string name, float Lat, float Long, int national,string Ocean)
        {
            Port port = new Port();
            port.Name = name;
            port.Latitude = Lat;
            port.Longitude = Long;
            port.ID_Nation = national;
            port.Ocean = Ocean;
            try
            {
                db.Port.InsertOnSubmit(port);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        [WebMethod]
        public bool UpdatePort(int id,string name, float Lat, float Long, int national, string Ocean)
        {
            Port port = new Port();
            port = db.Port.Where(p => p.ID == id).FirstOrDefault();
            port.Name = name;
            port.Latitude = Lat;
            port.Longitude = Long;
            port.Ocean = Ocean;
            port.ID_Nation = national;
            try
            {
               
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion
    }
}
