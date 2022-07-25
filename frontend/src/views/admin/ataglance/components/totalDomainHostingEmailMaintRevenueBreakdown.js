import React, { useEffect, useState } from 'react'
import axiosClient from 'services/api/axiosClient'

export const TotalDomainHostingEmailMaintRevenueBreakdown = () => {
    const [TotalAndDomainRevenueBreakdownList, setTotalAndDomainRevenueBreakdownList] = useState({})
    useEffect(() => {
        async function getTotalAndDomainRevenueBreakdownList() {
            const res = await axiosClient.get("Ataglances/TotalAndDomainRevenueBreakdownList")
            return res
        }
        getTotalAndDomainRevenueBreakdownList()
            .then(resolve => setTotalAndDomainRevenueBreakdownList(resolve))
            .catch(err => console.log(err))
    }, {})
    const [TotalAndHostingRevenueBreakdownList, setTotalAndHostingRevenueBreakdownList] = useState({})
    useEffect(() => {
        async function getTotalAndHostingRevenueBreakdownList() {
            const res = await axiosClient.get("Ataglances/TotalAndEmailRevenueBreakdownList")
            return res
        }
        getTotalAndHostingRevenueBreakdownList()
            .then(resolve => setTotalAndHostingRevenueBreakdownList(resolve))
            .catch(err => console.log(err))
    }, {})

    const [TotalAndEmailRevenueBreakdownList, setTotalAndEmailRevenueBreakdownList] = useState({})
    useEffect(() => {
        async function getTotalAndEmailRevenueBreakdownList() {
            const res = await axiosClient.get("Ataglances/TotalAndEmailRevenueBreakdownList")
            return res
        }
        getTotalAndEmailRevenueBreakdownList()
            .then(resolve => setTotalAndEmailRevenueBreakdownList(resolve))
            .catch(err => console.log(err))
    }, {})
    return (
        <div>
            <div className="col-md-4 col-xs-12">
                <div className="m-portlet m-portlet--tab">
                    <div className="m-portlet__head">
                        <div className="m-portlet__head-caption">
                            <div className="m-portlet__head-title">
                                <h3 className="m-portlet__head-text">Total Domain Revenue Per Month: {TotalAndDomainRevenueBreakdownList.Total}
                                </h3>
                            </div>
                        </div>
                    </div>
                    <div className="m-portlet__body">
                        <b>Revenue Breakdown</b>
                        <table className="table">
                            <tbody>
                                {TotalAndDomainRevenueBreakdownList.domainRevenueBreakdownIColection.map(item => {
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
            </div>
            <div className="col-md-4 col-xs-12">
                <div className="m-portlet m-portlet--tab">
                    <div className="m-portlet__head">
                        <div className="m-portlet__head-caption">
                            <div className="m-portlet__head-title">
                                <h3 className="m-portlet__head-text">Total Hosting Revenue Per Month: $
                                </h3>
                            </div>
                        </div>
                    </div>
                    <div className="m-portlet__body">
                        <b>Revenue Breakdown</b>
                        <table className="table">
                            <tbody>
                                <tr>
                                    <td></td>
                                    <td></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            <div className="col-md-4 col-xs-12">
                <div className="m-portlet m-portlet--tab">
                    <div className="m-portlet__head">
                        <div className="m-portlet__head-caption">
                            <div className="m-portlet__head-title">
                                <h3 className="m-portlet__head-text">Total Email Revenue Per Month: $
                                </h3>
                            </div>
                        </div>
                    </div>
                    <div className="m-portlet__body">
                        <b>Revenue Breakdown</b>
                        <table className="table">
                            <tbody>
                                <tr>
                                    <td></td>
                                    <td></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    )
}

export default TotalDomainHostingEmailMaintRevenueBreakdown