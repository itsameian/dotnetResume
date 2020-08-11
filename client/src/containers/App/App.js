import React from "react";
import classes from "./App.module.css";
import Head from "../../components/Head/Head";
import Body from "../Body/Body";
import Foot from "../Foot/Foot";

function App() {
  return (
    <div className={classes.App}>
      <Head></Head>
      <Body></Body>
      <Foot></Foot>
    </div>
  );
}

export default App;
