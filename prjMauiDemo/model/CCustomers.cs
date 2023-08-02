using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMauiDemo.model
{
    public  class CCustomers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }

        //這邊用到繼承多型的技巧 因為在父類別中已經有Tostring()這個方法，
        //在這邊可以用多形再宣告一個ToString()方法，
        //但這樣還是會優先宣告父類別中的ToString()方法，因此要加上Override 關鍵字
        public override string ToString()    
        {
            return this.Name +"   /"+this.phone +"   /"+this.email;
        }
    }
}
