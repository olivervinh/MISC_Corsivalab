import { mapResponsive } from '@chakra-ui/utils'
import React, { useEffect, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { getActMainProjAssigned } from './apiRequest'
import { Link} from "react-router-dom";
import Loading from '../../../../../components/loading/index'
export const Index = () => {
  const[loading,setLoading] = useState(false)
  const value = useSelector((state)=>state.actMainProjAssigned.object.data)
  const dispatch = useDispatch()
  useEffect(()=>{
    getActMainProjAssigned(dispatch)
    if(value!=null)
        setLoading(true)
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
                            loading?
                            value.map((item, key) => {
                                return (
                                <tr> 
                                    <th scope="row">{ key + 1}</th>
                                    <td>{item.MaintainBy}</td>
                                    <td>{item.Countproject}</td>
                                    <td><Link className="btn btn-primary editemailbtn" to={`/admin/MaintenanceProjectAssigned/?MaintainBy=${item.MaintainBy}`} style={{color: 'white'}}>View Projects</Link></td>
                                </tr>
                                );
                            }):
                            <Loading/>
                        }
                    </tbody>
                </table>
            </div>
    </div>
  )
}
export default Index
