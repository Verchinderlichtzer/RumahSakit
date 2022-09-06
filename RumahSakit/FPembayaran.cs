using System;
using System.Linq;
using System.Windows.Forms;
using static RumahSakit.Ly;

namespace RumahSakit
{
    public partial class FPembayaran : Form
    {
        Perawatan perawatan;
        KamarDetail kamarDetail;
        string idPerawatan;
        int balance;

        public FPembayaran()
        {
            InitializeComponent();
        }

        #region Form
        void Clear()
        {
            Tampil();
            balance = 0;
            tNamaPasien.Clear();
            tNamaKamar.Clear();
            tTglMasuk.Clear();
            tDiagnosis.Clear();
            tTotalBiaya.Clear();
            tTerbayar.Clear();
            tSisa.Clear();
            tBayar.Clear();
            tBalance.Clear();
            tCariData.Clear();
            tBayar.Enabled = false;
            dgv.Rows.Clear();
        }

        void Tampil()
        {
            tIdPerawatan.Items.Clear();
            tIdPerawatan.Items.AddRange((from x in daftarPerawatan where x.Status != "Terdaftar" && x.TotalBiaya > x.Terbayar orderby x.TanggalMasuk descending select x.IdPerawatan).ToArray());
        }

        void FPembayaran_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        void TIdPerawatan_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            perawatan = daftarPerawatan.Find(x => x.IdPerawatan == tIdPerawatan.Text);
            kamarDetail = daftarKamarDetail.Find(x => x.IdPerawatan == tIdPerawatan.Text);
            var hasil = (from v in daftarPerawatan
                         join w in daftarPasien on v.IdPasien equals w.IdPasien
                         join x in daftarKamarDetail on v.IdPerawatan equals x.IdPerawatan
                         join y in daftarKamar on x.NoKamar equals y.NoKamar
                         where v.IdPerawatan.Cari(tIdPerawatan.Text)
                         select new
                         {
                             v.IdPerawatan,
                             NamaPasien = w.Nama,
                             NamaKamar = y.Nama,
                             v.TanggalMasuk,
                             v.Diagnosis,
                             v.TotalBiaya,
                             v.Terbayar,
                             v.Status
                         }).First();
            tNamaPasien.Text = hasil.NamaPasien;
            tNamaKamar.Text = hasil.NamaKamar;
            tTglMasuk.Text = SVal(hasil.TanggalMasuk, "dd MMMM yyyy");
            tDiagnosis.Text = hasil.Diagnosis;
            tTotalBiaya.Text = SVal(hasil.TotalBiaya, "n0");
            tTerbayar.Text = SVal(hasil.Terbayar, "n0");
            tSisa.Text = SVal(hasil.TotalBiaya - hasil.Terbayar, "n0");
            idPerawatan = hasil.IdPerawatan;
            tBayar.Enabled = true;
            TampilDGV();
        }

        void InputAngka(object sender, KeyPressEventArgs e)
        {
            Numbers(sender, e);
        }

        void TBayar_TextChanged(object sender, EventArgs e)
        {
            balance = IVal(tBayar.Text) - (IVal(tTotalBiaya.Text.Replace(".", "")) - IVal(tTerbayar.Text.Replace(".", "")));
            tBalance.Text = SVal(Math.Abs(balance), "n0");
            lblBalance.Text = balance >= 0 && tIdPerawatan.SelectedIndex >= 0 ? "Kembali" : "Kurang";
            Validasi();
        }

        void Validasi()
        {
            btnSimpan.Enabled = tIdPerawatan.SelectedIndex >= 0 && IVal(tBayar.Text) > 0;
        }
        #endregion

        #region CRUD
        void BTNSimpan_Click(object sender, EventArgs e)
        {
            int bayar = balance < 0 ? IVal(tBayar.Text) : IVal(tTotalBiaya.Text.Replace(".", "")) - IVal(tTerbayar.Text.Replace(".", ""));
            QN($"INSERT INTO Pembayaran VALUES('{tIdPerawatan.Text}',DATE(),{bayar})");
            daftarPembayaran.Add(new Pembayaran { IdPerawatan = tIdPerawatan.Text, Tanggal = DateTime.Now, Nominal = bayar });
            QN($"UPDATE Perawatan SET TanggalKeluar = DATE(), Terbayar = Terbayar + {bayar}, Status = 'Selesai' WHERE IdPerawatan = '{tIdPerawatan.Text}'");
            QN($"UPDATE Pasien SET Status = '-' WHERE IdPasien = '{perawatan.IdPasien}'");
            daftarPasien.Find(x => x.IdPasien == perawatan.IdPasien).Status = "-";
            if (perawatan.Status == "Dirawat")
            {
                QN($"UPDATE Kamar SET Isi = Isi - 1 WHERE NoKamar = '{kamarDetail.NoKamar}'");
                daftarKamar.Find(x => x.NoKamar == kamarDetail.NoKamar).Isi--;
            }
            perawatan.TanggalKeluar = DateTime.Today;
            perawatan.Terbayar += bayar;
            perawatan.Status = "Selesai";
            QN($"INSERT INTO LogUser VALUES('{userAktif}',NOW(),'Perawatan {tIdPerawatan.Text} membayar {SVal(bayar, "c0")}')");
            daftarLogUser.Add(new LogUser { Username = userAktif, Tanggal = DateTime.Today, Catatan = $"Perawatan {tIdPerawatan.Text} membayar {SVal(bayar, "c0")}" });
            Pesan("Pembayaran berhasil", Notifikasi.Jenis.Berhasil);
            Clear();
        }

        void BTNRefresh_Click(object sender, EventArgs e)
        {
            Clear();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys koentji)
        {
            if (koentji == Keys.Enter)
            {
                btnSimpan.PerformClick();
                return true;
            }
            else if (koentji == Keys.Oemtilde)
            {
                btnRefresh.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, koentji);
        }
        #endregion

        #region DGV
        void TCariData_TextChanged(object sender, EventArgs e)
        {
            TampilDGV();
        }

        void TampilDGV()
        {
            if (tIdPerawatan.SelectedIndex < 0) return;
            dgv.Rows.Clear();
            var detailAlat = from x in daftarAlat
                             join y in daftarAlatDetail on x.IdAlat equals y.IdAlat
                             where y.IdPerawatan == idPerawatan && x.Nama.Cari(tCariData.Text)
                             select new
                             {
                                 Kolom1 = x.Nama,
                                 Kolom2 = "Alat",
                                 Kolom3 = y.Tarif
                             };
            var detailTindakan = from x in daftarTindakan
                                 join y in daftarTindakanDetail on x.IdTindakan equals y.IdTindakan
                                 where y.IdPerawatan == idPerawatan && x.Nama.Cari(tCariData.Text)
                                 select new
                                 {
                                     Kolom1 = x.Nama,
                                     Kolom2 = "Tindakan",
                                     Kolom3 = y.Tarif
                                 };
            var detailKamar = from x in daftarKamar
                              join y in daftarKamarDetail on x.NoKamar equals y.NoKamar
                              where y.IdPerawatan == idPerawatan && x.Nama.Cari(tCariData.Text)
                              select new
                              {
                                  Kolom1 = x.Nama,
                                  Kolom2 = "Kamar",
                                  Kolom3 = y.Tarif
                              };
            var detailObat = from x in daftarObat
                             join y in daftarObatDetail on x.IdObat equals y.IdObat
                             where y.IdPerawatan == idPerawatan && x.Nama.Cari(tCariData.Text)
                             select new
                             {
                                 Kolom1 = x.Nama,
                                 Kolom2 = "Obat",
                                 Kolom3 = y.Harga
                             };
            var detailDokter = from x in daftarDokter
                               join y in daftarDokterDetail on x.IdDokter equals y.IdDokter
                               where y.IdPerawatan == idPerawatan && (x.Nama.Cari(tCariData.Text) || x.Spesialis.Cari(tCariData.Text))
                               select new
                               {
                                   Kolom1 = x.Nama,
                                   Kolom2 = "Dokter",
                                   Kolom3 = y.Tarif
                               };
            int nomor = 0;
            foreach (var g in detailAlat.Concat(detailTindakan).Concat(detailKamar).Concat(detailObat).Concat(detailDokter).OrderBy(x => x.Kolom2).ThenBy(x => x.Kolom1)) dgv.Rows.Add(++nomor, g.Kolom1, g.Kolom2, g.Kolom3);
        }
        #endregion
    }
}
