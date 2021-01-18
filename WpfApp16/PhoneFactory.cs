using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp16
{
    class PhoneFactory
    {
        List<AbstractPhone> _list;
        private PhoneFactory(List<AbstractPhone> list) { _list = list; }
        static PhoneFactory _phoneFactory;
        public AbstractPhone CreatePhone(int model)
        {   if (_list.Count > model)
                return _list[model];
            else
                throw new Exception("Посмотри в список. Ты предлагаешь мне создавать ничего, блин");
        }

        static public PhoneFactory BuildFactory( List<AbstractPhone> list)
        {
            if (_phoneFactory == null)
                _phoneFactory = new PhoneFactory(list);
            return _phoneFactory;
        }
    }
}
