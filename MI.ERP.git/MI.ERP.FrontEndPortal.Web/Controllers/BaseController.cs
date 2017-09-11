
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MI.ERP.FrontEndPortal.Common.Configurtions;


namespace MI.ERP.FrontEndPortal.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        protected IAppSettings _AppSettings;
        protected BaseController(IAppSettings appSettings)
        {
            _AppSettings = appSettings;         
        }
    }
}