using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entities.Tools
{
    public static class SettingsTool
    {
        static FileIniDataParser parser = new FileIniDataParser();
        static IniData data;
        static string dosyaAdi = "Settings.ini";

        static SettingsTool()
        {
            try
            {
                if (System.IO.File.Exists(Application.StartupPath + "\\" + dosyaAdi))
                {
                    data = parser.ReadFile(dosyaAdi);
                }
                else
                {
                    using (System.IO.File.Create(Application.StartupPath + "\\" + dosyaAdi))
                    {

                    }
                    data = parser.ReadFile(dosyaAdi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public enum Ayarlar
        {
            SmsAyarlari_KullanıcıAdı,
            SmsAyarlari_Parola,
            SatisAyarlari_VarsayilanDepo,
            SatisAyarlari_VarsayilanKasa,
            SatisAyarlari_FaturaYazdirmaAyari,
            SatisAyarlari_FaturaYazici,
            SatisAyarlari_BilgiFisiYazdirmaAyari,
            SatisAyarlari_BilgiFisiYazici,
            SatisAyarlari_FisKodu,
            YedeklemeAyarlari_YedeklemeKonumu,
            GenelAyarlar_GuncellemeKontrol,
            DatabaseAyarlari_BaglantiCumlesi,
            DatabaseAyarlari_GecerliDB,
            DatabaseAyarlari_ServerName,
            DatabaseAyarlari_UserName,
            DatabaseAyarlari_Password,
            DatabaseAyarlari_Security,
            FirmaAyarlari_NrBiznes,
            FirmaAyarlari_NrFiskal,
            FirmaAyarlari_NrTVSH,
            FirmaAyarlari_EmriBiznesit,
            FirmaAyarlari_AdresaBiznesit,
            FirmaAyarlari_Email,
            FirmaAyarlari_XhiroLogari,
            FirmaAyarlari_DataHapjes,
            FirmaAyarlari_Vendi,
            FirmaAyarlari_Telefoni,
            FirmaAyarlari_Mobil,
            FirmaAyarlari_Fax,
            FirmaAyarlari_Pronar,
            FirmaAyarlari_TelefonPronar,
            FirmaAyarlari_MobilPronar,
            GuncellemeAyarlari_DownloadURL,
            GuncellemeAyarlari_VersionURL,
        }
        public static void AyarDegistir(Ayarlar ayar, string value)
        {
            try
            {
                string[] gelenAyar = ayar.ToString().Split(Convert.ToChar("_"));
                if (data != null)
                {
                    if (data.Sections.Count(c => c.SectionName == gelenAyar[0]) == 0)
                    {
                        data.Sections.AddSection(gelenAyar[0]);
                        data[gelenAyar[0]].AddKey(gelenAyar[1]);
                    }
                    else
                    {
                        data[gelenAyar[0]].AddKey(gelenAyar[1]);
                    }
                    data[gelenAyar[0]][gelenAyar[1]] = value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static string AyarOku(Ayarlar ayar)
        {
            try
            {
                string[] gelenAyar = ayar.ToString().Split(Convert.ToChar("_"));
                return data[gelenAyar[0]][gelenAyar[1]];
            }
            catch (Exception)
            {
                throw;
            }

        }
        public static void Save()
        {
            try
            {
                parser.WriteFile(dosyaAdi, data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
