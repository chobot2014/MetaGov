using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace MetaGovVote
{
    class VoteHelpers
    {
        public static string NextBlockHash(VoteBlock block)
        {
            var hasher = SHA384.Create();
            var bytes = Encoding.UTF8.GetBytes(block.data + block.timeStamp.ToString());
            return Convert.ToBase64String(hasher.ComputeHash(bytes));
        }
    }
}
