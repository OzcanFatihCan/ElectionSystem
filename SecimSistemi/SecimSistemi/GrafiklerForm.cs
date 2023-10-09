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
    public partial class GrafiklerForm : Form
    {
        public GrafiklerForm()
        {
            InitializeComponent();
        }

        private void GrafiklerForm_Load(object sender, EventArgs e)
        {
            //ilçe adlarını comboxboxa çekme
            List<EntitySecim> IlceGetir = LogicSecim.LLIlceCek();
            foreach (var item in IlceGetir)
            {
                comboBox1.Items.Add(item.ILCEAD);
            }
            /*
            //GRAFİĞE TOPLAM SONUÇLARI GETİRME
            List<EntitySecim> Sonuclar=LogicSecim.LLSonuclar();
            foreach (var item in Sonuclar)
            {
                chart1.Series["Teknolar"].Points.AddXY("ATEKNO", item.ATEKNO);
                chart1.Series["Teknolar"].Points.AddXY("BTEKNO", item.BTEKNO);
                chart1.Series["Teknolar"].Points.AddXY("CTEKNO", item.CTEKNO);
                chart1.Series["Teknolar"].Points.AddXY("DTEKNO", item.DTEKNO);
                chart1.Series["Teknolar"].Points.AddXY("ETEKNO", item.ETEKNO);
            }*/
        }
    }
}
