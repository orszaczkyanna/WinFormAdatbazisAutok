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
    public partial class FormAuto : Form
    {
        private string muvelet = null;

        public FormAuto(string muvelet)
        {
            InitializeComponent();
            this.muvelet = muvelet;
        }

        private void FormAuto_Load(object sender, EventArgs e)
        {
            switch (muvelet)
            {
                case "insert":
                    textBox_Rendszam.Focus();
                    this.Text = "Új autó hozzáadása";
                    button_Muvelet.Text = "Hozzáadás";                    
                    break;
                case "update":
                    textBox_Rendszam.Focus();
                    this.Text = "Autó adatainak módosítása";
                    button_Muvelet.Text = "Módosítás";
                    kivalasztottAutoAdatainakMegjelenitese();
                    break;
                default:
                    break;
            }

        }

        private void kivalasztottAutoAdatainakMegjelenitese()
        {
            Auto kivalasztottAuto = (Auto)Program.formNyito.listBox_Autok.SelectedItem;
            textBox_Id.Text = kivalasztottAuto.Id.ToString();
            textBox_Rendszam.Text = kivalasztottAuto.Rendszam.ToString();
            textBox_Marka.Text = kivalasztottAuto.Marka.ToString();
            date_ForgalombaHelyezes.Value = kivalasztottAuto.ForgalombaHelyezes;
        }

        private void button_Muvelet_Click(object sender, EventArgs e)
        {
            switch (muvelet)
            {
                case "insert":
                    ujAutoHozzaAdasa();
                    break;
                case "update":
                    AutoModositasa();
                    break;
                default:
                    break;
            }
        }

        private void AutoModositasa()
        {
            if (mezokKitoltve())
            {
                Auto modositando = new Auto(ulong.Parse(textBox_Id.Text), textBox_Rendszam.Text, textBox_Marka.Text, date_ForgalombaHelyezes.Value);                
                Program.adatbazis.autoUPDATE(modositando);
                MessageBox.Show("Sikeres módosítás");
                this.Close();
            }
            else
            {
                MessageBox.Show("Töltsd ki a mezőket!");
            }
        }

        private void ujAutoHozzaAdasa()
        {
            if (mezokKitoltve())
            {
                Auto ujAuto = new Auto(0, textBox_Rendszam.Text, textBox_Marka.Text, date_ForgalombaHelyezes.Value);
                Program.adatbazis.autoINSERT(ujAuto);
                MessageBox.Show("Sikeres rögzítés");
                this.Close();
            }
            else
            {
                MessageBox.Show("Töltsd ki a mezőket!");
            }          
            

        }

        private bool mezokKitoltve()
        {
            if (String.IsNullOrEmpty(textBox_Id.Text) && !muvelet.Equals("insert"))
            {
                return false;
            }
            
            if (String.IsNullOrEmpty(textBox_Rendszam.Text))
            {
                return false;
            }

            if (String.IsNullOrEmpty(textBox_Marka.Text))
            {
                return false;
            }


            return true;
        }
    }
}
