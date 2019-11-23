using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesPdf.Models;
using iText.Forms;
using iText.Kernel.Pdf;
using System.Reflection;
using iText.IO.Source;
using System.IO;

namespace RazorPagesPdfs.Pages.Pdfs
{
    public class FillModel : PageModel
    {
        public static readonly String SRC = "Resources/5022.pdf";

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Pdf Pdf { get; set; }
        public string Gender { get; set; }
        //relationship status
        public string[] StatusList = { "Married", "Separated", "Engaged","Divorced","De facto","Widowed",
            "Never married or been in a de facto relationship" };

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //read src file
            ByteArrayOutputStream baos = new ByteArrayOutputStream();
            PdfDocument pdfDoc = new PdfDocument(new PdfReader(Path.GetFullPath(SRC)), new PdfWriter(baos));

            //genetate pdf form fields
            PdfAcroForm form = PdfAcroForm.GetAcroForm(pdfDoc, false);
            PropertyInfo[] properties = Pdf.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (property.GetValue(Pdf, null) == null)
                {
                    continue;
                }

                //field name
                string name = property.Name;
                //field value
                string value = "";
                string propertyValue = property.GetValue(Pdf, null).ToString();
                switch (property.Name)
                {
                    case "Dob":
                        //date of birth
                        value = DateTime.Parse(propertyValue).ToString("dd/MMM/yyyy");
                        break;
                    case "Restatus":
                        //relationship status
                        name = RelationshipStatus(propertyValue);
                        value = "yes";
                        form.GetField(name).SetCheckType(1);
                        break;
                    default:
                        value = propertyValue;
                        break;

                }
                //set field name
                form.GetField(name).SetValue(value);
            }

            //flat form
            form.FlattenFields();

            pdfDoc.Close();

            return File(baos.ToArray(), "application/pdf", "result.pdf");
        }

        //relationship status 
        protected static string RelationshipStatus(string description)
        {
            return description switch
            {
                "Married" => "MaritalMar",
                "Engaged" => "MaritalEng",
                "De facto" => "MaritalDef",
                "Separated" => "MaritalSep",
                "Divorced" => "MaritalDiv",
                "Widowed" => "MaritalWid",
                "Never married or been in a de facto relationship" => "MaritalNevmar",
                _ => "",
            };
        }
    }
}
