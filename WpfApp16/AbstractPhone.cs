using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp16
{
     abstract class AbstractPhone : IPhone
    {
        public int Balance { get; set; }
        string _model;
       protected AbstractPhone (string model)
        {
            _model = model;
        }
        public void Call(int minutes)
        {
            if (Balance > 0)
                Balance -= minutes * 10;
        }
        public string getInfo()
        {
            return $"Телефон {_model};\n\rБаланс {Balance} рублей";
        }
    }
}
