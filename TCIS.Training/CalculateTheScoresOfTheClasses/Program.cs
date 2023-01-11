using CalculateTheScoresOfTheClasses.Entities;
using CalculateTheScoresOfTheClasses.Entities.TeacherModel;
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
        static List<ClassificationClassesMonth> ClassificationClassesMonths { get; set; }
        static List<ClassificationInMonthsDTO> ClassificationInMonthsDTOs { get; set; }
        static List<ClassificationClassesYear> ClassificationClassesYears { get; set; }
        static List<ClassificationInYearsDTO> ClassificationInYearsDTOs { get; set; }
        static List<HomeroomTeacher> HomeroomTeachers { get; set; }
        //static List<HeadTeacher> HeadTeachers { get; set; }
        static List<AssistantHeadTeacher> AssistantHeadTeachers { get; set; }
        static List<Teacher> Teachers { get; set; }
        static HeadTeacher HeadTeacher { get; set; }


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
            ClassificationClassesMonths = new List<ClassificationClassesMonth>();
            ClassificationInMonthsDTOs = new List<ClassificationInMonthsDTO>();
            ClassificationClassesYears = new List<ClassificationClassesYear>();
            ClassificationInYearsDTOs = new List<ClassificationInYearsDTO>();
            HomeroomTeachers = new List<HomeroomTeacher>();
            //HeadTeachers = new List<HeadTeacher>();
            
            AssistantHeadTeachers = new List<AssistantHeadTeacher>();
            Teachers = new List<Teacher>();

            var classes = new List<string>{"6A1", "6A2", "6A3", "6A4", "6A5", "6A6",
                "7A1", "7A2", "7A3", "8A1", "8A2", "8A3", "8A4", "9A1", "9A2", "9A3", "9A4"};

            var classCount = classes.Count();//16
            var random = new Random();
            //int week = 1; // số tuần học
            //int month = 4; // số tháng = 1 tuần * 4
            int year = 35; // số tuần học của 1 năm học = 35 tuần            
                           //int violationErrorCount= violationError.Count();

            #region Generates data GVCN
            //for (int i = 0; i <= classCount; i++)
            //{
            //    //var gvcn = new HomeroomTeacher
            //    //{

            //    //};
            //    HomeroomTeachers.Add(new HomeroomTeacher(i + 1, $"Nguyen Van {i + 1}"));
            //}
            #endregion

            #region Generates data GVCN PrintInfoSalaryTeacher
            for (int i = 0; i <= classCount; i++)
            {
                HomeroomTeachers.Add(new HomeroomTeacher(
                    i + 1,
                    $"Nguyen Van {i + 1}",
                    1,
                    5000000,
                    1,
                    3000000
                    ));
            }

            #endregion

            #region  Generates data HeadTeacher PrintInfoSalaryTeacher

             HeadTeacher = new HeadTeacher(
                    1,
                    $"Nguyễn Văn Hiệu Trưởng",
                    3,
                    5000000,
                    3,
                    15000000,
                    7000000
            );
            
                        //for (int i = 0; i < 1; i++)
            //{
            //    HeadTeachers.Add(new HeadTeacher(
            //        i + 1,
            //        $"Nguyễn Văn Hiệu Trưởng",
            //        3,
            //        5000000,
            //        3,
            //        15000000,
            //        7000000
            //        ));
            //}

            #endregion

            #region Generates data AsitantHeadTeacher PrintInfoSalaryTeacher
            for (int i = 0; i < 1; i++)
            {
                AssistantHeadTeachers.Add(new AssistantHeadTeacher(
                    i + 1,
                    $"Nguyễn Văn Hiệu Phó",
                    2,
                    4000000,
                    2,
                    10000000,
                    4000000
                    ));
            }
            #endregion

            #region Generates data Class danh sách lớp
            //for (int i = 0; i < classCount; i++)
            //{
            //    var ex = new Class
            //    {
            //        Id = i + 1,
            //        Name = classes[i]
            //    };
            //    Classes.Add(ex);
            //}
            #endregion

            #region Generates Data Điểm 1 tuần 
            //for (int i = 0; i < week; i++)
            //{
            //    for (int j = 0; j < classCount; j++)
            //    {
            //        var weeks = new ScoreBoard
            //        {
            //            Id = j + 1,
            //            Class = Classes.FirstOrDefault(x => x.Name == classes[j]),
            //            NumberWeek = i + 1,
            //            // random điểm trừ
            //            DiHocTre = random.Next(0, 20),
            //            VangCoPhep = random.Next(0, 20),
            //            TronTiet = random.Next(0, 20),
            //            KhongDongPhuc = random.Next(0, 20),
            //            MangVietXoa = random.Next(0, 20),
            //            TietHocLoaiCD = random.Next(0, 20),
            //            KhongThucHienTotChaoCo = random.Next(0, 20),
            //            NhuomToc = random.Next(0, 20),
            //            NoiTucChuiThe = random.Next(0, 20),
            //            VoLe = random.Next(0, 20),
            //            PhaHoaiTaiSan = random.Next(0, 20),
            //            TeNanXaHoi = random.Next(0, 20),
            //            VeSinhBan = random.Next(0, 20),
            //            XaRacBuaBai = random.Next(0, 20),
            //            MangDTDD = random.Next(0, 20),
            //            KhongTatQuatDien = random.Next(0, 20),
            //            KhongHoanThanhNiemVu = random.Next(0, 20),
            //            BaoLucHocDuong = random.Next(0, 20),
            //            //random điểm cộng
            //            TuanHocTot = random.Next(50, 100),
            //            NhatDuocCuaRoi = random.Next(50, 100),
            //        };
            //        ScoreBoards.Add(weeks);
            //    }
            //}
            #endregion

            #region Generates data Điểm 1 tháng

            //for (int i = 1; i <= month; i++)
            //{
            //    for (int j = 0; j < classCount; j++)
            //    {
            //        var months = new ScoreBoard
            //        {
            //            Id = j + 1,
            //            Class = Classes.FirstOrDefault(x => x.Name == classes[j]),
            //            NumberWeek = i,
            //            NumberMonth = 1,
            //            // random điểm trừ
            //            DiHocTre = random.Next(0, 20),
            //            VangCoPhep = random.Next(0, 20),
            //            TronTiet = random.Next(0, 20),
            //            KhongDongPhuc = random.Next(0, 20),
            //            MangVietXoa = random.Next(0, 20),
            //            TietHocLoaiCD = random.Next(0, 20),
            //            KhongThucHienTotChaoCo = random.Next(0, 20),
            //            NhuomToc = random.Next(0, 20),
            //            NoiTucChuiThe = random.Next(0, 20),
            //            VoLe = random.Next(0, 20),
            //            PhaHoaiTaiSan = random.Next(0, 20),
            //            TeNanXaHoi = random.Next(0, 20),
            //            VeSinhBan = random.Next(0, 20),
            //            XaRacBuaBai = random.Next(0, 20),
            //            MangDTDD = random.Next(0, 20),
            //            KhongTatQuatDien = random.Next(0, 20),
            //            KhongHoanThanhNiemVu = random.Next(0, 20),
            //            BaoLucHocDuong = random.Next(0, 20),
            //            //random điểm cộng
            //            TuanHocTot = random.Next(50, 100),
            //            NhatDuocCuaRoi = random.Next(50, 100),
            //        };
            //        ScoreBoards.Add(months);
            //    }
            //}
            #endregion

            #region Điểm 1 năm học = 35 tuần học

            for (int i = 1; i <= year; i++)
            {
                for (int j = 0; j < classCount; j++)
                {

                    var ex = new ScoreBoard
                    {
                        Id = j + 1,
                        Class = Classes.FirstOrDefault(x => x.Name == classes[j]),
                        NumberWeek = i,
                        // random điểm trừ
                        DiHocTre = random.Next(0, 20),
                        VangCoPhep = random.Next(0, 20),
                        TronTiet = random.Next(0, 20),
                        KhongDongPhuc = random.Next(0, 20),
                        MangVietXoa = random.Next(0, 20),
                        TietHocLoaiCD = random.Next(0, 20),
                        KhongThucHienTotChaoCo = random.Next(0, 20),
                        NhuomToc = random.Next(0, 20),
                        NoiTucChuiThe = random.Next(0, 20),
                        VoLe = random.Next(0, 20),
                        PhaHoaiTaiSan = random.Next(0, 20),
                        TeNanXaHoi = random.Next(0, 20),
                        VeSinhBan = random.Next(0, 20),
                        XaRacBuaBai = random.Next(0, 20),
                        MangDTDD = random.Next(0, 20),
                        KhongTatQuatDien = random.Next(0, 20),
                        KhongHoanThanhNiemVu = random.Next(0, 20),
                        BaoLucHocDuong = random.Next(0, 20),
                        //random điểm cộng
                        TuanHocTot = random.Next(50, 100),
                        NhatDuocCuaRoi = random.Next(50, 100),
                    };
                    ScoreBoards.Add(ex);
                }
            }
            #endregion

            #region XẾP LOẠI THI ĐUA TUẦN
            ClassificationClassesWeeks.AddRange(new List<ClassificationClassWeek>
            {
                new ClassificationClassWeek
                {
                    // Xếp loại Yeu
                    // Các trường hợp còn lại
                    Id = 1,
                    TotalPoint = 69,
                    ViolationError = 31,

                    Classification  =  ClassificationRedStar.Yeu.ToString(),
                }, new ClassificationClassWeek
                {
                    // Xếp loại Yeu
                    // Các trường hợp còn lại
                    Id = 2,
                    TotalPoint = 70,
                    ViolationError = 30,

                    Classification  =  ClassificationRedStar.TrungBinh.ToString(),
                },
                new ClassificationClassWeek
                {
                    // Xếp loại Kha
                    //a. Điểm đạt: Trên 80 điểm; Điểm trừ không quá 20
                    //b.Không vi phạm mục b của xếp loại mạnh.
                    Id = 3,
                    TotalPoint = 80,
                    ViolationError = 20,
                    //ScoreBoard = ScoreBoards.FirstOrDefault(x=> x.TeNanXaHoi ==0 && x.BaoLucHocDuong==0),

                    Classification  =  ClassificationRedStar.Kha.ToString(),
                },
                 new ClassificationClassWeek
                {
                    // Xếp loại Manh
                    //a. Điểm đạt: Trên 90 điểm; Điểm trừ không quá 10 
                    //b. Không có trường hợp đánh nhau; không vi phạm các tệ nạn xã hội. 
                    //c.Không có trường hợp trốn học
                    Id = 4,
                    TotalPoint = 90,
                    ViolationError = 10,
                    //ScoreBoard = ScoreBoards.FirstOrDefault(x=>x.TronTiet == 0 && x.TeNanXaHoi ==0 && x.BaoLucHocDuong==0),

                    Classification  =  ClassificationRedStar.Manh.ToString()
                },
                new ClassificationClassWeek
                {
                    // Xếp loại XS
                    //Điểm đạt: Trên 100 điểm; Điểm trừ không quá 6 và là điểm trừ vắng có phép
                    Id = 5,
                    TotalPoint = 100,
                    ViolationError = 6,
                    //ScoreBoard = ScoreBoards.FirstOrDefault(x=>x.VangCoPhep == 0 ),

                    Classification = ClassificationRedStar.XuatSac.ToString()
                }

            });
            #endregion

            #region XẾP LOẠI THI ĐUA THÁNG
            ClassificationClassesMonths.AddRange(new List<ClassificationClassesMonth>
            {
                new ClassificationClassesMonth
                {
                    // Xếp loại Yeu
                    // Các trường hợp còn lại
                    Id = 1,
                    TotalPoint = 276,
                    ViolationError = 124,

                    Classification  =  ClassificationRedStar.Yeu.ToString(),
                }, new ClassificationClassesMonth
                {
                    // Xếp loại TB
                    //3 tuần xếp loại Trung bình, còn lại xếp loại Yếu
                    Id = 2,
                    TotalPoint = 279,
                    ViolationError = 121,

                    Classification  =  ClassificationRedStar.TrungBinh.ToString(),
                },
                new ClassificationClassesMonth
                {
                    // Xếp loại Kha
                    //3 tuần xếp loại Khá, còn lại xếp loại Trung bình
                    Id = 3,
                    TotalPoint = 310,
                    ViolationError = 90,
                    //ScoreBoard = ScoreBoards.FirstOrDefault(x=> x.TeNanXaHoi ==0 && x.BaoLucHocDuong==0),

                    Classification  =  ClassificationRedStar.Kha.ToString(),
                },
                 new ClassificationClassesMonth
                {
                    // Xếp loại Manh
                   // 3 tuần xếp loại Mạnh, còn lại xếp loại Khá
                    Id = 4,
                    TotalPoint = 350,
                    ViolationError = 50,

                    Classification  =  ClassificationRedStar.Manh.ToString()
                },
                new ClassificationClassesMonth
                {
                    // Xếp loại XS
                   // 3 tuần xếp loại Xuất Sắc, còn lại xếp loại Mạnh
                    Id = 5,
                    TotalPoint = 390,
                    ViolationError = 28,

                    Classification = ClassificationRedStar.XuatSac.ToString()
                }

            });
            #endregion

            #region XẾP LOẠI THI ĐUA NĂM
            ClassificationClassesYears.AddRange(new List<ClassificationClassesYear>
            {
                new ClassificationClassesYear
                {
                    // Xếp loại Yeu
                    // Các trường hợp còn lại
                    Id = 1,
                    TotalPoint = 1656,
                    ViolationError = 341,

                    Classification  =  ClassificationRedStar.Yeu.ToString(),
                }, new ClassificationClassesYear
                {
                    // Xếp loại TB
                    //3 tuần xếp loại Trung bình, còn lại xếp loại Yếu
                    Id = 2,
                    TotalPoint = 1674,
                    ViolationError = 363,

                    Classification  =  ClassificationRedStar.TrungBinh.ToString(),
                },
                new ClassificationClassesYear
                {
                    // Xếp loại Kha
                    //3 tuần xếp loại Khá, còn lại xếp loại Trung bình
                    Id = 3,
                    TotalPoint = 1860,
                    ViolationError = 270,
                    //ScoreBoard = ScoreBoards.FirstOrDefault(x=> x.TeNanXaHoi ==0 && x.BaoLucHocDuong==0),

                    Classification  =  ClassificationRedStar.Kha.ToString(),
                },
                 new ClassificationClassesYear
                {
                    // Xếp loại Manh
                   // 3 tuần xếp loại Mạnh, còn lại xếp loại Khá
                    Id = 4,
                    TotalPoint = 2100,
                    ViolationError = 150,

                    Classification  =  ClassificationRedStar.Manh.ToString()
                },
                new ClassificationClassesYear
                {
                    // Xếp loại XS
                   // 3 tuần xếp loại Xuất Sắc, còn lại xếp loại Mạnh
                    Id = 5,
                    TotalPoint = 2340,
                    ViolationError = 84,

                    Classification = ClassificationRedStar.XuatSac.ToString()
                }

            });
            #endregion
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int weeklyDefaultPoint = 100;// điểm mặc định hàng tuần
            DummyData();

            #region Dummy data danh sách lớp
            //Console.WriteLine("=========================");
            //Console.WriteLine("DANH SÁCH LỚP");
            //foreach (var c in Classes)
            //{
            //    Console.WriteLine(c.ToString());
            //}
            #endregion

            #region Dummy data bảng điểm tuần            
            //Console.Write($"===========================================================================================================" +
            //              $"\n \t\t\t\t\t\tBẢNG ĐIỂM TUẦN" +
            //              $"\n===========================================================================================================");

            //foreach (var s in ScoreBoards)
            //{
            //    Console.WriteLine(s.PrintDummyScoreWeek());
            //}
            #endregion

            #region Tính tổng điểm hàng tuần, XẾP LOẠI LỚP
            //foreach (var classificationClassWeek in ScoreBoards)
            //{
            //    var scoresClass = ScoreBoards.Where(x => x.Id == classificationClassWeek.Id);
            //    if (scoresClass == null)
            //        continue;

            //    //tính điểm trừ - bỏ bớt điểm trừ ra để nhảy ra kết quả hợp lý
            //    var mistakePoints = scoresClass.Sum(x =>
            //    x.DiHocTre + x.VaoHocTre
            //    + x.TronTiet + x.VangCoPhep
            //    //+ x.VangCoPhep + x.BaoLucHocDuong
            //    //+ x.KhongDongPhuc + x.MangVietXoa
            //    //+ x.TietHocLoaiCD + x.KhongThucHienTotChaoCo
            //    //+ x.NhuomToc + x.NoiTucChuiThe
            //    //+ x.VoLe + x.PhaHoaiTaiSan
            //    //+ x.TeNanXaHoi + x.VeSinhBan
            //    //+ x.XaRacBuaBai + x.MangDTDD
            //    //+ x.KhongTatQuatDien + x.KhongHoanThanhNiemVu
            //    );
            //    //tính điểm cộng
            //    var plusPoints = scoresClass.Sum(x => x.TuanHocTot + x.NhatDuocCuaRoi);
            //    // tính tổng điểm
            //    var pointWeekOfClass = (weeklyDefaultPoint + plusPoints) - mistakePoints;

            //    // kiểm tra xếp hạng lớp theo tuần

            //    var classification = ClassificationClassesWeeks.FirstOrDefault
            //        (x => x.TotalPoint <= pointWeekOfClass && x.ViolationError <= mistakePoints).Classification;
            //    //if (classification == null)
            //    //{
            //    //    var classification1 = ClassificationClassesWeeks.FirstOrDefault
            //    //    (x => x.ViolationError >= mistakePoints).Classification;
            //    //}
            //    ClassificationInWeeksDTOs.Add(new ClassificationInWeeksDTO
            //    {
            //        ScoreBoard = classificationClassWeek,
            //        TotalPoint = pointWeekOfClass,
            //        ViolationError = mistakePoints,
            //        PlusMark = plusPoints,
            //        Classification = classification
            //    });
            //}
            //Console.Write($"===========================================================================================================" +
            //$"\n \t\t\t\t\t\tBẢNG ĐIỂM TUẦN" +
            //$"\n===========================================================================================================\n");

            //foreach (var summary in ClassificationInWeeksDTOs)
            //{
            //    Console.WriteLine(summary.ToString());
            //}
            #endregion

            #region Dummy data bảng điểm tháng       
            //Console.Write($"===========================================================================================================" +
            //$"\n \t\t\t\t\t\tBẢNG ĐIỂM THÁNG" +
            //$"\n===========================================================================================================\n");

            //foreach (var s in ScoreBoards)
            //{
            //    Console.WriteLine(s.PrintDummyScoreMonth());
            //}
            #endregion

            #region Tính tổng điểm hàng tháng, XẾP LOẠI LỚP
            //foreach (var classificationClassMonth in ScoreBoards)
            //{
            //    var scoresClass = ScoreBoards.Where(x => x.Id == classificationClassMonth.Id);
            //    if (scoresClass == null)
            //        continue;

            //    //tính điểm trừ - bỏ bớt điểm trừ ra để nhảy ra kết quả hợp lý
            //    var mistakePoints = scoresClass.Sum(x =>
            //    x.DiHocTre + x.VaoHocTre
            //    + x.TronTiet + x.VangCoPhep
            //    //+ x.VangCoPhep + x.BaoLucHocDuong
            //    //+ x.KhongDongPhuc + x.MangVietXoa
            //    //+ x.TietHocLoaiCD + x.KhongThucHienTotChaoCo
            //    //+ x.NhuomToc + x.NoiTucChuiThe
            //    //+ x.VoLe + x.PhaHoaiTaiSan
            //    //+ x.TeNanXaHoi + x.VeSinhBan
            //    //+ x.XaRacBuaBai + x.MangDTDD
            //    //+ x.KhongTatQuatDien + x.KhongHoanThanhNiemVu
            //    );
            //    //tính điểm cộng
            //    var plusPoints = scoresClass.Sum(x => x.TuanHocTot + x.NhatDuocCuaRoi);
            //    // tính tổng điểm
            //    var pointWeekOfClass = (weeklyDefaultPoint + plusPoints) - mistakePoints;

            //    // kiểm tra xếp hạng lớp theo tuần
            //    //if (classification == null)
            //    //{
            //    //    var classification1 = ClassificationClassesWeeks.FirstOrDefault
            //    //    (x => x.ViolationError >= mistakePoints).Classification;
            //    //}
            //    var classification = ClassificationClassesMonths.FirstOrDefault
            //        (x => x.TotalPoint <= pointWeekOfClass && x.ViolationError <= mistakePoints).Classification;

            //    ClassificationInMonthsDTOs.Add(new ClassificationInMonthsDTO
            //    {
            //        ScoreBoard = classificationClassMonth,
            //        TotalPoint = pointWeekOfClass,
            //        ViolationError = mistakePoints,
            //        PlusMark = plusPoints,
            //        Classification = classification
            //    });
            //}
            //Console.Write($"===========================================================================================================" +
            //$"\n \t\t\t\t\t\tBẢNG XẾP HẠNG THÁNG" +
            //$"\n===========================================================================================================\n");

            //foreach (var summary in ClassificationInMonthsDTOs)
            //{
            //    Console.WriteLine(summary.ToString());
            //}
            #endregion

            #region Dummy data bảng điểm Năm       
            //Console.Write($"===========================================================================================================" +
            //$"\n \t\t\t\t\t\tBẢNG ĐIỂM NĂM" +
            //$"\n===========================================================================================================\n");

            //foreach (var s in ScoreBoards)
            //{
            //    Console.WriteLine(s.PrintDummyScoreMonth());
            //}
            #endregion

            #region Tính tổng điểm NĂM, XẾP LOẠI LỚP
            //foreach (var classificationClassYear in ScoreBoards)
            //{
            //    var scoresClass = ScoreBoards.Where(x => x.Id == classificationClassYear.Id);
            //    if (scoresClass == null)
            //        continue;

            //    //tính điểm trừ - bỏ bớt điểm trừ ra để nhảy ra kết quả hợp lý
            //    var mistakePoints = scoresClass.Sum(x =>
            //    x.DiHocTre + x.VaoHocTre
            //    + x.TronTiet + x.VangCoPhep
            //    //+ x.VangCoPhep + x.BaoLucHocDuong
            //    //+ x.KhongDongPhuc + x.MangVietXoa
            //    //+ x.TietHocLoaiCD + x.KhongThucHienTotChaoCo
            //    //+ x.NhuomToc + x.NoiTucChuiThe
            //    //+ x.VoLe + x.PhaHoaiTaiSan
            //    //+ x.TeNanXaHoi + x.VeSinhBan
            //    //+ x.XaRacBuaBai + x.MangDTDD
            //    //+ x.KhongTatQuatDien + x.KhongHoanThanhNiemVu
            //    );
            //    //tính điểm cộng
            //    var plusPoints = scoresClass.Sum(x => x.TuanHocTot + x.NhatDuocCuaRoi);
            //    // tính tổng điểm
            //    var pointWeekOfClass = (weeklyDefaultPoint + plusPoints) - mistakePoints;

            //    // kiểm tra xếp hạng lớp theo tuần
            //    //if (classification == null)
            //    //{
            //    //    var classification1 = ClassificationClassesWeeks.FirstOrDefault
            //    //    (x => x.ViolationError >= mistakePoints).Classification;
            //    //}
            //    var classification = ClassificationClassesMonths.FirstOrDefault
            //        (x => x.TotalPoint <= pointWeekOfClass && x.ViolationError <= mistakePoints).Classification;

            //    ClassificationInYearsDTOs.Add(new ClassificationInYearsDTO
            //    {
            //        ScoreBoard = classificationClassYear,
            //        TotalPoint = pointWeekOfClass,
            //        ViolationError = mistakePoints,
            //        PlusMark = plusPoints,
            //        Classification = classification
            //    });
            //}
            //Console.Write($"===========================================================================================================" +
            //$"\n \t\t\t\t\t\tBẢNG XẾP HẠNG NĂM" +
            //$"\n===========================================================================================================\n");

            //foreach (var summary in ClassificationInYearsDTOs)
            //{
            //    Console.WriteLine(summary.ToString());
            //}
            #endregion

            #region Dummy data & Tính lương GVCN
            //foreach (var t in HomeroomTeachers)
            //{
            //    Console.WriteLine(t.ToString());
            //}
            double sum = 0;
            foreach (var t in HomeroomTeachers)
            {
                Console.WriteLine("=========================================================");
                Console.WriteLine("\t========BẢNG TÍNH LƯƠNG GVCN========");
                Console.WriteLine("=========================================================");

                Console.WriteLine(t.PrintInfoSalaryTeacher());
                Console.Write("Lương:\t");
                Console.WriteLine(t.CalculateSalary());
                if (t.Level ==2)
                {
                    sum += t.CalculateSalary();
                }
                
            }

            Console.WriteLine(sum);
            Teachers.AddRange(HomeroomTeachers);
            Teachers.AddRange(AssistantHeadTeachers);
            Teachers.Add(HeadTeacher);

            foreach (var t in Teachers)
            {
                if (t.Level==1)
                {
                    Console.WriteLine(t.PrintInfoSalaryTeacher());
                }                
            }
            #endregion

            //#region Dummy data & tính lương hiệu trưởng

            ////foreach (var t in HeadTeachers)
            ////{
            ////    Console.WriteLine(t.ToString());
            ////}



            //Console.WriteLine("=========================================================");
            //    Console.WriteLine("\t========BẢNG TÍNH LƯƠNG HIỆU TRƯỞNG========");
            //    Console.WriteLine("=========================================================");
           
            //    Console.WriteLine(HeadTeacher.PrintInfoSalaryTeacher());
            //    Console.Write("Lương:\t");
            //   Console.WriteLine(HeadTeacher.CalculateSalary());
            
            //#endregion

            //#region Dummy data & tính lương hiệu phó
            //foreach (var t in AssistantHeadTeachers)
            //{
            //    Console.WriteLine(t.ToString());
            //}
            //foreach (var t in AssistantHeadTeachers)
            //{
            //    Console.WriteLine("=========================================================");
            //    Console.WriteLine("\t========BẢNG TÍNH LƯƠNG HIỆU PHÓ========");
            //    Console.WriteLine("=========================================================");
            //    Console.WriteLine(t.PrintInfoSalaryTeacher());
            //    Console.Write("Lương:\t");
            //    Console.WriteLine(t.CalculateSalary());
            //}
            //#endregion


            Console.ReadKey();

        }
    }
}

