using NetBanking.Core.Application.ViewModels.Recipients;
using NetBanking.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.Interfaces.Services
{
    public interface IRecipientsService : IGenericService<SaveRecipientsViewModel, RecipientsViewModel, Recipients>
    {
    }
}
