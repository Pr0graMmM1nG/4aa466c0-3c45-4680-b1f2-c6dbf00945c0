using System;
using System.Windows.Forms;
using OrthoCathoPashTELE;


namespace Paştele
{
    public partial class Form1 : Form
    {
        #region // Properties GOD_Rus_String
        private int GOD_rus_string;

        public int GOD_Rus_String
        {
            get { return GOD_rus_string; }
            set { GOD_rus_string = value; }
        }
        #endregion
        public Form1 ()
        {
            InitializeComponent ();
        }

        public DateTime Catholic ( int GOD_YEARS )
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
        public DateTime Orthodox ( int GOD_YEARS )
        {
            int Y = GOD_YEARS;
            int a = Y % 4;
            int b = Y % 7;
            int c = Y % 19;
            int d = ((19 * c) + 15) % 30;
            int e = ((2 * a) + (4 * b) - d + 34) % 7;

            int month = (d + e + 114) / 31;

            int day = ((d + e + 114) % 31) + 1;

            DateTime myDTPashTELE = new DateTime (GOD_YEARS, month, day);
            TimeSpan AddMyDTPashTELE = new TimeSpan (13, 0, 0, 0);
            return myDTPashTELE + AddMyDTPashTELE;
        }
        private void TextBox1_Key_Up ( object sender, KeyEventArgs e )
        {
            string text = textBox1 .Text ;
            int num;
            bool res = int.TryParse (text, out num);
            if (res == false)
            {
                textBox1.Text = "";
            }
            else
            {
                GOD_Rus_String = Convert.ToInt32 (textBox1.Text);
            }
           

        }
        private void button1_Click ( object sender, EventArgs e )
        {
            OrthoCathoPashTELE.OrthoCatho_Class a = new OrthoCathoPashTELE.OrthoCatho_Class ();
            if ( radioButton1 .Checked == true)
            {
                
               label1 .Text= Orthodox (GOD_Rus_String).ToString ();
            }
            else
            {
                label1.Text = Catholic  (GOD_Rus_String).ToString ();
            }

        }

       
    } 
}
