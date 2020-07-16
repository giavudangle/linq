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



namespace LinqToEntities
{
    public partial class MainForm : Form
    {
        #region Main
        MINI_MARTEntities db = new MINI_MARTEntities();
        public MainForm()
        {
            InitializeComponent();
            LoadData_Products();
            LoadData_Receipts();
            BindDataTo_ComboBoxProductName();
            BindDataTo_ComboBoxProductCategory();
            BindDataTo_ComboBoxReceiptProduct();
            BindDataTo_ComboBoxReceiptCategory();
        }
        #endregion
        #region METHODS

        private void ControlProducts_DataSource(object data)
        {
            dtGridProducts.DataSource = data;
        }

        private void ControlReceipts_DataSource(object data)
        {
            dtGridReceipts.DataSource = data;
        }

        private void LoadData_Products()
        {
            var data = from p in db.PRODUCTS
                       join c in db.CATEGORIES
                       on p.Product_CategoryID equals c.Category_ID
                       select new
                       {
                           ProductID = p.Product_ID,
                           ProductCategory = c.Category_Name,
                           ProductName = p.Product_Name,
                           ProductPrice = p.Product_Price,
                           ProductStatus = p.Product_Status
                       };
            ControlProducts_DataSource(data.ToList());
            Products_DataBinding();
        }
        private void LoadData_Receipts()
        {
            var data = from r in db.RECEIPTS
                       join p in db.PRODUCTS
                       on r.Product_ID equals p.Product_ID
                       select new
                       {
                           ReceiptID = r.Receipt_ID,
                           ProductName = p.Product_Name,
                           ProductPrice = p.Product_Price,
                           ProductAmount = r.Product_Amount,                          
                           ReceiptDate = r.Receipt_Date
                       };
            ControlReceipts_DataSource(data.ToList());
            Receipts_DataBinding();
        }

        private void Products_DataBinding()
        {
            txtProductID.DataBindings.Clear();
            cbCategory.DataBindings.Clear();
            cbProductName.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            cxActiveProduct.DataBindings.Clear();

            txtProductID.DataBindings.Add(new Binding("Text", dtGridProducts.DataSource, "ProductID"));           
            cbCategory.DataBindings.Add(new Binding("Text", dtGridProducts.DataSource, "ProductCategory"));
            cbProductName.DataBindings.Add(new Binding("Text", dtGridProducts.DataSource, "ProductName"));
            txtPrice.DataBindings.Add(new Binding("Text", dtGridProducts.DataSource, "ProductPrice"));
            cxActiveProduct.DataBindings.Add(new Binding("Checked", dtGridProducts.DataSource, "ProductStatus"));
        }

        private void Receipts_DataBinding()
        {
            txtReceiptID.DataBindings.Clear();           
            txtDate.DataBindings.Clear();
            cbxProductOrder.DataBindings.Clear();
            numAmount.DataBindings.Clear();
            txtPriceReceipt.DataBindings.Clear();

            txtReceiptID.DataBindings.Add(new Binding("Text", dtGridReceipts.DataSource, "ReceiptID"));
            txtDate.DataBindings.Add(new Binding("Text", dtGridReceipts.DataSource, "ReceiptDate"));
            txtPriceReceipt.DataBindings.Add(new Binding("Text", dtGridReceipts.DataSource, "ProductPrice"));
            cbxProductOrder.DataBindings.Add(new Binding("Text", dtGridReceipts.DataSource, "ProductName"));
            numAmount.DataBindings.Add(new Binding("Text", dtGridReceipts.DataSource, "ProductAmount"));
        }
        private bool IsValidPriceProduct()
        {         
            return int.Parse(txtPrice.Text) > 0 ? true : false ;
        }

        


        #region Map Data Function
        private string MapCategoryName_To_CategoryID(string categoryName)
        {
            var res = db.CATEGORIES.Where(c => c.Category_Name == categoryName)
                 .Select(c => c.Category_ID)
                 .FirstOrDefault();        
            return res;
        }
        private string MapProductName_To_ProductID(string productName)
        {
            var res = db.PRODUCTS.Where(r => r.Product_Name == productName)
                .Select(p => p.Product_ID)
                .FirstOrDefault();
            return res;
        }

        private void MapCategoryID_To_ListProducts(string ID)
        {
            var res = db.PRODUCTS.Where(p => p.Product_CategoryID == ID)
                .Select(p => p.Product_Name);
            cbProductName.DataSource = res.ToList();
        }

        private void MapCategoryID_To_ReceiptListProducts(string ID)
        {
            var res = db.PRODUCTS.Where(p => p.Product_CategoryID == ID)
                .Select(p => p.Product_Name);
            cbxProductOrder.DataSource = res.ToList();
        }
        #endregion
        #region Bind Data Function
        private void BindDataTo_ComboBoxProductName()
        {
            var x = db.PRODUCTS.Select(p => p.Product_Name);
            cbProductName.DataSource = x.ToList();
        }

        private void BindDataTo_ComboBoxProductCategory()
        {        
            var x = db.CATEGORIES.Select(c => c.Category_Name);
            cbCategory.DataSource = x.ToList();
        }

        private void BindDataTo_ComboBoxReceiptProduct()
        {
            var x = db.PRODUCTS.Select(p => p.Product_Name);
            cbxProductOrder.DataSource = x.ToList();
        }

        private void BindDataTo_ComboBoxReceiptCategory()
        {
            var x = db.CATEGORIES.Select(c => c.Category_Name);
            cbxReceiptCategory.DataSource = x.ToList();
        }
        #endregion
        private void AddProduct()
        {
            string productID = txtProductID.Text;        
            PRODUCT product = db.PRODUCTS.Where(p => p.Product_ID == productID).SingleOrDefault();
            if(product == null)
            {
                string categoryName = cbCategory.SelectedValue.ToString();
                string categoryID = MapCategoryName_To_CategoryID(categoryName);
                Console.WriteLine(categoryID);
                if (IsValidPriceProduct())
                {
                    PRODUCT p = new PRODUCT()
                    {
                        Product_ID = productID,
                        Product_CategoryID = categoryID,
                        Product_Name = cbProductName.SelectedValue.ToString(),
                        Product_Price = int.Parse(txtPrice.Text),
                        Product_Status = cxActiveProduct.Checked
                    };
                    db.PRODUCTS.Add(p);
                    db.SaveChanges();
                    LoadData_Products();
                    MessageBox.Show("Add product successully");
                }
                else
                {
                    MessageBox.Show("Product Price MUST BE GREATER THAN ZERO");
                }
               
            } else
            {
                MessageBox.Show("Product ID Duplicate or Blank !");
            }
        }

        private void UpdateProduct()
        {         
            string productID = txtProductID.Text;          
            PRODUCT product = db.PRODUCTS.Where(p => p.Product_ID == productID).SingleOrDefault();         
            Console.WriteLine(product);
            if (product != null)
            {
                if (IsValidPriceProduct())
                {
                    string categoryName = cbCategory.SelectedValue.ToString();
                    string categoryID = MapCategoryName_To_CategoryID(categoryName);
                    product.Product_CategoryID = categoryID;
                    product.Product_Name = cbProductName.SelectedValue.ToString();
                    product.Product_Price = int.Parse(txtPrice.Text);
                    product.Product_Status = cxActiveProduct.Checked;
                    db.SaveChanges();
                    LoadData_Products();
                    MessageBox.Show("Update product successully");
                }
                else
                {
                    MessageBox.Show("Product Price MUST BE GREATER THAN ZERO");
                }
               

            }
            else
            {
                MessageBox.Show("System prevent to edit Product ID");
            }
        }

        private void DeleteProduct()
        {
            string productID = txtProductID.Text;
            PRODUCT product = db.PRODUCTS.Where(p => p.Product_ID == productID).SingleOrDefault();
           
            if (product != null)
            {
                db.PRODUCTS.Remove(product);
                db.SaveChanges();
                LoadData_Products();
                MessageBox.Show("Delete product successully");

            }
            else
            {
                MessageBox.Show("Can not find this Product ID");
            }
        }

        private void AddOrder()
        {
            string orderID = txtReceiptID.Text;
            RECEIPT receipt = db.RECEIPTS.Where(r => r.Receipt_ID == orderID).SingleOrDefault();
            if(receipt == null)
            {
                string productName = cbxProductOrder.SelectedValue.ToString();
                string productID = MapProductName_To_ProductID(productName);
                DateTime dt = DateTime.Now;
                decimal amount = numAmount.Value;
                RECEIPT r = new RECEIPT()
                {
                    Receipt_ID = orderID,
                    Product_ID = productID,
                    Product_Amount = (int)amount,
                    Receipt_Date = dt
                };
                db.RECEIPTS.Add(r);
                db.SaveChanges();
                LoadData_Receipts();
                MessageBox.Show("Add Receipt successully");

            } else
            {
                MessageBox.Show("Duplicate Receipt ID");
            }
        }
        private void Calculate()
        {
            decimal res = int.Parse(txtPriceReceipt.Text) * numAmount.Value;
            MessageBox.Show("Giá trị đơn hàng là : " + res.ToString() +" VND","TỔNG CỘNG");
        }

        private void FindSingleProduct()
        {

            string product = txtProductFind.Text;
            var res = from p in db.PRODUCTS
                      join c in db.CATEGORIES
                      on p.Product_CategoryID equals c.Category_ID
                      where p.Product_Name.Contains(product)
                      select new
                      {
                          ProductID = p.Product_ID,
                          ProductCategory = c.Category_Name,
                          ProductName = p.Product_Name,
                          ProductPrice = p.Product_Price,
                          ProductStatus = p.Product_Status
                      };
            ControlProducts_DataSource(res.ToList());
            MessageBox.Show("Found " + res.Count().ToString() + " result !");

        }



        private void SortProductName_Ascending()
        {
            var data = from p in db.PRODUCTS
                       join c in db.CATEGORIES
                       on p.Product_CategoryID equals c.Category_ID
                       orderby p.Product_Name
                       select new
                       {
                           ProductID = p.Product_ID,
                           ProductCategory = c.Category_Name,
                           ProductName = p.Product_Name,
                           ProductPrice = p.Product_Price,
                           ProductStatus = p.Product_Status
                       };
            ControlProducts_DataSource(data.ToList());
            Products_DataBinding();
        }
        private void SortProductName_Descending()
        {
            var data = from p in db.PRODUCTS
                       join c in db.CATEGORIES
                       on p.Product_CategoryID equals c.Category_ID
                       orderby p.Product_Name descending
                       select new
                       {
                           ProductID = p.Product_ID,
                           ProductCategory = c.Category_Name,
                           ProductName = p.Product_Name,
                           ProductPrice = p.Product_Price,
                           ProductStatus = p.Product_Status
                       };
            ControlProducts_DataSource(data.ToList());
            Products_DataBinding();
        }


        private void SortCategory_Ascending()
        {
            var data = from p in db.PRODUCTS
                       join c in db.CATEGORIES
                       on p.Product_CategoryID equals c.Category_ID
                       orderby p.Product_CategoryID
                       select new
                       {
                           ProductID = p.Product_ID,
                           ProductCategory = c.Category_Name,
                           ProductName = p.Product_Name,
                           ProductPrice = p.Product_Price,
                           ProductStatus = p.Product_Status
                       };
            ControlProducts_DataSource(data.ToList());
            Products_DataBinding();
        }

        private void SortCategory_Descending()
        {
            var data = from p in db.PRODUCTS
                       join c in db.CATEGORIES
                       on p.Product_CategoryID equals c.Category_ID
                       orderby p.Product_CategoryID descending
                       select new
                       {
                           ProductID = p.Product_ID,
                           ProductCategory = c.Category_Name,
                           ProductName = p.Product_Name,
                           ProductPrice = p.Product_Price,
                           ProductStatus = p.Product_Status
                       };
            ControlProducts_DataSource(data.ToList());
            Products_DataBinding();
        }



        private void SortPrice_Ascending()
        {
            var data = from p in db.PRODUCTS
                       join c in db.CATEGORIES
                       on p.Product_CategoryID equals c.Category_ID
                       orderby p.Product_Price
                       select new
                       {
                           ProductID = p.Product_ID,
                           ProductCategory = c.Category_Name,
                           ProductName = p.Product_Name,
                           ProductPrice = p.Product_Price,
                           ProductStatus = p.Product_Status
                       };
            ControlProducts_DataSource(data.ToList());
            Products_DataBinding();
        }

        private void SortPrice_Descending()
        {
            var data = from p in db.PRODUCTS
                       join c in db.CATEGORIES
                       on p.Product_CategoryID equals c.Category_ID
                       orderby p.Product_Price descending
                       select new
                       {
                           ProductID = p.Product_ID,
                           ProductCategory = c.Category_Name,
                           ProductName = p.Product_Name,
                           ProductPrice = p.Product_Price,
                           ProductStatus = p.Product_Status
                       };
            ControlProducts_DataSource(data.ToList());
            Products_DataBinding();
        }



        private void FilterActiveProductStatus()
        {
            var data = from p in db.PRODUCTS
                       join c in db.CATEGORIES
                       on p.Product_CategoryID equals c.Category_ID
                       where p.Product_Status == true
                       select new
                       {
                           ProductID = p.Product_ID,
                           ProductCategory = c.Category_Name,
                           ProductName = p.Product_Name,
                           ProductPrice = p.Product_Price,
                           ProductStatus = p.Product_Status
                       };
            ControlProducts_DataSource(data.ToList());
            Products_DataBinding();
        }

        private void FilterNoActiveProductStatus()
        {
            var data = from p in db.PRODUCTS
                       join c in db.CATEGORIES
                       on p.Product_CategoryID equals c.Category_ID
                       where p.Product_Status == false
                       select new
                       {
                           ProductID = p.Product_ID,
                           ProductCategory = c.Category_Name,
                           ProductName = p.Product_Name,
                           ProductPrice = p.Product_Price,
                           ProductStatus = p.Product_Status
                       };
            ControlProducts_DataSource(data.ToList());
            Products_DataBinding();
        }



        private void GroupBy_Category()
        {

            var rawData =
                from s in db.PRODUCTS
                group s by s.Product_CategoryID;

            var result =
                from r in rawData
                join c in db.CATEGORIES
                on r.Key equals c.Category_ID
                select new
                {
                    CategoryName = c.Category_Name,
                    Amount = r.Count()
                };
            ControlProducts_DataSource(result.ToList());
        }


        private void GroupBy_ProductName()
        {
            var rawData =
               from s in db.PRODUCTS
               group s by s.Product_Name;


            var result =
                from r in rawData
                join c in db.PRODUCTS
                on r.Key equals c.Product_Name
                select new
                {
                    ProductName = c.Product_Name,
                    Amount = r.Count()
                };
            ControlProducts_DataSource(result.ToList());
        }
        #endregion
        #region EVENTS
        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            UpdateProduct();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            DeleteProduct();
        }
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = cbCategory.SelectedValue.ToString();
            string categoryID = MapCategoryName_To_CategoryID(category);
            MapCategoryID_To_ListProducts(categoryID);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var DR = MessageBox.Show("Are you sure to exit ?", "Warning", MessageBoxButtons.YesNo);
            if (DR == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            AddOrder();
        }

        private void cbxReceiptCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoryName = cbxReceiptCategory.SelectedValue.ToString();
            string categoryID = MapCategoryName_To_CategoryID(categoryName);
            MapCategoryID_To_ReceiptListProducts(categoryID);
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            fStatistic f = new fStatistic();
            f.Show();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FindSingleProduct();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData_Products();
        }

        private void btnSortNameAsc_Click(object sender, EventArgs e)
        {
            SortProductName_Ascending();
        }

        private void btnSortNameDsc_Click(object sender, EventArgs e)
        {
            SortProductName_Descending();

        }

        private void btnSortCategorytAsc_Click(object sender, EventArgs e)
        {
            SortCategory_Ascending();
        }

        private void btnSortCategorytDsc_Click(object sender, EventArgs e)
        {
            SortCategory_Descending();
        }

        private void btnSortPriceAsc_Click(object sender, EventArgs e)
        {
            SortPrice_Ascending();
        }

        private void btnSortPriceDsc_Click(object sender, EventArgs e)
        {
            SortPrice_Descending();

        }
        private void btnFilterActive_CheckedChanged(object sender, EventArgs e)
        {
            FilterActiveProductStatus();
        }

        private void btnFilterNotActive_CheckedChanged(object sender, EventArgs e)
        {
            FilterNoActiveProductStatus();
        }
        private void btnGroupBy_ProductName_Click(object sender, EventArgs e)
        {
            GroupBy_ProductName();
        }
        private void btnGroupBy_Category_Click(object sender, EventArgs e)
        {
            GroupBy_Category();
        }
        #endregion

        private void btnExport_Click(object sender, EventArgs e)
        {
            //ExportOrder_ToExcel();
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void CopyDataToClipboard()
        {
            dtGridReceipts.SelectAll();
            DataObject dt = dtGridReceipts.GetClipboardContent();
            if (dt != null) Clipboard.SetDataObject(dt);
        }
        private void ExportOrder_ToExcel()
        {
            CopyDataToClipboard();
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workBook;
            Microsoft.Office.Interop.Excel.Application workSheet;
            object misValue = System.Reflection.Missing.Value;
            excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            workBook = excel.Workbooks.Add(misValue);
            workSheet = (Microsoft.Office.Interop.Excel.Application)(Microsoft.Office.Interop.Excel.Worksheet)workBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)workSheet.Cells[1, 1];
            range.Select();
           
        }
        private void copyAlltoClipboard()
        {
            //to remove the first blank column from datagridview
            dtGridReceipts.RowHeadersVisible = false;
            dtGridReceipts.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dtGridReceipts.SelectAll();
            DataObject dataObj = dtGridReceipts.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void Temp(object sender, EventArgs e)
        {
            copyAlltoClipboard();

            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;

            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);

            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
          
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
           
            CR.Select();
           
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
    }
}
