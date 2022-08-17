import React, { useEffect, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { getCountProjNotTagged } from './apiRequest'
const Index = () => {
    const value = useSelector((state)=>state.countProjNotTaggedReducer.object.data)
    const dispatch = useDispatch()
    useEffect(()=>{
        getCountProjNotTagged(dispatch)
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
                        <td>{value}</td>
                        <td><a className="btn btn-primary editemailbtn" style={{color: "#ffffff"}}>  View projects</a></td>
                    </tr>
                </tbody>
                </table>
            </div>
        <div style={{padding:"24px"}}></div>
    </div>
  )
}

export default Index