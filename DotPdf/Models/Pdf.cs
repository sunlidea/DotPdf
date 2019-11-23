using System;
using System.ComponentModel.DataAnnotations;
namespace RazorPagesPdf.Models
{
    public class Pdf
    {
        [Display(Name = "Family Name")]
        public string Fam { get; set; }
        [Display(Name = "Given names")]
        public string Giv { get; set; }
        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }
        [Display(Name = "Town/city")]
        public string BirthTown { get; set; }
        [Display(Name = "Country")]
        public string BirthCntry { get; set; }
        [Display(Name = "Passport number")]
        public string PassNo { get; set; }
        [Display(Name = "Country of passport")]
        public string PassCntry { get; set; }
        [Display(Name = "Relationship status")]
        public string Restatus { get; set; }
        [Display(Name = "Identity number")]
        public string IdentNo { get; set; }
        [Display(Name = "Country of issue")]
        public string IdentCntry { get; set; }
        [Display(Name = "Your present country of citizenship")]
        public string Cit { get; set; }
        [Display(Name = "Street")]
        public string ResiStr { get; set; }
        [Display(Name = "Sub Address")]
        public string ResiSub { get; set; }
        [Display(Name = "Country")]
        public string ResiCntry { get; set; }
        [Display(Name = "Postcode")]
        public string ResiPc { get; set; }
        [Display(Name = "Street")]
        public string CorrespStr { get; set; }
        [Display(Name = "Sub Address")]
        public string CorrespSub { get; set; }
        [Display(Name = "Country")]
        public string CorrespCntry { get; set; }
        [Display(Name = "Postcode")]
        public string CorrespHap { get; set; }
        [Display(Name = "Country code")]
        public string OffPhCc { get; set; }
        [Display(Name = "Area code")]
        public string OffPhAc { get; set; }
        [Display(Name = "Number")]
        public string OffPh { get; set; }
        [Display(Name = "Country code")]
        public string AfterPhCc { get; set; }
        [Display(Name = "Area code")]
        public string AfterPhAc { get; set; }
        [Display(Name = "Number")]
        public string AfterPn { get; set; }
        [Display(Name = "Country code")]
        public string FaxCc { get; set; }
        [Display(Name = "Area code")]
        public string FaxAc { get; set; }
        [Display(Name = "Number")]
        public string FaxPh { get; set; }
        [Display(Name = "Email address")]
        public string Email { get; set; }
        [Display(Name = "Client number or file number")]
        public string FileNo { get; set; }
    }
}

