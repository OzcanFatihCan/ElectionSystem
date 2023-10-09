using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DALSecim
    {
        public static int OyEkle(EntitySecim e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO TBLILCE (ILCEAD,ATEKNO,BTEKNO,CTEKNO,DTEKNO,ETEKNO) VALUES (UPPER(@P1),@P2,@P3,@P4,@P5,  @P6)",Baglanti.Conn);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1",e.ILCEAD);
            komut.Parameters.AddWithValue("@P2", e.ATEKNO);
            komut.Parameters.AddWithValue("@P3", e.BTEKNO);
            komut.Parameters.AddWithValue("@P4", e.CTEKNO);
            komut.Parameters.AddWithValue("@P5", e.DTEKNO);
            komut.Parameters.AddWithValue("@P6", e.ETEKNO);
            return komut.ExecuteNonQuery();
        }

        public static List<EntitySecim> IlceGetir()
        {
            List<EntitySecim> Ilceler=new List<EntitySecim>();
            SqlCommand komut = new SqlCommand("SELECT ILCEAD FROM TBLILCE",Baglanti.Conn);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                EntitySecim ent = new EntitySecim();
                ent.ILCEAD = dr["ILCEAD"].ToString();
                Ilceler.Add(ent);
            }
            dr.Close();
            return Ilceler;
        }
        public static List<EntitySecim> SonucGetir()
        {
            List<EntitySecim> Sonuclar=new List<EntitySecim>();
            SqlCommand komut = new SqlCommand("SELECT SUM(ATEKNO),SUM(BTEKNO),SUM(CTEKNO),SUM(DTEKNO),SUM(ETEKNO) FROM TBLILCE", Baglanti.Conn);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr2=komut.ExecuteReader();
            while (dr2.Read())
            {
                EntitySecim ent = new EntitySecim();
                ent.ATEKNO = short.Parse(dr2[0].ToString());
                ent.BTEKNO = short.Parse(dr2[1].ToString());
                ent.CTEKNO = short.Parse(dr2[2].ToString());
                ent.DTEKNO = short.Parse(dr2[3].ToString());
                ent.ETEKNO = short.Parse(dr2[4].ToString());
                Sonuclar.Add(ent);
            }
            dr2.Close();
            return Sonuclar;
        }

        public static List<EntitySecim> IlceSonucGetir(string ilce)
        {
            List<EntitySecim> IlceSonuclar = new List<EntitySecim>();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLILCE WHERE ILCEAD=@P1", Baglanti.Conn);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1",ilce);
            SqlDataReader dr3 = komut.ExecuteReader();
            while (dr3.Read())
            {
                EntitySecim ent = new EntitySecim();
                ent.ATEKNO = short.Parse(dr3[2].ToString());
                ent.BTEKNO = short.Parse(dr3[3].ToString());
                ent.CTEKNO = short.Parse(dr3[4].ToString());
                ent.DTEKNO = short.Parse(dr3[5].ToString());
                ent.ETEKNO = short.Parse(dr3[6].ToString());
                IlceSonuclar.Add(ent);
            }
            dr3.Close();
            return IlceSonuclar;
        }
    }
}
