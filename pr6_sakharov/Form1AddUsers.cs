using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pr6_sakharov.ModelEF;

namespace pr6_sakharov
{
    public partial class Form1AddUsers : Form
    {
        public Form1AddUsers()
        {
            InitializeComponent();
        }
        Model1 model = new Model1();

        void StartLoad()
        {
            dataGridView.DataSource = model.UsersHash.ToList();
        }
        private void Form1AddUsers_Load(object sender, EventArgs e)
        {
            StartLoad();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(LogTxtBox.Text == "" || PassTxtBox.Text == "" || NameTxtBox.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            UsersHash usersHash = new UsersHash();
            usersHash.Login = LogTxtBox.Text;
            usersHash.Password = SHA256Builder.ConvertToHash(PassTxtBox.Text);
            usersHash.FirstName = NameTxtBox.Text;
            try
            {
                model.UsersHash.Add(usersHash);
                model.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                StartLoad();
            }
            LogTxtBox.Text = "";
            PassTxtBox.Text = "";
            NameTxtBox.Text= "";
            MessageBox.Show("Данные добавлены");
        }

        private void AutoBtn_Click(object sender, EventArgs e)
        {
            Form2Authorization form2 = new Form2Authorization();
            form2.ShowDialog();
        }
    }
}
