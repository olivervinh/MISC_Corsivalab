import React, { useEffect, useState } from 'react'
import axiosClient from 'services/api/axiosClient'
export const TotalHostingRevenueBreakdown = () => {
    const [TotalAndHostingRevenueBreakdownList, setTotalAndHostingRevenueBreakdownList] = useState({})
    useEffect(() => {
        //call Hosting
        async function getTotalAndHostingRevenueBreakdownList() {
            const res = await axiosClient.get("Ataglances/TotalAndHostingRevenueBreakdownList")
            return res
        }
        //after call Hosting
        getTotalAndHostingRevenueBreakdownList()
            .then(resolve => setTotalAndHostingRevenueBreakdownList(resolve))
            .catch(err => console.log(err))
    }, {})

  return (
    <div>
        <div className="m-portlet__head">
                        <div className="m-portlet__head-caption">
                            <div className="m-portlet__head-title">
                                <h3 className="m-portlet__head-text">Total Hosting Revenue Per Month: {TotalAndHostingRevenueBreakdownList.Total} $
                                </h3>
                            </div>
                        </div>
                    </div>
                    <div className="m-portlet__body">
                        <b>Revenue Breakdown</b>
                        <table className="table">
                            <tbody>
                                {TotalAndHostingRevenueBreakdownList.hostingRevenueBreakdownIColection.map(item => {
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

export default TotalHostingRevenueBreakdown