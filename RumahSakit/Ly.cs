using Krypton.Toolkit;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RumahSakit
{
    public static class Ly
    {
        public static FMain fmain;
        public static Login login;

        public static OleDbConnection conn;
        public static OleDbCommand cmd;
        public static OleDbDataReader dr;
        public static OleDbDataAdapter da;
        public static DataSet ds;

        public static string userAktif;
        public static int halamanTerpilih;
        public static bool[] hakAkses;
        public static bool locked, isShowingId, isSavingResolution;

        public static void Koneksi()
        {
            try
            {
                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\RumahSakit.accdb;Jet OLEDB:Database Password=f;");
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.ExitThread();
            }
        }

        public static void QR(string queryReader)
        {
            try
            {
                cmd = new OleDbCommand(queryReader, conn);
                dr = cmd.ExecuteReader();
                dr.Read();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.ExitThread();
            }
        }

        public static void QRL(string queryReaderLooping)
        {
            try
            {
                cmd = new OleDbCommand(queryReaderLooping, conn);
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.ExitThread();
            }
        }

        public static void QN(string queryNonReader)
        {
            try
            {
                cmd = new OleDbCommand(queryNonReader, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.ExitThread();
            }
        }

        public static void QDGV(string queryDGV, DataGridView dataGrid, int startRecord, int maxRecord, string srcTable)
        {
            da = new OleDbDataAdapter(queryDGV, conn);
            ds = new DataSet();
            da.Fill(ds, startRecord, maxRecord, srcTable);
            dataGrid.DataSource = ds.Tables[0];
        }

        public static void HakAksesEdit(int hakE, KryptonButton btn1, KryptonButton btn2) // HakE merupakan urutan hak akses edit, cek di FMain_VisibleChanged
        {
            if (!hakAkses[hakE])
            {
                btn1.Visible = false;
                btn2.Visible = false;
            }
            else
            {
                btn1.Visible = true;
                btn2.Visible = true;
            }
        }

        public static string EncodeUsername(string plainUsername)
        {
            var wrapper = new Encryptor("1337");
            return wrapper.EncryptData(plainUsername);
        }

        public static string DecodeUsername(string cipherUsername)
        {
            var wrapper = new Encryptor("1337");
            return wrapper.DecryptData(cipherUsername);
        }

        public static string EncodePassword(string plainUsername, string plainPassword)
        {
            var wrapper = new Encryptor(plainUsername);
            string cipherPassword = wrapper.EncryptData(Reverse(plainPassword));
            var asciis = Encoding.ASCII.GetBytes(cipherPassword);
            for (int i = 0, loopTo = asciis.Length - 1; i <= loopTo; i++) asciis[i] = (byte)(asciis[i] + 4);
            return Encoding.ASCII.GetString(asciis);
        }

        public static string DecodePassword(string plainUsername, string cipherPassword)
        {
            var wrapper = new Encryptor(plainUsername);
            var asciis = Encoding.ASCII.GetBytes(cipherPassword);
            for (int i = 0, loopTo = asciis.Length - 1; i <= loopTo; i++) asciis[i] = (byte)(asciis[i] - 4);
            string plainPassword = wrapper.DecryptData(Encoding.ASCII.GetString(asciis));
            return Reverse(plainPassword);
        }

        public static void SetReg(string valueName, object value)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\System\Windows", valueName, value);
        }

        public static string GetReg(string valueName)
        {
            return SVal(Registry.GetValue(@"HKEY_CURRENT_USER\System\Windows", valueName, null));
        }

        public static void Characters(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar)) e.Handled = true;
        }

        public static void Numbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        public static void Decimals(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',')) || ((e.KeyChar == ',') && ((sender as TextBox)?.Text.IndexOf(',') > -1))) e.Handled = true;
        }

        public static void Pesan(string msg, Notifikasi.Jenis type)
        {
            if (!Application.OpenForms.OfType<Notifikasi>().Any())
            {
                var f = new Notifikasi();
                f.SetAlert(msg, type);
            }
        }

        public static void GoToPageNumber(int totalBaris, double maxRows, ref int current)
        {
            var Confirm = new Konfirmasi("Pilih antara halaman 1 ~ " + Math.Ceiling(totalBaris / maxRows), "-", 0, Konfirmasi.Jenis.Pagination);
            if (Confirm.ShowDialog() == DialogResult.Yes && halamanTerpilih != 0) current = halamanTerpilih;
        }

        public static bool Cari(this string source, string toCheck)
        {
            return source?.IndexOf(toCheck, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        public static string Left(this string str, int count)
        {
            str += string.Empty;
            if (count > str.Length) count = str.Length;
            return str.Substring(0, count);
        }

        public static string Right(this string str, int count)
        {
            str += string.Empty;
            if (count > str.Length) count = str.Length;
            return str.Substring(str.Length - count);
        }

        public static string Mid(this string str, int index)
        {
            str += string.Empty;
            return str.Substring(index);
        }

        public static string Mid(this string str, int index, int count)
        {
            str += string.Empty;
            if (count > str.Length) count = str.Length - index;
            return str.Substring(index, count);
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string SVal(object objek)
        {
            return Convert.ToString(objek);
        }

        public static string SVal(object objek, string format)
        {
            if (objek is int)
            {
                int.TryParse(objek.ToString(), out int hasilInt);
                return hasilInt.ToString(format);
            }
            else if (objek is DateTime)
            {
                DateTime.TryParse(objek.ToString(), out DateTime hasilDateTime);
                return hasilDateTime.ToString(format);
            }
            return null;
        }

        public static int IVal(object objek)
        {
            int.TryParse(objek.ToString(), out int hasil);
            return hasil;
        }

        public static double DVal(object objek)
        {
            double.TryParse(objek.ToString(), out double hasil);
            return hasil;
        }

        public static bool BVal(object objek)
        {
            bool.TryParse(objek.ToString(), out bool hasil);
            return hasil;
        }

        public static DateTime DtVal(object objek)
        {
            DateTime.TryParse(objek.ToString(), out DateTime hasil);
            return hasil;
        }

        public static void Ukur(DataGridView dg) // For Development
        {
            int totalPanjang = 0;
            string z = null;
            foreach (DataGridViewTextBoxColumn x in dg.Columns)
            {
                if (!x.Visible) continue;
                z += $"{x.HeaderText} = {x.Width}\r";
                totalPanjang += x.Width;
            }
            z += $"\rTotal = {totalPanjang} / {dg.Width}\rSisa = {dg.Width - totalPanjang}";
            MessageBox.Show(z);
        }

        public static List<User> daftarUser = new List<User>();
        public static List<LogUser> daftarLogUser = new List<LogUser>();
        public static List<Alat> daftarAlat = new List<Alat>();
        public static List<AlatDetail> daftarAlatDetail = new List<AlatDetail>();
        public static List<Tindakan> daftarTindakan = new List<Tindakan>();
        public static List<TindakanDetail> daftarTindakanDetail = new List<TindakanDetail>();
        public static List<Kamar> daftarKamar = new List<Kamar>();
        public static List<KamarDetail> daftarKamarDetail = new List<KamarDetail>();
        public static List<Obat> daftarObat = new List<Obat>();
        public static List<ObatDetail> daftarObatDetail = new List<ObatDetail>();
        public static List<Dokter> daftarDokter = new List<Dokter>();
        public static List<DokterDetail> daftarDokterDetail = new List<DokterDetail>();
        public static List<Pasien> daftarPasien = new List<Pasien>();
        public static List<Perawatan> daftarPerawatan = new List<Perawatan>();
        public static List<Pembayaran> daftarPembayaran = new List<Pembayaran>();
        public static Info info;
    }

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool HakUser { get; set; }
        public bool HakAlat { get; set; }
        public bool HakTindakan { get; set; }
        public bool HakKamar { get; set; }
        public bool HakObat { get; set; }
        public bool HakDokter { get; set; }
        public bool HakPasien { get; set; }
        public bool HakRegistrasi { get; set; }
        public bool HakPerawatan { get; set; }
        public bool HakPembayaran { get; set; }
    }

    public class LogUser
    {
        public string Username { get; set; }
        public DateTime Tanggal { get; set; }
        public string Catatan { get; set; }
    }

    public class Alat
    {
        public int IdAlat { get; set; }
        public string Nama { get; set; }
        public int Tarif { get; set; }
    }

    public class Tindakan
    {
        public int IdTindakan { get; set; }
        public string Nama { get; set; }
        public int Tarif { get; set; }
    }

    public class Kamar
    {
        public string NoKamar { get; set; }
        public string Nama { get; set; }
        public int Tarif { get; set; }
        public int Kapasitas { get; set; }
        public int Isi { get; set; }
    }

    public class Obat
    {
        public string IdObat { get; set; }
        public string Nama { get; set; }
        public int Harga { get; set; }
    }

    public class Dokter
    {
        public string IdDokter { get; set; }
        public string Nama { get; set; }
        public string JenisKelamin { get; set; }
        public DateTime TanggalLahir { get; set; }
        public string Alamat { get; set; }
        public string NoTelepon { get; set; }
        public string Spesialis { get; set; }
        public int Tarif { get; set; }
    }

    public class Pasien
    {
        public string IdPasien { get; set; }
        public string Nama { get; set; }
        public string JenisKelamin { get; set; }
        public DateTime TanggalLahir { get; set; }
        public string Alamat { get; set; }
        public string NoTelepon { get; set; }
        public string Status { get; set; }
    }

    public class Perawatan
    {
        public string IdPerawatan { get; set; }
        public string IdPasien { get; set; }
        public DateTime TanggalMasuk { get; set; }
        public DateTime? TanggalKeluar { get; set; }
        public string Diagnosis { get; set; }
        public int TotalBiaya { get; set; }
        public int Terbayar { get; set; }
        public string Status { get; set; }
    }

    public class Pembayaran
    {
        public string IdPerawatan { get; set; }
        public DateTime Tanggal { get; set; }
        public int Nominal { get; set; }
    }

    public class AlatDetail
    {
        public string IdPerawatan { get; set; }
        public int IdAlat { get; set; }
        public int Tarif { get; set; }
    }

    public class TindakanDetail
    {
        public string IdPerawatan { get; set; }
        public int IdTindakan { get; set; }
        public int Tarif { get; set; }
    }

    public class KamarDetail
    {
        public string IdPerawatan { get; set; }
        public string NoKamar { get; set; }
        public int Tarif { get; set; }
    }

    public class ObatDetail
    {
        public string IdPerawatan { get; set; }
        public string IdObat { get; set; }
        public int Harga { get; set; }
    }

    public class DokterDetail
    {
        public string IdPerawatan { get; set; }
        public string IdDokter { get; set; }
        public int Tarif { get; set; }
    }

    public class Info
    {
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public string Telepon { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Pengurus { get; set; }
        public string Jabatan { get; set; }
    }
}
