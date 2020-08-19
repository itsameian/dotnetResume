import React from 'react';

import Responsibility from './Responsibility/Responsibility';

const Job = props => {
  const responsibilities = props.job.responsibilities;
  console.log("[Job.js] Responsibilities:", responsibilities)
  const responsibilityList = responsibilities.map((r) => {
    return (
      <li key={r.id}>
        <Responsibility responsibility={r} />
      </li>
    )
  });
  return (
    <div>
      <hr />
      <p>
        <span>{props.job.title}</span> <em><span>{props.job.company}</span></em>
      </p>
      <p>{props.job.startDate} - {props.job.endDate}</p>
      <ul>
        {responsibilityList}
      </ul>
    </div>
  )
};

export default Job;