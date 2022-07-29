using NetBanking.Core.Application.Enums;
using NetBanking.Core.Application.ViewModels.Roles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.ViewModels.Users
{
    public class DeleteViewModel
    {
        public string Id { get; set; }

        public bool EmailConfirmed { get; set; }


    }
}
