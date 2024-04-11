using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aminimanesh.Core.DTOs.ProjectDTOs
{
    public class ProjectListItemDTO
    {
        public int ProjectId { get; set; }

        public int CategoryId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string MiniDescription { get; set; }

        public string Thumbnail { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime FinishDate { get; set; }

        public bool IsFinished { get; set; }

        public string CustomerName { get; set; }

        public string CustomerLocation { get; set; }
    }
}
