import React from 'react'
import TotalDomainHostingEmailMaintRevenueBreakdown from './components/totalDomainHostingEmailMaintRevenueBreakdown'
import TotalProjects from './components/totalProjects'

const Index = () => {
  return (
    <div className="m-content"style={{marginTop:130+"px"}}>
        <div className="row">
            <TotalProjects/>
            <TotalDomainHostingEmailMaintRevenueBreakdown/>
        </div>
    </div>
  )
}

export default Index