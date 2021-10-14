using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        class User<T>
        {
            public T id;
            public string fio;
            public string email;

            public void DisplayInfoUser()
            {
                MessageBox.Show($"Код пользователя: {id.ToString()}; ФИО пользователя: {fio}; Адрес электронной почты: {email}");
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User<int> user1 = new User<int> { id = 15, fio = "Иванов Иван Иванович", email = "test@mail.ru" };
            User<string> user2 = new User<string> { id = "123/23", fio = "Иванов Иван Иванович", email = "test@mail.ru" };

            user1.DisplayInfoUser();
            user2.DisplayInfoUser();

        }
    }
}
