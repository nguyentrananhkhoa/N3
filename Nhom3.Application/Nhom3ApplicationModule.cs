using System.Reflection;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Modules;
using Nhom3.Authorization.Roles;
using Nhom3.Authorization.Users;
using Nhom3.MatHangs.DTO;
using Nhom3.Models;
using Nhom3.Roles.Dto;
using Nhom3.Users.Dto;

namespace Nhom3
{
    [DependsOn(typeof(Nhom3CoreModule), typeof(AbpAutoMapperModule))]
    public class Nhom3ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
            {
                #region Create
                mapper.CreateMap<CreateMatHangInput, MatHang>().ReverseMap();
                mapper.CreateMap<MatHang, GetMatHangOutput>().ReverseMap();
                mapper.CreateMap<UpdateMatHangInput, MatHang>().ReverseMap();
                mapper.CreateMap<MatHang, GetMatHangOutput>().ReverseMap();
                #endregion
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            // TODO: Is there somewhere else to store these, with the dto classes
            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                // Role and permission
                cfg.CreateMap<Permission, string>().ConvertUsing(r => r.Name);
                cfg.CreateMap<RolePermissionSetting, string>().ConvertUsing(r => r.Name);

                cfg.CreateMap<CreateRoleDto, Role>().ForMember(x => x.Permissions, opt => opt.Ignore());
                cfg.CreateMap<RoleDto, Role>().ForMember(x => x.Permissions, opt => opt.Ignore());
                
                cfg.CreateMap<UserDto, User>();
                cfg.CreateMap<UserDto, User>().ForMember(x => x.Roles, opt => opt.Ignore());

                cfg.CreateMap<CreateUserDto, User>();
                cfg.CreateMap<CreateUserDto, User>().ForMember(x => x.Roles, opt => opt.Ignore());
            });
        }
    }
}
