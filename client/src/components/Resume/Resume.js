import React from 'react';

import Jobs from './Jobs/Jobs'
import Skills from './Skills/Skills'
import classes from './Resume.module.css';

const Resume = props => {
    return (
        <div className={classes.Resume}>
            <Jobs jobs={props.jobs}></Jobs>
        </div>
    )
};

export default Resume;