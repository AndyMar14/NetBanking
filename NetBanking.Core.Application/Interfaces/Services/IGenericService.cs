﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.Interfaces.Services
{
    public interface IGenericServices<SaveViewModel, ViewModel, Model>
        where SaveViewModel : class
        where ViewModel : class
        where Model : class
    {
        Task Update(SaveViewModel vm, int id);

        Task<SaveViewModel> Add(SaveViewModel vm);

        Task Delete(int id);

        Task<SaveViewModel> GetByIdSaveViewModel(int id);

        Task<List<ViewModel>> GetAllViewModel();
    }

}
