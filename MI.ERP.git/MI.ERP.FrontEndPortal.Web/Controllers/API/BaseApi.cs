
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using MI.ERP.FrontEndPortal.Common.Configurtions;

namespace MI.ERP.FrontEndPortal.Web.Controllers.API
{
    public class BaseApi : ApiController
    {

        protected IAppSettings _AppSettings;
        protected BaseApi(IAppSettings appSettings)
        {
            _AppSettings = appSettings;
        }

    }
}