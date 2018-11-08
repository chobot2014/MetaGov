import * as React from 'react';
import { RouteComponentProps } from 'react-router';
import { VoteProvider } from '../providers/VoteProvider';

interface VoteState { voteTest: string }

export class Vote extends React.Component<RouteComponentProps<{}>, VoteState> {
    constructor(props: any) {
        super(props);
        this.state ={
            voteTest: ''
        };
    }
        
    callVote = () => {
        const voteProvider = new VoteProvider();
        voteProvider.voteTest("vote id").then(x => this.setState({ voteTest: x }));        
    };
    
    public render() {
        return <div>
            <button value='vote test' onClick={this.callVote} >Cast Vote</button>
            <h2> { this.state.voteTest } </h2>
        </div>;
    }
}
