using LegalPlatform.Infrastructure.Domain.Entity.Business;
using LegalPlatform.Infrastructure.Domain.Entity.Security;
using LegalPlatform.Infrastructure.Domain.Enum;

namespace LegalPlatform.Infrastructure.Persistence.DataSeed
{
    public static class DataSeeder
    {
        public static (
            List<LegalUser> Users,
            List<Payment> Payments,
            List<Articale> Articles,
            List<Comment> Comments,
            List<Appointment> Appointments
        ) Seeder()
        {
            var user1 = new LegalUser
            {
                Id = Guid.NewGuid(),
                UserName = "john_doe",
                NormalizedUserName = "JOHN_DOE",
                Email = "john.doe@example.com",
                NormalizedEmail = "JOHN.DOE@EXAMPLE.COM",
                EmailConfirmed = true,
                PhoneNumber = "1234567890",
                PhoneNumberConfirmed = true,
                Address = "123 Main St, New York, NY",
                Balance = 500.75m
            };

            var user2 = new LegalUser
            {
                Id = Guid.NewGuid(),
                UserName = "jane_smith",
                NormalizedUserName = "JANE_SMITH",
                Email = "jane.smith@example.com",
                NormalizedEmail = "JANE.SMITH@EXAMPLE.COM",
                EmailConfirmed = true,
                PhoneNumber = "0987654321",
                PhoneNumberConfirmed = true,
                Address = "456 Elm St, Los Angeles, CA",
                Balance = 1200.50m
            };

            var users = new List<LegalUser> { user1, user2 };

            // Create articles
            var article1 = new Articale
            {
                Id = Guid.NewGuid(),
                Title = "Legal Insights",
                Content = "Content of legal insights article.",
                UserId = user1.Id
            };

            var article2 = new Articale
            {
                Id = Guid.NewGuid(),
                Title = "Understanding Legal Policies",
                Content = "Content of legal policies article.",
                UserId = user2.Id
            };

            var articles = new List<Articale> { article1, article2 };

            // Create comments referencing existing articles
            var comments = new List<Comment>
            {
                new Comment
                {
                    Id = Guid.NewGuid(),
                    Text = "Great article!",
                    AddedAt = DateTime.UtcNow,
                    UserId = user1.Id,
                    ArticaleId = article1.Id
                },
                new Comment
                {
                    Id = Guid.NewGuid(),
                    Text = "Very informative!",
                    AddedAt = DateTime.UtcNow,
                    UserId = user2.Id,
                    ArticaleId = article2.Id
                }
            };

            // Create payments
            var payments = new List<Payment>
            {
                new Payment
                {
                    Id = Guid.NewGuid(),
                    PaymentDate = DateTime.UtcNow,
                    Amount = 250.00m,
                    Sender = user1.Id,
                    Reciever = user2.Id,
                    UserId = user1.Id
                },
                new Payment
                {
                    Id = Guid.NewGuid(),
                    PaymentDate = DateTime.UtcNow.AddDays(-5),
                    Amount = 100.00m,
                    Sender = user2.Id,
                    Reciever = user1.Id,
                    UserId = user2.Id
                }
            };

            var appointment1 = new Appointment
            {
                Id = Guid.NewGuid(),
                Note = "Consultation for legal advice.",
                Date = DateTime.UtcNow.AddDays(7),
                UserId = user1.Id ,
                Status = AppointmentStatus.Pending
            };

            var appointment2 = new Appointment()
            {
                Id = Guid.NewGuid(),
                Note = "Consultation for legal advice.",
                Date = DateTime.UtcNow.AddDays(3),
                UserId = user2.Id,
                Status = AppointmentStatus.Completed
            };

            var appointments = new List<Appointment>()
            {
                appointment1,
                appointment2
            };

            return (users, payments, articles, comments, appointments);
        }
    }
}
