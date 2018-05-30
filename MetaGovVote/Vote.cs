using System;
using System.Collections.Generic;
using System.Text;

namespace MetaGovVote
{
    public enum VoteStatus {
        pendingApproval,
        approved,
        current,
        processing,
        completed
    }

    public class VoteOption
    {

    }

    public class VoteResult
    {
        // 
    }


    public class Vote
    {
        public string id;
        public string title;
        public IEnumerable<VoteOption> options;
        public VoteStatus status;
        public VoteResult result;
    }
}
