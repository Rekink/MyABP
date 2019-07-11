using Abp.Web.Mvc.Views;

namespace MyABP.Web.Views
{
    public abstract class MyABPWebViewPageBase : MyABPWebViewPageBase<dynamic>
    {

    }

    public abstract class MyABPWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected MyABPWebViewPageBase()
        {
            LocalizationSourceName = MyABPConsts.LocalizationSourceName;
        }
    }
}