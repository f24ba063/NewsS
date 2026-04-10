using Microsoft.AspNetCore.Mvc;
using NewsS.Models;
using NewsS.Services;
using System;
using System.Reflection;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Timers;
using static System.Net.WebRequestMethods;

namespace NewsS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewsController :ControllerBase
	{
        private readonly CsvExporter _csvExporter;
        public NewsController(CsvExporter c)
        {
            _csvExporter = c;
        }

       [HttpGet]
		public IActionResult Get()
		{
			var data = new List<NewsItem>
			{
					new NewsItem
                    {
                        Title = "テスト１",
                        Summary  ="要約１",
                        Url = "https://example.com",
                        PublishedAt = DateTime.Now
                    },
                    new NewsItem
                    {
                        Title = "テスト2",
                        Summary  ="要約2",
                        Url = "https://example2.com",
                        PublishedAt = DateTime.Now
                    },
                   new NewsItem
                        {
                        Title = "テスト3",
                        Summary  ="要約3",
                        Url = "https://example3.com",
                        PublishedAt = DateTime.Now
                    }
            };

            _csvExporter.Export(data, "test.csv");
			return Ok(data);
        }
	}
}