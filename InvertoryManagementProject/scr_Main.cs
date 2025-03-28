using System.Data.SqlClient;
using System.Runtime.InteropServices.Marshalling;

namespace InvertoryManagementProject
{
    public partial class scr_Main : Form
    {
        public scr_Main()
        {
            InitializeComponent();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHomePage);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnOrders);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnProducts);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnCustomers);
            showFormInPanel(new scr_Customers());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSettings);
        }

        private void btnHomePage_Leave(object sender, EventArgs e)
        {
            changeColorToDefault(btnHomePage);
        }

        private void btnOrders_Leave(object sender, EventArgs e)
        {
            changeColorToDefault(btnOrders);
        }

        private void btnProducts_Leave(object sender, EventArgs e)
        {
            changeColorToDefault(btnProducts);
        }

        private void btnCustomers_Leave(object sender, EventArgs e)
        {
            changeColorToDefault(btnCustomers);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            changeColorToDefault(btnSettings);
        }

        private void changeColorToDefault(Control c)
        {
            c.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void moveSidePanel(Control c)
        {
            pnlNav.Height = c.Height;
            pnlNav.Top = c.Top;
            pnlNav.Left = c.Left;
            c.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void scr_Main_Load(object sender, EventArgs e)
        {
            pnlNav.BringToFront();
            moveSidePanel(btnHomePage);
        }

        private void showFormInPanel(Form form)
        {
            if (pnlFormLoader.Controls.OfType<Form>().Any(f => f.GetType() == form.GetType()))
                return;

            this.pnlFormLoader.Controls.Clear();
            form.TopLevel = false;
            form.TopMost = true;
            this.pnlFormLoader.Controls.Add(form);
            form.Show();

        }
    }


}
