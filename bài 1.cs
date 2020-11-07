using System;
using System.Collections.Generic;
using System.Text;

namespace bài_thực_hành_số_5
{
    class TIENDIEN

    {
        private string chuho;
        private string diachi;
        private int congtothangtruoc;
        private int congtothangnay;
        public TIENDIEN()
        {
            chuho = diachi = "";
            congtothangtruoc = congtothangnay;
        }
        public TIENDIEN(string chuho, string diachi, int congtothangtruoc, int congtothangnay)
        {
            this.chuho = chuho;
            this.diachi = diachi;
            this.congtothangnay = congtothangnay;
            this.congtothangtruoc = congtothangtruoc;
        }
        public void nhap()
        {
            Console.WriteLine("nhập thông tin ");
            Console.WriteLine("nhập tên chủ hộ");
            chuho = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("địa chỉ chủ hộ");
            diachi = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("nhập số công tơ tháng trước");
            congtothangtruoc = int.Parse(Console.ReadLine());
            Console.WriteLine("nhập số công tơ tháng này");
            congtothangnay = int.Parse(Console.ReadLine());


        }
        public void Hien()
        {
            Console.WriteLine("thông tin hiển thị");
            Console.WriteLine("{0}\n{1}\n{2}\n{3}", chuho, diachi, congtothangnay, congtothangtruoc);
            Console.WriteLine();
        }
        public int Congtodadung
        {
            get
            {
                return (congtothangnay - congtothangtruoc);

            }

        }
        public int tiendien()
        {
            return Congtodadung * 500;
        }

    }
    class TIENDIENMOI : TIENDIEN
    {
        private int dinhmuc;
        public TIENDIENMOI() : base()
        {
            dinhmuc = 50;
        }
        public TIENDIENMOI(string tenchuho, string diachi, int sodienthangtruoc, int sodienthangnay, int dinhmuc) : base(tenchuho, diachi, sodienthangtruoc, sodienthangnay)
        {
            this.dinhmuc = dinhmuc;
        }
        public new void nhap()
        {
            base.nhap();
            Console.Write("Nhap he so dinh muc: ");
            dinhmuc = int.Parse(Console.ReadLine());

        }
        public new int tiendien()
        {
            if (Congtodadung < dinhmuc) return Congtodadung * 500;
            else return Congtodadung * 600;
        }
    }
    class Test1
    {
        static void Main1(string[] args)
        {
            TIENDIENMOI t = new TIENDIENMOI();
            t.nhap();
            t.Hien();
            Console.WriteLine("Tien dien phai tra:{0}", t.tiendien());
            Console.ReadKey();
        }
    }
}


