using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study
{
    public partial class MainView : Form
    {
        readonly IEmployeesRepository employeesRepository;
        readonly UserProvider userProvider;
        public MainView(
            IEmployeesRepository employeesRepository,
            UserProvider userProvider)
        {
            InitializeComponent();
            this.userProvider = userProvider;
            this.employeesRepository = employeesRepository;
            this.lblUser.Text = userProvider.GetCurrentUser();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            IEnumerable<Employee> data = null;
            try
            {
                data = employeesRepository.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            this.gridControl.DataSource = data.ToList();
        }
    }
}
