using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.ViewModels
{
    public class FileUploadViewModel : BaseViewModel
    {
        [Required(ErrorMessage = "File is required!")]
        public HttpPostedFileBase fileUpload { get; set; }
    }
}