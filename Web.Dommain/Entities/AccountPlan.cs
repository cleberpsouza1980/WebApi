namespace Web.Dommain.Entities
{
    public class AccountPlan
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public bool AcceptsLaunches { get; set; }
        public int? ParentId { get; set; }
    }
}
