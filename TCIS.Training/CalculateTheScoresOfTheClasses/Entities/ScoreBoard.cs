﻿using System;
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


        //// thuộc tính tổng điểm
        //public double TotalPoint { get; set; } //tính tổng điểm       
        //public double ViolationError { get; set; } //điểm trừ
        //public double PlusMark { get; set; }//điểm cộng


        /// <summary>
        /// Thuộc tính trừ điểm
        /// </summary>
        public int DiHocTre { get; set; }
        public int VaoHocTre { get; set; }
        public int TronTiet { get; set; }
        public int VangCoPhep { get; set; }
        public int KhongDongPhuc { get; set; }
        public int MangVietXoa { get; set; }
        public int TietHocLoaiCD { get; set; }
        public int KhongThucHienTotChaoCo { get; set; }
        public int NhuomToc { get; set; }
        public int NoiTucChuiThe { get; set; }
        public int VoLe { get; set; }
        public int PhaHoaiTaiSan { get; set; }
        public int TeNanXaHoi { get; set; }
        public int VeSinhBan { get; set; }
        public int XaRacBuaBai { get; set; }
        public int MangDTDD { get; set; }
        public int KhongTatQuatDien { get; set; }
        public int KhongHoanThanhNiemVu { get; set; }
        public int BaoLucHocDuong { get; set; }
           
       /// <summary>
        /// Thuộc tính cộng điểm
        /// </summary>
        /// <returns></returns>
        public int TuanHocTot { get; set; }
        public int NhatDuocCuaRoi { get; set; }



        //public string ToString()
        //{
        //    return $"{Id}-{Class.Name}-Điểm trừ: {ViolationError}-Điểm cộng: {PlusMark}- Tổng điểm: {TotalPoint}";

        //}        
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