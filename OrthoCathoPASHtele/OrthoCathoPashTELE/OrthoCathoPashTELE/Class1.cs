using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrthoCathoPashTELE
{
    public class OrthoCatho_Class
    {
        
        private int GOD_YEARS;
        #region // Properties int Anul in care dorim sa aflam cind e pastele
        public int God_Years
        {
            get { return GOD_YEARS; }
            set { GOD_YEARS = value; }
        }
        #endregion
        public  DateTime Catholic ( int GOD_YEARS )
        {
            int Y = GOD_YEARS;
            int a = Y % 19;
            int b = Y / 100;
            int c = Y % 100;
            int d = b / 4;
            int e = b % 4;
            int f = (b + 8) / 25;
            int g = (b - f + 1) / 3;
            int h = ((19 * a) + b - d - g + 15) % 30;
            int i = c / 4;
            int k = c % 4;
            int l = (32 + (2 * e) + (2 * i) - h - k) % 7;
            int m = (a + (11 * h) + (22 * l)) / 451;
            int month = (h + l - (7 * m) + 114) / 31;
            int day = ((h + l - (7 * m) + 114) % 31) + 1;
            DateTime myDTPashTELE = new DateTime (GOD_YEARS, month, day);
            return myDTPashTELE;
        }
        public  DateTime Orthodox ( int GOD_YEARS )
        {
            int Y = GOD_YEARS;
            int a = Y % 4;
            int b = Y / 7;
            int c = Y % 19;
            int d = ((19*c)+15) % 30;
            int e = ((2*a)+(4*b)-d+34) % 7;
 
            int month = (d+e+114)/31;

            int day = ((d+e+114)%31)+1;

            DateTime myDTPashTELE = new DateTime (GOD_YEARS, month, day);
            TimeSpan  AddMyDTPashTELE = new TimeSpan (13, 0, 0, 0);
            return myDTPashTELE + AddMyDTPashTELE ;
        }
    }
}
