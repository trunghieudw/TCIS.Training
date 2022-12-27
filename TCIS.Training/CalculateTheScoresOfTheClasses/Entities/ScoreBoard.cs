using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTheScoresOfTheClasses.Entities
{
    public class ScoreBoard // bảng tổng kết điểm
    {
        public int Id { get; set; }      
        public Class Class { get; set; }
        //Thuộc tính tuần tháng
        public int NumberWeek { get; set; }


        // thuộc tính tổng điểm
        public double TotalPoint { get; set; } //tính tổng điểm       
        public double ViolationError { get; set; } //điểm trừ
        public double PlusMark { get; set; }//điểm cộng


        /// <summary>
        /// Thuộc tính trừ điểm
        /// </summary>
        public double DiHocTre { get; set; }
        public double VaoHocTre { get; set; }
        public double TronTiet { get; set; }
        public double VangCoPhep { get; set; }
        public double KhongDongPhuc { get; set; }
        public double MangVietXoa { get; set; }
        public double TietHocLoaiCD { get; set; }
        public double KhongThucHienTotChaoCo { get; set; }
        public double NhuomToc { get; set; }
        public double NoiTucChuiThe { get; set; }
        public double VoLe { get; set; }
        public double PhaHoaiTaiSan { get; set; }
        public double TeNanXaHoi { get; set; }
        public double VeSinhBan { get; set; }
        public double XaRacBuaBai { get; set; }
        public double MangDTDD { get; set; }
        public double KhongTatQuatDien { get; set; }
        public double KhongHoanThanhNiemVu { get; set; }
        public double BaoLucHocDuong { get; set; }

        /// <summary>
        /// Thuộc tính cộng điểm
        /// </summary>
        /// <returns></returns>
        public double TuanHocTot { get; set; }
        public double NhatDuocCuaRoi { get; set; }



        public string ToString()
        {
            return $"{Id}-{Class.Name}-Điểm trừ: {ViolationError}-Điểm cộng: {PlusMark}- Tổng điểm: {TotalPoint}";

        }        
        public string PrintDummyScore()
        {
            return
                $"\n============================================******************============================================" +
                $"\nTuần:{NumberWeek}\t Lớp: {Class.Name}" +
                "\n===========================================================================================================" +
                "\n \t\t\t\t\t\tLỖI VI PHẠM" +
                "\n===========================================================================================================" +
                $"\nDiHocTre {DiHocTre} \t VaoHocTre {VaoHocTre} \t TronTiet {TronTiet} \t VangCoPhep {VangCoPhep}"+
                $"\nDiHocTre {KhongDongPhuc} \t MangVietXoa {MangVietXoa} \t TietHocLoaiCD {TietHocLoaiCD}"+
                $"\nNhuomToc {NhuomToc} \t NoiTucChuiThe {NoiTucChuiThe} \t VoLe {VoLe} \t PhaHoaiTaiSan {PhaHoaiTaiSan}"+
                $"\nTeNanXaHoi {TeNanXaHoi} \t VeSinhBan {VeSinhBan} \t XaRacBuaBai {XaRacBuaBai} \t MangDTDD {MangDTDD}"+
                $"\nKhongTatQuatDien {KhongTatQuatDien} \t KhongHoanThanhNiemVu {KhongHoanThanhNiemVu} \t KhongThucHienTotChaoCo {KhongThucHienTotChaoCo} \t BaoLucHocDuong {BaoLucHocDuong}" +
                "\n===========================================================================================================" +
                "\n \t\t\t\t\t\tCỘNG ĐIỂM LỚP" +
                "\n===========================================================================================================" +
                $"\nTuanHocTot {TuanHocTot} \t NhatDuocCuaRoi {NhatDuocCuaRoi}";

        }
    }
}
