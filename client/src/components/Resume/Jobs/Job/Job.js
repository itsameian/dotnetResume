import React from 'react';
import JobResponsibilities from './JobResponsibility/JobResponsibility';

const Job = props => {
  const responsibilityList = props.job.responsibilities.map((r) => {
    return (
      <JobResponsibility responsibility = {r}></JobResponsibility>
    )
  });
  return (
    <div>
      <p>{props.job}</p>
      <p>{props.job.startDate} - {props.job.endDate}</p>
      {responsibilityList}
    </div>
  )
};

export default Job;