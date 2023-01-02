﻿using CalculateTheScoresOfTheClasses.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculateTheScoresOfTheClasses
{
    class Program
    {
        static List<Class> Classes { get; set; }
        static List<ScoreBoard> ScoreBoards { get; set; }
        static List<ClassificationClassWeek> ClassificationClassesWeeks { get; set; }
        static List<ClassificationInWeeksDTO> ClassificationInWeeksDTOs { get; set; }
        //static List<ClassificationClassesMonths> ClassificationClassesMonth { get; set; }

        enum ClassificationRedStar
        {
            XuatSac,
            Manh,
            Kha,
            TrungBinh,
            Yeu
        }

        static void DummyData() // tạo dữ liệu giả
        {
            Classes = new List<Class>();
            ScoreBoards = new List<ScoreBoard>();
            ClassificationClassesWeeks = new List<ClassificationClassWeek>();
            ClassificationInWeeksDTOs = new List<ClassificationInWeeksDTO>();
            //ClassificationClassesMonths = new List<ClassificationClassesMonth>();

            var classes = new List<string>{"6A1", "6A2", "6A3", "6A4", "6A5", "6A6",
                "7A1", "7A2", "7A3", "8A1", "8A2", "8A3", "8A4", "9A1", "9A2", "9A3", "9A4"};

            //var violationError = new List<string> { "DiHocTre", "VaoHocTre" , "TronTiet", "VangCoPhep",
            //    "KhongDongPhuc", "MangVietXoa","TietHocLoaiCD" ,"KhongThucHienTotChaoCo" ,"NhuomToc" ,"NoiTucChuiThe" ,"VoLe" ,
            //"PhaHoaiTaiSan" ,"TeNanXaHoi" ,"VeSinhBan" ,"XaRacBuaBai" ,"MangDTDD" ,"KhongTatQuatDien" ,"KhongHoanThanhNiemVu" ,"BaoLucHocDuong"};


            var classCount = classes.Count();
            var random = new Random();
            int week = 1; // số tuần học
            int moth = 4;
            int year = 35;


            double pointMistake = 0;
            //int violationErrorCount= violationError.Count();

            // generates data Class danh sách lớp
            for (int i = 0; i < classCount; i++)
            {
                var ex = new Class
                {
                    Id = i + 1,
                    Name = classes[i]
                };
                Classes.Add(ex);
            }

            #region Điểm 1 tuần

            // generates data Điểm 1 tuần 
            for (int i = 0; i < week; i++)
            {
                for (int j = 0; j < classCount; j++)
                {

                    var ex = new ScoreBoard
                    {
                        Id = j + 1,
                        Class = Classes.FirstOrDefault(x => x.Name == classes[j]),
                        NumberWeek = i+1,
                        // random điểm trừ
                        DiHocTre = random.Next(-20, 1),
                        VangCoPhep = random.Next(-20, 1),
                        VaoHocTre = random.Next(-20, 1),
                        TronTiet = random.Next(-20, 1),
                        KhongDongPhuc = random.Next(-20, 1),
                        MangVietXoa = random.Next(-20, 1),
                        TietHocLoaiCD = random.Next(-20, 1),
                        KhongThucHienTotChaoCo = random.Next(-20, 1),
                        NhuomToc = random.Next(-20, 1),
                        NoiTucChuiThe = random.Next(-20, 1),
                        VoLe = random.Next(-20, 1),
                        PhaHoaiTaiSan = random.Next(-20, 1),
                        TeNanXaHoi = random.Next(-20, 1),
                        VeSinhBan = random.Next(-20, 1),
                        XaRacBuaBai = random.Next(-20, 1),
                        MangDTDD = random.Next(-20, 1),
                        KhongTatQuatDien = random.Next(-20, 1),
                        KhongHoanThanhNiemVu = random.Next(-20, 1),
                        BaoLucHocDuong = random.Next(-20, 1),
                        //random điểm cộng
                        TuanHocTot = random.Next(0, 50),
                        NhatDuocCuaRoi = random.Next(0, 50),
                    };
                    ScoreBoards.Add(ex);
                }
            }
            #endregion
            #region Điểm 1 tháng
            // generates data Điểm 1 tháng 
            //for (int i = 1; i < moth; i++)
            //{
            //    for (int j = 0; j < classCount; j++)
            //    {

            //        var ex = new ScoreBoard
            //        {
            //            Id = j + 1,
            //            Class = Classes.FirstOrDefault(x => x.Name == classes[j]),
            //            NumberWeek = i,
            //            // random điểm trừ
            //            DiHocTre = random.Next(-20, 1),
            //            VangCoPhep = random.Next(-20, 1),
            //            VaoHocTre = random.Next(-20, 1),
            //            TronTiet = random.Next(-20, 1),
            //            KhongDongPhuc = random.Next(-20, 1),
            //            MangVietXoa = random.Next(-20, 1),
            //            TietHocLoaiCD = random.Next(-20, 1),
            //            KhongThucHienTotChaoCo = random.Next(-20, 1),
            //            NhuomToc = random.Next(-20, 1),
            //            NoiTucChuiThe = random.Next(-20, 1),
            //            VoLe = random.Next(-20, 1),
            //            PhaHoaiTaiSan = random.Next(-20, 1),
            //            TeNanXaHoi = random.Next(-20, 1),
            //            VeSinhBan = random.Next(-20, 1),
            //            XaRacBuaBai = random.Next(-20, 1),
            //            MangDTDD = random.Next(-20, 1),
            //            KhongTatQuatDien = random.Next(-20, 1),
            //            KhongHoanThanhNiemVu = random.Next(-20, 1),
            //            BaoLucHocDuong = random.Next(-20, 1),
            //            //random điểm cộng
            //            TuanHocTot = random.Next(0, 21),
            //            NhatDuocCuaRoi = random.Next(0, 21),
            //        };
            //        ScoreBoards.Add(ex);
            //    }
            //}
            #endregion
            #region Điểm 1 năm học = 35 tuần học
            // generates data Điểm 35 tuần = 1 năm học

            //for (int i = 1; i < year; i++)
            //{
            //    for (int j = 0; j < classCount; j++)
            //    {

            //        var ex = new ScoreBoard
            //        {
            //            Id = j + 1,
            //            Class = Classes.FirstOrDefault(x => x.Name == classes[j]),
            //            NumberWeek = i,
            //            // random điểm trừ
            //            DiHocTre = random.Next(-20, 1),
            //            VangCoPhep = random.Next(-20, 1),
            //            VaoHocTre = random.Next(-20, 1),
            //            TronTiet = random.Next(-20, 1),
            //            KhongDongPhuc = random.Next(-20, 1),
            //            MangVietXoa = random.Next(-20, 1),
            //            TietHocLoaiCD = random.Next(-20, 1),
            //            KhongThucHienTotChaoCo = random.Next(-20, 1),
            //            NhuomToc = random.Next(-20, 1),
            //            NoiTucChuiThe = random.Next(-20, 1),
            //            VoLe = random.Next(-20, 1),
            //            PhaHoaiTaiSan = random.Next(-20, 1),
            //            TeNanXaHoi = random.Next(-20, 1),
            //            VeSinhBan = random.Next(-20, 1),
            //            XaRacBuaBai = random.Next(-20, 1),
            //            MangDTDD = random.Next(-20, 1),
            //            KhongTatQuatDien = random.Next(-20, 1),
            //            KhongHoanThanhNiemVu = random.Next(-20, 1),
            //            BaoLucHocDuong = random.Next(-20, 1),
            //            //random điểm cộng
            //            TuanHocTot = random.Next(0, 21),
            //            NhatDuocCuaRoi = random.Next(0, 21),
            //        };
            //        ScoreBoards.Add(ex);
            //    }
            //}
            #endregion

            #region XẾP LOẠI THI ĐUA TUẦN
            ClassificationClassesWeeks.AddRange(new List<ClassificationClassWeek>
            {
                new ClassificationClassWeek
                {
                    // Xếp loại XS
                    //Điểm đạt: Trên 100 điểm; Điểm trừ không quá 6 và là điểm trừ vắng có phép
                    Id = 1,
                    TotalPoint = 100,
                    ViolationError = -6,
                    //ScoreBoard = ScoreBoards.FirstOrDefault(x=>x.VangCoPhep == 0 ),

                    Classification = ClassificationRedStar.XuatSac.ToString(),
                },
                new ClassificationClassWeek
                {
                    // Xếp loại Manh
                    //a. Điểm đạt: Trên 90 điểm; Điểm trừ không quá 10 
                    //b. Không có trường hợp đánh nhau; không vi phạm các tệ nạn xã hội. 
                    //c.Không có trường hợp trốn học
                    Id = 2,
                    TotalPoint = 90,
                    ViolationError = -10,
                    //ScoreBoard = ScoreBoards.FirstOrDefault(x=>x.TronTiet == 0 && x.TeNanXaHoi ==0 && x.BaoLucHocDuong==0),

                    Classification  =  ClassificationRedStar.Manh.ToString()
                },
                new ClassificationClassWeek
                {
                    // Xếp loại Kha
                    //a. Điểm đạt: Trên 80 điểm; Điểm trừ không quá 20
                    //b.Không vi phạm mục b của xếp loại mạnh.
                    Id = 3,
                    TotalPoint = 80,
                    ViolationError = -20,
                    //ScoreBoard = ScoreBoards.FirstOrDefault(x=> x.TeNanXaHoi ==0 && x.BaoLucHocDuong==0),


                    Classification  =  ClassificationRedStar.Kha.ToString(),
                },
                new ClassificationClassWeek
                {
                    // Xếp loại TrungBinh
                    // Điểm đạt: Trên 70 điểm ; Điểm trừ không quá 30
                    Id = 4,
                    TotalPoint = 70,
                    ViolationError = -30,

                    Classification  =  ClassificationRedStar.TrungBinh.ToString(),
                },
                new ClassificationClassWeek
                {
                    // Xếp loại Yeu
                    // Các trường hợp còn lại
                    Id = 5,
                    TotalPoint = 69,
                    ViolationError = -31,

                    Classification  =  ClassificationRedStar.Yeu.ToString(),
                }
            });
            #endregion

            #region XẾP LOẠI THI ĐUA THÁNG
            //ClassificationClassesMonths.AddRange(new List<ClassificationClassesMonth>
            //{
            //    new ClassificationClassWeek
            //    {
            //        // Xếp loại XS
            //        //Điểm đạt: Trên 100 điểm; Điểm trừ không quá 6 và là điểm trừ vắng có phép
            //        Id = 1,
            //        TotalPoint = 100,
            //        ViolationError = -6,
            //        ScoreBoard = ScoreBoards.FirstOrDefault(x=>x.VangCoPhep == 0 ),

            //        Classification = ClassificationRedStar.XuatSac.ToString(),
            //    },
            //    new ClassificationClassWeek
            //    {
            //        // Xếp loại Manh
            //        //a. Điểm đạt: Trên 90 điểm; Điểm trừ không quá 10 
            //        //b. Không có trường hợp đánh nhau; không vi phạm các tệ nạn xã hội. 
            //        //c.Không có trường hợp trốn học
            //        Id = 2,
            //        TotalPoint = 90,
            //        ViolationError = -10,
            //        ScoreBoard = ScoreBoards.FirstOrDefault(x=>x.TronTiet == 0 && x.TeNanXaHoi ==0 && x.BaoLucHocDuong==0),

            //        Classification  =  ClassificationRedStar.Manh.ToString()
            //    },
            //    new ClassificationClass
            //    {
            //        // Xếp loại Kha
            //        //a. Điểm đạt: Trên 80 điểm; Điểm trừ không quá 20
            //        //b.Không vi phạm mục b của xếp loại mạnh.
            //        Id = 3,
            //        TotalPoint = 80,
            //        ViolationError = -20,
            //        ScoreBoard = ScoreBoards.FirstOrDefault(x=> x.TeNanXaHoi ==0 && x.BaoLucHocDuong==0),


            //        Classification  =  ClassificationRedStar.Kha.ToString(),
            //    },
            //    new ClassificationClass
            //    {
            //        // Xếp loại TrungBinh
            //        // Điểm đạt: Trên 70 điểm ; Điểm trừ không quá 30
            //        Id = 4,
            //        TotalPoint = 70,
            //        ViolationError = -30,

            //        Classification  =  ClassificationRedStar.TrungBinh.ToString(),
            //    },
            //    new ClassificationClass
            //    {
            //        // Xếp loại Yeu
            //        // Các trường hợp còn lại
            //        Id = 5,

            //        Classification  =  ClassificationRedStar.Yeu.ToString(),
            //    }
            //});
            #endregion

        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int weeklyDefaultPoint = 100;// điểm mặc định hàng tuần
            DummyData();
            #region dummy data bảng điểm
            //Console.WriteLine("=========================");
            //Console.WriteLine("DANH SÁCH LỚP");
            //foreach (var c in Classes)
            //{
            //    Console.WriteLine(c.ToString());
            //}
            //Console.WriteLine("===========================================================================================================");
            //Console.WriteLine("\t\t\t\t\t\tBẢNG ĐIỂM TUẦN");
            //Console.WriteLine("===========================================================================================================");

            //foreach (var s in ScoreBoards)
            //{
            //    Console.WriteLine(s.PrintDummyScore());
            //}
            #endregion
            #region Tính tổng điểm hàng tuần, XẾP LOẠI LỚP
            foreach (var classificationClassWeek in ScoreBoards)
            {
                var scoresClass = ScoreBoards.Where(x => x.Id == classificationClassWeek.Id);
                if (scoresClass == null)
                    continue;

                //tính điểm trừ bỏ bớt điểm trừ ra để nhảy ra kết quả hợp lý
                var mistakePoints = scoresClass.Sum(x =>
                x.DiHocTre + x.VaoHocTre
                + x.TronTiet + x.VangCoPhep
                //+ x.VangCoPhep + x.BaoLucHocDuong
                //+ x.KhongDongPhuc + x.MangVietXoa
                //+ x.TietHocLoaiCD + x.KhongThucHienTotChaoCo
                //+ x.NhuomToc + x.NoiTucChuiThe
                //+ x.VoLe + x.PhaHoaiTaiSan
                //+ x.TeNanXaHoi + x.VeSinhBan
                //+ x.XaRacBuaBai + x.MangDTDD
                //+ x.KhongTatQuatDien + x.KhongHoanThanhNiemVu
                );
                //tính điểm cộng
                var plusPoints = scoresClass.Sum(x => x.TuanHocTot + x.NhatDuocCuaRoi);
                // tính tổng điểm
                var pointWeekOfClass = (weeklyDefaultPoint + plusPoints) + mistakePoints;
               
                // kiểm tra xếp hạng lớp theo tuần
                var classification = ClassificationClassesWeeks.FirstOrDefault
                    (x => x.ViolationError >= mistakePoints && x.TotalPoint <= pointWeekOfClass ).Classification;

                ClassificationInWeeksDTOs.Add(new ClassificationInWeeksDTO
                {
                    ScoreBoard = classificationClassWeek,
                    TotalPoint = pointWeekOfClass,
                    ViolationError = mistakePoints,
                    PlusMark = plusPoints,
                    Classification = classification
                });
            }
            foreach (var summary in ClassificationInWeeksDTOs)
            {
                Console.WriteLine(summary.ToString());
            }
            #endregion





            Console.ReadKey();

        }
    }
}