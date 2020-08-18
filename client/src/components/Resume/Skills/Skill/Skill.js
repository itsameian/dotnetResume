import React from 'react'

const Skill = props => {
  return (
    <Auxilliary>
      <p>
        <span>
          {props.skill}
        </span>
        <span>
          {props.skillLevel}
        </span>
      </p>
    </Auxilliary>
  )
};

export default Skill