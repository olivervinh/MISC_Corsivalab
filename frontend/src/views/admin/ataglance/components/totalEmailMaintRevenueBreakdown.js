import React, { useEffect, useState } from 'react'
import axiosClient from 'services/api/axiosClient'
export const TotalEmailRevenueBreakdown = () => {
    const [TotalAndEmailRevenueBreakdownList, setTotalAndEmailRevenueBreakdownList] = useState({})
    useEffect(() => {
        //call email
        async function getTotalAndEmailRevenueBreakdownList() {
            const res = await axiosClient.get("Ataglances/TotalAndEmailRevenueBreakdownList")
            return res
        }
        //after call Email
        getTotalAndEmailRevenueBreakdownList()
            .then(resolve => setTotalAndEmailRevenueBreakdownList(resolve))
            .catch(err => console.log(err))
    }, {})

  return (
    <div>
        <div className="m-portlet__head">
                        <div className="m-portlet__head-caption">
                            <div className="m-portlet__head-title">
                                <h3 className="m-portlet__head-text">Total Email Revenue Per Month: {TotalAndEmailRevenueBreakdownList.Total} $
                                </h3>
                            </div>
                        </div>
                    </div>
                    <div className="m-portlet__body">
                        <b>Revenue Breakdown</b>
                        <table className="table">
                            <tbody>
                                {TotalAndEmailRevenueBreakdownList.emailRevenueBreakdownIColection.map(item => {
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

export default TotalEmailRevenueBreakdown