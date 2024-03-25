using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKy_C_.Model
{
	internal class Bao : TaiLieu
	{
		public DateTime NgayPhatHanh {  get; set; }
		public Bao() {
		}

		public Bao(int maXuatBan, string tenTaiLieu, string nhaPhatHanh, int danhMuc, DateTime ngayPhatHanh) : base (maXuatBan, tenTaiLieu, nhaPhatHanh, danhMuc)
		{
			NgayPhatHanh = ngayPhatHanh;
		}
	}
}
