using System;
using System.Collections.Generic;

namespace Wrapper.Model
{
    public class ScriptPubKey
    {
        public String Asm { get; set; }
        public String Hex { get; set; }
        public String ReqSigs { get; set; }
        public String Type { get; set; }
        public List<String> Addresses { get; set; }
    }
}