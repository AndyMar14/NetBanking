﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.ViewModels.Transactions
{
    public class SaveTransactionsViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe colocar la cuenta ")]
        public string UserProductId { get; set; }

        [Required(ErrorMessage = "Debe colocar la cuenta")]
        public string RecipientProductId { get; set; }
        public int Type { get; set; }

        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Debe colocar el monto")]
        [DataType(DataType.Currency)]
        public float Amount { get; set; }
    }
}
