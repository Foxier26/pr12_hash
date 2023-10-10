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

namespace pr6_sakharov.ModelEF
{
    public partial class Form2Authorization : Form
    {
        public Form2Authorization()
        {
            InitializeComponent();
        }

        private void EntBtn_Click(object sender, EventArgs e)
        {
            Model1 model = new Model1();
            if (model.UsersHash.ToList().Any(x =>
            x.Login == LogTxtBox.Text && 
            x.Password == SHA256Builder.ConvertToHash(PassTxtBox.Text)))
            {
                MessageBox.Show("Пользователь найден!");
                return;
            }
            MessageBox.Show("Пользователь не найден!");
        }
    }
}
