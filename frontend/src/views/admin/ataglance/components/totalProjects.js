import React, { useEffect, useState } from 'react'
import axiosClient from 'services/api/axiosClient'

export const TotalProjects = () => {
  const [totalProject,setTotalProject] = useState(null)
  useEffect(()=>{
    async function getTotalProject(){
        const res = await axiosClient.get("Ataglances/CountProjectList")
        return res
    }
    getTotalProject()
    .then(resolve=>setTotalProject(resolve))
    .catch(err=>console.log(err))
  },null)
  return (
<div className="col-md-12 col-xs-12">
    <div className="m-portlet m-portlet--tab">
        <div className="m-portlet__head">
            <div className="m-portlet__head-caption">
                <div className="m-portlet__head-title" style={{display: 'flex', justifyContent: 'space-between'}}>
                    <h3 className="m-portlet__head-text">Total Projects: {totalProject}</h3>
                </div>
            </div>
        </div>
    </div>
</div>
  )
}

export default TotalProjects