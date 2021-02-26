using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace PhanMemQLTV
{
    public partial class frmQLSach : Form
    {
        public frmQLSach()
        {
            InitializeComponent();
        }
        string chuoiKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        private SqlConnection myConnection;
        private SqlDataAdapter myDataAdapter;
        private DataTable myTable;
        private SqlCommand myCommand;

        private DataTable ketnoi(string truyvan)
        {
            myConnection = new SqlConnection(chuoiKetNoi);
            myConnection.Open();
            string thuchiencaulenh = truyvan;
            myCommand = new SqlCommand(thuchiencaulenh, myConnection);
            myDataAdapter = new SqlDataAdapter(myCommand);
            myTable = new DataTable();
            myDataAdapter.Fill(myTable);
            dataGridViewDSSach.DataSource = myTable;
            return myTable;
        }

        private void setControls(bool edit)
        {
            txtTenSach.Enabled = edit;
            txtChuDe.Enabled = edit;
            txtTacGia.Enabled = edit;
            txtNXB.Enabled = edit;
            txtNamXB.Enabled = edit;
            txtSLNhap.Enabled = edit;
            txtDonGia.Enabled = edit;
            cboTinhTrang.Enabled = edit;
            txtGhiChu.Enabled = edit;
        }

        private void frmQLSach_Load(object sender, EventArgs e)
        {
            string cauTruyVan = "select * from tblSach";
            dataGridViewDSSach.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSSach.AutoGenerateColumns = false;
            myConnection.Close();
            setControls(false);
            dataGridViewDSSach.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            txtMaSach.Enabled = false;   
        }

        public string maSach, tenSach, tacGia, chuDe, nXB, namXB, slNhap, donGia, tinhTrang, ghiChu;
        private void dataGridViewDSSach_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                txtMaSach.Text = myTable.Rows[row]["MaSach"].ToString();
                maSach = txtMaSach.Text;
                txtTenSach.Text = myTable.Rows[row]["TenSach"].ToString();
                tenSach = txtTenSach.Text;
                txtChuDe.Text = myTable.Rows[row]["ChuDe"].ToString();
                chuDe = txtChuDe.Text;
                txtTacGia.Text = myTable.Rows[row]["TacGia"].ToString();
                tacGia = txtTacGia.Text;
                txtNXB.Text = myTable.Rows[row]["NXB"].ToString();
                nXB = txtNXB.Text;
                txtNamXB.Text = myTable.Rows[row]["NamXB"].ToString();
                namXB = txtNamXB.Text;
                
                txtSLNhap.Text = myTable.Rows[row]["SLNhap"].ToString();
                slNhap = txtSLNhap.Text;
                txtDonGia.Text = myTable.Rows[row]["DonGia"].ToString();
                donGia = txtDonGia.Text;
                cboTinhTrang.Text = myTable.Rows[row]["TinhTrang"].ToString();
                tinhTrang = cboTinhTrang.Text;
                txtGhiChu.Text = myTable.Rows[row]["GhiChu"].ToString();
                ghiChu = txtGhiChu.Text;
            }
            catch
            {

            }
        }

        public int xuly;
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaSach.Text = tangMaTuDong();
            txtTenSach.Text = "";
            txtChuDe.Text = "";
            txtTacGia.Text = "";
            txtNXB.Text = "";
            txtSLNhap.Text = "";
            txtNamXB.Text = "";
            txtDonGia.Text = "";
            cboTinhTrang.Text = "";
            txtGhiChu.Text = "";

            setControls(true);
            dataGridViewDSSach.Enabled = false;
            txtTenSach.Focus();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            xuly = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cboTinhTrang.Text = "Mới";
            setControls(true);
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            dataGridViewDSSach.Enabled = false;
            txtTenSach.Focus();
            xuly = 1;
            //lblNhapCD.Text = "";
            //lblNhapDonGia.Text = "";
            //lblNhapSLCon.Text = "";
            //lblNhapSLNhap.Text = "";
            //lblNhapTenNXB.Text = "";
            //lblNhapTenSach.Text = "";
            //lblNhapTenTG.Text = "";
            //lblNhapTinhTrang.Text = "";
        }

        private void xoaSach()
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn xóa.", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    string xoadongSql;
                    xoadongSql = "DELETE FROM tblSach WHERE MaSach='" + txtMaSach.Text + "'";
                    ketnoi(xoadongSql);
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công.", "Thông Báo");
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại.\nSách này đang được mượn.", "Thông Báo");
                }
            }
            string cauTruyVan = "select * from tblSach";
            dataGridViewDSSach.DataSource = ketnoi(cauTruyVan);
            myConnection.Close();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoaSach();
        }

        private void themSach()
        {
            try
            {

                string themdongSql;
                themdongSql = "insert into tblSach values ('" + txtMaSach.Text + "',N'" + txtTenSach.Text + "',N'" + txtChuDe.Text + "',N'" + txtTacGia.Text + "',N'" + txtNXB.Text + "','" + txtNamXB.Text + "','" + txtSLNhap.Text + "','" + txtDonGia.Text + "',N'" + cboTinhTrang.Text + "',N'" + txtGhiChu.Text + "')";
                ketnoi(themdongSql);
                MessageBox.Show("Thêm thành công.", "Thông Báo");
                myCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            catch
            {
            }
        }

        private void suaSach()
        {
            try
            {
                string capnhatdong;
                capnhatdong = "update tblSach set TenSach=N'" + txtTenSach.Text + "',ChuDe=N'" + txtChuDe.Text + "',TacGia=N'" + txtTacGia.Text + "',NXB=N'" + txtNXB.Text + "',NamXB='" + txtNamXB.Text + "',SLNhap='" + txtSLNhap.Text + "',DonGia='" + txtDonGia.Text + "',TinhTrang=N'" + cboTinhTrang.Text + "',GhiChu=N'" + txtGhiChu.Text + "' where MaSach='" + txtMaSach.Text + "'";
                //capnhatdong = "update tblSach set TenSach=N'" + txtTenSach.Text + "',ChuDe=N'" + txtChuDe.Text + "',TacGia=N'" + txtTacGia.Text + "',NXB=N'" + txtNXB.Text + "',NamXB='" + txtNamXB.Text + "',SLNhap='" + txtSLNhap.Text + "',DonGia='" + txtDonGia.Text + "',TinhTrang=N'" + cboTinhTrang.Text + "' where MaSach='" + txtMaSach.Text + "' ";
                ketnoi(capnhatdong);
                myCommand.ExecuteNonQuery();

                MessageBox.Show("Sửa thành công.", "Thông Báo");
            }
            catch
            {
                MessageBox.Show("Sửa thất bại.\nVui lòng kiểm tra lại dữ liệu.", "Thông Báo");
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtTenSach.Text=="")
            {
                errTenSach.SetError(txtTenSach, "Vui lòng nhập Tên Sách");
            }
            else
            {
                errTenSach.Clear();
            }
            if (txtChuDe.Text == "")
            {
                errCD.SetError(txtChuDe, "Vui lòng nhập Chủ Đề");
            }
            else
            {
                errCD.Clear();
            }
            if (txtTacGia.Text == "")
            {
                errTG.SetError(txtTacGia, "Vui lòng nhập Tác Giả");
            }
            else
            {
                errTG.Clear();
            }
            if (txtNXB.Text == "")
            {
                errNXB.SetError(txtNXB, "Vui lòng nhập NXB");
            }
            else
            {
                errNXB.Clear();
            }
            if (txtNamXB.Text == "")
            {
                errNamXB.SetError(txtNamXB, "Vui lòng nhập Năm XB");
            }
            else
            {
                errNXB.Clear();
            }
            if (txtSLNhap.Text == "")
            {
                errSLNhap.SetError(txtSLNhap, "Vui lòng nhập SL");
            }
            else
            {
                errSLNhap.Clear();
            }
            
            if (txtDonGia.Text == "")
            {
                errDonGia.SetError(txtDonGia, "Vui lòng nhập Đơn Giá");
            }
            else
            {
                errDonGia.Clear();
            }
            if (cboTinhTrang.Text == "")
            {
                errTinhTrang.SetError(cboTinhTrang, "Vui lòng nhập Tình Trạng");
            }
            else
            {
                errTinhTrang.Clear();
            }
            int ktSLNhap, ktNamXB, ktDonGia;
            bool isNumberSLNhap = int.TryParse(txtSLNhap.Text, out ktSLNhap);
            bool isNumberDonGia = int.TryParse(txtDonGia.Text, out ktDonGia);
            bool isNumberNamXB = int.TryParse(txtNamXB.Text, out ktNamXB);
            if(isNumberSLNhap==false || isNumberDonGia==false || isNumberNamXB==false)
            {
                MessageBox.Show("Vui lòng nhập số trong các ô:\nSL Nhập.\nNăm XB.\nĐơn Giá.", "Thông Báo");
            }
            if (txtTenSach.Text.Length > 0 && txtTacGia.Text.Length > 0 && txtNXB.Text.Length > 0 && txtChuDe.Text.Length > 0 && isNumberSLNhap == true && isNumberDonGia == true && cboTinhTrang.Text.Length > 0 && isNumberNamXB == true)
            {
                    if (xuly == 0)
                    {
                        themSach();
                    }
                    else if (xuly == 1)
                    {
                        suaSach();
                        
                    }
                    string cauTruyVan = "select * from tblSach";
                    dataGridViewDSSach.DataSource = ketnoi(cauTruyVan);
                    dataGridViewDSSach.AutoGenerateColumns = false;
                    myConnection.Close();
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    setControls(false);
                    dataGridViewDSSach.Enabled = true;

                    errTenSach.Clear();
                    errCD.Clear();
                    errTG.Clear();
                    errNamXB.Clear();
                    errNXB.Clear();
                    errDonGia.Clear();
                    errSLNhap.Clear();
                    errTinhTrang.Clear();
                
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông Báo");
                if (txtTenSach.Text.Length == 0)
                    txtTenSach.Focus();
                else if (txtChuDe.Text.Length == 0)
                    txtChuDe.Focus();
                else if (txtTacGia.Text.Length == 0)
                    txtTacGia.Focus();
                else if (txtNXB.Text.Length == 0)
                    txtNXB.Focus();
                else if (txtNamXB.Text.Length == 0)
                    txtNamXB.Focus();
                else if (txtSLNhap.Text.Length == 0)
                    txtSLNhap.Focus();
                else if (txtDonGia.Text.Length == 0)
                    txtDonGia.Focus();
                else if (cboTinhTrang.Text.Length == 0)
                    cboTinhTrang.Focus();
            }      
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaSach.Text = maSach;
            txtTenSach.Text = tenSach;
            txtChuDe.Text = chuDe;
            txtTacGia.Text = tacGia;
            txtNXB.Text = nXB;
            txtSLNhap.Text = slNhap;
            txtDonGia.Text = donGia;
            cboTinhTrang.Text = tinhTrang;
            txtGhiChu.Text = ghiChu;
            setControls(false);
            dataGridViewDSSach.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            errTenSach.Clear();
            errCD.Clear();
            errTG.Clear();
            errNamXB.Clear();
            errNXB.Clear();
            errDonGia.Clear();
            errSLNhap.Clear();
            errTinhTrang.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoadDS_Click(object sender, EventArgs e)
        {
            lblNhapCD.Text = "";
            lblNhapDonGia.Text = "";
            lblNhapSLCon.Text = "";
            lblNhapSLNhap.Text = "";
            lblNhapTenNXB.Text = "";
            lblNhapTenSach.Text = "";
            lblNhapTenTG.Text = "";
            lblNhapTinhTrang.Text = "";
            setControls(false);
            txtNDTimKiem.Text = "";
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            string cauTruyVan = "select * from tblSach";
            dataGridViewDSSach.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSSach.AutoGenerateColumns = false;
            myConnection.Close();
        }
        private void timKiemSach()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            if (radMaSach.Checked)
            {
                string timkiemMS = "select * from tblSach where MaSach like '%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiemMS);
                myCommand.ExecuteNonQuery();
                dataGridViewDSSach.DataSource = myTable;
                dataGridViewDSSach.AutoGenerateColumns = false;
                myConnection.Close();
            }
            else if (radTenSach.Checked)
            {
                string timkiemTS = "select * from tblSach where TenSach like N'%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiemTS);
                myCommand.ExecuteNonQuery();
                dataGridViewDSSach.DataSource = ketnoi(timkiemTS);
                dataGridViewDSSach.AutoGenerateColumns = false;
                myConnection.Close();
            }
            else if (radTenTG.Checked)
            {
                string timkiemMS = "select * from tblSach where TacGia like N'%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiemMS);
                myCommand.ExecuteNonQuery();
                dataGridViewDSSach.DataSource = myTable;
                dataGridViewDSSach.AutoGenerateColumns = false;
                myConnection.Close();
            }
            else if (radTenCD.Checked)
            {
                string timkiemMS = "select * from tblSach where ChuDe like N'%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiemMS);
                myCommand.ExecuteNonQuery();
                dataGridViewDSSach.DataSource = myTable;
                dataGridViewDSSach.AutoGenerateColumns = false;
                myConnection.Close();
            }
        }
        private void txtNDTimKiem_TextChanged(object sender, EventArgs e)
        {
            timKiemSach();
        }
        public string tangMaTuDong()
        {
            string cauTruyVan = "select * from tblSach";
            dataGridViewDSSach.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSSach.AutoGenerateColumns = false;
            myConnection.Close();
            string maTuDong = "";
            if(myTable.Rows.Count<=0)
            {
                maTuDong = "MS001";
            }
            else
            {
                int k;
                maTuDong = "MS";
                k = Convert.ToInt32(myTable.Rows[myTable.Rows.Count - 1][0].ToString().Substring(2, 3));
                k = k + 1;
                if(k<10)
                {
                    maTuDong = maTuDong + "00";
                }
                else if(k<100)
                {
                    maTuDong = maTuDong + "0";
                }
                maTuDong = maTuDong + k.ToString();
            }
            return maTuDong;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }


    }
}
