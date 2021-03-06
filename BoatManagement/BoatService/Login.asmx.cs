﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace BoatService
{
    /// <summary>
    /// Summary description for Login
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Login : System.Web.Services.WebService
    {
        BoatLoadDataContext db = new BoatLoadDataContext();
        [WebMethod]
       public bool CheckLogin(string account, string password)
       {
            var ListUser = db.User.ToList();
            if (ListUser.Where(p => p.Account == account && p.Password == password).ToList().Count == 0) return false;
            return true;
       }

        [WebMethod]
        public User getUser(string account) 
        {
            return db.User.Where(p => p.Account == account).FirstOrDefault();
        }
        [WebMethod]
        public bool updatepass(string account, string pass)
        {
            try
            {
                var user = db.User.Where(p => p.Account == account).FirstOrDefault();
                user.Account = account;
                user.Password = pass;
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        
    }
}
