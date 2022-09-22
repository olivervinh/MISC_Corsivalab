import React from 'react'
import ProjectDetail from '../update-project/projectDetails'
import ProjectBackUpLink from '../update-project/projectBackupLink'
import ForecastMaintenance from '../update-project/forecastMaintenance'
import ProjectMonthlyMaintenance from '../update-project/projectMonthlyMaintenancePackages'
import ProjectHourlyMaintenance from './projectHourlyMaintenancePackages'
const Index = () => {
  return (
    <div className="m-content" style={{paddingLeft: 10+"%"}}>
         <div className="row">
            <div className="col-md-6">
                <ProjectDetail/>
            </div>
            <div className='col-md-6'>
               <ProjectBackUpLink/>
               <ForecastMaintenance/>
            </div>
        </div>
        <div class="row">
              <ProjectMonthlyMaintenance/>
              <ProjectHourlyMaintenance/>
        </div>
    </div>
  )
}
export default Index