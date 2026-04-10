using NewsS.Models;
using System.Text;

namespace NewsS.Services
{
    public class CsvExporter
    {
        public void Export(List<NewsItem> items, string path)
        {
            var sb = new StringBuilder();

            sb.AppendLine("title,Summary,Url,PublishedAt");

            foreach(var n in items)
            {
                sb.AppendLine(
                    $"\"{n.Title}\"," +
                    $"\"{n.Summary}\"," +
                    $"\"{n.Url}\"," +
                    $"\"{n.PublishedAt:yyyy-MM-dd HH:mm}\""
                    );
            }

            File.WriteAllText(path, sb.ToString(), Encoding.UTF8);
        }
    }
}
