using Application.Repository;
using Microsoft.EntityFrameworkCore;
using NetBanking.Core.Application.Interfaces.Repositories;
using NetBanking.Core.Application.ViewModels.Recipients;
using NetBanking.Core.Domain.Entities;
using NetBanking.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Infrastructure.Persistence.Repositories
{
    public class RecipientsRepository : GenericRepository<Recipients>, IRecipientsRepository
    {
        private readonly ApplicationContext _dbContext;
        public RecipientsRepository(ApplicationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<RecipientsViewModel>> GetRecipients(string id)
        {
            var recipients = await _dbContext.Set<Recipients>().Where(p => p.IdUser == id).Select(reci => new RecipientsViewModel { 
                IdUser = reci.IdUser,
                IdRecipient = reci.IdRecipient
            }).ToListAsync();


            return recipients;
        }

        public async Task<Recipients> GetRecipientsId(string Identifier, string User)
        {
            Recipients recipients = await _dbContext.Set<Recipients>()
                .FirstOrDefaultAsync(p => p.IdUser == User && p.IdRecipient == Identifier);

            return recipients;
        }
    }
}
