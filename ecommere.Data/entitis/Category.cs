using ecommere.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ecommere.Data.entitis
{
    public class Category
    {
        public int ID { get; set; }
        public int SortOder { get; set; }
        public Boolean IsShowOnHome { get; set; }
        //Cho phép null
        public int? ParenID { get; set; }
        // Khai báo class Status
        public Status Status { get; set; }

    }
}
