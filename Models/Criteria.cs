using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bbiblioo.Models
{
    public class Criteria
    {

        private Int32 criterion_id;
        private String criterion_name;
        private String criterion_descripton;
        private DateTime criterion_update; 

        public Int32 Criterion_id { get; set; }
        public String Criterion_name { get; set; }
        public String Criterion_description { get; set; }
        public DateTime Criterion_update { get; set; }

        public void write_criteria()
        {

        }

        public void read_criteria()
        {

        }
        public void update_criteria()
        {

        }
    }
}
