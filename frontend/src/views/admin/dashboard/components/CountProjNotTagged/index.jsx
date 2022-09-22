import React, { useEffect, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { Link } from 'react-router-dom'
import { getCountProjNotTagged } from './apiRequest'
import Loading from '../../../../../components/loading/index'
const Index = () => {
    const[loading,setLoading] = useState(false)
    const value = useSelector((state)=>state.countProjNotTagged.object.data)
    const dispatch = useDispatch()
    useEffect(()=>{
        getCountProjNotTagged(dispatch)
        if(value!=null)
            setLoading(true)
    },[])
  return (
    <div style={{backgroundColor: "white",marginTop:"24px",borderRadius:"20px"}}>
        <h3 className="m-portlet__head-text" style={{margin:"20px",padding:"24px",display:'inline-block'}}>Count projects not tagged to any maintenance person </h3>
        <div className="custom-table-responsive">
            <table className="table" style={{margin:"20px"}}>
                <thead>
                    <tr>
                        <th style={{width:"33.33%"}} scope="col">#</th>
                        <th style={{width:"33.33%"}} scope="col">Count</th>
                        <th style={{width:"33.33%"}} scope="col">Action</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <th scope="row">1</th>
                        <td>{loading?value:<Loading/>}</td>
                        <td><Link className="btn btn-primary editemailbtn" to={`/admin/MaintenanceProjectAssigned/?MaintainBy=to no one`} style={{color: 'white'}}>View Projects</Link></td>
                    </tr>
                </tbody>
                </table>
            </div>
        <div style={{padding:"24px"}}></div>
    </div>
  )
}

export default Index