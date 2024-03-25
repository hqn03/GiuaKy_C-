using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKy_C_.Model
{
	internal class TapChi : TaiLieu
	{
		public int SoPhatHanh {  get; set; }
		public string TrangPhatHanh { get; set; }
		public TapChi() { }

		public TapChi(int maXuatBan, string tenTaiLieu, string nhaPhatHanh, int danhMuc, int soPhatHanh, string trangPhatHanh) : base(maXuatBan, tenTaiLieu, nhaPhatHanh, danhMuc)
		{
			SoPhatHanh = soPhatHanh;
			TrangPhatHanh = trangPhatHanh;
		}
	}
}
