using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Miniblog.Core.Services;

namespace Miniblog.Core.ViewComponents
{
    public class SidebarViewComponent:ViewComponent
    {

        private readonly IBlogService _blog;
        public SidebarViewComponent(IBlogService blog)
        {
            _blog = blog;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var posts = await _blog.GetPosts(7);
            return View( posts);
        }
    }
}
