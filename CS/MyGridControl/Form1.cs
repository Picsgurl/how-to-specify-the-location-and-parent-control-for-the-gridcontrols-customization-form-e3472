using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyGridControl
{
    public partial class FormMain : Form
    {
        private DataTable dtList;
        public FormMain()
        {
            InitializeComponent();
            InitDataList();
            myGridContrl.DataSource = dtList;
        }



        private void InitDataList()
        {
            dtList = new DataTable();
            dtList.Columns.AddRange(new DataColumn[] { new DataColumn("Name"), new DataColumn("Info")});

            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
                dtList.Rows.Add(new object[] { "Name_" + rnd.Next(10, 100).ToString(), "Info" + rnd.Next(1000, 100000).ToString() });
           
        }



        private void sbShowStandart_Click(object sender, EventArgs e)
        {
            myGridV.ShowCustomization();
        }



        private void sbShowLocation_Click(object sender, EventArgs e)
        {
            myGridV.ShowCustomization(new Point((int)seX.Value, (int)seY.Value));
        }



        private void sbShowInParent_Click(object sender, EventArgs e)
        {
            myGridV.ShowCustomization(panel1);
        }
    }
}