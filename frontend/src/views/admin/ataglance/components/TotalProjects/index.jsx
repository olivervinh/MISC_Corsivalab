import React, { useEffect, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { getTotalProjects } from './apiRequest'
const Index = () => {
  const value = useSelector((state)=>state.totalProjects.object.data)
  const dispatch = useDispatch()
  useEffect(()=>{
    getTotalProjects(dispatch)
  },[])
  return (
  <div className="col-md-12 col-xs-12">
    <div className="m-portlet m-portlet--tab">
        <div className="m-portlet__head">
            <div className="m-portlet__head-caption">
                <div className="m-portlet__head-title" style={{display: 'flex', justifyContent: 'space-between'}}>
                    <h3 className="m-portlet__head-text">Total Projects: {value}</h3>
                </div>
            </div>
        </div>
    </div>
</div>
  )
}

export default Index