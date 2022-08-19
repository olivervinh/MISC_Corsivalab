import React, { useReducer } from 'react'
import TotalProjects from './components/TotalProjects/index'
import TotalDomainRevenueBreakdown from './components/TotalDomainRevenueBreakdown/index'
import axiosClient from 'services/api/axiosClient'
import { useEffect } from 'react'
import TotalEmailRevenueBreakdown from './components/TotalEmailMaintRevenueBreakdown/index'
import TotalHostingRevenueBreakdown from './components/TotalHostingRevenueBreakdown/index'
//email
const Index = () => {


  return (
    <div className="m-content"style={{marginTop:130+"px"}}>
        <div className="row">
            <TotalProjects/>
            <div>
            <div className="col-md-4 col-xs-12">
                <div className="m-portlet m-portlet--tab">
                  <TotalDomainRevenueBreakdown/>
                  <TotalEmailRevenueBreakdown/>
                  <TotalHostingRevenueBreakdown/>
                </div>
            </div> 
           
        </div>
        </div>
    </div>
  )
}

export default Index