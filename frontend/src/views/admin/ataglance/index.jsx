import React from 'react'
import TotalProjects from './components/totalProjects'
import TotalDomainRevenueBreakdown from './components/totalDomainRevenueBreakdown'
import TotalEmailRevenueBreakdown from './components/totalEmailMaintRevenueBreakdown'
import TotalHostingRevenueBreakdown from './components/totalHostingRevenueBreakdown'
const Index = () => {
  return (
    <div className="m-content"style={{marginTop:130+"px"}}>
        <div className="row">
            <TotalProjects/>
            <div>
            <div className="col-md-4 col-xs-12">
                <div className="m-portlet m-portlet--tab">
                    <TotalDomainRevenueBreakdown/>
                </div>
            </div> 
           
        </div>
        </div>
    </div>
  )
}

export default Index