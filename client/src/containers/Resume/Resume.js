import React from 'react';

import classes from './Resume.modules.css';

class Resume extends React.Component {
    constructor(){
        super()
        this.setState({
            jobs: [],
            skills: []
        })
    }
    render() {
        return (
            <div className={classes.Resume}>
                <Jobs jobs={this.state.jobs}></Jobs>
                <Skills skills={this.state.skills}></Skills>
            </div>
        )
    }
}

export default Resume;