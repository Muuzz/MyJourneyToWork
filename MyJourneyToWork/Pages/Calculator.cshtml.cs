using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyJourneyToWork.Pages
{
    [ExcludeFromCodeCoverage]
    public class CalculatorModel : PageModel
    {
        [ExcludeFromCodeCoverage]
        [BindProperty]      // bound on POST request
        public Calculator.Calculator calculator { get; set; }

        [ExcludeFromCodeCoverage]
        public void OnGet()
        {
        }
    }
}
