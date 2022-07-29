using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetBanking.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Infrastructure.Persistence.Mapping
{
    public class RecipientsMap : IEntityTypeConfiguration<Recipients>
    {
        public void Configure(EntityTypeBuilder<Recipients> builder)
        {
            builder.ToTable("Recipients")
                .HasKey(p => p.Id);
        }
    }
}
