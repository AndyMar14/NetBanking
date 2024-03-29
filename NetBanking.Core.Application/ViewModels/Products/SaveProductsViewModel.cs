﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.ViewModels.Products
{
    public class SaveProductsViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        [Required(ErrorMessage = "Debe colocar el producto")]
        public int MainProduct { get; set; }
        public int ProductTypeId { get; set; }

        [Required(ErrorMessage = "Debe colocar el número de identificación del producto")]
        public int ProductIdentifier { get; set; }
        public double Balance { get; set; }

        [Required(ErrorMessage = "Debe colocar el límite de la tarjeta")]
        [DataType(DataType.Currency)]
        public double CreditLimit { get; set; }

        [Required(ErrorMessage = "Debe colocar el límite del préstamo")]
        [DataType(DataType.Currency)]
        public double LoanAmount { get; set; }
    }
}
