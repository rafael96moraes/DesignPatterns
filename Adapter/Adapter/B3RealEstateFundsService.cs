using Adapter.Adapter.Interface;
using Adapter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Adapter.Adapter
{
    class B3RealEstateFundsService : IB3RealEstateFundsService
    {
        string RequestService()
        {
            return "ABCD11,ABCD Empresa Fundo Imobiliario,56.4";
        }

        public string GetAssetABCD11()
        {
            var result = RequestService();
            return result;
        }
    }
}
