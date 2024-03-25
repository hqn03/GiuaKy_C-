using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKy_C_.Model
{
	internal class TaiLieu
	{
		public int MaXuatBan {  get; set; }
		public string TenTaiLieu { get; set; }
		public string NhaPhatHanh {  get; set; }
		public int DanhMuc {  get; set; }
		public TaiLieu() { }
		public TaiLieu(int maXuatBan, string tenTaiLieu, string nhaPhatHanh, int danhMuc)
		{
			MaXuatBan = maXuatBan;
			TenTaiLieu = tenTaiLieu;
			NhaPhatHanh = nhaPhatHanh;
			DanhMuc = danhMuc;
		}
	}
}
