import 'isomorphic-fetch';


export class VoteProvider extends BaseProvider {
    constructor() {
        super();        
    }

    public voteTest(id: string, onDone: Function) {
        fetch('/Vote/Test', { body: JSON.stringify({ voteID: id }) })
            .then(response => response.json())
            .then(data => {
                onDone(data.VoteTestResult);
            });
    }

}
