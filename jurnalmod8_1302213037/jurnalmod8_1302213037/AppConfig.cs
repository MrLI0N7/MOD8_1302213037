using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace jurnalmod8_1302213037
{
    internal class AppConfig
    {
        public BankTransferConfig bankTFconfig;
        public void readConfig()
        {
            string hasilbaca = File.ReadAllText(@"./bank_transfer_config.json");
            bankTFconfig = JsonSerializer.Deserialize<BankTransferConfig>(hasilbaca);
        }
        public void writeConfig()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            String jsonString = JsonSerializer.Serialize(bankTFconfig, options);

            File.WriteAllText(@"./bank_transfer_config.json", jsonString);
        }
        public void defaultConfig()
        {
            List<string> listdefault = new List<string>() { "RTO(real-time", "SKN", "RTGS", "BI FAST" };

            BankTransferConfig BankTFConfig = new BankTransferConfig("en",25000000,6500,1500, listdefault, "yes","ya");
        }
        
    }
}
