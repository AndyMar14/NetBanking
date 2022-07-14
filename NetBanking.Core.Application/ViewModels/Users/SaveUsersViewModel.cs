using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.ViewModels.Users
{
    public class SaveUsersViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe colocar su nombre ")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Debe colocar su apellido")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Debe colocar un nombre de usuario")]
        [DataType(DataType.Text)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Debe colocar una contraseña")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare(nameof(Password), ErrorMessage = "Las contraseñas no coiciden")]
        [Required(ErrorMessage = "Debe colocar una contraseña")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Debe colocar un correo")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Debe colocar su número de identificación")]
        [DataType(DataType.Text)]
        public string Identification { get; set; }

        [Required(ErrorMessage = "Debe colocar el tipo de usuario")]
        [DataType(DataType.Text)]
        public string Type { get; set; }

        [Required(ErrorMessage = "Debe colocar el monto inicial")]
        [DataType(DataType.Currency)]
        public string InitialAmount { get; set; }

        [Required(ErrorMessage = "Debe colocar un telefono")]
        [DataType(DataType.Text)]
        public string Phone { get; set; }


        //Products

        public int ProductId { get; set; }

        [Required(ErrorMessage = "Debe colocar un producto")]
        [DataType(DataType.Text)]
        public string ProductType { get; set; }

        public int ProductIdentifier { get; set; }

        [Required(ErrorMessage = "Debe colocar un límite para la tarjeta")]
        [DataType(DataType.Currency)]
        public double CreditLimit { get; set; }

        [Required(ErrorMessage = "Debe colocar un límite para el préstamo")]
        [DataType(DataType.Currency)]
        public double LoanAmount { get; set; }



        public bool HasError { get; set; }
        public string Error { get; set; }
    }
}
