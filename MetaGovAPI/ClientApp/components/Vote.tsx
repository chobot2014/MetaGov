import * as React from 'react';
import { RouteComponentProps } from 'react-router';
import { VoteProvider } from '../providers/VoteProvider';

export class Vote extends React.Component<RouteComponentProps<{}>, {}> {
    private callVote() {
        const voteProvider = new VoteProvider();
        return voteProvider.voteTest();
    }
    
    public render() {
        return <div>
            <button value='vote test' onClick={this.callVote} />
        </div>;
    }
}
