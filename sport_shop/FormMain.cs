using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using sport_shop.models1;
using Microsoft.EntityFrameworkCore;
using sport_shop.Properties;

namespace sport_shop
{
    public partial class FormMain : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }
        public FormMain(User user, bool guest)
        {
            InitializeComponent();

            var colPhoto = new DataGridViewImageColumn();
            colPhoto.Name = "colPhoto";
            colPhoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colPhoto.Width = 200;
            colPhoto.FillWeight = 30;

            var colInfo = new DataGridViewTextBoxColumn();
            colInfo.Name = "colInfo";
            colInfo.FillWeight = 60;
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


            var colDiscount = new DataGridViewTextBoxColumn();
            colDiscount.Name = "colDiscount";
            colDiscount.FillWeight = 10;
            colDiscount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void LoadProducts()
        {
            try
            {
                using (var db = new SportShopContext)
                {
                    var products = db.Products
                        .Include(i => i.CategoryName)
                        .Include(i => i.Manufacturer)
                        .Include(i => i.Supplier)
                        .Include(i => i.Measure)
                        .Include(i => i.ProductType)
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
