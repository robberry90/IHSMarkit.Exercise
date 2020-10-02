using IHSMarkit.Exercise.Enums;
using IHSMarkit.Exercise.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace IHSMarkit.Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeData();
            InitializeComponent();
        }

        private static void InitializeData()
        {
            SharesRepository.AddShares(new DateTime(2005, 1, 1), 100, 10);
            SharesRepository.AddShares(new DateTime(2005, 2, 2), 40, 12);
            SharesRepository.AddShares(new DateTime(2005, 3, 3), 50, 11);
        }

        private void calculate_Button_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(sharesSold_TextBox.Text, out var quantity))
            {
                return;
            }

            if (!decimal.TryParse(pricePerShare_TextBox.Text, out var price))
            {
                return;
            }

            if (!Enum.TryParse<CostingMethod>(costMethod_ComboBox.SelectedIndex.ToString(), out var costingMethod))
            {
                return;
            }

            var shares = SharesRepository.GetShares();
            var sharesRemaining = shares.Sum(s => s.Quantity) - quantity;
            var costingMethodResult = CostingMethodResultFactory.GetCostingMethodResult(shares, quantity, price, costingMethod);
            var costPrice = costingMethodResult.CostPrice;
            var remainingCostPrice = costingMethodResult.RemainingCostPrice;
            var gainLoss = (price - costPrice) * quantity;

            costPrice_Label.Text = costPrice.ToString("C");
            gainLoss_Label.Text = gainLoss.ToString("C");
            sharesRemaining_Label.Text = sharesRemaining.ToString("C");
            remainingCostPrice_Label.Text = remainingCostPrice.ToString("C");
        }
    }
}
