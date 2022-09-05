using Krypton.Toolkit;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static RumahSakit.Ly;

namespace RumahSakit
{
    public partial class FLaporan : Form
    {
        // Ukuran Kertas :
        // A4 = 8.27in, 11.69in / 11.69in, 8.27in
        // F4 = 8.27in, 12.99in / 12.99in, 8.27in

        // Layout / Positioning
        // Page Header Height : 0.25in
        // Page Footer Height : 0.4in
        // Tablix Size : 7.27in, 0.5in
        // Jarak Dengan Arrow Key => Top = 0 | Left & Right = 4 | Bottom = ?
        // Logo Size 100px : 1.0416in, 1.0416in
        // Bulatkan ukuran inci sampai formatnya 0.00in

        // Parameters :
        // - Nama
        // - Alamat
        // - Telepon
        // - Fax
        // - Email
        // - Website
        // - Pengurus
        // - Jabatan
        // - Filter
        // - Tahun

        // Report Property :
        // - InteractiveSize = 8.27in, 11.69in
        // - Language = id-ID
        // - PageSize = 8.27in, 11.69in

        // Basic Settings
        // - Font = Segoe UI
        // - Header BackColor dan BorderColor = #21333a
        // - BorderStyle (Kiri / Kanan) = None, Solid, Solid, , 
        // - BorderWidth (Kiri / Kanan) = 1pt, 1pt, 1pt, , 
        // - Row BackColor  =IIf(RowNumber(Nothing) Mod 2, "#F7F7F8", "#F1F2F3")
        // - Row BackColor By Group  =IIf(RunningValue(Fields!ID_Barang.Value, CountDistinct, Nothing) Mod 2, "#F7F7F8", "#F1F2F3")
        // - Row BorderColor = #dbdedf

        // Warna Berdasarkan Kriteria :
        // =IIf(Fields!Status.Value = "Belum Lunas", "#DC3545", "#333333")
        // =IIf(Left(Fields!ID_Masuk.Value, 1) = "K", "#198754", "#DC3545")
        // #333333 = Default
        // #198754 = Hijau
        // #DC3545 = Merah

        // Grafik :

        // Category Groups :

        // Group Expression
        // =Month(Fields!Tanggal.Value)

        // Labels
        // =IIf(Month(Fields!Tanggal.Value) = 1, "JAN", IIf(Month(Fields!Tanggal.Value) = 2, "FEB", IIf(Month(Fields!Tanggal.Value) = 3, "MAR", IIf(Month(Fields!Tanggal.Value) = 4, "APR", IIf(Month(Fields!Tanggal.Value) = 5, "MEI", IIf(Month(Fields!Tanggal.Value) = 6, "JUN", IIf(Month(Fields!Tanggal.Value) = 7, "JUL", IIf(Month(Fields!Tanggal.Value) = 8, "AGS", IIf(Month(Fields!Tanggal.Value) = 9, "SEP", IIf(Month(Fields!Tanggal.Value) = 10, "OKT", IIf(Month(Fields!Tanggal.Value) = 11, "NOV", IIf(Month(Fields!Tanggal.Value) = 12, "DES", Nothing))))))))))))

        // Values
        // =Sum(IIf(Left(Fields!ID_Masuk.Value, 1) = "M / K", Fields!Nominal.Value, Nothing))

        // Chart Axis X
        // Interval = 1

        // Values > Series > Show Data Labels


        string laporanTerpilih; // Nama control yang mewakili laporan terpilih
        string queryTanggal, queryStatus; // Kriteria WHERE pada query
        string idTerpilih, namaTerpilih; // Entitas terpilih

        enum Lt // Laporan terpilih
        {
            None,
            File,
            Perawatan,
            Grafik,
            Entitas
        }
        enum Tgl // Tanggal terpilih
        {
            None,
            Periodik,
            Bulanan,
            Tahunan
        }

        KryptonRadioButton laporanKiriTerpilih;
        KryptonCheckBox[] statusPerawatan;
        readonly StringBuilder sb = new StringBuilder();
        Lt lt;
        Tgl tgl;

        ReportParameter paramFilter, paramNama, paramAlamat, paramTelepon, paramFax, paramEmail, paramWebsite, paramPengurus, paramJabatan, paramTahun;
        ReportParameter[] parameter;
        public FLaporan()
        {
            InitializeComponent();
        }

        #region Form
        void Clear()
        {
            locked = true;
            rbRingkasan.Checked = true;
            foreach (KryptonRadioButton x in new[] { rbAlat, rbTindakan, rbKamar, rbObat, rbDokter, rbPasien, rbPerawatan, rbGrafik }) x.Checked = false;
            foreach (KryptonCheckBox x in new[] { cbMasuk, cbKeluar, cbTerdaftar, cbDirawat, cbSelesai }) x.Checked = false;
            tDari.Value = DateTime.Today;
            tSampai.Value = DateTime.Today;
            tBulan.Value = DateTime.Today;
            tTahun.SelectedIndex = 0;
            tEntitas.SelectedIndex = -1;
            tCariData.Clear();
            dgv.Rows.Clear();
            btnTampil.Enabled = false;

            lt = Lt.None;
            tgl = Tgl.None;
            lblFilter.Text = "";

            queryTanggal = null;
            queryStatus = null;
            laporanTerpilih = null;
            Akses(false, false, false, false, false, false);
            locked = false;
        }

        void Filter()
        {
            sb.Clear();
            if (lt != Lt.Entitas) sb.Append("Laporan ");
            if (lt == Lt.File)
            {
                sb.Append(SVal(laporanKiriTerpilih.Tag).ToLower());
            }
            else if (lt == Lt.Perawatan)
            {
                sb.Append("Perawatan");
            }
            else if (lt == Lt.Grafik)
            {
                sb.Append("Grafik");
            }
            else if (lt == Lt.Entitas)
            {
                if (tEntitas.Text == "Rawat Inap")
                {
                    sb.Append("Laporan perawatan pada ID ");
                }
                else if (tEntitas.Text == "Alat" || tEntitas.Text == "Obat" || tEntitas.Text == "Tindakan")
                {
                    sb.Append("Perawatan yang dilakukan dengan ");
                    if (tEntitas.Text == "Tindakan") sb.Append("cara ");
                }
                else if (tEntitas.Text == "Kamar")
                {
                    sb.Append("Perawatan yang dilakukan di ");
                }
                else if (tEntitas.Text == "Dokter")
                {
                    sb.Append("Perawatan yang dilakukan oleh ");
                }
                else if (tEntitas.Text == "Pasien")
                {
                    sb.Append("Perawatan yang dilakukan kepada ");
                }
                sb.Append(namaTerpilih);
            }

            if ((cbMasuk.Checked ^ cbKeluar.Checked) && (lt == Lt.Perawatan || (lt == Lt.Entitas && tEntitas.SelectedIndex > 0)))
            {
                sb.Append(" yang").Append(cbMasuk.Checked ? " masuk" : " keluar");
            }

            if (tgl == Tgl.Periodik && (lt == Lt.Perawatan || (lt == Lt.Entitas && tEntitas.SelectedIndex > 0)))
            {
                sb.Append(tDari.Value == tSampai.Value ? " pada tanggal " : " antara tanggal ").Append(SVal(tDari.Value, "dd/MM/yyyy"));
                if (tDari.Value < tSampai.Value) sb.Append(" sampai ").Append(SVal(tSampai.Value, "dd/MM/yyyy"));
            }
            else if (tgl == Tgl.Bulanan && (lt == Lt.Perawatan || (lt == Lt.Entitas && tEntitas.SelectedIndex > 0)))
            {
                sb.Append(" pada bulan ").Append(SVal(tBulan.Value, "MMMM")).Append(" tahun ").Append(SVal(tBulan.Value, "yyyy"));
            }
            else if (tgl == Tgl.Tahunan && (lt == Lt.Perawatan || lt == Lt.Grafik || (lt == Lt.Entitas && tEntitas.SelectedIndex > 0)))
            {
                sb.Append(" pada tahun ").Append(tTahun.Text);
            }
            else if (tgl == Tgl.None && (cbMasuk.Checked || cbKeluar.Checked) && (lt == Lt.Perawatan || (lt == Lt.Entitas && tEntitas.SelectedIndex > 0)))
            {
                sb.Append(" (pilih tanggal)");
            }

            if ((cbTerdaftar.Checked || cbDirawat.Checked || cbSelesai.Checked) && (lt == Lt.Perawatan || (lt == Lt.Entitas && tEntitas.SelectedIndex > 0)))
            {
                sb.Append(" yang ");
                statusPerawatan = new[] { cbTerdaftar, cbDirawat, cbSelesai };
                sb.Append(string.Join(" / ", from x in statusPerawatan where x.Checked select x.Text.ToLower()));
            }
            btnTampil.Enabled = !(tgl == Tgl.None && (cbMasuk.Checked || cbKeluar.Checked) && (lt == Lt.Perawatan || (lt == Lt.Entitas && tEntitas.SelectedIndex > 0)));
            lblFilter.Text = SVal(sb);
        }

        void Akses(bool kriteriaTanggal, bool periodikBulanan, bool tahunan, bool statusPerawatan, bool bentukRingkasan, bool bentukDetail)
        {
            cbMasuk.Enabled = kriteriaTanggal;
            cbKeluar.Enabled = kriteriaTanggal;
            tDari.Enabled = periodikBulanan;
            tSampai.Enabled = periodikBulanan;
            tBulan.Enabled = periodikBulanan;
            tTahun.Enabled = tahunan;
            cbTerdaftar.Enabled = statusPerawatan;
            cbDirawat.Enabled = statusPerawatan;
            cbSelesai.Enabled = statusPerawatan;
            rbRingkasan.Enabled = bentukRingkasan;
            rbDetail.Enabled = bentukDetail;
        }

        void FLaporan_Load(object sender, EventArgs e)
        {
            locked = true;
            paramNama = new ReportParameter("Nama", info.Nama);
            paramAlamat = new ReportParameter("Alamat", info.Alamat);
            paramTelepon = new ReportParameter("Telepon", info.Telepon);
            paramFax = new ReportParameter("Fax", info.Fax);
            paramWebsite = new ReportParameter("Website", info.Website);
            paramEmail = new ReportParameter("Email", info.Email);
            paramPengurus = new ReportParameter("Pengurus", info.Pengurus);
            paramJabatan = new ReportParameter("Jabatan", info.Jabatan);
            parameter = new[] { paramNama, paramAlamat, paramTelepon, paramFax, paramWebsite, paramEmail, paramPengurus, paramJabatan };
            tDari.Value = DateTime.Today;
            tSampai.Value = DateTime.Today;
            tBulan.Value = DateTime.Today;
            for (int x = DateTime.Today.Year; x >= 2021; x--) tTahun.Items.Add(x);
            tTahun.SelectedIndex = 0;
            locked = false;
        }

        void FLaporan_Resize(object sender, EventArgs e)
        {
            //8   +   355   +   6   +   356   +   6   +   355   +   8
            panelKiri.Width = (Width - 8 - 6 - 6 - 8 - 356) / 2;
            panelKanan.Width = (Width - 8 - 6 - 6 - 8 - 356) / 2;
            panelTanggal.Location = new Point(panelKiri.Width + 14, 8);
            panelStatusPerawatan.Location = new Point(panelKiri.Width + 14, panelTanggal.Height + 8 + 6);
            panelBentukLaporan.Location = new Point(panelKiri.Width + 14, panelTanggal.Height + panelStatusPerawatan.Height + 8 + 6 + 6);
            panelKanan.Location = new Point(panelTanggal.Location.X + panelTanggal.Width + 6, 8);
            panelDGVPagination.Location = new Point(3 + (dgv.Width / 2) - 100, dgv.Location.Y + dgv.Height);
            lblPerawatanGrafik.Width = panelKiri.Width;
        }

        void BTNTampil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(laporanTerpilih))
            {
                Pesan("Laporan tidak valid", Notifikasi.Jenis.Gagal);
                return;
            }
            switch (laporanTerpilih)
            {
                case "Alat":
                    {
                        TampilLaporan("Alat", "SELECT * FROM Alat ORDER BY Nama", dSRumahSakit.Alat);
                        break;
                    }
                case "Tindakan":
                    {
                        TampilLaporan("Tindakan", "SELECT * FROM Tindakan ORDER BY Nama", dSRumahSakit.Tindakan);
                        break;
                    }
                case "Kamar":
                    {
                        TampilLaporan("Kamar", "SELECT * FROM Kamar ORDER BY Nama", dSRumahSakit.Kamar);
                        break;
                    }
                case "Obat":
                    {
                        TampilLaporan("Obat", "SELECT * FROM Obat ORDER BY Nama", dSRumahSakit.Obat);
                        break;
                    }
                case "Dokter":
                    {
                        TampilLaporan("Dokter", "SELECT * FROM Dokter ORDER BY Nama", dSRumahSakit.Dokter);
                        break;
                    }
                case "Pasien":
                    {
                        TampilLaporan("Pasien", "SELECT * FROM Pasien ORDER BY Nama", dSRumahSakit.Pasien);
                        break;
                    }
                case "Perawatan":
                    {
                        if (rbRingkasan.Checked)
                        {
                            TampilLaporan("PerawatanRingkasan", $"SELECT Perawatan.IdPerawatan, Pasien.Nama, Kamar.Nama, TanggalMasuk, TanggalKeluar, Diagnosis, TotalBiaya FROM Pasien INNER JOIN (Kamar INNER JOIN (Perawatan INNER JOIN KamarDetail ON Perawatan.IdPerawatan = KamarDetail.IdPerawatan) ON Kamar.NoKamar = KamarDetail.NoKamar) ON Pasien.IdPasien = Perawatan.IdPasien WHERE NOT Perawatan.IdPerawatan IS NULL{queryTanggal}{queryStatus}", dSRumahSakit.PerawatanRingkasan);
                        }
                        else
                        {
                            TampilLaporan("PerawatanDetail", $"SELECT Perawatan.IdPerawatan, Pasien.Nama, TanggalMasuk, TanggalKeluar, Diagnosis, TotalBiaya, Kamar.Nama, KamarDetail.Tarif FROM Pasien INNER JOIN (Kamar INNER JOIN (Perawatan INNER JOIN KamarDetail ON Perawatan.IdPerawatan = KamarDetail.IdPerawatan) ON Kamar.NoKamar = KamarDetail.NoKamar) ON Pasien.IdPasien = Perawatan.IdPasien WHERE NOT Perawatan.IdPerawatan IS NULL{queryTanggal}{queryStatus} UNION ALL SELECT Perawatan.IdPerawatan, Pasien.Nama, TanggalMasuk, TanggalKeluar, Diagnosis, TotalBiaya, Alat.Nama + ' (Alat)', AlatDetail.Tarif FROM Alat INNER JOIN ((Pasien INNER JOIN Perawatan ON Pasien.IdPasien = Perawatan.IdPasien) INNER JOIN AlatDetail ON Perawatan.IdPerawatan = AlatDetail.IdPerawatan) ON Alat.IdAlat = AlatDetail.IdAlat WHERE NOT Perawatan.IdPerawatan IS NULL{queryTanggal}{queryStatus} UNION ALL SELECT Perawatan.IdPerawatan, Pasien.Nama, TanggalMasuk, TanggalKeluar, Diagnosis, TotalBiaya, Tindakan.Nama + ' (Tindakan)', TindakanDetail.Tarif FROM Tindakan INNER JOIN ((Pasien INNER JOIN Perawatan ON Pasien.IdPasien = Perawatan.IdPasien) INNER JOIN TindakanDetail ON Perawatan.IdPerawatan = TindakanDetail.IdPerawatan) ON Tindakan.IdTindakan = TindakanDetail.IdTindakan WHERE NOT Perawatan.IdPerawatan IS NULL{queryTanggal}{queryStatus} UNION ALL SELECT Perawatan.IdPerawatan, Pasien.Nama, TanggalMasuk, TanggalKeluar, Diagnosis, TotalBiaya, Obat.Nama + ' (Obat)', ObatDetail.Harga FROM Obat INNER JOIN ((Pasien INNER JOIN Perawatan ON Pasien.IdPasien = Perawatan.IdPasien) INNER JOIN ObatDetail ON Perawatan.IdPerawatan = ObatDetail.IdPerawatan) ON Obat.IdObat = ObatDetail.IdObat WHERE NOT Perawatan.IdPerawatan IS NULL{queryTanggal}{queryStatus} UNION ALL SELECT Perawatan.IdPerawatan, Pasien.Nama, TanggalMasuk, TanggalKeluar, Diagnosis, TotalBiaya, Dokter.Nama + ' (Dokter)', DokterDetail.Tarif FROM (Pasien INNER JOIN Perawatan ON Pasien.IdPasien = Perawatan.IdPasien) INNER JOIN (Dokter INNER JOIN DokterDetail ON Dokter.IdDokter = DokterDetail.IdDokter) ON Perawatan.IdPerawatan = DokterDetail.IdPerawatan WHERE NOT Perawatan.IdPerawatan IS NULL{queryTanggal}{queryStatus}", dSRumahSakit.PerawatanDetail);
                        }
                        break;
                    }
                case "Grafik":
                    {
                        TampilLaporan("Grafik", $"SELECT Tanggal, Nominal FROM Pembayaran WHERE YEAR(Tanggal) = {tTahun.Text}", dSRumahSakit.Grafik);
                        break;
                    }
                case "ERawatInap":
                    {
                        TampilLaporan("ERawatInap", $"SELECT Nama, JenisKelamin, TanggalLahir, Alamat, Diagnosis, TanggalMasuk, TanggalKeluar FROM Perawatan INNER JOIN Pasien ON Perawatan.IdPasien = Pasien.IdPasien WHERE IdPerawatan = '{idTerpilih}'", dSRumahSakit.ERawatInap);
                        break;
                    }
                case "EAlat":
                    {
                        TampilLaporan("EAlat", $"SELECT AlatDetail.IdPerawatan, Nama, TanggalMasuk, TanggalKeluar, Diagnosis, Tarif FROM Pasien INNER JOIN (Perawatan INNER JOIN AlatDetail ON Perawatan.IdPerawatan = AlatDetail.IdPerawatan) ON Pasien.IdPasien = Perawatan.IdPasien WHERE AlatDetail.IdAlat = {idTerpilih}{queryTanggal}{queryStatus}", dSRumahSakit.EAlat);
                        break;
                    }
                case "ETindakan":
                    {
                        TampilLaporan("ETindakan", $"SELECT TindakanDetail.IdPerawatan, Nama, TanggalMasuk, TanggalKeluar, Diagnosis, Tarif FROM (Pasien INNER JOIN Perawatan ON Pasien.IdPasien = Perawatan.IdPasien) INNER JOIN TindakanDetail ON Perawatan.IdPerawatan = TindakanDetail.IdPerawatan WHERE TindakanDetail.IdTindakan = {idTerpilih}{queryTanggal}{queryStatus}", dSRumahSakit.ETindakan);
                        break;
                    }
                case "EKamar":
                    {
                        TampilLaporan("EKamar", $"SELECT KamarDetail.IdPerawatan, Nama, TanggalMasuk, TanggalKeluar, Diagnosis, Tarif FROM (Pasien INNER JOIN Perawatan ON Pasien.IdPasien = Perawatan.IdPasien) INNER JOIN KamarDetail ON Perawatan.IdPerawatan = KamarDetail.IdPerawatan WHERE KamarDetail.NoKamar = '{idTerpilih}'{queryTanggal}{queryStatus}", dSRumahSakit.EKamar);
                        break;
                    }
                case "EObat":
                    {
                        TampilLaporan("EObat", $"SELECT ObatDetail.IdPerawatan, Nama, TanggalMasuk, TanggalKeluar, Diagnosis, Harga FROM (Pasien INNER JOIN Perawatan ON Pasien.IdPasien = Perawatan.IdPasien) INNER JOIN ObatDetail ON Perawatan.IdPerawatan = ObatDetail.IdPerawatan WHERE ObatDetail.IdObat = '{idTerpilih}'{queryTanggal}{queryStatus}", dSRumahSakit.EObat);
                        break;
                    }
                case "EDokter":
                    {
                        TampilLaporan("EDokter", $"SELECT DokterDetail.IdPerawatan, Nama, TanggalMasuk, TanggalKeluar, Diagnosis, Tarif FROM Pasien INNER JOIN (Perawatan INNER JOIN DokterDetail ON Perawatan.IdPerawatan = DokterDetail.IdPerawatan) ON Pasien.IdPasien = Perawatan.IdPasien WHERE DokterDetail.IdDokter = '{idTerpilih}'{queryTanggal}{queryStatus}", dSRumahSakit.EDokter);
                        break;
                    }
                case "EPasien":
                    {
                        TampilLaporan("EPasien", $"SELECT IdPerawatan, Nama, TanggalMasuk, TanggalKeluar, Diagnosis, TotalBiaya FROM Pasien INNER JOIN Perawatan ON Pasien.IdPasien = Perawatan.IdPasien WHERE Perawatan.IdPasien = '{idTerpilih}'{queryTanggal}{queryStatus}", dSRumahSakit.EPasien);
                        break;
                    }
            }
        }

        void TampilLaporan(string judul, string query, DataTable dt)
        {
            Terlapor terlapor = new Terlapor();
            paramFilter = new ReportParameter("Filter", lblFilter.Text);
            paramTahun = new ReportParameter("Tahun", tTahun.Text);
            dSRumahSakit.Clear();
            terlapor.Show();
            da = new OleDbDataAdapter(query, conn);
            da.Fill(dt);
            terlapor.rv.LocalReport.ReportEmbeddedResource = $"RumahSakit.Laporan{judul}.rdlc";
            ReportDataSource currentReportDS = new ReportDataSource($"DataSet{judul}", dt);
            terlapor.rv.LocalReport.DataSources.Add(currentReportDS);
            terlapor.rv.LocalReport.SetParameters(paramFilter);
            terlapor.rv.LocalReport.SetParameters(paramTahun);
            foreach (ReportParameter param in parameter) terlapor.rv.LocalReport.SetParameters(param);
            terlapor.rv.SetDisplayMode(DisplayMode.PrintLayout);
            terlapor.rv.ZoomMode = ZoomMode.Percent;
            terlapor.rv.ZoomPercent = 100;
            terlapor.rv.RefreshReport();
        }

        void BTNRefresh_Click(object sender, EventArgs e)
        {
            Clear();
        }
        #endregion

        #region Laporan Kiri
        void LaporanKiri(object sender, EventArgs e)
        {
            if (locked) return;
            laporanKiriTerpilih = sender as KryptonRadioButton;
            if (lt != Lt.Grafik && !cbMasuk.Checked && !cbKeluar.Checked) tgl = Tgl.None;
            if (rbGrafik.Checked)
            {
                Akses(false, false, true, false, false, false);
                lt = Lt.Grafik;
                tgl = Tgl.Tahunan;
                queryTanggal = $" AND YEAR(Tanggal) = {tTahun.Text}";
            }
            else if (rbPerawatan.Checked)
            {
                Akses(true, true, true, true, true, true);
                lt = Lt.Perawatan;
            }
            else
            {
                Akses(false, false, false, false, false, false);
                lt = Lt.File;
            }
            laporanTerpilih = SVal(laporanKiriTerpilih.Tag);
            Filter();
        }
        #endregion

        #region Filtrasi
        void FilterTanggal(object sender, EventArgs e)
        {
            if ((lt != Lt.File && lt != Lt.Perawatan && lt != Lt.Grafik && lt != Lt.Entitas) || locked) return;
            if (sender == tDari && tDari.Value > tSampai.Value)
            {
                tSampai.Value = tDari.Value;
            }
            else if (sender == tSampai && tSampai.Value < tDari.Value)
            {
                tDari.Value = tSampai.Value;
            }

            if (!cbMasuk.Checked && !cbKeluar.Checked && lt != Lt.Grafik)
            {
                tgl = Tgl.None;
                queryTanggal = null;
            }
            else if ((sender == tDari || sender == tSampai) && (lt == Lt.Perawatan || (lt == Lt.Entitas && tEntitas.SelectedIndex > 0)))
            {
                tgl = Tgl.Periodik;
                if (!(cbMasuk.Checked ^ cbKeluar.Checked))
                {
                    queryTanggal = $" AND ((DATEVALUE(TanggalMasuk) BETWEEN #{SVal(tDari.Value, "M/d/yyyy")}# AND #{SVal(tSampai.Value, "M/d/yyyy")}#) OR (DATEVALUE(TanggalKeluar) BETWEEN #{SVal(tDari.Value, "M/d/yyyy")}# AND #{SVal(tSampai.Value, "M/d/yyyy")}#))";
                }
                else if (cbMasuk.Checked)
                {
                    queryTanggal = $" AND (DATEVALUE(TanggalMasuk) BETWEEN #{SVal(tDari.Value, "M/d/yyyy")}# AND #{SVal(tSampai.Value, "M/d/yyyy")}#)";
                }
                else
                {
                    queryTanggal = $" AND (DATEVALUE(TanggalKeluar) BETWEEN #{SVal(tDari.Value, "M/d/yyyy")}# AND #{SVal(tSampai.Value, "M/d/yyyy")}#)";
                }
                if (lt == Lt.Grafik) return;
            }
            else if (sender == tBulan && (lt == Lt.Perawatan || (lt == Lt.Entitas && tEntitas.SelectedIndex > 0)))
            {
                tgl = Tgl.Bulanan;
                if (!(cbMasuk.Checked ^ cbKeluar.Checked))
                {
                    queryTanggal = $" AND ((MONTH(TanggalMasuk) = {tBulan.Value.Month} AND YEAR(TanggalMasuk) = {tBulan.Value.Year}) OR (MONTH(TanggalKeluar) = {tBulan.Value.Month} AND YEAR(TanggalKeluar) = {tBulan.Value.Year}))";
                }
                else if (cbMasuk.Checked)
                {
                    queryTanggal = $" AND MONTH(TanggalMasuk) = {tBulan.Value.Month} AND YEAR(TanggalMasuk) = {tBulan.Value.Year}";
                }
                else
                {
                    queryTanggal = $" AND MONTH(TanggalKeluar) = {tBulan.Value.Month} AND YEAR(TanggalKeluar) = {tBulan.Value.Year}";
                }
                if (lt == Lt.Grafik) return;
            }
            else if (sender == tTahun && (lt == Lt.Perawatan || lt == Lt.Grafik || (lt == Lt.Entitas && tEntitas.SelectedIndex > 0)))
            {
                tgl = Tgl.Tahunan;

                if (!(cbMasuk.Checked ^ cbKeluar.Checked))
                {
                    queryTanggal = $" AND (YEAR(TanggalMasuk) = {tTahun.Text} OR YEAR(TanggalKeluar) = {tTahun.Text})";
                }
                else if (cbMasuk.Checked)
                {
                    queryTanggal = $" AND YEAR(TanggalMasuk) = {tTahun.Text}";
                }
                else
                {
                    queryTanggal = $" AND YEAR(TanggalKeluar) = {tTahun.Text}";
                }
            }
            Filter();
        }

        void FilterStatus(object sender, EventArgs e)
        {
            if (locked) return;
            queryStatus = null;
            if (cbTerdaftar.Checked || cbDirawat.Checked || cbSelesai.Checked)
            {
                StringBuilder sbStatus = new StringBuilder();
                List<string> s = new List<string>();
                sbStatus.Append(" AND (");
                if (cbTerdaftar.Checked) s.Add("Perawatan.Status = 'Terdaftar'");
                if (cbDirawat.Checked) s.Add("Perawatan.Status = 'Dirawat'");
                if (cbSelesai.Checked) s.Add("Perawatan.Status = 'Selesai'");
                sbStatus.Append(string.Join(" OR ", s));
                sbStatus.Append(")");
                queryStatus = SVal(sbStatus);
            }
            Filter();
        }
        #endregion

        #region Laporan Kanan
        void TEntitas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (locked) return;
            idTerpilih = null;
            dgv.Tag = $"E{tEntitas.Text.Replace(" ", string.Empty)}";
            currentPage = 1;
            TampilDGV();
        }

        IEnumerable<object[]> rows;
        int currentPage = 1;
        const int maxRows = 16;

        void TCariData_TextChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            TampilDGV();
        }

        void TampilDGV()
        {
            if (tEntitas.SelectedIndex == 0)
            {
                rows = from x in daftarPerawatan where x.IdPerawatan.Cari(tCariData.Text) orderby x.TanggalMasuk descending select new object[] { x.IdPerawatan, x.IdPerawatan };
            }
            else if (tEntitas.SelectedIndex == 1)
            {
                rows = from x in daftarAlat where x.Nama.Cari(tCariData.Text) orderby x.Nama select new object[] { x.IdAlat, x.Nama };
            }
            else if (tEntitas.SelectedIndex == 2)
            {
                rows = from x in daftarTindakan where x.Nama.Cari(tCariData.Text) orderby x.Nama select new object[] { x.IdTindakan, x.Nama };
            }
            else if (tEntitas.SelectedIndex == 3)
            {
                rows = from x in daftarKamar where x.Nama.Cari(tCariData.Text) orderby x.Nama select new object[] { x.NoKamar, x.Nama };
            }
            else if (tEntitas.SelectedIndex == 4)
            {
                rows = from x in daftarObat where x.Nama.Cari(tCariData.Text) orderby x.Nama select new object[] { x.IdObat, x.Nama };
            }
            else if (tEntitas.SelectedIndex == 5)
            {
                rows = from x in daftarDokter where x.Nama.Cari(tCariData.Text) || x.Spesialis.Cari(tCariData.Text) orderby x.Nama select new object[] { x.IdDokter, x.Nama };
            }
            else if (tEntitas.SelectedIndex == 6)
            {
                rows = from x in daftarPasien where x.Nama.Cari(tCariData.Text) orderby x.Nama select new object[] { x.IdPasien, x.Nama };
            }
            Paging();
        }

        void Paging()
        {
            dgv.Rows.Clear();
            dgvPageCounter.Text = $"{currentPage} / {(rows.Count() <= maxRows ? 1 : Math.Ceiling(rows.Count() / DVal(maxRows)))}";
            if (currentPage == 1)
            {
                dgvPrev.Enabled = false;
                dgvFirst.Enabled = false;
            }
            else
            {
                dgvPrev.Enabled = true;
                dgvFirst.Enabled = true;
            }
            if (currentPage >= Math.Ceiling(rows.Count() / DVal(maxRows)))
            {
                dgvNext.Enabled = false;
                dgvLast.Enabled = false;
            }
            else
            {
                dgvNext.Enabled = true;
                dgvLast.Enabled = true;
            }
            if (!rows.Any()) return;
            if (rows.Count() % maxRows == 0 && currentPage > 1 && currentPage > Math.Ceiling(rows.Count() / DVal(maxRows))) dgvPrev.PerformClick();
            foreach (object[] x in rows.Skip((currentPage - 1) * maxRows).Take(maxRows)) dgv.Rows.Add(x[0], x[1]);
        }

        void DGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            laporanTerpilih = SVal(dgv.Tag);
            idTerpilih = SVal(dgv.Rows[e.RowIndex].Cells[0].Value);
            namaTerpilih = SVal(dgv.Rows[e.RowIndex].Cells[1].Value);
            lt = Lt.Entitas;
            if (tEntitas.Text == "Rawat Inap")
            {
                Akses(false, false, false, false, false, false);
            }
            else
            {
                Akses(true, true, true, true, true, false);
                rbRingkasan.Checked = true;
                if (!cbMasuk.Checked && !cbKeluar.Checked) tgl = Tgl.None;
            }
            Filter();
        }

        void DGVFirst_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            Paging();
        }

        void DGVPrev_Click(object sender, EventArgs e)
        {
            currentPage--;
            Paging();
        }

        void DGVPageCounter_Click(object sender, EventArgs e)
        {
            if (Math.Ceiling(rows.Count() / DVal(maxRows)) <= 1d) return;
            GoToPageNumber(rows.Count(), maxRows, ref currentPage);
            Paging();
        }

        void DGVNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            Paging();
        }

        void DGVLast_Click(object sender, EventArgs e)
        {
            currentPage = IVal(Math.Ceiling(rows.Count() / DVal(maxRows)));
            Paging();
        }
        #endregion
    }
}
