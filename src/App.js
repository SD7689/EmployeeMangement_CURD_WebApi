import React from 'react';
import './App.css';

import {Home} from './components/Home'
import {Employee} from './components/Employee'
import {Login} from './components/Login'
import {Navigation} from "./components/Navigation"

import {BrowserRouter, Route, Switch} from 'react-router-dom'
//import { NavLink } from 'react-bootstrap';

function App() {
  return (
    <BrowserRouter>
    <div className="container">

<h3 className = "m-3 d-flex justify-content-center">
  React JS with Web Api Demo
</h3>
<h5 className = "m-3 d-flex justify-content-center">
Employee Management Portal.
</h5>

<Navigation/>

      <Switch>
        <Route path='/' component={Home} exact />
        <Route path='/login' component={Login}/>
        <Route path='/employee' component={Employee}/>
        </Switch>  
    </div>
    </BrowserRouter>
  );
}

export default App;