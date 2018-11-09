using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom3.Models
{
    public class MatHangManager: DomainService,IMatHangManager
    {
        private readonly IRepository<MatHang> _repositoryMatHang;
        public MatHangManager(IRepository<MatHang> repositoryMatHang)
        {
            _repositoryMatHang = repositoryMatHang;
        }
        public IEnumerable<MatHang> GetAllList()
        {
            return _repositoryMatHang.GetAll();
        }

        public MatHang GetMatHangById(int MaMH)
        {
            //var maMH = _repositoryMatHang.FirstOrDefault(x => x.MaMH == id);
            return _repositoryMatHang.Get(MaMH);
        }

        public async Task<MatHang> Create(MatHang enttity)
        {
            var mathang = _repositoryMatHang.FirstOrDefault(x => x.MaMH == enttity.MaMH);
            if(mathang!=null)
            {
                throw new UserFriendlyException("Mat hang da ton tai");
            }
            return await _repositoryMatHang.InsertAsync(enttity);
        }

        public void Update(MatHang enitity)
        {
            _repositoryMatHang.Update(enitity);
        }

        public void Delete(int id)
        {
            var mathang = _repositoryMatHang.FirstOrDefault(x => x.MaMH == id);
            if(mathang==null)
            {
                throw new UserFriendlyException("Khong co du lieu");
            }
            _repositoryMatHang.Delete(mathang);
        }

       
    }
}
