using System;
using System.Data;
using System.Windows.Forms;

namespace thu
{
    public partial class Form1 : Form
    {
        // Khởi tạo đối tượng kết nối cơ sở dữ liệu từ lớp ConnectDb đã tạo
        connectdb db = new connectdb();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            LoadDuLieu(); // Tự động load dữ liệu từ SQL lên bảng khi mở form
        }

        // Hàm tải dữ liệu từ SQL Server lên DataGridView
        private void LoadDuLieu()
        {
            // Đặt tên cột tiếng Việt trực tiếp ngay trong câu lệnh SQL
            string sql = @"SELECT 
                    MaDocGia AS [MÃ ĐỘC GIẢ], 
                    HoTen AS [HỌ VÀ TÊN], 
                    NgaySinh AS [NGÀY SINH], 
                    GioiTinh AS [GIỚI TÍNH], 
                    DiaChi AS [ĐỊA CHỈ], 
                    DienThoai AS [ĐIỆN THOẠI], 
                    CMND AS [CMND], 
                    NgayLamThe AS [NGÀY LÀM THẺ] 
                   FROM DocGia";

            DataTable dt = db.ReadData(sql);

            if (dt != null)
            {
                dtgdocgia.Columns.Clear(); // <-- DÒNG QUAN TRỌNG: Xóa sạch cột trong Designer để tránh bị lặp
                dtgdocgia.DataSource = dt;
                dtgdocgia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtgdocgia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            else
            {
                dtgdocgia.DataSource = null;
            }
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra dữ liệu bắt buộc
            if (string.IsNullOrWhiteSpace(txtmadocgia.Text) ||
                string.IsNullOrWhiteSpace(txthovaten.Text))
            {
                MessageBox.Show("Vui lòng nhập mã độc giả và họ tên!");
                return;
            }

            // 2. Kiểm tra mã độc giả là số nguyên
            if (!int.TryParse(txtmadocgia.Text.Trim(), out int maDocGia))
            {
                MessageBox.Show("Mã độc giả phải là số nguyên!");
                return;
            }

            // 3. Lấy dữ liệu từ các ô nhập
            string hoTen = txthovaten.Text.Trim().Replace("'", "''");
            string gioiTinh = txtgioitinh.Text.Trim().Replace("'", "''");
            string diaChi = txtdiachi.Text.Trim().Replace("'", "''");
            string dienThoai = txtdienthoai.Text.Trim().Replace("'", "''");
            string cmnd = txtcmnd.Text.Trim().Replace("'", "''");

            string ngaySinh = dtpngaysinh.Value.ToString("yyyyMMdd");
            string ngayLamThe = dtpngaylamthe.Value.ToString("yyyyMMdd");

            // 4. Thêm đầy đủ thông tin độc giả
            string sql = $@"
        INSERT INTO DocGia
        (MaDocGia, HoTen, NgaySinh, GioiTinh,
         DiaChi, DienThoai, CMND, NgayLamThe)
        VALUES
        ({maDocGia}, N'{hoTen}', '{ngaySinh}',
         N'{gioiTinh}', N'{diaChi}', N'{dienThoai}',
         N'{cmnd}', '{ngayLamThe}')";

            // 5. Thực hiện thêm dữ liệu
            int kq = db.WriteData(sql);

            if (kq > 0)
            {
                MessageBox.Show("Thêm độc giả thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadDuLieu();

                // Mở khóa mã độc giả để nhập người tiếp theo
                txtmadocgia.Enabled = true;
            }
            else
            {
                MessageBox.Show(
                    "Thêm thất bại! Hãy kiểm tra cấu trúc bảng DocGia " +
                    "và thông báo lỗi SQL.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // 2. Nút SỬA
        private void btnsua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmadocgia.Text))
            {
                MessageBox.Show("Vui lòng chọn độc giả cần sửa trên bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu và chống lỗi dấu nháy đơn
            string hoTen = txthovaten.Text.Trim().Replace("'", "''");
            string gioiTinh = txtgioitinh.Text.Trim().Replace("'", "''");
            string diaChi = txtdiachi.Text.Trim().Replace("'", "''");
            string dienThoai = txtdienthoai.Text.Trim().Replace("'", "''");
            string cmnd = txtcmnd.Text.Trim().Replace("'", "''");

            string ngaysinh = dtpngaysinh.Value.ToString("yyyy-MM-dd");
            string ngaylamthe = dtpngaylamthe.Value.ToString("yyyy-MM-dd");

            string sql = $"UPDATE DocGia SET HoTen = N'{hoTen}', " +
                         $"NgaySinh = '{ngaysinh}', " +
                         $"GioiTinh = N'{gioiTinh}', " +
                         $"DiaChi = N'{diaChi}', " +
                         $"DienThoai = '{dienThoai}', " +
                         $"CMND = '{cmnd}', " +
                         $"NgayLamThe = '{ngaylamthe}' " +
                         $"WHERE MaDocGia = {txtmadocgia.Text.Trim()}";

            int kq = db.WriteData(sql);
            if (kq > 0)
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDuLieu();
                txtmadocgia.Enabled = true;
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // 3. Nút XÓA
        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmadocgia.Text))
            {
                MessageBox.Show("Vui lòng chọn độc giả cần xóa trên bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa độc giả này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string sql = $"DELETE FROM DocGia WHERE MaDocGia = '{txtmadocgia.Text.Trim()}'";
                int kq = db.WriteData(sql);

                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDuLieu();
                    txtmadocgia.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 4. Nút HIỂN THỊ
        private void btnhienthi_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
            txtmadocgia.Enabled = true;
        }

        // 5. Nút TÌM KIẾM
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string tukhoa = txttimkiem.Text.Trim().Replace("'", "''");
            if (string.IsNullOrEmpty(tukhoa))
            {
                MessageBox.Show("Vui lòng nhập từ khóa cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ép kiểu MaDocGia sang NVARCHAR để dùng được LIKE
            string sql = $"SELECT * FROM DocGia WHERE CAST(MaDocGia AS NVARCHAR) LIKE '%{tukhoa}%' OR HoTen LIKE N'%{tukhoa}%'";
            DataTable dt = db.ReadData(sql);

            if (dt != null && dt.Rows.Count > 0)
            {
                dtgdocgia.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtgdocgia_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu click vào hàng hợp lệ (tránh click vào tiêu đề cột)
            if (e.RowIndex >= 0 && e.RowIndex < dtgdocgia.Rows.Count - 1)
            {
                DataGridViewRow row = dtgdocgia.Rows[e.RowIndex];

                // Lấy dữ liệu an toàn (tránh lỗi nếu giá trị trong ô bị NULL)
                txtmadocgia.Text = row.Cells["MaDocGia"].Value?.ToString() ?? "";
                txthovaten.Text = row.Cells["HoTen"].Value?.ToString() ?? "";
                txtgioitinh.Text = row.Cells["GioiTinh"].Value?.ToString() ?? "";
                txtdiachi.Text = row.Cells["DiaChi"].Value?.ToString() ?? "";
                txtdienthoai.Text = row.Cells["DienThoai"].Value?.ToString() ?? "";
                txtcmnd.Text = row.Cells["CMND"].Value?.ToString() ?? "";

                // Gán giá trị ngày sinh nếu có
                if (row.Cells["NgaySinh"].Value != null &&
                    DateTime.TryParse(row.Cells["NgaySinh"].Value.ToString(), out DateTime dtsinh))
                {
                    dtpngaysinh.Value = dtsinh;
                }

                // Gán giá trị ngày làm thẻ nếu có
                if (row.Cells["NgayLamThe"].Value != null &&
                    DateTime.TryParse(row.Cells["NgayLamThe"].Value.ToString(), out DateTime dtthe))
                {
                    dtpngaylamthe.Value = dtthe;
                }

                // Khóa mã độc giả lại để không cho phép sửa khóa chính khi chọn từ bảng
                txtmadocgia.Enabled = false;
            }
        }

       

    }
}