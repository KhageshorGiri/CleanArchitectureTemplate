using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketManagement.Application.Contracts.Infrastructure;

namespace TricketManagement.Infrastructure.MailServiceProvider;

public class EmailService : IEmailService
{
    public Task<bool> SendEmailAsync(string to, string subject, string message)
    {
        throw new NotImplementedException();
    }
}
