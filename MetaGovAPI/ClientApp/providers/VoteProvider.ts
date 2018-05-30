import 'isomorphic-fetch';


export class VoteProvider extends BaseProvider {
    constructor() {
        super();

        
    }

    getVoteResults(): Promise<string> {
        fetch(_baseUrl = '/Vote/GetResults')
            .then(response => response.json() as Promise<WeatherForecast[]>)
            .then(data => {
                this.setState({ forecasts: data, loading: false });
            });
    }
}
