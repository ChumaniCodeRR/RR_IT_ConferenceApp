﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConferenceSys;
using System.Drawing;

namespace Global
{
    static class Global
    {
        public static NS_System.StrongTypesNS.DS_PHOTODataSet ds_logo;
        public static NS_Conference.StrongTypesNS.ds_booking_summaryDataSet ds_bookings;
        public static NS_Conference.StrongTypesNS.ds_bookingsDataSet ds_single_booking;
        public static NS_Conference.StrongTypesNS.ds_conference_lookupDataSet ds_conference_lookups;
        public static NS_Conference.StrongTypesNS.ds_conf_codesDataSet ds_conf_codes;
        public static NS_Global.StrongTypesNS.ds_stuDataSet ds_Stu;

        public static Bitmap RULogo = new Bitmap(ConferenceSys.Properties.Resources.RUpurple);
        public static Bitmap NoPhoto = new Bitmap(ConferenceSys.Properties.Resources.no_photo_available);

        public static bool fincore_status;
    }
}
