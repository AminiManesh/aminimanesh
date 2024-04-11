﻿using Aminimanesh.Core.DTOs.AttachmentDTOs;
using Aminimanesh.Core.DTOs.CategoryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aminimanesh.Core.DTOs.ProjectDTOs
{
    public class ProjectGeneralDTO
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

        public List<AttachmentListItemDTO> Attachments { get; set; }

        public CategoryListItemDTO Category { get; set; }
    }
}