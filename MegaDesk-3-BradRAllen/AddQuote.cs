using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_BradRAllen
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void closeForm_btn_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void DeskWidth_tb_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(DeskWidth_tb.Text, out int WidthInput))
            {
                if(WidthInput < Desk.WIDTH_MIN || WidthInput > Desk.WIDTH_MAX)
                {
                    MessageBox.Show(@"Minimum Width is 24"" and Maximum Width is 96"". Please enter a valid Width");
                    DeskWidth_tb.Text = String.Empty;
                    DeskWidth_tb.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter width as a whole number.");
                DeskWidth_tb.Text = string.Empty;
                DeskWidth_tb.Focus();
            }
        }

        private void DeskDepth_tb_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(DeskDepth_tb.Text, out int DepthInput))
            {
                if (DepthInput < Desk.DEPTH_MIN || DepthInput > Desk.DEPTH_MAX)
                {
                    MessageBox.Show(@"Minimum Depth is 12"" and Maximum Depth is 48"". Please enter a valid Depth");
                    DeskDepth_tb.Text = String.Empty;
                    DeskDepth_tb.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter width as a whole number.");
                DeskDepth_tb.Text = string.Empty;
                DeskDepth_tb.Focus();
            }
        }

        private void IsWholeNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Please enter a whole number.");
                // Stop the character from being entered into the control by cutting off the rest of the method
                e.Handled = true;
                this.Focus();
            }
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }
    }
}
