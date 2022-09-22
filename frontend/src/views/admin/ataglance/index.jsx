import React, { useReducer } from 'react'
import TotalProjects from './components/TotalProjects/index'
import TotalDomainRevenueBreakdown from './components/TotalDomainRevenueBreakdown/index'
import TotalEmailRevenueBreakdown from './components/TotalEmailMaintRevenueBreakdown/index'
import TotalHostingRevenueBreakdown from './components/TotalHostingRevenueBreakdown/index'
import MaintenanceRevenueBreakdown from './components/MaintenanceRevenueBreakdown/index'
//email
const Index = () => {
  return (
    <div className="m-content"style={{marginTop:130+"px"}}>
        <div className="row">
          <div className="col-md-12 col-xs-12">
              <TotalProjects/>
          </div>
          <div className="col-md-4 col-xs-12">
              <TotalDomainRevenueBreakdown/>
          </div>
          <div className="col-md-4 col-xs-12">
              <TotalEmailRevenueBreakdown/>
          </div>
          <div className="col-md-4 col-xs-12">
              <TotalHostingRevenueBreakdown/> 
          </div>
          <div className='col-md-12 col-xs-12'>
              <MaintenanceRevenueBreakdown/>
          </div>
      </div>
    </div>
  )
}
export default Index