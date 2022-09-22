import React, { useEffect, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { getTotalDomainRevenueBreakdown } from './apiRequest'
import Loading from '../../../../../components/loading/index'
export const TotalDomainRevenueBreakdown  = () => {
    const[loading,setLoading] = useState(false)
    const value = useSelector((state)=>state.totalDomainRevenueBreakdown.object.data)
    console.log('value',value)
    const dispatch = useDispatch()
    useEffect(()=>{
        getTotalDomainRevenueBreakdown(dispatch)
        if(value!=null)
            setLoading(true)
    },[])
    return (
        <div className="m-portlet m-portlet--tab">
            <div className="m-portlet__head">
                <div className="m-portlet__head-caption">
                    <div className="m-portlet__head-title">
                        <h3 className="m-portlet__head-text">Total Domain Revenue Per Month: {value.Total} $
                        </h3>
                    </div>
                </div>
            </div>
            <div className="m-portlet__body">
                    <b>Revenue Breakdown</b>
                <table className="table">
                    <tbody>
                        {loading?value.domainRevenueBreakdownIColection.map(item => {
                            return (
                                <tr>
                                    <td>{item.Key}</td>
                                    <td>{item.Value}</td>
                                </tr>
                            )
                        }):<Loading/>}

                        </tbody>
                </table>
            </div>
        </div>
    )
}

export default TotalDomainRevenueBreakdown