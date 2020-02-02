using BilgeKoleji.CORE.Entity;
using BilgeKoleji.CORE.Entity.Enum;
using BilgeKoleji.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji.MODEL.Entities
{
    public class ManagementRegister : CoreEntity
    {
        public ManagementRegister()
        {
            IsActive = false;
        }
               
        [Required(ErrorMessage="Bu alan zorunludur."),Display(Name="Ad")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur."), Display(Name = "Soyisim")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur."), Display(Name = "Parola")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur."), Display(Name = "Parola Doğrulama")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur."), Display(Name = "Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur."), Display(Name = "Cinsiyet")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur."), Display(Name = "Adres")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur."), Display(Name = "Telefon Numarası")]
        public int PhoneNumber { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur."), Display(Name = "Branş")]
        public string Branch { get; set; }
        public Roles? Role { get; set; }
        public Guid ActivationCode { get; set; }
        public bool IsActive { get; set; }


        public virtual List<Article> Articles { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Todo> Todos { get; set; }
    }
}
