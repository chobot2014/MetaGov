import * as React from 'react';
import { RouteComponentProps } from 'react-router';
import { VoteProvider } from '../providers/VoteProvider';

interface VoteState { voteTest: string }

export class Vote extends React.Component<RouteComponentProps<{}>, VoteState> {
    constructor(props: any) {
        super(props);
        this.state ={
            voteTest: 'not nothing'
        };
    }
        
    private callVote() {
        const voteProvider = new VoteProvider();
        voteProvider.voteTest('test message from client', (x: string) => {
            this.setState({voteTest: x});
        });
    }   
    
    public render() {
        return <div>
            <button value='vote test' onClick={this.callVote} />
            <h2> { this.state.voteTest } </h2>
        </div>;
    }
}
