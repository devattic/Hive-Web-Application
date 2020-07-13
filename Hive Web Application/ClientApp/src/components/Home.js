import React, { Component } from "react";
import { observer } from "mobx-react";
import pluginManager from "../utils/pluginManager";

class _Home extends Component {
  static displayName = _Home.name;

  render() {
    return (
      <div>
        {pluginManager.components.map((X) => (
          <X key={X.componentName}></X>
        ))}
      </div>
    );
  }
}

export const Home = observer(_Home);