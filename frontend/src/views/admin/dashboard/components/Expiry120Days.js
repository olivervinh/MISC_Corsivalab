import React, { useEffect, useState } from 'react'
import Tab from 'react-bootstrap/Tab';
import Tabs from 'react-bootstrap/Tabs';
import axiosClient from 'services/api/axiosClient';

const Expiry120Days = () => {
  //tab domain
  const [domain,setDomain] = useState([])
  useEffect(()=>{
    async function getDomain(){
      const res = axiosClient.get("Dashboards/ListProject120Domain")
      return res
    }
    getDomain()
    .then(res=>setDomain(res))
    .catch(err=>console.log(err))
  },[])
  //tab domain
  
  //tab hosting
  const [hosting,setHosting]=useState([])
  useEffect(()=>{
    async function getHosting(){
      const res = axiosClient.get("Dashboards/ListProject120Hosting")
      return res
    }
    getHosting()
    .then(res=>setHosting(res))
    .catch(err=>console.log(err))
  },[])
  //tab hosting

  //email system
  const [emailSystem,setEmailSystem] = useState([])
  useEffect(()=>{
    async function getEmailSystem(){
      const res = axiosClient.get("Dashboards/ListProject120Email")
      return res
    }
    getEmailSystem()
    .then(res=>setEmailSystem(res))
    .catch(err=>console.log(err))
  },[])
  //email system

  //maintenance
  const [maintenance,setMaintenance]=useState([])
  useEffect(()=>{
    async function getMaintenance(){
      const res = axiosClient.get("Dashboards/ListProject120Maintenance")
      return res
    }
    getMaintenance()
    .then(res=>setMaintenance(res))
    .catch(err=>console.log(err))
  },[])
  //maintenance
  return (
<div style={{backgroundColor:"white",borderRadius:20+"px"}}>
    <h3 className="m-portlet__head-text" style={{margin:20 +"px",padding:24+"px"}}>Active Maintenance Project Assigned</h3>
    <div style={{padding:20+"px"}}>
    <Tabs
    defaultActiveKey="profile"
    id="uncontrolled-tab-example"
    className="mb-3"
  >
    <Tab eventKey="domain" title="Domain">
    <div className="custom-table-responsive">
                <table className="table" style={{margin:20+"px"}}>
                    <thead>
                        <tr>
                            <th scope="col">#</th>
                            <th scope="col">Title</th>
                            <th scope="col">Customer</th>
                            <th scope="col">Maintain by</th>
                            <th scope="col">Expiry</th>
                            <th scope="col">Action</th>
                        </tr>
                    </thead>
                        <tbody>
                        {
                            domain.map((item, key) => {
                                return (
                                <tr> 
                                    <th scope="row">{ key + 1}</th>
                                    <td>{item.Title}</td>
                                    <td>{item.Customer}</td>
                                    <td>{item.MaintainBy}</td>
                                    <td>{item.Expiry}</td>
                                    <td>Action</td>
                                </tr>
                                );
                            })
                        }
                    </tbody>
                </table>
            </div>
    </Tab>
    <Tab eventKey="hosting" title="Hosting">
    <div className="custom-table-responsive">
                <table className="table" style={{margin:20+"px"}}>
                    <thead>
                        <tr>
                            <th scope="col">#</th>
                            <th scope="col">Title</th>
                            <th scope="col">Customer</th>
                            <th scope="col">Maintain by</th>
                            <th scope="col">Expiry</th>
                            <th scope="col">Action</th>
                        </tr>
                    </thead>
                        <tbody>
                        {
                            domain.map((item, key) => {
                                return (
                                <tr> 
                                    <th scope="row">{ key + 1}</th>
                                    <td>{item.Title}</td>
                                    <td>{item.Customer}</td>
                                    <td>{item.MaintainBy}</td>
                                    <td>{item.Expiry}</td>
                                    <td>Action</td>
                                </tr>
                                );
                            })
                        }
                    </tbody>
                </table>
            </div>
    </Tab>
    <Tab eventKey="emailSystem" title="EmailSystem">
    <div className="custom-table-responsive">
                <table className="table" style={{margin:20+"px"}}>
                    <thead>
                        <tr>
                            <th scope="col">#</th>
                            <th scope="col">Title</th>
                            <th scope="col">Customer</th>
                            <th scope="col">Maintain by</th>
                            <th scope="col">Expiry</th>
                            <th scope="col">Action</th>
                        </tr>
                    </thead>
                        <tbody>
                        {
                            domain.map((item, key) => {
                                return (
                                <tr> 
                                    <th scope="row">{ key + 1}</th>
                                    <td>{item.Title}</td>
                                    <td>{item.Customer}</td>
                                    <td>{item.MaintainBy}</td>
                                    <td>{item.Expiry}</td>
                                    <td>Action</td>
                                </tr>
                                );
                            })
                        }
                    </tbody>
                </table>
            </div>
    </Tab>
    <Tab eventKey="monthlyMaintenance" title="MonthlyMaintenance">
    <div className="custom-table-responsive">
                <table className="table" style={{margin:20+"px"}}>
                    <thead>
                        <tr>
                            <th scope="col">#</th>
                            <th scope="col">Title</th>
                            <th scope="col">Customer</th>
                            <th scope="col">Maintain by</th>
                            <th scope="col">Expiry</th>
                            <th scope="col">Action</th>
                        </tr>
                    </thead>
                        <tbody>
                        {
                            domain.map((item, key) => {
                                return (
                                <tr> 
                                    <th scope="row">{ key + 1}</th>
                                    <td>{item.Title}</td>
                                    <td>{item.Customer}</td>
                                    <td>{item.MaintainBy}</td>
                                    <td>{item.Expiry}</td>
                                    <td>Action</td>
                                </tr>
                                );
                            })
                        }
                    </tbody>
                </table>
            </div>
    </Tab>
  </Tabs>
    </div>
</div>
  
  )
}

export default Expiry120Days