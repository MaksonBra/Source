using System;

namespace CourtDecisionsDictionary.Model
{
    public class Document
    {
        public int ID { get; private set; }
        public string DecisionNumber { get; set; }
        public DateTime Date { get; set; }
        public string ContentFileName { get; set; }
        public int DecisionTypeID { get; set; }
        public int DocumentTypeID { get; set; }
        public int CourtID { get; set; }
        public int JudgeID { get; set; }
        public int LawArticleID { get; set; }
        public Judge ItsJudge => Controller.DB.AccessDB.GetJudgeData(JudgeID);
        public Court ItsCourt => Controller.DB.AccessDB.GetCourtData(CourtID);
        public LawArticle ItsLawArticle => Controller.DB.AccessDB.GetLawArticleData(LawArticleID);
        public DocumentType ItsDocumentType => Controller.DB.AccessDB.GetDocumentTypeData(DocumentTypeID);
        public DecisionType ItsDecisionType => Controller.DB.AccessDB.GetDecisionTypeData(DecisionTypeID);

        public Document(int ID = 0)
        {
            this.ID = ID;
        }


        public static Document CurrentDocument = null; 
    }
}