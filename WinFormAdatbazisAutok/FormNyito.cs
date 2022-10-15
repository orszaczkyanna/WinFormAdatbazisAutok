using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAdatbazisAutok
{
    public partial class FormNyito : Form
    {
        public FormNyito()
        {
            InitializeComponent();
        }

        private void FormNyito_Load(object sender, EventArgs e)
        {
            autokMegjelenitese();
        }

        private void FormNyito_Activated(object sender, EventArgs e)
        {
            autokMegjelenitese();
        }

        private void autokMegjelenitese()
        {
            listBox_Autok.Items.Clear();
            foreach (Auto item in Program.adatbazis.osszesAuto())
            {
                listBox_Autok.Items.Add(item);
            }
        }

        private void button_Insert_Click(object sender, EventArgs e)
        {
            FormAuto formAuto = new FormAuto("insert");
            formAuto.ShowDialog();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {            
            if (listBox_Autok.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott elem");
            }
            else
            {
                FormAuto formAuto = new FormAuto("update");
                formAuto.ShowDialog();
            }            
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (listBox_Autok.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott elem");
            }
            else
            {
                Auto torlendoAuto = (Auto)listBox_Autok.SelectedItem;
                Program.adatbazis.autoDELETE(torlendoAuto);
                autokMegjelenitese();
                MessageBox.Show("Sikeres törlés");

            }
        }
    }
}
