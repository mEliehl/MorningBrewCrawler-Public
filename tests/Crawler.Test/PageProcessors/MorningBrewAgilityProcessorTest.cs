using System.Collections.Generic;
using Crawler.Entities;
using Crawler.PageProcessors;

namespace Crawler.Test.PageProcessors
{
    public class MorningBrewAgilityProcessorTest : MorningBrewProcessorTest
    {
        protected override IEnumerable<Article> GetArticles(string page)
        {
            IMorningBrewProcessor processor = new MorningBrewAgility();
            return processor.Map(page);
        }
    }
}