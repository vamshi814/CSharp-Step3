//using System.Runtime.InteropServices;
//using System.Threading.Tasks;

//[ApiController]
//[Route("api/dashboard")]
//public class DashboardController : ControllerBase
//{
//    private readonly IProductService _productService;
//    private readonly ICartService _cartService;
//    private readonly IRecommendationService _recommendationService;

//    public DashboardController(IProductService productService,
//                               ICartService cartService,
//                               IRecommendationService recommendationService)
//    {
//        _productService = productService;
//        _cartService = cartService;
//        _recommendationService = recommendationService;
//    }

//    [HttpGet("summary")]
//    public async Task<IActionResult> GetDashboardSummary(int userId)
//    {
//        // Fire all tasks concurrently
//        var productTask = _productService.GetTopProductsAsync();
//        var cartTask = _cartService.GetUserCartAsync(userId);
//        var recTask = _recommendationService.GetRecommendationsAsync(userId);

//        // Wait for all to complete
//        await Task.WhenAll(productTask, cartTask, recTask);

//        // Aggregate results
//        var response = new
//        {
//            TopProducts = productTask.Result,
//            Cart = cartTask.Result,
//            Recommendations = recTask.Result
//        };

//        return Ok(response);
//    }
//}