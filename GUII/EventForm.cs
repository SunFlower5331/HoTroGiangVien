using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DTO;

namespace GUII
{
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
        }
        private void EventForm_Load(object sender, EventArgs e)
        {
            txtdate.Text = FormMenu.static_month + "/" + UserControlDay.satic_day+ "/" + FormMenu.static_year;
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            string userID = Program.userID;
            string date = txtdate.Text;
            string ca = txtevent.Text;

            BusinessLogic.AddTeachingSchedule(userID, date, ca);

            MessageBox.Show("Lịch giảng dạy đã được thêm thành công!");
            
          

        }
    }
}
