namespace CourtDecisionsDictionary.Model
{
    public class Judge
    {
        public int ID { get; private set; }
        public string SecondName { get; set; }
        public string FirstName { get; set; }
        public string FurName { get; set; }
        public int PostID { get; set; }
        public int CourtID { get; set; }
        public Post ItsPost => Controller.DB.AccessDB.GetPostData(PostID);
        public Court ItsCourt => Controller.DB.AccessDB.GetCourtData(CourtID);
        public string FullName => $"{SecondName} {FirstName} {FurName}";

        public Judge(int ID = 0)
        {
            this.ID = ID;
        }        
    }
}