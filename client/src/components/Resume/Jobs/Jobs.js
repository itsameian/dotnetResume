import React from 'react';

import Job from './Job/Job'

const Jobs = props => {
  const jobs = [...Array(props.jobs)][0];
  console.log("[Jobs.js]", jobs)
  return (
    jobs.map((j) => {
      return (
        <Job job={j} key={j.id} />
      )
    })
  )
};

export default Jobs;