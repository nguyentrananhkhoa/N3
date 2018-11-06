using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom3.Models
{
    public interface IMatHangManager: IDomainService
    {
        IEnumerable<MatHang> GetAllList();
        MatHang GetMatHangById(int id);
        Task<MatHang> Create(MatHang enttity);
        void Update(MatHang enitity);
        void Delete(int id);
    }
}
