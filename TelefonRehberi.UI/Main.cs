using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelefonRehberi.Business.Abstract;
using TelefonRehberi.Business.DependencyResolvers.Ninject;
using TelefonRehberi.Entities.Concrete;

namespace TelefonRehberi.UI
{
    public partial class Main : Form
    {
        private ICustomerService customerService;
        public Main()
        {
            InitializeComponent();
            customerService = InstanceFactory.GetInstance<ICustomerService>();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            dataGridView_Customers.AutoGenerateColumns = false;
        }

        private void LoadCustomers()
        {
            dataGridView_Customers.DataSource = customerService.GetAll();
            Clear_Add();
            Clear_Update();
        }

        private void Clear_Add()
        {
            textBox_Add_Title.Text = "";
            textBox_Add_Name.Text = "";
            textBox_Add_LastName.Text = "";
            textBox_Add_Phone1.Text = "";
            textBox_Add_Phone2.Text = "";
        }

        private void Clear_Update()
        {
            textBox_Update_Title.Text = "";
            textBox_Update_Name.Text = "";
            textBox_Update_LastName.Text = "";
            textBox_Update_Phone1.Text = "";
            textBox_Update_Phone2.Text = "";
        }

        private void dataGridView_Customers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_Update_Title.Text = dataGridView_Customers.CurrentRow.Cells["TITLE"].Value.ToString();
            textBox_Update_Name.Text = dataGridView_Customers.CurrentRow.Cells["NAME"].Value.ToString();
            textBox_Update_LastName.Text = dataGridView_Customers.CurrentRow.Cells["LASTNAME"].Value.ToString();
            textBox_Update_Phone1.Text = dataGridView_Customers.CurrentRow.Cells["PHONE1"].Value.ToString();
            textBox_Update_Phone2.Text = dataGridView_Customers.CurrentRow.Cells["PHONE2"].Value.ToString();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            customerService.Delete(new Customer
            {
                ID = Convert.ToInt32(dataGridView_Customers.CurrentRow.Cells["ID"].Value)
            });
            LoadCustomers();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            customerService.Update(new Customer
            {
                ID = Convert.ToInt32(dataGridView_Customers.CurrentRow.Cells["ID"].Value),
                Title = textBox_Update_Title.Text,
                Name = textBox_Update_Name.Text,
                LastName = textBox_Update_LastName.Text,
                Phone1 = textBox_Update_Phone1.Text,
                Phone2 = textBox_Update_Phone2.Text
            });
            LoadCustomers();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            customerService.Add(new Customer
            {
                Title = textBox_Add_Title.Text,
                Name = textBox_Add_Name.Text,
                LastName = textBox_Add_LastName.Text,
                Phone1 = textBox_Add_Phone1.Text,
                Phone2 = textBox_Add_Phone2.Text
            });
            LoadCustomers();
        }
    }
}
