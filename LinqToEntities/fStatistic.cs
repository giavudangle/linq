using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LinqToEntities
{
    public partial class fStatistic : Form
    {
        MINI_MARTEntities db = new MINI_MARTEntities();
        public fStatistic()
        {
            InitializeComponent();
            FillChartOne();
            FillChartTwo();
          
        }

        private void FillChartOne()
        {
            var res = from p in db.PRODUCTS
                      join r in db.RECEIPTS
                      on p.Product_ID equals r.Product_ID
                      orderby r.Product_Amount
                      select new
                      {
                          ProductName=p.Product_Name,
                          Amount=r.Product_Amount,
                          Date=r.Receipt_Date
                      };
            myChart.DataSource = res.ToList();
            myChart.Titles.Add("Hot Seller");

            myChart.ChartAreas[0].AxisX.Title = "PRODUCTS NAME";
            myChart.ChartAreas[0].AxisY.Title = "PRODUCTS AMOUNT";


            myChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            myChart.Series[0].XValueType = ChartValueType.String;
            myChart.Series[0].XValueMember = "ProductName";
            myChart.Series[0].YValueMembers = "Amount";
        }

        private void FillChartTwo()
        {

            var res = from p in db.RECEIPTS
                      orderby p.Receipt_Date
                      select new
                      {
                          Date = p.Receipt_Date,
                          Amount = p.Product_Amount
                      };

            myAnotherChart.DataSource = res.ToList();
            myAnotherChart.Titles.Add("Day by Day");
            myAnotherChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            myAnotherChart.ChartAreas[0].AxisX.Title = "DAY";
            myAnotherChart.ChartAreas[0].AxisY.Title = "PRODUCTS AMOUNT";
            myAnotherChart.Series[0].XValueType = ChartValueType.DateTime;
            myAnotherChart.Series[0].XValueMember = "Date";
            myAnotherChart.Series[0].YValueMembers = "Amount";
        }

       
    }
}
