using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using System.Globalization;
namespace GUII
{
    public partial class FormMenu : Form

    {
        public static int static_month, static_year;
        int month, year;
        private UserBLL userBLL = new UserBLL();
        public string LoggedInAccountId { get; set; }

        public FormMenu()
        {
            InitializeComponent();
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            User user = userBLL.getAccByID(Program.userID);
            if (user != null)
            {
                hoten.Text = user.FullName;
                sdt.Text = user.PhoneNumber;
                sohd.Text = user.SoHD;
                luong.Text = user.Luong.ToString();
                email.Text = user.Email;
                diachi.Text = user.Address;
                hanhd.Text = user.NgayHetHan.ToString("dd/MM/yyyy");
            }
        }
    private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            displayDays();

        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbdate.Text = monthname + " " + year;
            static_month = month;
            static_year = year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank unblank = new UserControlBlank();
                flowLayoutPanel1.Controls.Add(unblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDay day = new UserControlDay();
                day.days(i);
                flowLayoutPanel1.Controls.Add(day);
            }
        }

        private void btprevious_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            month--;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbdate.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank unblank = new UserControlBlank();
                flowLayoutPanel1.Controls.Add(unblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDay day = new UserControlDay();
                day.days(i);
                flowLayoutPanel1.Controls.Add(day);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnext_Click(object sender, EventArgs e)
        {

            flowLayoutPanel1.Controls.Clear();
            month++;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbdate.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank unblank = new UserControlBlank();
                flowLayoutPanel1.Controls.Add(unblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDay day = new UserControlDay();
                day.days(i);
                flowLayoutPanel1.Controls.Add(day);
            }
        }



    private void thongtincanhan_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
