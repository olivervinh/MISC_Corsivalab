import React, { useEffect, useState} from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { getTotalProjects } from './apiRequest'
import Loading from '../../../../../components/loading/index'
const Index = () => {
  const[loading,setLoading] = useState(false)
  const value = useSelector((state)=>state.totalProjects.object.data)
  const dispatch = useDispatch()
  useEffect(()=>{
    getTotalProjects(dispatch)
    if(value!=null)
      setLoading(true)
  },[])
  return (
    <div className="m-portlet m-portlet--tab">
        <div className="m-portlet__head">
            <div className="m-portlet__head-caption">
                <div className="m-portlet__head-title" style={{display: 'flex', justifyContent: 'space-between'}}>
                {loading?<h3 className="m-portlet__head-text">Total Projects: {value}</h3>:<Loading/>}
                </div>
            </div>
        </div>
    </div>
  )
}

export default Index