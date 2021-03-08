using Adapter.Adapter.Interface;
using Adapter.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Adapter
{
    internal class XPRealEstateFundsJSON : IXPRealEstateFundsJSON
    {
        private IB3RealEstateFundsService Xml { get; set; }

        internal XPRealEstateFundsJSON(IB3RealEstateFundsService xml)
        {
            Xml = xml;
        }

        public string ConvertToJson()
        {
            var response = Xml.GetAssetABCD11();
            string[] separate = response.Split(',').ToArray();

            var model = new RealEstateFunds() { Code = separate[0], Name = separate[1], Value = Convert.ToDouble(separate[2]) };

            string json = JsonConvert.SerializeObject(model, Formatting.Indented);

            return json;
        }
    }
}