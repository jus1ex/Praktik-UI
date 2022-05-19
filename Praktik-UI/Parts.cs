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
        string _name;
        string _price;
        string _id;
        string _amount;
        string _amountcart;
        string _date;
        public void _setamountcart(string amount)
        {
            _amountcart = _amount;
        }
        public string _getamountcart() => _amountcart;
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