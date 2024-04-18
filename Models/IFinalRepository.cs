namespace _413FinalLarson.Models
{
    public interface IFinalRepository
    {
        public IQueryable<Entertainer> Entertainers { get; }
        public void UpdateEntertainer(Entertainer entertainer);
        public void DeleteEntertainer(Entertainer entertainer);
        public void AddEntertainer(Entertainer entertainer);
    }
}
