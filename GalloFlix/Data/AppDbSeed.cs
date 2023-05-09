using GalloFlix.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GalloFlix.Data;

    public class AppDbSeed
    {

        public AppDbSeed(ModelBuilder builder)
        {

            #region Populate Roles - Perfis de Usuário
            List<IdentityRole> roles = new()
            {
                new IdentityRole()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Administrator",
                    NormalizedName ="ADMINISTRADOR"
                },

                 new IdentityRole()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Moderador",
                    NormalizedName ="MODERADOR"
                },

                 new IdentityRole()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Usuário",
                    NormalizedName ="USUÁRIO"
                }
            };
            builder.Entity<IdentityRole>().HasData(roles);
            #endregion
            
            #region Popular AppUser - Usuários

            List<AppUser> users = new() {
                new AppUser() {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Marina Porfirio",
                    DateOfBirth = DateTime.Parse("20/06/2006"),
                    Email = "marinaporfirio11@gmail.com",
                    NormalizedEmail = "MARINAPORFIRIO11@GMAIL.COM",
                    UserName = "MarinaMunhoz",
                    NormalizedUserName = "MARINAMUNHOZ",
                    LockoutEnabled = false,
                    PhoneNumber = "14998091305",
                    PhoneNumberConfirmed = true,
                    EmailConfirmed = true,
                    ProfilePicture = "/img/users/avatar.png"
                }
            };
            foreach (var user in users)
            {
                PasswordHasher<AppUser> pass = new();
                user.PasswordHash = pass.HashPassword(user, "@Etec123");
            };
            builder.Entity<AppUser>().HasData(users);
            #endregion
            
            #region Populate UserRole - Usuário com Perfil
            List<IdentityUserRole<string>> userRoles = new()
            {
                new IdentityUserRole<string>() {
                    UserId = users[0].Id,
                    RoleId = roles[0].Id
                }
            };
            builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
            #endregion
        }
        
    }