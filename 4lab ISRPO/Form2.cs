using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4lab_ISRPO
{
    public partial class Form2 : Form
    {
        private readonly Form1 _mainForm;

        public Form2(Form1 mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // при закрытии второй формы (кнопкой «Назад» или крестиком) снова показываем главную
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _mainForm.Show();
            base.OnFormClosed(e);
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (name == "")
            {
                MessageBox.Show("Введите имя");
                return;
            }
            MessageBox.Show($"Привет, {name}!");
        }
    }
}