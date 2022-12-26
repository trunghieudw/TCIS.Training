using CalculateTheScoresOfTheClasses.Entities;
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


        static void DummyData() // tạo dữ liệu giả
        {
            Classes = new List<Class>();
            ScoreBoards = new List<ScoreBoard>();


            var classes = new List<string>{"6A1", "6A2", "6A3", "6A4", "6A5", "6A6",
                "7A1", "7A2", "7A3", "8A1", "8A2", "8A3", "8A4", "9A1", "9A2", "9A3", "9A4"};

            var ClassCount = classes.Count();
            var random = new Random();


            // generates data Class danh sách lớp
            for (int i = 0; i < ClassCount; i++)
            {
                var ex = new Class
                {
                    Id = i + 1,
                    Name = classes[i]
                };
                Classes.Add(ex);
            }

            // generates data Điểm 
            for (int i = 0; i < ClassCount; i++)
            {
                var ex = new ScoreBoard
                {
                    Id = i + 1,
                    Class = Classes.FirstOrDefault(x => x.Name == classes[i]),
                    // random điểm trừ
                    DiHocTre = random.Next(-20, 0),
                    VangCoPhep = random.Next(-20, 0),
                    VaoHocTre = random.Next(-20, 0),
                    TronTiet = random.Next(-20, 0),
                    KhongDongPhuc = random.Next(-20, 0),
                    MangVietXoa = random.Next(-20, 0),
                    TietHocLoaiCD = random.Next(-20, 0),
                    KhongThucHienTotChaoCo = random.Next(-20, 0),
                    NhuomToc = random.Next(-20, 0),
                    NoiTucChuiThe = random.Next(-20, 0),
                    VoLe = random.Next(-20, 0),
                    PhaHoaiTaiSan = random.Next(-20, 0),
                    TeNanXaHoi = random.Next(-20, 0),
                    VeSinhBan = random.Next(-20, 0),
                    XaRacBuaBai = random.Next(-20, 0),
                    MangDTDD = random.Next(-20, 0),
                    KhongTatQuatDien = random.Next(-20, 0),
                    KhongHoanThanhNiemVu = random.Next(-20, 0),
                    TuanHocTot = random.Next(0,20),
                    NhatDuocCuaRoi = random.Next(0,20)

                };
                ScoreBoards.Add(ex);
            }

        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DummyData();
            //Console.WriteLine("=========================");
            //Console.WriteLine("DANH SÁCH LỚP");
            //foreach (var c in Classes)
            //{
            //    Console.WriteLine(c.ToString());
            //}
            Console.WriteLine("=========================");
            Console.WriteLine("BẢNG ĐIỂM TUẦN");
            foreach (var s in ScoreBoards)
            {
                Console.WriteLine(s.Print());
            }




            Console.ReadKey();

        }
    }
}
