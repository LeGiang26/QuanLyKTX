using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using QuanLy_DAL;

namespace QuanLy_BLL
{
    public class DanhSachDangKy_BL
    {
        private DanhSachDangKy_DL danhSachDangKyDL;

        public DanhSachDangKy_BL()
        {
            danhSachDangKyDL = new DanhSachDangKy_DL();
        }

        public List<SinhVienDangKy> LayDSSinhVienDangKy()
        {
            try
            {
                return danhSachDangKyDL.LayDSSinhVienDangKy();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<SinhVien> LayDSSinhVien()
        {
            try
            {
                return danhSachDangKyDL.LayDSSinhVien();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }


        public bool CapNhatSinhVienDangKy(SinhVienDangKy sv)
        {
            try
            {
                return danhSachDangKyDL.CapNhatSinhVienDangKy(sv);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void XepPhongTuDong(List<SinhVienDangKy> dsDangKy)
        {

            // Nhóm sinh viên theo giới tính và khoa (Clustering)
            var clusterGroups = new Dictionary<string, List<SinhVienDangKy>>();
            foreach (var sv in dsDangKy)
            {
                string key = $"{sv.gioitinh}_{sv.khoa}";
                if (!clusterGroups.ContainsKey(key))
                    clusterGroups[key] = new List<SinhVienDangKy>();
                clusterGroups[key].Add(sv);
            }


            var sinhVienKhongXepDuoc = new List<SinhVienDangKy>();

            // Xếp phòng cho từng nhóm (Greedy)
            foreach (var cluster in clusterGroups)
            {
                // Lấy danh sách phòng phù hợp cho nhóm hiện tại
                var phongTrong = danhSachDangKyDL.LayPhongTheoDieuKien(
                    cluster.Key.Split('_')[0], // Giới tính
                    cluster.Key.Split('_')[1], // Khoa
                    "Thiếu" // Tình trạng phòng
                );

                // Xử lý từng sinh viên trong nhóm
                foreach (var sv in cluster.Value)
                {
                    bool daXep = false;

                    foreach (var phong in phongTrong)
                    {
                        // Kiểm tra số lượng sinh viên HIỆN TẠI từ CSDL
                        int soSVHienTai = danhSachDangKyDL.LaySoSVHienTai(phong.maphong);

                        if (soSVHienTai < phong.sosvtoida)
                        {
                            ThemSinhVienVaoPhong(sv, phong);
                            daXep = true;
                            break; // Thoát khi xếp được
                        }
                        if (!daXep)
                        {
                            sinhVienKhongXepDuoc.Add(sv);
                        }
                    }
                }
            }
        }

        private void ThemSinhVienVaoPhong(SinhVienDangKy sv, Phong phong)
        {
            // Chuyển sinh viên từ đăng ký sang danh sách chính thức
            var sinhVien = new SinhVien(
                sv.masvdky, sv.tensv, sv.gioitinh, sv.ngaysinh,
                sv.quequan, sv.email, sv.khoa, sv.lop, sv.loaiuutien, phong.maphong
            );

            // Cập nhật CSDL
            danhSachDangKyDL.ThemSinhVien(sinhVien);
            danhSachDangKyDL.XoaSinhVienDangKy(sv.masvdky);
            danhSachDangKyDL.CapNhatSoSV(phong.maphong); // Cập nhật số SV và tình trạng phòng
        }

        public List<Phong> LayPhongTrong()
        {
            try
            {
                return danhSachDangKyDL.LayPhongTrong();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
