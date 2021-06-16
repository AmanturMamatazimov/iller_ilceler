using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class ekle : Form
    {
        public ekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //VT kayit yapmak 3 adimi
            //1.boglanti nesnesi
            SqlConnection bag = new SqlConnection("Data Source=DESKTOP-DNDEKN8\\SQLEXPRESS;Initial Catalog=manas-iller;Integrated Security=True");//1
            //2.cammand nesnesi olustur:
            SqlCommand komut = new SqlCommand("insert into iller(iladi) values ('" +textBox1.Text+ "')", bag);
            bag.Open();
            //3
            komut.ExecuteNonQuery();
            bag.Close();
            textBox1.Text = "";
            dgvilyukle();
        }

        private void ekle_Load(object sender, EventArgs e)
        {
            dgvilyukle();
        }
        public void dgvilyukle()
        {
            //dgw il yukle
            SqlConnection bag = new SqlConnection("Data Source=DESKTOP-DNDEKN8\\SQLEXPRESS;Initial Catalog=manas-iller;Integrated Security=True");//1
            string sql = "select * from iller";
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);//2
            DataTable tablo = new DataTable();//3
            da.Fill(tablo);//4
            dataGridView1.DataSource = tablo;//5
        }
    }
}
