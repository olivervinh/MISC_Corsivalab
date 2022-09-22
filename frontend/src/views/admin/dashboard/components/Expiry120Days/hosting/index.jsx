import React, { useEffect, useState } from 'react'
import { getExpiry120Days_hosting } from './apiRequest'
import moment from 'moment'
import { useDispatch, useSelector } from 'react-redux';
import Tab from 'react-bootstrap/Tab';
import Loading from '../../../../../components/loading/index'
const Index = () => {
    const[loading,setLoading] = useState(false)
    const value = useSelector((state)=>state.expiry120Days_hosting.object.data)
    const dispatch = useDispatch()
    useEffect(()=>{
        getExpiry120Days_hosting(dispatch)
        if(value!=null)
        setLoading(true)
    },[])
  return (
                <table className="table" style={{margin:20+"px"}}>
                    <thead>
                        <tr>
                            <th scope="col">#</th>
                            <th scope="col">Title</th>
                            <th scope="col">Customer</th>
                            <th scope="col">Maintain by</th>
                            <th scope="col">Expiry</th>
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
                                    <td>{item.Title}</td>
                                    <td>{item.CustomerName}</td>
                                    <td>{item.MaintainBy}</td>
                                    <td>{moment(item.ExpiryDashboardView).format('LL')}</td>
                                    <td>Action</td>
                                </tr>
                                );
                            }):<Loading/>}
                    </tbody>
                </table>

  )
}

export default Index