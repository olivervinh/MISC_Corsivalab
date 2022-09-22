import React, { useEffect, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { get_UpdateProject_ProjectMonthlyMaintenancePackages } from './apiRequest'
import queryString from 'query-string'
import {useLocation } from 'react-router-dom';
import Loading from '../../../../components/loading/index'
export const Index = () => {
    const[loading,setLoading] = useState(false)
    const value = useSelector((state)=>state.UpdateProject_ProjectMonthlyMaintenancePackages.object.data)
    const dispatch = useDispatch()
    const {search} = useLocation()
    const param = queryString.parse(search)
    useEffect(()=>{
        get_UpdateProject_ProjectMonthlyMaintenancePackages(dispatch,param)
        if(value!=null)
            setLoading(true)
    },[])
  return (
<div className="col-md-12 col-xs-12">
    <div className="m-portlet m-portlet--tab">
       <div className="m-portlet__body">
            <div style={{display: 'flex', justifyContent: 'space-between'}}>
                <h4>Project Monthly Maintenance Packages</h4>
                <a className="btn btn-primary" data-toggle="modal" data-target="#AddProjectMonthlyMaintenace" style={{color: '#ffffff'}}>Add</a>
            </div>
            <table className="table">
                <thead>
                    <tr>
                        <th>Start Date</th>
                        <th>End Date</th>
                        <th>Amount</th>
                        <th>Payment Cycle</th>
                        <th>Remark</th>
                        <th>Action</th>
                    </tr>
                </thead>
                <tbody>
                    {loading?value.map(item=>{
                        return(
                            <tr>
                            <td>
                                {item.StartDate}
                            </td>
                            <td>
                                {item.EndDate}
                            </td>
                            <td>
                                <span className="currency-bold">{item.Amount}</span>
                            </td>
                            <td>
                                {item.Per}
                            </td>
                            <td>
                                {item.FkProjectId}
                            </td>
                            <td><a className="btn btn-primary editbtn"  data-toggle="modal" data-target="#EditProjectMonthlyMaintenace" style="color: #ffffff">Edit</a>
                                <a className="btn btn-primary deletebtn"  style={{color: '#ffffff', paddingLeft: 8+'px'}}>Delete</a></td>
                        </tr>
                        )
                    }):<Loading/>}
                </tbody>
            </table>
        </div>
    </div>
</div>
)
}
export default Index