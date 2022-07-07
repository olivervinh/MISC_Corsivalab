import logo from './logo.svg';
import './App.css';
import Login from './components/login/Login';
import { BrowserRouter as Router, Routes, Route } from "react-router-dom"
import Customer from './components/customer/customer';
import Project from './components/project/project';
import Domain from './components/domain/domain';
import Maintenance from './components/maintenance/maintenance';
import Ataglance from './components/ataglance/ataglance';
import Exportexcel from './components/exportexcel/exportexcel';
import Emailsystem from './components/data/emailsystem/emailsystem';
import Provider from './components/data/provider/provider';
import NavBar from './components/navbar/navbar';
import Dashboard from './components/dashboard/dashboard';
function App() {
  return (
    <div className='App'>
       <Router>
      <NavBar/>
          <div className='page-container'>
              <Routes>
                  <Route path='/login' element={<Login/>}/>
                  <Route path='/admin/dashboard' element={<Dashboard/>}/>
                  <Route path='/admin/customer'element={<Customer/>}/>
                  <Route path='/admin/project'element={<Project/>}/>
                  <Route path='/admin/domain' element={<Domain/>}/>
                  <Route path='/admin/maintenance' element={<Maintenance/>}/>
                  <Route path='/admin/ataglance' element={<Ataglance/>}/>
                  <Route path='/admin/exportexcel' element={<Exportexcel/>}/>
                  <Route path='/admin/datas/emailsystem' element={<Emailsystem/>}/>
                  <Route path='/admin/datas/provider' element={<Provider/>}/>
              </Routes>
          </div>
      </Router>
    </div>
  );
}

export default App;
