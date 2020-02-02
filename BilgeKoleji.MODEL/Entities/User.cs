using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilgeKoleji.CORE.Entity.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BilgeKoleji.MODEL.Entities
{
    public class User : CoreEntity
    {
        public User()
        {
            IsActive = false;
        }

        [Required(ErrorMessage = "Bu alan zorunludur."), Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur."), Display(Name = "Parola:")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur."), Display(Name = "TC Kimlik Numarası:")]
        public string OgrenciTCKimlikNumarasi { get; set; }
        [Required, EmailAddress(ErrorMessage = "Bu alan zorunludur."), Display(Name = "E-Posta")]
        public string Email { get; set; }
        public DateTime? BirthDate { get; set; }
        public string ImagePath { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur."), Display(Name = "Okul Numarası:")]
        public int OkulNumarasi { get; set; }
        public bool IsActive { get; set; }
        public Guid ActivationCode { get; set; }

        public virtual List<Article> Articles { get; set; }
        public virtual List<Comment> MyProperty { get; set; }
        public virtual List<Todo> Todos { get; set; }
    }
}
