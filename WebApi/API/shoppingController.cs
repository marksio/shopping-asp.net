using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;
//using Newtonsoft.Json;

namespace WebApi.API
{
    public class shoppingController : ApiController
    {
        SchoolMangementEntities _ctx = null; // SchoolMangementEntities is data model name
        public shoppingController()
        {
            _ctx = new SchoolMangementEntities();
        }
        public HttpResponseMessage GetStudents()
        {
            // 
            List<tbl_Student> students = null;
            //System.Web.Mvc.JsonResult jsonResult = new System.Web.Mvc.JsonResult();
            
            try
            {
                students = _ctx.tbl_Student.ToList();
                //jsonResult.Data = JsonObjectToString(students);
                Request.Headers.Add("Accept", "text/json");
                
            }
            catch
            {

                students = null;
            }

            return Request.CreateResponse(HttpStatusCode.OK, students);
            //return jsonResult;
        }

        //public static String JsonObjectToString(Object jsonObject)
        //{
        //    JsonSerializerSettings theJsonSerializerSettings = new JsonSerializerSettings();

        //    theJsonSerializerSettings.TypeNameHandling = TypeNameHandling.None;
        //    theJsonSerializerSettings.NullValueHandling = NullValueHandling.Ignore;
        //    theJsonSerializerSettings.MissingMemberHandling = MissingMemberHandling.Ignore;

        //    string jsonString = JsonConvert.SerializeObject(jsonObject, theJsonSerializerSettings);

        //    return jsonString;
        //}
    }
}
