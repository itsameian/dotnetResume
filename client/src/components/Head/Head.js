import React from "react";
import classes from "./Head.module.css";

const Head = (props) => {
  return (
    <nav>
      <ul className={classes.Nav}>
        <li className={classes.Left}>
          <span className={classes.Brand}>
            <strong>IAN KING SOFTWARE</strong>
          </span>
        </li>
        <li className={classes.Right}>
          <a className={classes.NavLink} href="#">
            Contact
          </a>
        </li>
        <li className={classes.Right}>
          <a className={classes.NavLink} href="#">
            About
          </a>
        </li>
        <li className={classes.Right}>
          <a className={classes.NavLink} href="#">
            Resume
          </a>
        </li>
      </ul>
    </nav>
  );
};

export default Head;
