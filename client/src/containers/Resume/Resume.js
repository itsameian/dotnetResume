import React from 'react';

import classes from './Resume.modules.css';

class Resume extends React.Component {
    render() {
        return (
            <div className={classes.Resume}>
                <Job></Job>
            </div>
        )
    }
}

export default Resume;