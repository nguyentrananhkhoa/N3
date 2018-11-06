using Abp.Application.Services;
using Nhom3.MatHangs.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom3.MatHangs
{
    public interface IMatHangAppService: IApplicationService
    {
        IEnumerable<GetMatHangOutput> ListAll();
        Task Create(CreateMatHangInput input);
        void Update(UpdateMatHangInput input);
        void Delete(DeleteMatHangInput input);
        GetMatHangOutput GetMatHangById(GetMatHangInput input);
    }
}
