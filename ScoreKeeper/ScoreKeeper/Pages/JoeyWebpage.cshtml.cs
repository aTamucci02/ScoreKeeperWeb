using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ScoreKeeper.Pages
{
    public class JoeyWebpageModel : PageModel
    {
        private readonly ILogger<JoeyWebpageModel> _logger;

        public JoeyWebpageModel(ILogger<JoeyWebpageModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
