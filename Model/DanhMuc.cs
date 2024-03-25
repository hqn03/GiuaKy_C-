using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKy_C_.Model
{
	internal class DanhMuc
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public static List<DanhMuc> GetDanhMucs()
		{
			return new List<DanhMuc>
			{
				new DanhMuc { Id = 1, Name = "Sach" },
				new DanhMuc { Id = 2, Name = "Tap chi" },
				new DanhMuc { Id = 3, Name = "Bao" },
			};
		}
	}
}
