using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilities
{
    internal static class AccessControl
    {
        internal static bool HasConfAdmin;
        internal static bool HasConfWarden;
        internal static bool HasManager;
        internal static bool HasUpdatePayments;
        internal static bool HasOverrideDates;
        
        internal static void CheckUserAccess()
        {
            HasConfAdmin = Proxy.System.Check_Sub_Menu_Access("Conf_Admin");
            HasConfWarden = Proxy.System.Check_Sub_Menu_Access("Conf_Warden");
            HasManager = Proxy.System.Check_Sub_Menu_Access("Conf_Manager");
            HasUpdatePayments = Proxy.System.Check_Sub_Menu_Access("Update_payments");

            HasOverrideDates = Proxy.System.Check_Sub_Menu_Access("OverrideDates");
        }
    }
}
