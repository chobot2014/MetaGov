import 'isomorphic-fetch';


export class VoteProvider {
    constructor() {
    }
    
    public voteTest(id: string): Promise<any> {
        return fetch(`http://${window.location.host}/api/Vote/Test`, {
            method: 'POST',
            body: JSON.stringify({ voteID: id })
        })
            .then(x => x.text() as Promise<any>)
            .catch(x => console.error(x));
    }

}
