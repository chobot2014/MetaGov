using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetaGovVote
{
    public enum BallotFieldStatus
    {
        untouched,
        dirty,        
        submitted,
        stored
    }

    public enum BallotStatus
    {
        untouched,        
        dirty,
        submitted,
        stored,
        cast,
        counted
    }


    public class BallotFieldItemResponse
    {
        // this is to abstract out the response, like we can have it be 
        // text for now, but text is shitty for ML but we need to support 
        // various other kinds of responses to be used in the models

        public string value;

        public override string ToString()
        {
            return value;
        }
    }

    public class BallotFieldItem
    {
        public string title;
        public string question;        
        public IEnumerable<BallotFieldItemResponse> response;
        public override string ToString()
        {           
            return title + question;
        }
    }    

    public class BallotField
    {
        public BallotFieldStatus status;
        public IEnumerable<BallotFieldItem> items;
        public override string ToString()
        {            
            return items.Where(x => x.ToString() != null && x.ToString() != "").ToString();
        }
    }
        
    public class BallotOption
    {
        public string key;
        public string value;
        public string description;
    }    

    public class Ballot
    {
        public string id;
        public BallotStatus status;
        private IEnumerable<BallotOption> _options;
        private IEnumerable<BallotField> _fields;

        public Ballot(IEnumerable<BallotOption> options, IEnumerable<BallotField> fields)
        {
            id = Guid.NewGuid().ToString();
            _fields = fields;
            status = BallotStatus.untouched;
        }

        public Ballot(IEnumerable<BallotField> fields)
        {
            id = Guid.NewGuid().ToString();
            _fields = fields;
            status = BallotStatus.untouched;
        }


        public int GetCompletionPercentage()
        {
            return (int) Math.Round((double)_fields.Count(x => x.status == BallotFieldStatus.stored) / (double)_fields.Count());
        }
        
    }
}
