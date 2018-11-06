using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace Nhom3.Models
{
    public class KhachHang: FullAuditedEntity
    {
        [Key]
        public int MaKH { get; set; }
        public string TenKh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
    }
}
