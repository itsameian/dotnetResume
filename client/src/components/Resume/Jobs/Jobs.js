import React from 'react';

const Jobs = props => {
  return (
    props.jobs.map((j) => {
      return (
        <Job job={j}></Job>
      )
    })
  )
};