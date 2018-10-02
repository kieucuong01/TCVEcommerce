using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TCVWeb.Areas.Admin.Models
{
    public class ModalFormResult
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public string ReturnUrl { get; set; }
    }

    public class FileUploadResult
    {
        public string[] initialPreview { get; set; }
        public object[] initialPreviewConfig { get; set; }
    }

    public class SelectItemModel
    {
        public int id { get; set; }
        public string text { get; set; }
        public bool selected { get; set; }
    }

    public class CheckCodeModel
    {
        [Display(Name = "Số ĐT")]
        public string Sender { get; set; }

        [Display(Name = "Mã Code")]
        public string CodeText { get; set; }
    }

    public class SendNotiModel
    {
        [Required, StringLength(40)]
        [Display(Name = "Tiêu đề")]
        public string Title { get; set; }

        [Required, StringLength(250)]
        [Display(Name = "Nội dung")]
        public string Message { get; set; }
    }
}
