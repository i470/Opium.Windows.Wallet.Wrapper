using System;
using System.Collections.Generic;

namespace Wrapper.Model
{
    public class Transaction
    {
        public String TxId { get; set; }
        public Int32 Version { get; set; }
        public Int32 LockTime { get; set; }
        public List<Vout> Vout { get; set; }
        public List<Vin> Vin { get; set; }
    }
}
