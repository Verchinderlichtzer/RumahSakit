using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static RumahSakit.Ly;

namespace RumahSakit
{
    public partial class FCatatan : Form
    {
        bool entitas;
        bool tanggal;
        bool status;

        KryptonRadioButton namaStatus;
        readonly StringBuilder sb = new StringBuilder();

        public FCatatan()
        {
            InitializeComponent();
        }

        #region Form
        void Clear()
        {
            rows = from x in daftarPerawatan select x.IdPerawatan;
            sb.Clear();
            sb.Append("Semua perawatan");
            tJenisEntitas.SelectedIndex = -1;
            tEntitas.SelectedIndex = -1;
            tJenisTgl.SelectedIndex = -1;
            tDari.Value = DateTime.Today;
            tSampai.Value = DateTime.Today;
            rbDaftar.Checked = false;
            rbDirawat.Checked = false;
            rbSelesai.Checked = false;
            entitas = false;
            tanggal = false;
            status = false;
            tDari.Enabled = false;
            tSampai.Enabled = false;
            lblFilter.Text = string.Empty;
        }

        void ClearDetail()
        {
            currentPage = 1;
            dgvTengah.Rows.Clear();
            dgvKanan.Rows.Clear();
            tNamaPasien.Clear();
            tNamaKamar.Clear();
            tTanggal.Clear();
            tDiagnosis.Clear();
            tTotalBiaya.Clear();
            tTerbayar.Clear();
            tStatus.Clear();
        }

        void FCatatan_Load(object sender, EventArgs e)
        {
            locked = true;
            tDari.Value = DateTime.Today;
            tSampai.Value = DateTime.Today;
            rows = from x in daftarPerawatan select x.IdPerawatan;
            sb.Append("Semua perawatan");
            Paging();
            locked = false;
        }

        void FCatatan_Resize(object sender, EventArgs e)
        {
            //dgvKiri.Width = (panelDGV.Width - 16) / 2;
            //dgvTengah.Width = (panelDGV.Width - 16) / 2;
            //pemisah1.Location = new Point(dgvKiri.Width + 6, 3);
            //dgvTengah.Location = new Point(dgvKiri.Width + 12, 3);
            panelDGVKiriPagination.Location = new Point(3 + (dgvKiri.Width / 2) - 100, 3 + dgvKiri.Height);
            pemisah1.Height = dgvKiri.Height;
            pemisah2.Height = dgvKiri.Height;
        }

        void Filter()
        {
            sb.Clear();
            if (entitas)
            {
                if (tEntitas.SelectedIndex == -1)
                {
                    lblFilter.Text = string.Empty;
                    return;
                }
                else if (tJenisEntitas.Text == "Alat" || tJenisEntitas.Text == "Obat" || tJenisEntitas.Text == "Tindakan")
                {
                    sb.Append("Perawatan yang dilakukan dengan ");
                    if (tJenisEntitas.Text == "Tindakan") sb.Append("cara ");
                }
                else if (tJenisEntitas.Text == "Kamar")
                {
                    sb.Append("Perawatan yang dilakukan di ");
                }
                else if (tJenisEntitas.Text == "Dokter")
                {
                    sb.Append("Perawatan yang dilakukan oleh ");
                }
                else if (tJenisEntitas.Text == "Pasien")
                {
                    sb.Append("Perawatan yang dilakukan kepada ");
                }
                sb.Append(tEntitas.Text.Mid(tEntitas.Text.IndexOf('-') + 2));
            }
            else
            {
                sb.Append("Perawatan yang ");
                if (tanggal)
                {
                    sb.Append(tJenisTgl.Text == "Masuk" ? "dimulai " : "selesai ");
                    sb.Append(tDari.Value == tSampai.Value ? "pada " : "antara ");
                    sb.Append("tanggal ").Append(SVal(tDari.Value, "dd/MM/yyyy"));
                    if (tDari.Value < tSampai.Value) sb.Append(" → ").Append(SVal(tSampai.Value, "dd/MM/yyyy"));
                }
                if (status)
                {
                    if (tanggal) sb.Append(" yang ");
                    sb.Append(namaStatus.Text.ToLower());
                }
            }
            lblFilter.Text = SVal(sb);
        }

        void Entitas(object sender, EventArgs e)
        {
            ClearDetail();
            entitas = true;
            tanggal = false;
            status = false;
            if (sender == tJenisEntitas && tEntitas.Items.Count > 0) tEntitas.Items.Clear();
            if (tJenisEntitas.Text == "Alat")
            {
                if (sender == tJenisEntitas)
                {
                    foreach (Alat x in daftarAlat) tEntitas.Items.Add(x.IdAlat + " - " + x.Nama);
                }
                else
                {
                    rows = from x in daftarPerawatan
                           join y in daftarAlatDetail on x.IdPerawatan equals y.IdPerawatan
                           where y.IdAlat == IVal(tEntitas.Text.Left(tEntitas.Text.IndexOf(' ')))
                           orderby x.TanggalMasuk descending
                           select y.IdPerawatan;
                }
            }
            else if (tJenisEntitas.Text == "Tindakan")
            {
                if (sender == tJenisEntitas)
                {
                    foreach (Tindakan x in daftarTindakan) tEntitas.Items.Add(x.IdTindakan + " - " + x.Nama);
                }
                else
                {
                    rows = from x in daftarPerawatan
                           join y in daftarTindakanDetail on x.IdPerawatan equals y.IdPerawatan
                           where y.IdTindakan == IVal(tEntitas.Text.Left(tEntitas.Text.IndexOf(' ')))
                           orderby x.TanggalMasuk descending
                           select y.IdPerawatan;
                }
            }
            else if (tJenisEntitas.Text == "Kamar")
            {
                if (sender == tJenisEntitas)
                {
                    foreach (Kamar x in daftarKamar) tEntitas.Items.Add(x.NoKamar + " - " + x.Nama);
                }
                else
                {
                    rows = from x in daftarPerawatan
                           join y in daftarKamarDetail on x.IdPerawatan equals y.IdPerawatan
                           where y.NoKamar == SVal(tEntitas.Text.Left(tEntitas.Text.IndexOf(' ')))
                           orderby x.TanggalMasuk descending
                           select x.IdPerawatan;
                }
            }
            else if (tJenisEntitas.Text == "Obat")
            {
                if (sender == tJenisEntitas)
                {
                    foreach (Obat x in daftarObat) tEntitas.Items.Add(x.IdObat + " - " + x.Nama);
                }
                else
                {
                    rows = from x in daftarPerawatan
                           join y in daftarObatDetail on x.IdPerawatan equals y.IdPerawatan
                           where y.IdObat == SVal(tEntitas.Text.Left(tEntitas.Text.IndexOf(' ')))
                           orderby x.TanggalMasuk descending
                           select y.IdPerawatan;
                }
            }
            else if (tJenisEntitas.Text == "Dokter")
            {
                if (sender == tJenisEntitas)
                {
                    foreach (Dokter x in daftarDokter) tEntitas.Items.Add(x.IdDokter + " - " + x.Nama);
                }
                else
                {
                    rows = from x in daftarPerawatan
                           join y in daftarDokterDetail on x.IdPerawatan equals y.IdPerawatan
                           where y.IdDokter == SVal(tEntitas.Text.Left(tEntitas.Text.IndexOf(' ')))
                           orderby x.TanggalMasuk descending
                           select y.IdPerawatan;
                }
            }
            else if (tJenisEntitas.Text == "Pasien")
            {
                if (sender == tJenisEntitas)
                {
                    foreach (Pasien x in daftarPasien) tEntitas.Items.Add(x.IdPasien + " - " + x.Nama);
                }
                else
                {
                    rows = from x in daftarPerawatan
                           join y in daftarPasien on x.IdPasien equals y.IdPasien
                           where y.IdPasien == SVal(tEntitas.Text.Left(tEntitas.Text.IndexOf(' ')))
                           orderby x.TanggalMasuk descending
                           select x.IdPerawatan;
                }
            }
            Filter();
            if (sender == tEntitas) Paging();
        }

        void Kriteria(object sender, EventArgs e)
        {
            if (locked) return;
            ClearDetail();
            entitas = false;
            IEnumerable<Perawatan> filter = from x in daftarPerawatan select x;
            if (tJenisTgl.SelectedIndex >= 0 && (sender == tJenisTgl || sender == tDari || sender == tSampai)) // Tanggal
            {
                tanggal = true;
                if (sender == tJenisTgl)
                {
                    tDari.Enabled = true;
                    tSampai.Enabled = true;
                }
                if (sender == tDari && tDari.Value > tSampai.Value)
                {
                    tSampai.Value = tDari.Value;
                }
                else if (sender == tSampai && tSampai.Value < tDari.Value)
                {
                    tDari.Value = tSampai.Value;
                }
                if (tJenisTgl.Text == "Masuk")
                {
                    filter = filter.Where(x => x.TanggalMasuk >= tDari.Value && x.TanggalMasuk <= tSampai.Value).Select(x => x);
                }
                else
                {
                    filter = filter.Where(x => x.TanggalKeluar >= tDari.Value && x.TanggalKeluar <= tSampai.Value).Select(x => x);
                }
            }
            else //Status
            {
                namaStatus = sender as KryptonRadioButton;
                status = true;
                filter = filter.Where(x => x.Status == namaStatus.Text).Select(x => x);
            }
            rows = filter.OrderByDescending(x => x.TanggalMasuk).Select(x => x.IdPerawatan);
            Filter();
            Paging();
        }

        void BTNRefresh_Click(object sender, EventArgs e)
        {
            Clear();
            ClearDetail();
            Paging();
        }
        #endregion

        #region DGVKiri
        IEnumerable<string> rows;
        int currentPage = 1;
        const int maxRows = 15;

        void Paging()
        {
            dgvKiri.Rows.Clear();
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
            int i = 0;
            i += (currentPage - 1) * maxRows;
            foreach (string x in rows.Skip((currentPage - 1) * maxRows).Take(maxRows)) dgvKiri.Rows.Add(++i, x);
        }

        void DGVKiri_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            dgvTengah.Rows.Clear();
            dgvKanan.Rows.Clear();
            var detailAlat = from x in daftarAlat
                             join y in daftarAlatDetail on x.IdAlat equals y.IdAlat
                             where y.IdPerawatan == SVal(dgvKiri.Rows[e.RowIndex].Cells[1].Value)
                             select new
                             {
                                 Kolom1 = x.Nama,
                                 Kolom2 = "Alat",
                                 Kolom3 = y.Tarif
                             };
            var detailTindakan = from x in daftarTindakan
                                 join y in daftarTindakanDetail on x.IdTindakan equals y.IdTindakan
                                 where y.IdPerawatan == SVal(dgvKiri.Rows[e.RowIndex].Cells[1].Value)
                                 select new
                                 {
                                     Kolom1 = x.Nama,
                                     Kolom2 = "Tindakan",
                                     Kolom3 = y.Tarif
                                 };
            var detailObat = from x in daftarObat
                             join y in daftarObatDetail on x.IdObat equals y.IdObat
                             where y.IdPerawatan == SVal(dgvKiri.Rows[e.RowIndex].Cells[1].Value)
                             select new
                             {
                                 Kolom1 = x.Nama,
                                 Kolom2 = "Obat",
                                 Kolom3 = y.Harga
                             };
            var detailDokter = from x in daftarDokter
                               join y in daftarDokterDetail on x.IdDokter equals y.IdDokter
                               where y.IdPerawatan == SVal(dgvKiri.Rows[e.RowIndex].Cells[1].Value)
                               select new
                               {
                                   Kolom1 = x.Nama,
                                   Kolom2 = "Dokter",
                                   Kolom3 = y.Tarif
                               };
            foreach (var g in detailAlat.Concat(detailTindakan).Concat(detailObat).Concat(detailDokter).OrderBy(x => x.Kolom2).ThenBy(x => x.Kolom1)) dgvTengah.Rows.Add(g.Kolom1, g.Kolom2, g.Kolom3);

            var pembayaran = from x in daftarPembayaran
                             where x.IdPerawatan == SVal(dgvKiri.Rows[e.RowIndex].Cells[1].Value)
                             select new { x.Tanggal, x.Nominal };
            foreach (var bayar in pembayaran) dgvKanan.Rows.Add(bayar.Tanggal, bayar.Nominal);

            var info = (from v in daftarPerawatan
                        join w in daftarPasien on v.IdPasien equals w.IdPasien
                        join x in daftarKamarDetail on v.IdPerawatan equals x.IdPerawatan
                        join y in daftarKamar on x.NoKamar equals y.NoKamar
                        where v.IdPerawatan == SVal(dgvKiri.Rows[e.RowIndex].Cells[1].Value)
                        select new
                        {
                            NamaPasien = w.Nama,
                            NamaKamar = y.Nama,
                            v.TanggalMasuk,
                            v.TanggalKeluar,
                            v.Diagnosis,
                            v.TotalBiaya,
                            v.Terbayar,
                            v.Status
                        }).FirstOrDefault();
            tNamaPasien.Text = info.NamaPasien;
            tNamaKamar.Text = info.NamaKamar;
            tTanggal.Text = $"{SVal(info.TanggalMasuk, "dd/MM/yyyy")} → {SVal(info.TanggalKeluar, "dd/MM/yyyy")}";
            tDiagnosis.Text = info.Diagnosis;
            tTotalBiaya.Text = SVal(info.TotalBiaya, "n0");
            tTerbayar.Text = SVal(info.Terbayar, "n0");
            tStatus.Text = info.Status;
            lblFilter.Text = SVal(sb) + " | Detail pada - " + dgvKiri.Rows[e.RowIndex].Cells[1].Value;
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
