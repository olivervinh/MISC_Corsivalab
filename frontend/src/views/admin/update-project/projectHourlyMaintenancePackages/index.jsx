import React, { useEffect, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { get_UpdateProject_ProjectHourlyMaintenancePackages } from './apiRequest'
import queryString from 'query-string'
import {useLocation } from 'react-router-dom';
import Loading from '../../../../components/loading/index'
const Index = () => {
    const[loading,setLoading] = useState(false)
    const value = useSelector((state)=>state.UpdateProject_ProjectMonthlyMaintenancePackages.object.data)
    const dispatch = useDispatch()
    const {search} = useLocation()
    const param = queryString.parse(search)
    useEffect(()=>{
        get_UpdateProject_ProjectHourlyMaintenancePackages(dispatch,param)
        if(value!=null)
            setLoading(true)
    },[])
  return (
    <div className="col-md-12 col-xs-12">
    <div className="m-portlet m-portlet--tab">
        <div className="m-portlet__body">
            <div style={{display: 'flex', justifyContent: 'space-between'}}>
                <h4>Hourly Maintenance Packages</h4>
                <a className="btn btn-primary" style={{color: '#ffffff'}}>Add</a>
            </div>
            <table className="table">
                <thead>
                    <tr>
                        <th>Hour Packge</th>
                        <th>Cost</th>
                        <th>Hours Spent</th>
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
                                <td><a className="btn btn-primary editbtn"  data-target="#EditProjectMonthlyMaintenace" style="color: #ffffff">Edit</a>
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