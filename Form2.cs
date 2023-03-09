using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QL_KTX
{
    public partial class frmTrangChu : Form
    {

        SqlDataAdapter daSV;
        
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void quảnLýTàiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        string chuoiKetNoi = "Data Source = OCEAN\\SQLEXPRESS; " +
                             " Initial Catalog = QL_DETAI_SV;" + " Intergrated Sercurity=True";
        SqlConnection conn = null;


        private void Xem_TTSV_Click(object sender, EventArgs e)
        {
            
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiKetNoi);
            conn.Open();
            string sql = "Select * from SINHVIEN";
            SqlDataAdapter daSV = new SqlDataAdapter(sql, conn);
            DataTable dtSV= new DataTable();
            daSV.Fill(dtSV);
            dgvSINHVIEN.DataSource = dtSV;
            
        }
    }
}
