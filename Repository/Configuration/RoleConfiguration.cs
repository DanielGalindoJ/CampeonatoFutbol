using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(

                new IdentityRole
                {
                    Name = "Administrador",
                    NormalizedName = "ADMINISTRADOR"
                },
                 new IdentityRole
                 {
                     Name = "Tecnico",
                     NormalizedName = "TECNICO"
                 },
                  new IdentityRole
                  {
                      Name = "Jugador",
                      NormalizedName = "JUGADOR"
                  },
                  new IdentityRole
                  {
                      Name = "Espectador",
                      NormalizedName = "ESPECTADOR"
                  }
            );
        }
    }
}
