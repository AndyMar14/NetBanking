using NetBanking.Core.Application.DTOs.Email;
using NetBanking.Core.Domain.Settings;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.Interfaces.Services
{
    public interface IEmailServices
    {
        public MailSettings _mailSettings { get; }
        Task SendAsync(EmailRequest request);
    }
}
