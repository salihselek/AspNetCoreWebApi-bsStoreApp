using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.EFCore.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();

            builder.HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Computer Science"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Network"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Database Management Systems"
                }
            );
        }
    }
}