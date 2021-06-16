using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection bag = new SqlConnection("Data Source=DESKTOP-DNDEKN8\\SQLEXPRESS;Initial Catalog=manas-iller;Integrated Security=True");//1
            string sql = "select * from iller";
            SqlDataAdapter da = new SqlDataAdapter(sql,bag);//2
            DataTable tablo = new DataTable();//3
            da.Fill(tablo);//4
            comboBox1.DataSource = tablo;//5
            comboBox1.DisplayMember = "iladi";
            comboBox1.ValueMember = "ilid";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         //   int seciliil = Convert.ToInt32(comboBox1.SelectedValue);
            SqlConnection bag = new SqlConnection("Data Source=DESKTOP-DNDEKN8\\SQLEXPRESS;Initial Catalog=manas-iller;Integrated Security=True");//1
            //string sql = "select * from ilceler where ili=seciliil'"+ comboBox1.SelectedValue+"'";
            SqlDataAdapter da = new SqlDataAdapter("select * from ilceler where ili='" + comboBox1.SelectedValue + "'", bag);//2

            DataTable tablo = new DataTable();//3
            da.Fill(tablo);//4
            comboBox2.DataSource = tablo;//5
            comboBox2.DisplayMember = "ilceadi";
            comboBox2.ValueMember = "ilceid";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ekle formunu acmak icin gerekli kodlar
            ekle frm2 = new ekle();
            frm2.Show();
        }
    }
}
