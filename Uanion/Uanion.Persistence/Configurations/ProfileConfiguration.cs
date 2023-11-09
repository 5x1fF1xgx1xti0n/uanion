using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uanion.Domain.Entities;

namespace Uanion.Persistence.Configurations;

internal class ProfileConfiguration : IEntityTypeConfiguration<Profile>
{
    public void Configure(EntityTypeBuilder<Profile> builder)
    {
        builder
            .ToTable("Profile")
            .HasKey(x => x.ProfileId);

        builder
            .HasOne(x => x.User)
            .WithOne(x => x.Profile)
            .HasForeignKey<Profile>(x => x.UserId)
            .IsRequired();
    }
}
