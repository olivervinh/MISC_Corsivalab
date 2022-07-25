import React, { useState } from 'react'
import axiosClient from 'services/api/axiosClient';
export const TableProject = () => {
  const [project, setProject] = useState([])
  React.useEffect(()=>{
    async function getProject(){
        var res =  await axiosClient.get("Projects/GetAll")
        return res
    }
    getProject()
    .then(resolve=>setProject(resolve))
    .catch(err=>console.log(err))
  },[])
  return (
    <div style={{backgroundColor:"white",borderRadius:20+"px"}}>
    <h3 className="m-portlet__head-text" style={{margin:20 +"px",padding:24+"px"}}>Active Maintenance Project Assigned</h3>
        <div className="custom-table-responsive">
            <table className="table" style={{margin:20+"px"}}>
                <thead>
                    <tr>
                        <th scope="col">#</th>
                        <th scope="col">Title</th>
                        <th scope="col">Domain</th>
                        <th scope="col">MaintExpire</th>
                        <th scope="col">ForecastStart</th>
                        <th scope="col">Forecast</th>
                        <th scope="col">MaintStart</th>
                        <th scope="col">ForecastAmount</th>
                        <th scope="col">EmailSystemExpire</th>
                        <th scope="col">FkCustomerId</th>
                        <th scope="col">MaintainBy</th>
                        <th scope="col">FkEmailSystemId</th>
                        <th scope="col">AMEmail</th>
                        <th scope="col">Phase</th>
                        <th scope="col">ProjectNature</th>
                        <th scope="col">Backup</th>
                        <th scope="col">Credential</th>
                    </tr>
                </thead>
                    <tbody>
                    {
                        project.map((item, key) => {
                            return (
                            <tr> 
                                <th scope="row">{ key + 1}</th>
                                <td>{item.Title}</td>
                                <td>{item.Domain}</td>
                                <td>{item.MaintExpire}</td>
                                <td>{item.ForecastStart}</td>
                                <td>{item.Forecast}</td>
                                <td>{item.MaintStart}</td>
                                <td>{item.ForecastAmount}</td>
                                <td>{item.EmailSystemExpire}</td>
                                <td>{item.FkCustomerId}</td>
                                <td>{item.MaintainBy}</td>
                                <td>{item.FkEmailSystemId}</td>
                                <td>{item.AMEmail}</td>
                                <td>{item.Phase}</td>
                                <td>{item.ProjectNature}</td>
                                <td>{item.Backup}</td>
                                <td>{item.Credential}</td>
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

export default TableProject