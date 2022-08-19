import React, { useEffect, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import axiosClient from 'services/api/axiosClient'
import { getTotalDomainRevenueBreakdown } from './apiRequest'
export const TotalDomainRevenueBreakdown = (data) => {
    const value = useSelector((state)=>state.totalDomainRevenueBreakdown.object.data)
    const dispatch = useDispatch()
    useEffect(()=>{
        getTotalDomainRevenueBreakdown(dispatch)
    },[])
    return (
    <div>
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
                            {value.domainRevenueBreakdownIColection.map(item => {
                                return (
                                    <tr>
                                        <td>{item.Key}</td>
                                        <td>{item.Value}</td>
                                    </tr>
                                )
                            })}

                        </tbody>
                    </table>
                </div>
        </div>
    )
}

export default TotalDomainRevenueBreakdown