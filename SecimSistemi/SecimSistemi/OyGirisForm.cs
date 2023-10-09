using EntityLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecimSistemi
{
    public partial class OyGirisForm : Form
    {
        public OyGirisForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Red;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGrafik_Click(object sender, EventArgs e)
        {
            GrafiklerForm fr = new GrafiklerForm();
            fr.Show();
        }

        private void BtnOyGir_Click(object sender, EventArgs e)
        {
            EntitySecim ent = new EntitySecim();

            if (short.TryParse(TxtA.Text, out short ATEKNO) &&
                short.TryParse(TxtB.Text, out short BTEKNO) &&
                short.TryParse(TxtC.Text, out short CTEKNO) &&
                short.TryParse(TxtD.Text, out short DTEKNO)&&
                short.TryParse(TxtE.Text, out short ETEKNO))
            {
                ent.ILCEAD = TxtIlceAd.Text;
                ent.ATEKNO = ATEKNO;
                ent.BTEKNO = BTEKNO;
                ent.CTEKNO = CTEKNO;
                ent.DTEKNO = DTEKNO;
                ent.ETEKNO = ETEKNO;

                int result = LogicSecim.LLOyEkle(ent);
                if (result >0 ) {
                    MessageBox.Show("Oy sisteme girildi","Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bir hata oluştur", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Boş hücre bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
//int.TryParse(Txtid.Text, out int randevuId) ilk if
//result && !string.IsNullOrEmpty(Txtid.Text) ikinci if  