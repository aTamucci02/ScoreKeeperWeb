using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ScoreKeeper.Pages
{
    public class TestWebpageModel : PageModel
    {
        private readonly ILogger<TestWebpageModel> _logger;

        public TestWebpageModel(ILogger<TestWebpageModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
