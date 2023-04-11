using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnalmod8_1302213037
{
    internal class BankTransferConfig
    {
        public string lang { get; set; }
        public Transfer transfer { get; set; }
        public List<string> method {get; set; }
        public Confirmation confirmation { get; set; }

        public class Transfer
        {
            public int threshold;
            public int low_fee;
            public int high_fee;
            public Transfer(int threshold, int low_fee, int high_fee)
            {
                this.threshold = threshold;
                this.low_fee = low_fee;
                this.high_fee = high_fee;
            }
        }
        public class Confirmation
        {
            public string en;
            public string id;

            public Confirmation(string en, string id)
            {
                this.en = en;
                this.id = id;
            }
        }

        public BankTransferConfig() { }
        public BankTransferConfig(string lang, int v1, int v2, int v3, List<string> method, string en, string id) 
        {
            this.lang = lang;
            Transfer transfer = new Transfer(v1, v2, v3);
            this.transfer = transfer;
            this.method = method;
            Confirmation confirmation = new Confirmation(en, id);
            this.confirmation = confirmation;

        }
    }
}
