using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace LogNLog.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;

		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;

			_logger.LogTrace("Trace で出力します。");
			_logger.LogDebug("Debug で出力します。");
			_logger.LogInformation("Information で出力します。");
			_logger.LogWarning("Warning で出力します。");
			_logger.LogError("Error で出力します。");
			_logger.LogCritical("Critical で出力します。");

			_logger.LogInformation(1, "EventID ありで出力します。");
		}

		public void OnGet()
		{
			_logger.LogInformation("ページを表示するタイミングでログを出力します。");
		}
	}
}
