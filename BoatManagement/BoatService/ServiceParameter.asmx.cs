using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace BoatService
{
    /// <summary>
    /// Summary description for ServiceParameter
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServiceParameter : System.Web.Services.WebService
    {
        BoatLoadDataContext db = new BoatLoadDataContext();
        [WebMethod]
        public Parameter parameter(int ID_Position)
        {
            return db.Parameter.Where(p => p.IDPosition == ID_Position).FirstOrDefault();
        }

        [WebMethod]
        public void InsertParameter(int ID_Position, int speed, int waterlevel, int wind, string weather)
        {
            Parameter para = new Parameter();
            para.IDPosition = ID_Position;
            para.Speed = speed;
            para.Waterlevel = waterlevel;
            para.Weather = weather;
            para.Wind = wind;
            try
            {
                db.Parameter.InsertOnSubmit(para);
                db.SubmitChanges();
            }
            catch
            {

            }
        }
    }
}
