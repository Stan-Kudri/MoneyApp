using Core.Components.Transaction.Category;
using Core.Db;

namespace Core.Repository.Transaction.Category
{
    public class SpendingCategoryRepository
    {
        private readonly AppDbContext _db;

        public SpendingCategoryRepository(AppDbContext dbContext) => _db = dbContext;

        public void Add(SpendingCategory category)
        {
            var wallet = _db.Spendings.FirstOrDefault(e => e.Name == category.Name);

            if (wallet != null)
            {
                return;
            }

            _db.Spendings.Add(category);
            _db.SaveChanges();
        }

        public void Remove(SpendingCategory category)
        {
            var transaction = _db.Spendings.FirstOrDefault(e => e.Id == category.Id);

            if (transaction == null)
            {
                return;
            }

            _db.Spendings.Remove(category);
            _db.SaveChanges();
        }
    }
}
