using System;
using Opium.MVVM.Framework.Model;

namespace Opium.Wallet.Model
{
    public class ShielCoinbaseResponse:BaseNotify
    {
        public String operationid;
        public int shieldedUTXOs;
        public double shieldedValue;
        public int remainingUTXOs;
        public double remainingValue;
    }
}
