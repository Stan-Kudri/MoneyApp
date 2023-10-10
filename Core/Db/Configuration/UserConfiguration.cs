using Core.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Db.Configuration
{
    public class UserConfiguration : ConfigurationBase<User>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<User> builder)
        {
            builder.Property(e => e.Username).HasMaxLength(64).IsRequired();
            builder.Property(e => e.PasswordHash).HasMaxLength(64).IsRequired();
            builder.Property(e => e.Id).HasDefaultValue(Guid.NewGuid());
            builder.
                HasMany(e => e.Wallets).
                WithOne().
                HasForeignKey(e => e.UserId);
        }
    }
}
