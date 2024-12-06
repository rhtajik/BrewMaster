namespace BrewMaster.Models
{
    public class Machine
    {
        public int Id { get; set; }
        public string Place { get; set; }
        public DateTime LatestClean { get; set; }
        public DateTime LatestService { get; set; }
        public int AmountUsed { get; set; }
    }
}
