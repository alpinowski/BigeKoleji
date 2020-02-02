using BilgeKoleji.CORE.Entity;
using BilgeKoleji.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BilgeKoleji.CORE.Entity.Enum;

namespace BilgeKoleji.MODEL.Entities
{
    public class Register : CoreEntity
    {
        public Register()
        {
            IsActive = false;
        }
        [Required(ErrorMessage = "Bu alan zorunludur."), Display(Name = "TC Kimlik Numarası:")]
        public string TcKimlikNumarasi{ get; set; }
        [Required(ErrorMessage ="Bu alan zorunludur"), Display(Name = "Öğrenci İsim Soyisim")]
        public string OgrenciIsimSoyisim { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur"), Display(Name = "Cinsiyet")]
        public string Cinsiyet { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur"), Display(Name ="Bitidiği Okul")]
        public string BitirdiğiOkul { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur"), Display(Name = "Not Ortalaması")]
        public decimal NotOrtalaması { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur"), Display(Name ="Veli Ad Soyad")]
        public string VeliAdSoyad { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur"), Display(Name = "Cep Telefonu")]
        public int CepTelefonu { get; set; }
        [Display (Name ="Diğer Telefon")]
        public int DigerTelefon { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur"), Display(Name = "Ev Adresi")]
        public string EvAdresi { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur"), Display(Name = "İlçe ve İl")]
        public string IlçeIl { get; set; }
        public Roles? Role { get; set; }
        public bool IsActive { get; set; }
        public Guid ActivationCode { get; set; }

      


        public virtual List<Article> Articles { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Todo> Todos { get; set; }

    }
}

   