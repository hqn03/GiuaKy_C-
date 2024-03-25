using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKy_C_.Model
{
	internal class Sach : TaiLieu
	{
		public string TenTacGia {get; set;}
		public int SoTrang { get; set;}
		public Sach() { }

		public Sach(int maXuatBan, string tenTaiLieu, string nhaPhatHanh, int danhMuc, string tenTacGia, int soTrang) : base(maXuatBan, tenTaiLieu, nhaPhatHanh, danhMuc)
		{
			TenTacGia = tenTacGia;
			SoTrang = soTrang;
		}
	}
}
