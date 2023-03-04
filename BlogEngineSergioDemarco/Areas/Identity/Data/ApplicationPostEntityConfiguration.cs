using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogEngineSergioDemarco.Areas.Identity.Data
{
    public class ApplicationPostEntityConfiguration : IEntityTypeConfiguration<ApplicationPost>
    {
        public void Configure(EntityTypeBuilder<ApplicationPost> builder)
        {
            builder.Property(u => u.Name).HasMaxLength(255);
        }
    }
}
