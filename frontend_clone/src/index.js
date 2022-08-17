import React, { useEffect } from "react";
import ReactDOM from "react-dom";
import "assets/css/App.css";
import { HashRouter, Route, Switch, Redirect } from "react-router-dom";
import AuthLayout from "layouts/auth";
import AdminLayout from "layouts/admin";
import { ChakraProvider } from "@chakra-ui/react";
import theme from "theme/theme";
import {Provider} from "react-redux"
import {store,persistor} from "./services/redux/store" //import cái store này vào
import { PersistGate } from 'redux-persist/integration/react'
import {Link} from "react-router-dom"
import { fetch } from "views/admin/ataglance/slices/totalProjectsSlice";
ReactDOM.render(
  <Provider store={store}>
    <ChakraProvider theme={theme}>
      <React.StrictMode>
        <PersistGate loading={null} persistor={persistor}>
          <HashRouter>
            <Switch>
              <Route path={`/auth`} component={AuthLayout} />
              <Route path={`/admin`} component={AdminLayout} />
            <Redirect from='/' to='/admin' />
          </Switch>
        </HashRouter>
      </PersistGate>
    </React.StrictMode>
  </ChakraProvider>
  </Provider>,  
  document.getElementById("root")
);
