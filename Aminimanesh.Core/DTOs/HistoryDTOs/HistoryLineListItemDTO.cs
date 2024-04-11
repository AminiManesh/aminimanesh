using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aminimanesh.Core.DTOs.HistoryDTOs
{
    public class HistoryLineListItemDTO
    {
        public string Title { get; set; }

        public List<HistoryListItemDTO> Histories { get; set; }
    }
}
