using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new NorthwindContext())
            {
                // var qur1 = db.Products.Select(p => new { p.ProductName, p.QuantityPerUnit}).ToList();
                // dataGridView1.DataSource = qur1;

                //var qur2 = db.Products.Where(p => p.Discontinued== false).Select(p => new {p.ProductId,p.ProductName}).ToList();
                // dataGridView1.DataSource = qur2;


                // var qur3 = db.Products.Where(p => p.Discontinued == true).Select(p => new { p.ProductId, p.ProductName }).ToList();
                // dataGridView1.DataSource = qur3;


                //var qur4 = db.Products.OrderBy(p=>p.UnitPrice).Select(p => new {p.ProductName , p.UnitPrice}).ToList();
                //var qur41 = db.Products.Where(p => p.UnitPrice == qur4[0].UnitPrice || p.UnitPrice == qur4[qur4.Count - 1].UnitPrice).Select(p => new { p.ProductName, p.UnitPrice }).ToList();
                //dataGridView1.DataSource = qur41;

                //var qur5 = db.Products.Where(p=>p.UnitPrice<20 && p.Discontinued == false).Select(p => new { p.ProductId,p.ProductName, p.UnitPrice }).ToList();
                ////dataGridView1.DataSource = qur5;

                //var qur6 = db.Products.Where(p => p.UnitPrice >= 15 && p.UnitPrice<= 25).Select(p => new { p.ProductId, p.ProductName, p.UnitPrice }).ToList();
                ////dataGridView1.DataSource = qur6;

                //var qur7 =db.Products.Average(p => p.UnitPrice);
                //var qur71 = db.Products.Where(p => p.UnitPrice > qur7).Select(p => new { p.ProductId, p.ProductName, p.UnitPrice }).ToList();
                //dataGridView1.DataSource = qur71;

                //var qur8 = db.Products.OrderByDescending(p=>p.UnitPrice).Select(p => new { p.ProductName, p.UnitPrice }).ToList();
                //qur8.RemoveRange(10, qur8.Count-10);
                //dataGridView1.DataSource = qur8;

                var dis = db.Products.Where(p => p.Discontinued == false).ToList().Count;
                var cur = db.Products.Where(p => p.Discontinued == true).ToList().Count;
                DataTable query9 = new DataTable();

                query9.Columns.Add("Discontinued", typeof(int));
                query9.Columns.Add("Current", typeof(int));

                query9.Rows.Add(dis, cur);
                dataGridView1.DataSource = query9;

                var qur10 = db.Products.Where(p => p.UnitsInStock < p.UnitsOnOrder).Select(p=> new {p.ProductName,p.UnitsOnOrder,p.UnitsInStock}).ToList();
                dataGridView1.DataSource = qur10;


            }

        }
    }
}
