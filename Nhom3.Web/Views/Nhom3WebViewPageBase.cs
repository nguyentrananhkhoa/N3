using Abp.Web.Mvc.Views;

namespace Nhom3.Web.Views
{
    public abstract class Nhom3WebViewPageBase : Nhom3WebViewPageBase<dynamic>
    {

    }

    public abstract class Nhom3WebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected Nhom3WebViewPageBase()
        {
            LocalizationSourceName = Nhom3Consts.LocalizationSourceName;
        }
    }
}