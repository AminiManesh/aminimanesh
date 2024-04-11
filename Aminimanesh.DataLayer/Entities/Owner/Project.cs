using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aminimanesh.DataLayer.Entities.Owner
{
    public class Project
    {
        public Project()
        {

        }


        [Key]
        public int ProjectId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Display(Name = "عنوان پروژه")]
        [Required(ErrorMessage = "{0} نمی‌تواند خالی باشد.")]
        [MaxLength(50, ErrorMessage = "{0} نمی‌تواند بیشتر از {1} کاراکتر باشد.")]
        public string Title { get; set; }

        [Display(Name = "توضیحات پروژه")]
        [Required(ErrorMessage = "{0} نمی‌تواند خالی باشد.")]
        public string Description { get; set; }

        [Display(Name = "توضیح مختصر پروژه")]
        [Required(ErrorMessage = "{0} نمی‌تواند خالی باشد.")]
        [MaxLength(200, ErrorMessage = "{0} نمی‌تواند بیشتر از {1} کاراکتر باشد.")]
        public string ShortDescription { get; set; }

        [Display(Name = "کاور پروژه")]
        [Required(ErrorMessage = "{0} نمی‌تواند خالی باشد.")]
        [MaxLength(200, ErrorMessage = "{0} نمی‌تواند بیشتر از {1} کاراکتر باشد.")]
        public string Thumbnail { get; set; }

        [Display(Name = "تاریخ شروع پروژه")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "تاریخ اتمام")]
        public DateTime FinishDate { get; set; }

        [Display(Name = "وضعیت پروژه")]
        [Required(ErrorMessage = "{0} نمی‌تواند خالی باشد.")]
        public bool IsFinished { get; set; }

        [Display(Name = "نام مشتری پروژه")]
        [Required(ErrorMessage = "{0} نمی‌تواند خالی باشد.")]
        public string CustomerName { get; set; }

        [Display(Name = "لوکیشن مشتری پروژه")]
        [Required(ErrorMessage = "{0} نمی‌تواند خالی باشد.")]
        public string CustomerLocation { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        #region Relations
        public List<Attachment> Attachments { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        #endregion
    }
}
