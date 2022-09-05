using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static RumahSakit.Ly;

namespace RumahSakit
{
    public partial class FPerawatan : Form
    {
        int total;
        string status;
        Perawatan perawatan;
        Pasien pasien;
        KamarDetail kamarDetail;

        public FPerawatan()
        {
            InitializeComponent();
        }

        #region Form
        void Clear()
        {
            locked = true;
            Tampil();
            kamarDetail = null;
            tNamaPasien.Clear();
            tNamaKamar.Clear();
            tTglMasuk.Clear();
            tDiagnosis.Clear();
            tTotalBiaya.Clear();
            tTerbayar.Clear();
            lblTotal.Text = "Alat : Rp 0  |  Tindakan : Rp 0  |  Kamar : Rp 0  |  Obat : Rp 0  |  Dokter : Rp 0";
            dgvAlat.Rows.Clear();
            dgvTindakan.Rows.Clear();
            dgvObat.Rows.Clear();
            dgvDokter.Rows.Clear();
            total = 0;
            Hitung();
            tKategori.SelectedIndex = -1;
            tCariData.Clear();
            dgvPencarian.Rows.Clear();
            locked = false;
        }

        void Tampil()
        {
            tIdPerawatan.Items.Clear();
            tIdPerawatan.Items.AddRange((from x in daftarPerawatan where x.Status != "Selesai" orderby x.TanggalMasuk descending select x.IdPerawatan).ToArray());
        }

        void FPerawatan_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        void FPerawatan_Resize(object sender, EventArgs e)
        {
            dgvAlat.Size = new Size((panelDGV.Width / 2) - 6, (panelDGV.Height / 2) - 8);
            dgvObat.Size = new Size((panelDGV.Width / 2) - 6, (panelDGV.Height / 2) - 8);
            dgvTindakan.Size = new Size((panelDGV.Width / 2) - 6, (panelDGV.Height / 2) - 8);
            dgvDokter.Size = new Size((panelDGV.Width / 2) - 6, (panelDGV.Height / 2) - 8);
            dgvTindakan.Location = new Point(9 + dgvAlat.Width, 3);
            dgvObat.Location = new Point(3, 13 + dgvAlat.Height);
            dgvDokter.Location = new Point(9 + dgvObat.Width, 13 + dgvTindakan.Height);
        }

        void TIdPerawatan_SelectedIndexChanged(object sender, EventArgs e)
        {
            perawatan = daftarPerawatan.Find(x => x.IdPerawatan == tIdPerawatan.Text);
            pasien = daftarPasien.Find(x => x.IdPasien == perawatan.IdPasien);
            kamarDetail = daftarKamarDetail.Find(x => x.IdPerawatan == tIdPerawatan.Text);
            dgvAlat.Rows.Clear();
            dgvTindakan.Rows.Clear();
            dgvObat.Rows.Clear();
            dgvDokter.Rows.Clear();
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
            status = hasil.Status;
            if (status == "Dirawat")
            {
                var detailAlat = from x in daftarAlat
                                 join y in daftarAlatDetail on x.IdAlat equals y.IdAlat
                                 where y.IdPerawatan == hasil.IdPerawatan
                                 select new
                                 {
                                     y.IdAlat,
                                     x.Nama,
                                     y.Tarif
                                 };
                foreach (var dA in detailAlat) dgvAlat.Rows.Add(dA.IdAlat, dA.Nama, dA.Tarif);

                var detailTindakan = from x in daftarTindakan
                                     join y in daftarTindakanDetail on x.IdTindakan equals y.IdTindakan
                                     where y.IdPerawatan == hasil.IdPerawatan
                                     select new
                                     {
                                         y.IdTindakan,
                                         x.Nama,
                                         y.Tarif
                                     };
                foreach (var dT in detailTindakan) dgvTindakan.Rows.Add(dT.IdTindakan, dT.Nama, dT.Tarif);

                var detailObat = from x in daftarObat
                                 join y in daftarObatDetail on x.IdObat equals y.IdObat
                                 where y.IdPerawatan == hasil.IdPerawatan
                                 select new
                                 {
                                     y.IdObat,
                                     x.Nama,
                                     y.Harga
                                 };
                foreach (var dO in detailObat) dgvObat.Rows.Add(dO.IdObat, dO.Nama, dO.Harga);

                var detailDokter = from x in daftarDokter
                                   join y in daftarDokterDetail on x.IdDokter equals y.IdDokter
                                   where y.IdPerawatan == hasil.IdPerawatan
                                   select new
                                   {
                                       y.IdDokter,
                                       x.Nama,
                                       y.Tarif
                                   };
                foreach (var dD in detailDokter) dgvDokter.Rows.Add(dD.IdDokter, dD.Nama, dD.Tarif);
            }
            Hitung();
        }

        void Hitung()
        {
            int biayaAlat = 0;
            int biayaTindakan = 0;
            int biayaKamar = (kamarDetail?.Tarif) ?? 0;
            int biayaObat = 0;
            int biayaDokter = 0;
            foreach (DataGridViewRow x in dgvAlat.Rows) biayaAlat += IVal(x.Cells[2].Value);
            foreach (DataGridViewRow x in dgvTindakan.Rows) biayaTindakan += IVal(x.Cells[2].Value);
            foreach (DataGridViewRow x in dgvObat.Rows) biayaObat += IVal(x.Cells[2].Value);
            foreach (DataGridViewRow x in dgvDokter.Rows) biayaDokter += IVal(x.Cells[2].Value);
            total = biayaAlat + biayaTindakan + biayaObat + biayaDokter + biayaKamar;
            lblTotal.Text = $"Alat : Rp {SVal(biayaAlat, "n0")}  |  Tindakan : Rp {SVal(biayaTindakan, "n0")}  |  Kamar : Rp {SVal(biayaKamar, "n0")}  |  Obat : Rp {SVal(biayaObat, "n0")}  |  Dokter : Rp {SVal(biayaDokter, "n0")}";
            tTotalBiaya.Text = SVal(total, "n0");
            Validasi();
        }

        void Validasi()
        {
            btnSimpan.Enabled = tIdPerawatan.SelectedIndex >= 0 && total > 0;
        }
        #endregion

        #region CRUD
        void BTNSimpan_Click(object sender, EventArgs e)
        {
            if (status == "Dirawat")
            {
                QN($"DELETE FROM AlatDetail WHERE IdPerawatan = '{tIdPerawatan.Text}'");
                daftarAlatDetail.RemoveAll(x => x.IdPerawatan == tIdPerawatan.Text);
                QN($"DELETE FROM TindakanDetail WHERE IdPerawatan = '{tIdPerawatan.Text}'");
                daftarTindakanDetail.RemoveAll(x => x.IdPerawatan == tIdPerawatan.Text);
                QN($"DELETE FROM ObatDetail WHERE IdPerawatan = '{tIdPerawatan.Text}'");
                daftarObatDetail.RemoveAll(x => x.IdPerawatan == tIdPerawatan.Text);
                QN($"DELETE FROM DokterDetail WHERE IdPerawatan = '{tIdPerawatan.Text}'");
                daftarDokterDetail.RemoveAll(x => x.IdPerawatan == tIdPerawatan.Text);
            }
            foreach (DataGridViewRow rowAlat in dgvAlat.Rows)
            {
                QN($"INSERT INTO AlatDetail VALUES ('{tIdPerawatan.Text}',{rowAlat.Cells[0].Value},{SVal(rowAlat.Cells[2].Value).Replace(".", "")})");
                daftarAlatDetail.Add(new AlatDetail { IdPerawatan = tIdPerawatan.Text, IdAlat = IVal(rowAlat.Cells[0].Value), Tarif = IVal(SVal(rowAlat.Cells[2].Value).Replace(".", "")) });
            }
            foreach (DataGridViewRow rowTindakan in dgvTindakan.Rows)
            {
                QN($"INSERT INTO TindakanDetail VALUES ('{tIdPerawatan.Text}',{rowTindakan.Cells[0].Value},{SVal(rowTindakan.Cells[2].Value).Replace(".", "")})");
                daftarTindakanDetail.Add(new TindakanDetail { IdPerawatan = tIdPerawatan.Text, IdTindakan = IVal(rowTindakan.Cells[0].Value), Tarif = IVal(SVal(rowTindakan.Cells[2].Value).Replace(".", "")) });
            }
            foreach (DataGridViewRow rowObat in dgvObat.Rows)
            {
                QN($"INSERT INTO ObatDetail VALUES ('{tIdPerawatan.Text}','{rowObat.Cells[0].Value}',{SVal(rowObat.Cells[2].Value).Replace(".", "")})");
                daftarObatDetail.Add(new ObatDetail { IdPerawatan = tIdPerawatan.Text, IdObat = SVal(rowObat.Cells[0].Value), Harga = IVal(SVal(rowObat.Cells[2].Value).Replace(".", "")) });
            }
            foreach (DataGridViewRow rowDokter in dgvDokter.Rows)
            {
                QN($"INSERT INTO DokterDetail VALUES ('{tIdPerawatan.Text}','{rowDokter.Cells[0].Value}',{SVal(rowDokter.Cells[2].Value).Replace(".", "")})");
                daftarDokterDetail.Add(new DokterDetail { IdPerawatan = tIdPerawatan.Text, IdDokter = SVal(rowDokter.Cells[0].Value), Tarif = IVal(SVal(rowDokter.Cells[2].Value).Replace(".", "")) });
            }
            QN($"UPDATE Perawatan SET Diagnosis = '{tDiagnosis.Text}', TotalBiaya = {total}, Status = 'Dirawat' WHERE IdPerawatan = '{tIdPerawatan.Text}'");
            perawatan.Diagnosis = tDiagnosis.Text;
            perawatan.TotalBiaya = total;
            perawatan.Status = "Dirawat";
            QN($"UPDATE Pasien SET Status = 'Dirawat' WHERE IdPasien = '{perawatan.IdPasien}'");
            pasien.Status = "Dirawat";
            QN($"INSERT INTO LogUser VALUES('{userAktif}',NOW(),'Input perawatan pada id {tIdPerawatan.Text}')");
            daftarLogUser.Add(new LogUser { Username = userAktif, Tanggal = DateTime.Today, Catatan = $"Input perawatan pada id {tIdPerawatan.Text}" });
            Pesan("Data berhasil diinput", Notifikasi.Jenis.Berhasil);
            Clear();
        }

        void BTNRefresh_Click(object sender, EventArgs e)
        {
            currentPage = 1;
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
        int currentPage = 1;
        List<object[]> rows;
        const int maxRows = 12;

        void TKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (locked) return;
            currentPage = 1;
            TampilDGVPencarian();
        }

        void TCariData_TextChanged(object sender, EventArgs e)
        {
            if (locked) return;
            currentPage = 1;
            TampilDGVPencarian();
        }

        void TampilDGVPencarian()
        {
            if (tKategori.SelectedIndex == 0)
            {
                rows = (from x in daftarAlat where x.Nama.Cari(tCariData.Text) select new object[] { x.IdAlat, x.Nama, x.Tarif }).ToList();
            }
            else if (tKategori.SelectedIndex == 1)
            {
                rows = (from x in daftarTindakan where x.Nama.Cari(tCariData.Text) select new object[] { x.IdTindakan, x.Nama, x.Tarif }).ToList();
            }
            else if (tKategori.SelectedIndex == 2)
            {
                rows = (from x in daftarObat where x.Nama.Cari(tCariData.Text) select new object[] { x.IdObat, x.Nama, x.Harga }).ToList();
            }
            else if (tKategori.SelectedIndex == 3)
            {
                rows = (from x in daftarDokter where x.Nama.Cari(tCariData.Text) || x.Spesialis.Cari(tCariData.Text) select new object[] { x.IdDokter, $"{x.Nama} ({x.Spesialis})", x.Tarif }).ToList();
            }
            PagingPencarian();
        }

        void PagingPencarian()
        {
            dgvPencarian.Rows.Clear();
            if (tKategori.SelectedIndex < 0) return;
            dgvPencarianPageCounter.Text = $"{currentPage} / {(rows.Count <= maxRows ? 1 : Math.Ceiling(rows.Count / DVal(maxRows)))}";
            if (currentPage == 1)
            {
                dgvPencarianPrev.Enabled = false;
                dgvPencarianFirst.Enabled = false;
            }
            else
            {
                dgvPencarianPrev.Enabled = true;
                dgvPencarianFirst.Enabled = true;
            }
            if (currentPage >= Math.Ceiling(rows.Count / DVal(maxRows)))
            {
                dgvPencarianNext.Enabled = false;
                dgvPencarianLast.Enabled = false;
            }
            else
            {
                dgvPencarianNext.Enabled = true;
                dgvPencarianLast.Enabled = true;
            }
            if (rows.Count == 0) return;
            if (rows.Count % maxRows == 0 && currentPage > 1 && currentPage > Math.Ceiling(rows.Count / DVal(maxRows))) dgvPencarianPrev.PerformClick();
            foreach (object[] x in rows.Skip((currentPage - 1) * maxRows).Take(maxRows)) dgvPencarian.Rows.Add(x[0], x[1], x[2]);
        }

        void DGVPencarian_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridView dgv;
            if (tKategori.SelectedIndex == 0)
            {
                dgv = dgvAlat;
            }
            else if (tKategori.SelectedIndex == 1)
            {
                dgv = dgvTindakan;
            }
            else if (tKategori.SelectedIndex == 2)
            {
                dgv = dgvObat;
            }
            else
            {
                dgv = dgvDokter;
            }
            foreach (DataGridViewRow x in dgv.Rows)
            {
                if (SVal(x.Cells[0].Value) == SVal(dgvPencarian.Rows[e.RowIndex].Cells[0].Value))
                {
                    Pesan($"{dgv.Name.Mid(3)} sudah terdaftar", Notifikasi.Jenis.Gagal);
                    return;
                }
            }
            object[] terpilih = { dgvPencarian.Rows[e.RowIndex].Cells[0].Value, dgvPencarian.Rows[e.RowIndex].Cells[1].Value, dgvPencarian.Rows[e.RowIndex].Cells[2].Value };
            dgv.Rows.Add(terpilih);
            Hitung();
        }

        void DGVPencarianFirst_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            PagingPencarian();
        }

        void DGVPencarianPrev_Click(object sender, EventArgs e)
        {
            currentPage--;
            PagingPencarian();
        }

        void DGVPencarianPageCounter_Click(object sender, EventArgs e)
        {
            if (Math.Ceiling(rows.Count / DVal(maxRows)) <= 1d) return;
            GoToPageNumber(rows.Count, maxRows, ref currentPage);
            PagingPencarian();
        }

        void DGVPencarianNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            PagingPencarian();
        }

        void DGVPencarianLast_Click(object sender, EventArgs e)
        {
            currentPage = IVal(Math.Ceiling(rows.Count / DVal(maxRows)));
            PagingPencarian();
        }
        #endregion

        #region DGV2
        void DGV_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            TextBox tb = e.Control as TextBox;
            tb.KeyPress -= Decimals;
            tb.KeyPress -= Numbers;
            if (dgv.CurrentCell.ColumnIndex == 2) tb.KeyPress += Numbers;
        }

        void DGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv.CurrentCell.Value is null || !int.TryParse(SVal(dgv.CurrentCell.Value).Replace(".", ""), out _)) dgv.CurrentCell.Value = 1;
            Hitung();
            dgv.Rows[e.RowIndex].Cells[2].Value = SVal(IVal(dgv.CurrentCell.Value), "n0");
        }

        void DGV_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            dgv.CurrentCell.Value = SVal(dgv.CurrentCell.Value).Replace(".", "");
        }

        void DGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (e.KeyChar == 27) dgv.Rows.RemoveAt(dgv.CurrentRow.Index);
            Hitung();
            PagingPencarian();
        }
        #endregion
    }
}
