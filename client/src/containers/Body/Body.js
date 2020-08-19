import React, { Component } from 'react';

import Resume from '../../components/Resume/Resume'
import {mockJobs} from '../../MockObjects/MockJobs'

class Body extends Component {
    constructor(props){
        super(props)
        this.state = ({
            jobs: mockJobs.data,
            skills: []
        })
    }
    render() {
        console.log("[Body.js] Jobs:", this.state.jobs)
        return (
            <div>
                <Resume 
                    skills={this.state.skills}
                    jobs={this.state.jobs}
                />
            </div>
        )
    }
};

export default Body;