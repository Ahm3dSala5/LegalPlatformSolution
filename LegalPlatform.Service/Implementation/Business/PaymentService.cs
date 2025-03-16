using LegalPlatform.Infrastructure.Domain.DTOs.Payment;
using LegalPlatform.Infrastructure.Domain.Entity.Business;
using LegalPlatform.Infrastructure.Persistence.Context;
using LegalPlatform.Infrastructure.Repository;
using LegalPlatform.Service.Abstraction.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LegalPlatform.Service.Implementation.Business
{
    public class PaymentService : MainRepository<Payment>, IPaymentService
    {
        private readonly LegalPlatformContext _context;

        public PaymentService(LegalPlatformContext context, IConfiguration config) : base(context, config)
        {
            this._context = context;
        }

        public async ValueTask<string> EditPaymentAsync(EditPaymentDTO payment)
        {
            var _payment = await _context.Payments.SingleOrDefaultAsync(x => x.Id == payment.Id);
            if (_payment == null)
                return "PaymentNotFound";

            var reciever = await _context.Users.SingleOrDefaultAsync(x => x.Id == payment.TO);
            if (reciever == null)
                return "RecieverNotFound";

            var sender = await _context.Users.SingleOrDefaultAsync(x => x.Id == payment.From);
            if (sender == null)
                return "SenderNotFound";

            int transactionOperation = 0;
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                if (sender.Balance < payment.Amount)
                    return "UserNotHaveEnoughMoney";

                reciever.Balance += payment.Amount;
                sender.Balance -= payment.Amount;
                await transaction.CommitAsync();
                transactionOperation = await _context.SaveChangesAsync();
                if (transactionOperation > 0)
                {
                    _context.Entry(_payment).CurrentValues.SetValues(payment);
                    transactionOperation = 0;
                    _context.Payments.Update(_payment);
                    transactionOperation = await _context.SaveChangesAsync();
                }
            }
            return transactionOperation > 0 ? "Successfully" : "Invalid";
        }

        public async ValueTask<string> StartPaymentAsync(StartPaymentDTO payment)
        {
            var reciever = await _context.Users.SingleOrDefaultAsync(x => x.Id == payment.TO);
            if (reciever == null)
                return "RecieverNotFound";

            var sender = await _context.Users.SingleOrDefaultAsync(x => x.Id == payment.From);
            if (sender == null)
                return "SenderNotFound";

            int transactionOperation = 0;
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                if (sender.Balance < payment.Amount)
                    return "UserNotHaveEnoughMoney";

                reciever.Balance += payment.Amount;
                sender.Balance -= payment.Amount;
                await transaction.CommitAsync();

                transactionOperation = await _context.SaveChangesAsync();
                if (transactionOperation > 0)
                {
                    Payment _payment = new Payment()
                    {
                        Amount = payment.Amount,
                        Reciever = payment.TO,
                        Sender = payment.From
                    };
                    transactionOperation = 0;
                    await _context.Payments.AddAsync(_payment);
                    transactionOperation = await _context.SaveChangesAsync();
                }

                return transactionOperation > 0 ? "Successfully" : "Invalid";
            }
        }
    }
}
