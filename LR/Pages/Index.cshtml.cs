using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BinaryToDecimalApp.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string BinaryInput { get; set; }

        public string ResultMessage { get; set; }

        private bool IsTrue;

        public void OnPost()
        {
            if (IsBinaryNumber(BinaryInput))
            {
                IsTrue = true;
                int decimalValue = Convert.ToInt32(BinaryInput, 2);
                ResultMessage = $"Binary: {BinaryInput} -> Decimal: {decimalValue}";
            }
            else
            {
                IsTrue = true;
                ResultMessage = "Please enter a valid binary number (only 0 and 1 allowed).";
            }
        }

        private bool IsBinaryNumber(string binaryInput)
        {
            return !string.IsNullOrEmpty(binaryInput) && binaryInput.All(c => c == '0' || c == '1');
        }
    }
}
