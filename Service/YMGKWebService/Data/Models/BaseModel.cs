using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YMGKWebService.Data.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; } = DateTime.Now;
    }
}
