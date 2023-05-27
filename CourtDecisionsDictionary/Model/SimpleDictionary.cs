namespace CourtDecisionsDictionary.Model
{
    public class SimpleDictionary
    {
        public int ID { get; private set; }
        public string Name { get; set; }

        public SimpleDictionary(int ID)
        {
            this.ID = ID;
        }
    }

    public class Post : SimpleDictionary { public Post(int ID) : base(ID) { } }
    public class Region : SimpleDictionary { public Region(int ID) : base(ID) { } }
    public class LawArticle : SimpleDictionary { public LawArticle(int ID) : base(ID) { } }
    public class DecisionType : SimpleDictionary { public DecisionType(int ID) : base(ID) { } }
    public class DocumentType : SimpleDictionary { public DocumentType(int ID) : base(ID) { } }
}