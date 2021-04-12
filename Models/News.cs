using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bbiblioo.Models
{
    public class News
    {
        private Int32 new_id;
        private DateTime publication_date;
        private DateTime registration_date;
        private DateTime update_date;
        private String news_date;
        private String image; 

        public Int32 New_id
        {
            get { return this.new_id; }
            set { this.new_id = value; }
        }

        public DateTime Publication_date
        {
            get { return this.publication_date; }
            set { this.publication_date = value; }
        }

        public DateTime Registration_date
        {
            get { return this.registration_date; }
            set { this.registration_date = value; }
        }

        public DateTime Update_date
        {
            get { return this.update_date; }
            set { this.update_date = value; }
        }

        public String New_date
        {
            get { return this.news_date; }
            set { this.news_date = value; }
        }

        public String Image
        {
            get { return this.image;  }
            set { this.image = value; }
        }

        public void write_news()
        {

        }

        public void read_news()
        {

        }


        public void update_news()
        {

        }







    }
}
