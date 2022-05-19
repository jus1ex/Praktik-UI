using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SupplierClass
{
    public class Supplier
    {
        string _name;
        string _adress;
        string _phonenumber;
        public Supplier(string name,string adress,string phonenumber)
        {
            _name = name;
            _adress = adress;
            _phonenumber = phonenumber;
        }
        public string _getname => _name;
        public string _getadress => _adress;
        public string _getphonenumber => _phonenumber;
        public void _setname(string name)
        {
            _name = name;
        }
        public void _setadress(string adress)
        {
            _adress=adress;
        }
        public void _setphonenumber(string phonenumber)
        {
            _phonenumber=phonenumber;
        }
    }
}
    