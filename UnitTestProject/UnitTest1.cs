using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestSearch_Case_1()
        {
            // Test values
            string filter_region = "калининград";
            string filter_court = "Светловский";

            // True answer (expected)
            string answer = "5-571/2017";

            // Create object and test method
            CourtDecisionsDictionary.View.ClientForm cf =
               new CourtDecisionsDictionary.View.ClientForm();
            List<CourtDecisionsDictionary.Model.Document> docs =
                cf.GetDocumentsByUserQuery("", filter_court, "", filter_region, "");

            // Response answer
            string response = docs.Count > 0 ? docs[0].DecisionNumber : string.Empty;

            // Results of test:
            // .. - номер найденного судебного решения
            Assert.AreEqual(answer, response);
            // .. - должно быть найдено только одно решение
            Assert.AreEqual(1, docs.Count);
        }

        [TestMethod]
        public void TestSearch_Case_2()
        {
            // Test values
            string filter_number = "5-";
            string filter_judge_sname = "Мальцева";
            string filter_article = "коап";

            // True answer (expected)
            string answer = "5-211/2017";

            // Create object and test method
            CourtDecisionsDictionary.View.ClientForm cf =
               new CourtDecisionsDictionary.View.ClientForm();
            List<CourtDecisionsDictionary.Model.Document> docs =
                cf.GetDocumentsByUserQuery(filter_number, "", filter_judge_sname, "", filter_article);

            // Response answer
            string response = docs.Count > 0 ? docs[0].DecisionNumber : string.Empty;

            // Results of test:
            // .. - номер найденного судебного решения
            Assert.AreEqual(answer, response);
            // .. - должно быть найдено только одно решение
            Assert.AreEqual(1, docs.Count);
        }
    }
}