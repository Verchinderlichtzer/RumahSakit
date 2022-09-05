using Microsoft.Win32;
using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using static RumahSakit.Ly;

namespace RumahSakit
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Mutex mutex = new Mutex(true, "{8F6F0AC4-C9A1-45fd-A8CF-72F04E6ZDE8F}", out bool result);
            if (!result) return;

            var id = new CultureInfo("id-ID");
            CultureInfo.DefaultThreadCurrentCulture = id;
            CultureInfo.DefaultThreadCurrentUICulture = id;

            if (Registry.CurrentUser.OpenSubKey(@"System\Windows") == null)
            {
                SetReg("LoggedIn", string.Empty);
                SetReg("IsShowingId", 0);
                SetReg("IsSavingResolution", 0);
                SetReg("CurResolution", string.Empty);
                SetReg("CurState", string.Empty);
            }

            Koneksi();
            #region Ambil Semua Data
            QRL("SELECT * FROM Users");
            while (dr.Read())
            {
                daftarUser.Add(new User { Username = SVal(dr[0]), Password = SVal(dr[1]), HakUser = BVal(dr[2]), HakAlat = BVal(dr[3]), HakTindakan = BVal(dr[4]), HakKamar = BVal(dr[5]), HakObat = BVal(dr[6]), HakDokter = BVal(dr[7]), HakPasien = BVal(dr[8]), HakRegistrasi = BVal(dr[9]), HakPerawatan = BVal(dr[10]), HakPembayaran = BVal(dr[11]) });
            }
            QRL("SELECT * FROM LogUser");
            while (dr.Read())
            {
                daftarLogUser.Add(new LogUser { Username = SVal(dr[0]), Tanggal = DtVal(dr[1]), Catatan = SVal(dr[2]) });
            }
            QRL("SELECT * FROM Alat");
            while (dr.Read())
            {
                daftarAlat.Add(new Alat { IdAlat = IVal(dr[0]), Nama = SVal(dr[1]), Tarif = IVal(dr[2]) });
            }
            QRL("SELECT * FROM Tindakan");
            while (dr.Read())
            {
                daftarTindakan.Add(new Tindakan { IdTindakan = IVal(dr[0]), Nama = SVal(dr[1]), Tarif = IVal(dr[2]) });
            }
            QRL("SELECT Kamar.NoKamar, Nama, Tarif, Kapasitas, Isi FROM Kamar");
            while (dr.Read())
            {
                daftarKamar.Add(new Kamar { NoKamar = SVal(dr[0]), Nama = SVal(dr[1]), Tarif = IVal(dr[2]), Kapasitas = IVal(dr[3]), Isi = IVal(dr[4]) });
            }
            QRL("SELECT * FROM Obat");
            while (dr.Read())
            {
                daftarObat.Add(new Obat { IdObat = SVal(dr[0]), Nama = SVal(dr[1]), Harga = IVal(dr[2]) });
            }
            QRL("SELECT * FROM Dokter");
            while (dr.Read())
            {
                daftarDokter.Add(new Dokter { IdDokter = SVal(dr[0]), Nama = SVal(dr[1]), JenisKelamin = SVal(dr[2]), TanggalLahir = (DateTime)dr[3], Alamat = SVal(dr[4]), NoTelepon = SVal(dr[5]), Spesialis = SVal(dr[6]), Tarif = IVal(dr[7]) });
            }
            QRL("SELECT * FROM Pasien");
            while (dr.Read())
            {
                daftarPasien.Add(new Pasien { IdPasien = SVal(dr[0]), Nama = SVal(dr[1]), JenisKelamin = SVal(dr[2]), TanggalLahir = (DateTime)dr[3], Alamat = SVal(dr[4]), NoTelepon = SVal(dr[5]), Status = SVal(dr[6]) });
            }
            QRL("SELECT * FROM Perawatan");
            while (dr.Read())
            {
                daftarPerawatan.Add(new Perawatan { IdPerawatan = SVal(dr[0]), IdPasien = SVal(dr[1]), TanggalMasuk = DtVal(dr[2]), TanggalKeluar = dr[3] as DateTime?, Diagnosis = SVal(dr[4]), TotalBiaya = IVal(dr[5]), Terbayar = IVal(dr[6]), Status = SVal(dr[7]) });
            }
            QRL("SELECT * FROM Pembayaran");
            while (dr.Read())
            {
                daftarPembayaran.Add(new Pembayaran { IdPerawatan = SVal(dr[0]), Tanggal = DtVal(dr[1]), Nominal = IVal(dr[2]) });
            }
            QRL("SELECT * FROM AlatDetail");
            while (dr.Read())
            {
                daftarAlatDetail.Add(new AlatDetail { IdPerawatan = SVal(dr[0]), IdAlat = IVal(dr[1]), Tarif = IVal(dr[2]) });
            }
            QRL("SELECT * FROM TindakanDetail");
            while (dr.Read())
            {
                daftarTindakanDetail.Add(new TindakanDetail { IdPerawatan = SVal(dr[0]), IdTindakan = IVal(dr[1]), Tarif = IVal(dr[2]) });
            }
            QRL("SELECT * FROM KamarDetail");
            while (dr.Read())
            {
                daftarKamarDetail.Add(new KamarDetail { IdPerawatan = SVal(dr[0]), NoKamar = SVal(dr[1]), Tarif = IVal(dr[2]) });
            }
            QRL("SELECT * FROM ObatDetail");
            while (dr.Read())
            {
                daftarObatDetail.Add(new ObatDetail { IdPerawatan = SVal(dr[0]), IdObat = SVal(dr[1]), Harga = IVal(dr[2]) });
            }
            QRL("SELECT * FROM DokterDetail");
            while (dr.Read())
            {
                daftarDokterDetail.Add(new DokterDetail { IdPerawatan = SVal(dr[0]), IdDokter = SVal(dr[1]), Tarif = IVal(dr[2]) });
            }
            QR("SELECT * FROM Info");
            info = new Info() { Nama = SVal(dr[0]), Alamat = SVal(dr[1]), Telepon = SVal(dr[2]), Fax = SVal(dr[3]), Email = SVal(dr[4]), Website = SVal(dr[5]), Pengurus = SVal(dr[6]), Jabatan = SVal(dr[7]) };
            #endregion

            try
            {
                userAktif = daftarUser.Find(x => x.Username == DecodeUsername(GetReg("LoggedIn"))).Username;
                Application.Run(new FMain());
            }
            catch (CryptographicException)
            {
                Application.Run(new Login());
            }
            catch (FormatException)
            {
                Application.Run(new Login());
            }
        }
    }
}
