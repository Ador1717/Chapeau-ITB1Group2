using ChepueService;
using ChepueModel;
using ChepueDAL;
using System.Windows.Forms;
using ChepueUI;

namespace Chapeau
{
    public partial class Form1 : Form
    {
        private EmployeeService employeeService;
        public Form1()
        {
            InitializeComponent();
            employeeService = new EmployeeService();

            pnlLogin.Visible = true;
            pnlRegistration.Visible = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            string username = txtBoxUserName.Text;
            string password = txtBoxPassword.Text;

            Employee employee = employeeService.LoginEmployee(username, password);

            if (employee != null)
            {
                if (employee.Role == "Waiter")
                {
                    this.Hide();
                    TabelOverview tabelOverview = new TabelOverview(employee);
                    tabelOverview.Show();
                }
                else if (employee.Role == "Chef" || employee.Role == "Bartender")
                {
                    this.Hide();
                    KitchenBarView kitchenBarView = new KitchenBarView();
                    kitchenBarView.Show();
                }
                else
                    MessageBox.Show("Incorrect password");
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }
        }

        private void BtnSignin_Click(object sender, EventArgs e)
        {
            pnlRegistration.Visible = true;
            pnlLogin.Visible=false;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string username = txtBoxName.Text;
            string Role=txtBoxRole.Text;
            string password = txtBoxNewPassword.Text;

            try
            {
                employeeService.RegisterEmployee(username, Role, password);
                MessageBox.Show("Registration Successful");

                pnlRegistration.Visible = false;
                pnlLogin.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void picBoxLogin_Logo_Click(object sender, EventArgs e)
        {

        }

        private void pnlRegistration_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}