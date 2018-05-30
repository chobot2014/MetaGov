using System;
using System.Collections.Generic;

namespace MetaGovVote
{    
    public enum MetaGovVoteProcessorTaskType
    {
        BallotAction,        
        StorageAction,
        TallyAction
    }

    public class MetaGovVoteProcessorTask
    {
        private MetaGovVoteProcessorTaskType _type;
        MetaGovVoteProcessorTask(MetaGovVoteProcessorTaskType type)
        {
            _type = type;
        }

        public bool ExecuteTaskOnBlocks(ref IEnumerable<VoteBlock> blocks)
        {
            throw new NotImplementedException();
        }
    }

    public class MetaGovVoteProcessor
    {
        
        public MetaGovVoteProcessor(IEnumerable<Ballot> ballots, IEnumerable<MetaGovVoteProcessorTask> tasks)
        {
            
        }
    }
}
