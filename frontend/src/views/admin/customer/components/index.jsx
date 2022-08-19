import React, { useEffect, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { getCustomers } from './apiRequest'
const Index = () => {
const value = useSelector((state)=>state.customers.object.data)
const dispatch = useDispatch()
useEffect(()=>{
    getCustomers(dispatch)
},[])
  return (
    <div style={{backgroundColor:"white",borderRadius:20+"px"}}>
    <h3 className="m-portlet__head-text" style={{margin:20 +"px",padding:24+"px"}}>Active Maintenance Project Assigned</h3>
        <div className="custom-table-responsive">
            <table className="table" style={{margin:20+"px"}}>
                <thead>
                    <tr>
                        <th scope="col">#</th>
                        <th scope="col">Company</th>
                        <th scope="col">Industry</th>
                        <th scope="col">Actions</th>   
                    </tr>
                </thead>
                    <tbody>
                    {
                        value.map((item, key) => {
                            return (
                            <tr> 
                                <th scope="row">{ key + 1}</th>
                                <td>{item.Company}</td>
                                <td>{item.FkIndustryId}</td>
                                <td><a className="btn btn-primary editemailbtn" style={{color: 'white'}}>View Projects</a></td>
                            </tr>
                            );
                        })
                    }
                </tbody>
            </table>
        </div>
</div>
  )
}
export default Index