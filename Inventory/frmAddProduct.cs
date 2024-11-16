using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Inventory
{
    public partial class frmAddProduct : Form
    {
        private string _ProductName, _Category, _ManufacturingDate, _ExpirationDate, _Description;
        private int _Quantity;
        private double _SellPrice;

        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            string[] ListofProductCategory = { "Beverages", "Bread/Bakery", "Canned/Jarred Goods", "Dairy", "Frozen Goods", "Meat", "Personal Care", "Other" };

            cbCategory.Items.AddRange(ListofProductCategory);
        }

        public string ValidateProductName(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || !Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
            {
                throw new StringFormatException("Invalid product name. Only letters and spaces are allowed.");
            }
            return name;
        }

        public int ValidateQuantity(string qty)
        {
            if (!int.TryParse(qty, out int result) || result <= 0)
            {
                throw new NumberFormatException("Quantity must be a positive number.");
            }
            return result;
        }

        public double ValidateSellingPrice(string price)
        {
            if (!double.TryParse(price, out double result) || result <= 0)
            {
                throw new CurrencyFormatException("Invalid price. Must be a positive number.");
            }
            return result;
        }

        public class StringFormatException : Exception
        {
            public StringFormatException(string message) : base(message) { }
        }

        public class NumberFormatException : Exception
        {
            public NumberFormatException(string message) : base(message) { }
        }

        public class CurrencyFormatException : Exception
        {
            public CurrencyFormatException(string message) : base(message) { }
        }

        private BindingSource showProductList = new BindingSource();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _ProductName = ValidateProductName(txtProductName.Text);
                _Category = cbCategory.Text;
                _ManufacturingDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                _ExpirationDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
                _Description = richTxtDescription.Text;
                _Quantity = ValidateQuantity(txtQuantity.Text);
                _SellPrice = ValidateSellingPrice(txtSellPrice.Text);

                showProductList.Add(new ProductClass
                {
                    ProductName = _ProductName,
                    Category = _Category,
                    ManufacturingDate = _ManufacturingDate,
                    ExpirationDate = _ExpirationDate,
                    Description = _Description,
                    Quantity = _Quantity,
                    SellingPrice = _SellPrice
                });

                gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridViewProductList.DataSource = showProductList;
            }
            catch (Exception ex) when (ex is StringFormatException || ex is NumberFormatException || ex is CurrencyFormatException)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    public class ProductClass
    {
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string ManufacturingDate { get; set; }
        public string ExpirationDate { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double SellingPrice { get; set; }
    }
}
