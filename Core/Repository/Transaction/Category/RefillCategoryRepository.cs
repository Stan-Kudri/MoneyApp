using Core.Components.Transaction.Category;
using Core.Db;

namespace Core.Repository.Transaction.Category
{
    public class RefillCategoryRepository
    {
        private readonly AppDbContext _db;

        public RefillCategoryRepository(AppDbContext dbContext) => _db = dbContext;

        public void Add(RefillCategory category)
        {
            var wallet = _db.Refills.FirstOrDefault(e => e.Name == category.Name);

            if (wallet != null)
            {
                return;
            }

            _db.Refills.Add(category);
            _db.SaveChanges();
        }

        public void Remove(RefillCategory category)
        {
            var transaction = _db.Refills.FirstOrDefault(e => e.Id == category.Id);

            if (transaction == null)
            {
                return;
            }

            _db.Refills.Remove(category);
            _db.SaveChanges();
        }
    }
}
