using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using prjMauiDemo.model;

namespace prjMauiDemo.ViewModel
{
    
    public class CStockViewModel
    {
        List<CStock> _list = new List<CStock>();
        int _position;
        
        public CStockViewModel()
        { 
        loadData();
        }

        private void loadData()
        {
            CStock x = new CStock();
            x.Id = 1;
            x.Name = "台積電";
            x.Price = 580;
            _list.Add(x);
            x = new CStock();
            x.Id = 2;
            x.Name = "聯發科";
            x.Price = 789;
            _list.Add(x);
            x = new CStock();
            x.Id = 3;
            x.Name = "光寶科";
            x.Price = 843;
            _list.Add(x);
        }


        internal void movefirst()
        {
            _position = 0;
        }
        internal void moveprevious()
        {
            _position--;
            if(_position<=0)
            {
                _position = 0;
            }
        }
         internal void movenext()
        { 
            _position++;
            if(_position>=_list.Count)
            {
                _position = _list.Count-1;
            }

        }
        internal void movelast()
        {
            _position=_list.Count-1;
        }

        public CStock current
        {
            get { return _list[_position]; }
            set { _list[_position] =value; }
        }
        public List<CStock> all
        { 
            get { return _list; } 
            set { _list = value; }
        }
   
    }

}
