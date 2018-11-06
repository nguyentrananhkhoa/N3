using Abp.Application.Services;
using Nhom3.MatHangs.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using Nhom3.Models;
using Nhom3.MatHangs.DTO;

namespace Nhom3.MatHangs
{
    public class MatHangAppService : ApplicationService, IMatHangAppService
    {
        private readonly IMatHangManager _mathangManager;
        public MatHangAppService(IMatHangManager mathangManager)
        {
            _mathangManager = mathangManager;
        }
        public async Task Create(CreateMatHangInput input)
        {
            MatHang output = Mapper.Map<CreateMatHangInput, MatHang>(input);
            await _mathangManager.Create(output); 
        }

        public void Delete(DeleteMatHangInput input)
        {
            _mathangManager.Delete(input.MaMH);
        }

        public GetMatHangOutput GetMatHangById(GetMatHangInput input)
        {
            var getMatHang = _mathangManager.GetMatHangById(input.MaMH);
            GetMatHangOutput output = Mapper.Map<MatHang, GetMatHangOutput>(getMatHang);
            return output;
        }

        public IEnumerable<GetMatHangOutput> ListAll()
        {
            var getAll = _mathangManager.GetAllList().ToList();
            List<GetMatHangOutput> output = Mapper.Map<List<MatHang>, List<GetMatHangOutput>>(getAll);
            return output;
        }

        public void Update(UpdateMatHangInput input)
        {
            MatHang output = Mapper.Map<UpdateMatHangInput, MatHang>(input);
            _mathangManager.Update(output);
        }

        
    }
}
