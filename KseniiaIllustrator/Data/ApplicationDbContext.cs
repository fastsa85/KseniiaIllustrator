using KseniiaIllustrator.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KseniiaIllustrator.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            //seed projects
            modelBuilder.Entity<Project>().HasData(new Project 
            { 
                Id = new Guid("d92700e2-f499-4666-aed9-7510e8383280"),
                Title = "Wednesday with Goddard",
                PreviewDescription = "Nicolas Ménard",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            });

            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = new Guid("a68946b5-bd95-469f-98c6-e39aff9adf5a"),
                Title = "Stephen Kelleher",
                PreviewDescription = "Offset",
                LongDescription = "Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur?"
            });

            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = new Guid("7d330015-bfe2-48af-b782-97ba13045046"),                
                Title = "Rigging Academy",
                PreviewDescription = "Lorem ipsur",
                LongDescription = "At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga."
            });

            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = new Guid("4a4630d2-d4f5-4bcc-9d7e-947e68e6a8eb"),                
                Title = "School of Motion",
                PreviewDescription = "Buck",
                LongDescription = "Et harum quidem rerum facilis est et expedita distinctio. Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat facere possimus, omnis voluptas assumenda est, omnis dolor repellendus. Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores repellat."
            });

            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = new Guid("e2ad5278-9cc4-4e39-9873-fb9ab81f3fdf"),                
                Title = "First Step",
                PreviewDescription = "Hive",
                LongDescription = "Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?"
            });

            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = new Guid("0b858d26-0984-4826-bb79-a8662ba8711f"),                
                Title = "Adventure Time",
                PreviewDescription = "Lorem ipsur",
                LongDescription = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            });

            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = new Guid("decc314a-c815-4654-ba6e-7e18c2b96a32"),                
                Title = "World Basketball Festival",
                PreviewDescription = "Cupidatat qui officia",
                LongDescription = "Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem."
            });

            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = new Guid("46f3a4e2-ebfa-47a8-ad19-9c9cff51207e"),                
                Title = "I'm Fine Thanks",
                PreviewDescription = "Factory Nemo enim",
                LongDescription = "But in certain circumstances and owing to the claims of duty or the obligations of business it will frequently occur that pleasures have to be repudiated and annoyances accepted. The wise man therefore always holds in these matters to this principle of selection: he rejects pleasures to secure other greater pleasures, or else he endures pains to avoid worse pains."
            });

            //seed images
            modelBuilder.Entity<Image>().HasData(new Image
            {
                Id = new Guid("16f3a4e2-ebfa-47a8-ad19-9c9cff51207e"),
                ProjectId = new Guid("d92700e2-f499-4666-aed9-7510e8383280"),
                IsThumbnail = true,
                FileName = "./images/project1.jpg",
                Description = "Sed odio morbi quis commodo odio aenean sed. Volutpat ac tincidunt vitae semper quis lectus. Pellentesque dignissim enim sit amet venenatis urna cursus eget."
            });

            modelBuilder.Entity<Image>().HasData(new Image
            {
                Id = new Guid("2aea7b9b-9243-4065-b2d4-71d58a5485a6"),
                ProjectId = new Guid("a68946b5-bd95-469f-98c6-e39aff9adf5a"),
                IsThumbnail = true,
                FileName = "./images/project2.jpg",
                Description = "Pellentesque habitant morbi tristique senectus. Eu facilisis sed odio morbi quis commodo."
            });

            modelBuilder.Entity<Image>().HasData(new Image
            {
                Id = new Guid("3a8d3c60-65dc-471c-ae54-d5cdfd843e74"),
                ProjectId = new Guid("7d330015-bfe2-48af-b782-97ba13045046"),
                IsThumbnail = true,
                FileName = "./images/project3.jpg",
                Description = "Nisi lacus sed viverra tellus in. Velit egestas dui id ornare. Pellentesque habitant morbi tristique senectus et netus. Porttitor leo a diam sollicitudin tempor id eu."
            });

            modelBuilder.Entity<Image>().HasData(new Image
            {
                Id = new Guid("4a4630d2-d4f5-4bcc-9d7e-947e68e6a8eb"),
                ProjectId = new Guid("4a4630d2-d4f5-4bcc-9d7e-947e68e6a8eb"),
                IsThumbnail = true,
                FileName = "./images/project4.gif",
                Description = "Pretium nibh ipsum consequat nisl vel pretium lectus quam."
            });

            modelBuilder.Entity<Image>().HasData(new Image
            {
                Id = new Guid("5a8d3c60-65dc-471c-ae54-d5cdfd843e74"),
                ProjectId = new Guid("e2ad5278-9cc4-4e39-9873-fb9ab81f3fdf"),
                IsThumbnail = true,
                FileName = "./images/project5.jpg",
                Description = "Neque volutpat ac tincidunt vitae semper quis lectus. Euismod quis viverra nibh cras."
            });

            modelBuilder.Entity<Image>().HasData(new Image
            {
                Id = new Guid("6a8d3c60-65dc-471c-ae54-d5cdfd843e74"),
                ProjectId = new Guid("0b858d26-0984-4826-bb79-a8662ba8711f"),
                IsThumbnail = true,
                FileName = "./images/project6.gif",
                Description = "Quam id leo in vitae turpis massa. Orci phasellus egestas tellus rutrum tellus pellentesque eu tincidunt."
            });

            modelBuilder.Entity<Image>().HasData(new Image
            {
                Id = new Guid("7ab8871c-52ed-4c04-8a17-dc31bca1a805"),
                ProjectId = new Guid("decc314a-c815-4654-ba6e-7e18c2b96a32"),
                IsThumbnail = true,
                FileName = "./images/project7.jpg",
                Description = "Viverra justo nec ultrices dui."
            });

            modelBuilder.Entity<Image>().HasData(new Image
            {
                Id = new Guid("86f3a4e2-ebfa-47a8-ad19-9c9cff51207e"),
                ProjectId = new Guid("46f3a4e2-ebfa-47a8-ad19-9c9cff51207e"),
                IsThumbnail = true,
                FileName = "./images/project8.jpg",
                Description = "Tincidunt vitae semper quis lectus nulla at volutpat diam. Eget nunc scelerisque viverra mauris in aliquam sem."
            });
        }
    }
}