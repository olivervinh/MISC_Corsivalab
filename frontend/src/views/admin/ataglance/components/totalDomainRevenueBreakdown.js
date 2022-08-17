import React, { useEffect, useState } from 'react'
import axiosClient from 'services/api/axiosClient'
export const TotalDomainRevenueBreakdown = (data) => {
    // const [TotalAndDomainRevenueBreakdownList, setTotalAndDomainRevenueBreakdownList] = useState({})
    // useEffect(() => {
    //     //call domain
    //     async function getTotalAndDomainRevenueBreakdownList() {
    //         const res = await axiosClient.get("Ataglances/TotalAndDomainRevenueBreakdownList")
    //         return res
    //     }
    //     //after call domain
    //     getTotalAndDomainRevenueBreakdownList()
    //         .then(resolve => setTotalAndDomainRevenueBreakdownList(resolve))
    //         .catch(err => console.log(err))
    // })

    return (
        
        <div>
            {console.log('TotalAndDomainRevenueBreakdownList', data.data)}
            {data.data.data.length == 0? <p>Loading ...</p> : <><div className="m-portlet__head">
                <div className="m-portlet__head-caption">
                    <div className="m-portlet__head-title">
                        <h3 className="m-portlet__head-text">Total Domain Revenue Per Month: {data.Total} $
                        </h3>
                    </div>
                </div>
            </div><div className="m-portlet__body">
                    <b>Revenue Breakdown</b>
                    <table className="table">
                        <tbody>
                            {data.domainRevenueBreakdownIColection.map(item => {
                                return (
                                    <tr>
                                        <td>{item.Key}</td>
                                        <td>{item.Value}</td>
                                    </tr>
                                )
                            })}

                        </tbody>
                    </table>
                </div></>}
        

        </div>
    )
}

export default TotalDomainRevenueBreakdown