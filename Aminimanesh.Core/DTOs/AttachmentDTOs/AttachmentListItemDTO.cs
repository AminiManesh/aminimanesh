using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aminimanesh.Core.DTOs.AttachmentDTOs
{
    public class AttachmentListItemDTO
    {
        public int AttachmentId { get; set; }

        public int ProjectId { get; set; }

        public string FileName { get; set; }

        public string ShowName { get; set; }

        public bool IsImage { get; set; }
    }
}
