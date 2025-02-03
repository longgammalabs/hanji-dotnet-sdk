using System.Numerics;

namespace OnchainClob.Client
{
    public class ApproveParams : TransactionParams
    {
        public string Spender { get; init; } = default!;
        public BigInteger Amount { get; init; }
    }
}
