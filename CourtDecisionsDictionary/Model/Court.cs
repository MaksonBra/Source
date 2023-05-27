namespace CourtDecisionsDictionary.Model
{
    public class Court
    {
        public int ID { get; private set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string President { get; set; }
        public string Site { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public int RegionID { get; set; }
        public Region ItsRegion => Controller.DB.AccessDB.GetRegionData(RegionID);

        public Court(int ID = 0)
        {
            this.ID = ID;
        }
    }
}