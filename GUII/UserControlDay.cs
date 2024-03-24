using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUII
{
    public partial class UserControlDay : UserControl
    {
        public static string satic_day;
        public UserControlDay()
        {
            InitializeComponent();
        }
        public void days(int munday)
        {
            idday.Text = munday + "";

        }

        private void UserControlDay_Click(object sender, EventArgs e)
        {
            satic_day = idday.Text;

            EventForm even = new EventForm();
            even.Show();

        }

        private void UserControlDay_Load(object sender, EventArgs e)
        {

        }
    }
}
