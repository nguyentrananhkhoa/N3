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
    public class MatHang: FullAuditedEntity
    {
        [Key]
        public int MaMH { get; set; }
        public string TenMH { get; set; }
        public int SL { get; set; }
    }
}
