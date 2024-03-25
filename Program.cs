using GiuaKy_C_.Model;

namespace GiuaKy_C_
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<TaiLieu> taiLieus = new List<TaiLieu>
			{
				new Sach{MaXuatBan=1,TenTaiLieu="ABC",NhaPhatHanh="ABC",DanhMuc=1,SoTrang=100,TenTacGia="ABC"},
				new TapChi{MaXuatBan=2,TenTaiLieu="DEF",NhaPhatHanh="DEF",DanhMuc=2,SoPhatHanh=2,TrangPhatHanh="DEF"},
				new Bao{MaXuatBan=3,TenTaiLieu="XYZ",NhaPhatHanh="XYZ",DanhMuc=3,NgayPhatHanh=new DateTime(2024,3,10)},
				new Bao{MaXuatBan=4,TenTaiLieu="XYZIK",NhaPhatHanh="XYZ",DanhMuc=3,NgayPhatHanh=new DateTime(2024,4,10)},
			};

			foreach(var i in taiLieus)
                Console.WriteLine(i.MaXuatBan+","+i.TenTaiLieu+","+i.NhaPhatHanh+","+i.DanhMuc);


			Console.WriteLine("Tim kiem 1.Sach \t2.TapChi\t3.Bao");
			int key = Int16.Parse(Console.ReadLine());

			var x = taiLieus.Where(x => x.DanhMuc == key);

			foreach (var y in x)
				Console.WriteLine(y.MaXuatBan + "," + y.TenTaiLieu + "," + y.NhaPhatHanh + "," + y.DanhMuc);

			var nam = taiLieus.Where(x => x.DanhMuc == 3).Where(x => ((Bao)x).NgayPhatHanh.Month == 3).Where(x => ((Bao)x).NgayPhatHanh.Year == 2024);

			foreach(var y in nam)
				Console.WriteLine(y.MaXuatBan + "," + y.TenTaiLieu + "," + y.NhaPhatHanh + "," + y.DanhMuc+","+((Bao)y).NgayPhatHanh);


		}
	}
}
