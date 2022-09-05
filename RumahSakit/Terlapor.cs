using System.Windows.Forms;

namespace RumahSakit
{
    public partial class Terlapor : Form
    {
        public Terlapor()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys koentji)
        {
            if (koentji == Keys.Escape)
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, koentji);
        }
    }
}
