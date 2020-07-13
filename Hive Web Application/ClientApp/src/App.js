import "./global-exports";

import React, { Component } from "react";
import { observer } from "mobx-react";
import { Route } from "react-router";
import { Layout } from "./components/Layout";
import { Home } from "./components/Home";
import { FetchData } from "./components/FetchData";
import { Counter } from "./components/Counter";
import pluginManager from "./utils/pluginManager";

import "./custom.css";

class _App extends Component {
  static displayName = "App";

  componentDidMount() {
    pluginManager.loadPlugins();
  }

  render() {
    return (
      <Layout>
        <Route exact path="/" component={Home} />
        <Route path="/counter" component={Counter} />
        <Route path="/fetch-data" component={FetchData} />
        {pluginManager.routes.map((route) => (
          <Route
            path={route.path}
            component={route.component}
            key={route.path}
          />
        ))}
      </Layout>
    );
  }
}

export default observer(_App);
