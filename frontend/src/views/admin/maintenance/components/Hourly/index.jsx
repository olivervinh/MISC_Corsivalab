import React, { useEffect, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import {getMaintenance_Hourly} from './apiRequest'
import Loading from '../../../../../components/loading/index'
const Index = () => {
    const[loading,setLoading] = useState(false)
    const value = useSelector((state)=>state.maintenance_Hourly.object.data)
    const dispatch = useDispatch()
    useEffect(()=>{
        getMaintenance_Hourly(dispatch)
        if(value!=null)
        setLoading(true)
    },[])
  return (
    <div style={{backgroundColor:"white",borderRadius:20+"px"}}>
    <h3 className="m-portlet__head-text" style={{margin:20 +"px",padding:24+"px"}}>Active Maintenance Project Assigned</h3>
        <div className="custom-table-responsive">
            <table className="table" style={{margin:20+"px"}}>
                <thead>
                    <tr>
                        <th scope="col">#</th>
                        <th scope="col">Customer</th>
                        <th scope="col">Project Title</th>
                        <th scope="col">Project Type</th>
                        <th scope="col">Expiry Date</th>
                        <th scope="col">Report Last Uploaded</th>
                        <th scope="col">Actions</th>   
                    </tr>
                </thead>
                    <tbody>
                    {loading?
                        value.map((item, key) => {
                            return (
                            <tr> 
                                <th scope="row">{ key + 1}</th>
                                <td>{item.CustomerName}</td>
                                <td>{item.ProjectTitle}</td>
                                <td>{item.ProjectNature}</td>
                                <td>{item.ExpiryTime}</td>
                                <td>Null</td>
                                <td><a className="btn btn-primary editemailbtn" style={{color: 'white'}}>View Projects</a></td>
                            </tr>
                            );
                        }):
                        <Loading/>
                    }
                </tbody>
            </table>
        </div>
</div>
  )
}

export default Index