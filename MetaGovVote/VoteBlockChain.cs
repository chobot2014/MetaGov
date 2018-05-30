using System;
using System.Collections.Generic;
using System.Text;

namespace MetaGovVote
{
    class VoteBlockChain
    {
        private string _id;
        private List<VoteBlock> _chain;

        VoteBlockChain()
        {
            _chain = new List<VoteBlock>();
            _chain.Add(new VoteBlock() {
                index = 1,
                data = "First Block",
                previousHash = null
            });
        }

        public int GetLength()
        {
            return _chain.Count;
        }

        public VoteBlock AddNewBlock(string data)
        {
            var newBlock = new VoteBlock()
            {
                data = data,
                index = _chain.Count + 1,
                timeStamp = DateTime.Now,
                previousHash = VoteHelpers.NextBlockHash(_chain[_chain.Count - 1])
            };
            _chain.Add(newBlock);
            return newBlock;
        }

        public bool IsChainValid()
        {
            for(int i = 0; i< _chain.Count; i++)
            {
                var hash = VoteHelpers.NextBlockHash(_chain[i]);
                if (_chain[i + 1] != null && hash != _chain[i+1].previousHash)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
