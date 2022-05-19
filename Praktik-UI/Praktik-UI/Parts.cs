using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PartClass
{
    public class Part
    {
        public Part(string name,string amount,string price,string id)
        {
            _name = name;
            _amount = amount;
            _price = price;
            _id = id;
        }
        public string _name;
        public string _price;
        public string _id;
        public string _amount;
        public string _getamount() => _amount;
        public string _getname() => _name;
        public string _getprice() => _price;
        public string _getid() => _id;
        public void _setamount(string amount)
        {
            _amount = amount;
        }
        public void _setname(string name)
        {
            _name = name;
        }
        public void _setprice(string price)
        {
            _price = price;
        }
        public void _setid(string id)
        {
            _id = id;
        }
    }
}