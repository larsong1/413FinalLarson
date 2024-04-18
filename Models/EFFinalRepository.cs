namespace _413FinalLarson.Models
{
    public class EFFinalRepository : IFinalRepository
    {
        private FinalContext _context;
        public EFFinalRepository(FinalContext temp) {
            _context = temp;
        }
        public IQueryable<Entertainer> Entertainers => _context.Entertainers;

        public void UpdateEntertainer(Entertainer ent)
        {
            _context.Update(ent);
            _context.SaveChanges();
        }
        public void DeleteEntertainer(Entertainer ent)
        {
            _context.Entertainers.Remove(ent);
            _context.SaveChanges();
        }
        public void AddEntertainer(Entertainer ent)
        {
            _context.Entertainers.Add(ent);
            _context.SaveChanges();
        }
    }
}
