using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bbiblioo.Models
{
    public class Notes : IPerson , IBook, ICriteria
    { 
       
        
        int IPerson.Person_id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IBook.Book_id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int ICriteria.Criterion_id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

 

        public Int32 Note { get; set; }
        

        public void insert_note()
        {

        }

        public void save_note()
        {

        }

        public void update()
        {

        }

        public void delete_note()
        {

        }
    }
}
