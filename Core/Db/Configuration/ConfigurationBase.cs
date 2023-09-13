using Core.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Db.Configuration
{
    public abstract class ConfigurationBase<T> : IEntityTypeConfiguration<T> where T : Entity
    {
        public void Configure(EntityTypeBuilder<T> modelBuilder)
        {
            modelBuilder.Property(e => e.Id).ValueGeneratedOnAdd();
            modelBuilder.HasKey(e => e.Id);
            ConfigureEntity(modelBuilder);
        }

        protected abstract void ConfigureEntity(EntityTypeBuilder<T> builder);
    }
}
