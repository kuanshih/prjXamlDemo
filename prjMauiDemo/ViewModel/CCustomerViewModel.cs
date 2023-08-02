//using Bumptech.Glide.Load.Model;
//using Java.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjMauiDemo.model;


//此為:商業邏輯層
namespace prjMauiDemo.ViewModel
{
    public class CCustomerViewModel:INotifyPropertyChanged

    {
        public CCustomerViewModel()
        {
            loadData();
        }
        int _position = 0;
        List<CCustomers> _list = new List<CCustomers>(); /*建立一個CCustomer Entity 的list*/

        public event PropertyChangedEventHandler PropertyChanged;

        public void loadData()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string path = Path.Combine(folder, "Cutomers.txt");
            string data = File.ReadAllText(path, Encoding.UTF8);

            var lines = data.Split("\n");
            foreach (var line in lines)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    var cell = line.Split("\t");
                    CCustomers x = new CCustomers();
                    x.Id = Convert.ToInt32(cell[0]);
                    x.Name = cell[1];
                    x.phone = cell[2];
                    x.email = cell[3];
                    x.address = cell[4];
                    _list.Add(x);
                }
            }
            //CCustomers x = new CCustomers();
            //x.Id = 1;
            //x.Name = "Marco";
            //x.phone = "0946413830";
            //x.email = "marco@gmail.com";
            //x.address = "marco city marco district";
            //_list.Add(x);
            //x = new CCustomers();
            //x.Id = 2;
            //x.Name = "Steve";
            //x.phone = "0916351054";
            //x.email = "steve@gmail.com";
            //x.address = "steve city steve district";
            //_list.Add(x);
            //x = new CCustomers();
            //x.Id = 3;
            //x.Name = "Jack";
            //x.phone = "09143122420";
            //x.email = "jack@gmail.com";
            //x.address = "jack city jack district";
            //_list.Add(x);
        }

        public void persistant()
        {
            string s = "";
            foreach(var c in _list)
            {
                s += c.Id.ToString() + "\t";
                s += c.Name.ToString() + "\t";
                s += c.phone.ToString() + "\t";
                s += c.email.ToString() + "\t";
                s += c.address.ToString() + "\n";
            }
            string folder =Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string path = Path.Combine(folder, "Cutomers.txt");
            File.WriteAllText(path, s, Encoding.UTF8);
        }
        public void moveFirst()
        {
            _position = 0;
            PropertyChanged(this, new PropertyChangedEventArgs("current"));
        }
        public void movePrevious()
        {
            _position--;
            if (_position < 0) _position = 0;
            PropertyChanged(this, new PropertyChangedEventArgs("current"));
        }
        public void moveNext()
        {
            _position++;
            if (_position == _list.Count)
                _position = _list.Count - 1;
            PropertyChanged(this, new PropertyChangedEventArgs("current"));
        }
        public void moveLast()
        {
            _position = _list.Count - 1;
            PropertyChanged(this, new PropertyChangedEventArgs("current"));
        }
        public void moveTo(int to)
        {
            _position = to;
            PropertyChanged(this, new PropertyChangedEventArgs("current"));
        }

        public CCustomers queryByKeyword(string keyword)
        {
            for (int i = 0; i < _list.Count; i++)
            {
                if (_list[i].Name.ToUpper().Contains(keyword.ToUpper())
                    || _list[i].phone.ToUpper().Contains(keyword.ToUpper())
                    || _list[i].email.ToUpper().Contains(keyword.ToUpper())
                    || _list[i].address.ToUpper().Contains(keyword.ToUpper())
                    )
                {
                    _position = i;
                    return _list[i];
                }
            }
            return null;
        }

        public CCustomers current
        {
            get { return _list[_position]; }
            set { _list[_position] = value; }
        }
        public List<CCustomers> all
        {
            get { return _list; }
            set { _list = value; }
        }
    }
}
