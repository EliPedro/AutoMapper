using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using MvcMapping.Mappers;

namespace MvcMapping
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            Application["appName"] = "AutoMapper e View Models";

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);


            AutoMapperConfig.RegisterMappings();
        }      
    }
}
