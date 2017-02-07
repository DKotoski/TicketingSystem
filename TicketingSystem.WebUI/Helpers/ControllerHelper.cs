using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketingSystem.WebUI.Helpers
{
    public static class ControllerHelper
    {
        public static string CurrentUsername
        {
            get
            {
                {
                    return HttpContext.Current.User.Identity.Name;
                }
            }
        }

        public static bool IsLoggedIn
        {
            get
            {
                return HttpContext.Current.User.Identity.IsAuthenticated;
            }
        }
    }
}