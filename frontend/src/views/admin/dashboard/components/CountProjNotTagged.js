import React, { useEffect, useState } from 'react'
export const CountProjNotTagged = () => {
    const [CountProjNotTaggedData,setCountProjNotTaggedData] = useState([])
    useEffect(()=>{
        async function getCountProjNotTaggedData(){
            const res = await axiosClient.get('Dashboards/ListProjectCountMaintenance')
        }
        getCountProjNotTaggedData().then((res)=>setCountProjNotTaggedData(res))
    })
  return (
    <div style="background-color:white;border-radius:20px;">
                          <h3 class="m-portlet__head-text" style="margin:20px;padding:24px">Active Maintenance Project Assigned</h3>
                        <div class="custom-table-responsive">
                            <table class="table" style="margin:20px">
                                <thead>
                                    <tr>
                                        <th scope="col">#</th>
                                        <th scope="col">Maintain by</th>
                                        <th scope="col">Count</th>
                                        <th scope="col">Action</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    {CountProjNotTaggedData.map((item)=>{
                                    <tr>
                                        <th scope="row"></th>
                                        <td>{item.MaintainBy}</td>
                                        <td>{item.CountProject}</td>
                                        <td><a class="btn btn-primary editemailbtn" style={{color: 'white'}}>View Projects</a></td>
                                    </tr>
                                    })}
                                </tbody>
                            </table>
                        </div>
                    </div>
  )
}

export default CountProjNotTagged
