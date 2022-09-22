import React,{useEffect, useState} from 'react'
import queryString from 'query-string'
import { Link, useLocation } from 'react-router-dom';
import { getMaintenanceProjectAssigned } from './apiRequest';
import { useDispatch, useSelector } from 'react-redux';
import Loading from '../../../../../../components/loading/index'
const Index = () => {
    const[loading,setLoading]=useState(false)
    const value = useSelector((state)=>state.maintenanceProjectAssigneds.object.data)
    const { search } = useLocation()
    const dispatch = useDispatch()
    const param = queryString.parse(search)
    useEffect(()=>{
        getMaintenanceProjectAssigned(dispatch,param)
        if(value!=null)
            setLoading(true)
      },[])
  return (
    <div className="m-portlet__body" style={{backgroundColor:"white",borderRadius:20+"px"}}>
        <div className="row">
            <div className="col-md-12">
                <div className="m-content">
                    <div className="m-portlet__body">
                        <div className="row">
                            <div className="col-md-12">
                                <div className="m-content" style={{backgroundColor: 'white'}}>
                                    <h3 className="m-portlet__head-text" style={{margin: 20+"px", padding: 24+"px"}}>Active Maintenance Project Assigned {value.MaintainBy}</h3>
                                    <table className="table" style={{margin: 20+"px"}}>
                                        <thead>
                                            <tr>
                                                <th title="Field #1">ID</th>
                                                <th title="Field #2">Title</th>
                                                <th title="Field #2">Customer</th>         
                                                <th title="Field #2">Link to update project</th>          
                                            </tr>
                                        </thead>
                                        <tbody>
                                            {
                                                loading?
                                                 value.MaintenanceProjects.map((item, key) => {
                                                    return (
                                                    <tr> 
                                                        <th scope="row">{ key + 1}</th>
                                                        <td>{item.Title}</td>
                                                        <td>{item.CustomerName}</td>
                                                        <td><Link className="btn btn-primary editemailbtn" to={`/admin/update-project/?Id=${item.Id}`} style={{color: 'white'}}>Go to project</Link></td>
                                                    </tr>
                                                    );
                                                })
                                                :
                                                <Loading/>
                                            }
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
  )
}
export default Index