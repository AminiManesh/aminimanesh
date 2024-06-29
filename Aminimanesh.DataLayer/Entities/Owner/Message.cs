using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aminimanesh.DataLayer.Entities.Owner
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }

        [Display(Name = "نام")]
        [Required(ErrorMessage = "{0} نمی‌تواند خالی باشد.")]
        [MaxLength(100, ErrorMessage = "{0} نمی‌تواند بیشتر از {1} کاراکتر باشد.")]
        public string SenderName { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "{0} نمی‌تواند خالی باشد.")]
        [MaxLength(200, ErrorMessage = "{0} نمی‌تواند بیشتر از {1} کاراکتر باشد.")]
        [EmailAddress(ErrorMessage = "فرمت ورودی {0} صحیح نمی‌باشد.")]
        public string SenderEmail { get; set; }

        [Display(Name = "متن")]
        [Required(ErrorMessage = "{0} نمی‌تواند خالی باشد.")]
        [MaxLength]
        public string Content { get; set; }

        [Display(Name = "تاریخ ارسال")]
        public DateTime? SendDate { get; set; }
    }
}
