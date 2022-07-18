import { mapResponsive } from '@chakra-ui/utils'
import React, { useEffect, useState } from 'react'
import axiosClient from 'services/api/axiosClient'
export const ActMainProjAssigned = () => {
    const [CountProjNotTaggedData,setCountProjNotTaggedData] = useState([])
    useEffect(()=>{
        async function getCountProjNotTaggedData(){
            const res = await axiosClient.get('Dashboards/ListProjectCountMaintenance')
            return res
        }
        getCountProjNotTaggedData()
        .then((res)=>setCountProjNotTaggedData(res))
        .catch((err)=>console.log(err))
    },[])
  return (
    <div style={{backgroundColor:"white",borderRadius:20+"px"}}>
        <h3 className="m-portlet__head-text" style={{margin:20 +"px",padding:24+"px"}}>Active Maintenance Project Assigned</h3>
            <div className="custom-table-responsive">
                <table className="table" style={{margin:20+"px"}}>
                    <thead>
                        <tr>
                            <th scope="col">#</th>
                            <th scope="col">Maintain by</th>
                            <th scope="col">Count</th>
                            <th scope="col">Action</th>
                        </tr>
                    </thead>
                        <tbody>
                        {
                            
                            CountProjNotTaggedData.map((item, key) => {
                                return (
                                <tr> 
                                    <th scope="row">{ key + 1}</th>
                                    <td>{item.MaintainBy}</td>
                                    <td>{item.Countproject}</td>
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

export default ActMainProjAssigned
