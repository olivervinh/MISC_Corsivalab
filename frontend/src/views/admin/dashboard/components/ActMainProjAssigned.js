import React from 'react'
import ImageGoogleDoc from '../../../../assets/dashboard/google-docs-144.png'
import urlGoogleDoc from '../variables/urlGoogleDoc'
function ActMainProjAssigned() {
    const HandoverRecordOnClick = () => {
        location.href = urlGoogleDoc.HandoverRecord
    }
    const HostingRecordOnClick = () => {
        location.href = urlGoogleDoc.HostingRecord
    }
    const HourlyMaintenanceTrackingOnClick = () => {
        location.href = urlGoogleDoc.HourlyMaintenanceTracking
    }
    const ReplyTemplateOnClick = () => {
        location.href = urlGoogleDoc.ReplyTemplate
    }
    const RenewalRecordOnClick = () => {
        location.href = urlGoogleDoc.RenewalRecord
    }
    const CustomerEmailRecordOnClick = () => {
        location.href = urlGoogleDoc.CustomerEmailRecord
    }
    const ProjectPPTOnClick = () => {
        location.href = urlGoogleDoc.ProjectPPT
    }
    const MaintenanceLDPOnClick = () => {
        location.href = urlGoogleDoc.MaintenanceLDP
    }
  return (
    <div class="col-md-12 col-lg-12 col-sm-12" style="background:white;border-radius:20px;">
       <h3 class="m-portlet__head-text" style="margin:20px;padding:24px">Playground</h3>
        <div class="row" style="text-align:center;">
            <div class="playground-section col-6 col-lg-2 col-md-3" onClick={HandoverRecordOnClick} style={{padding:20}}><img class="playground-image" src={ImageGoogleDoc}/><div>Handover Record</div></div>
            <div class="playground-section col-6 col-lg-2 col-md-3" onClick={HostingRecordOnClick} style={{padding:20}}><img class="playground-image" src={ImageGoogleDoc}/><div>Hosting Record</div></div>
            <div class="playground-section col-6 col-lg-2 col-md-3" onClick={HourlyMaintenanceTrackingOnClick} style={{padding:20}}><img class="playground-image" src={ImageGoogleDoc}/><div>Hourly Maintenance Tracking</div></div>
            <div class="playground-section col-6 col-lg-2 col-md-3" onClick={ReplyTemplateOnClick} style={{padding:20}}><img class="playground-image" src={ImageGoogleDoc}/><div>Reply Template</div></div>
            <div class="playground-section col-6 col-lg-2 col-md-3" onClick={RenewalRecordOnClick} style={{padding:20}}><img class="playground-image" src={ImageGoogleDoc}/><div>Renewal Record</div></div>
            <div class="playground-section col-6 col-lg-2 col-md-3" onClick={CustomerEmailRecordOnClick} style={{padding:20}}><img class="playground-image" src={ImageGoogleDoc}/><div>Customer Email Record</div></div>
            <div class="playground-section col-6 col-lg-2 col-md-3" onClick={ProjectPPTOnClick} style={{padding:20}}><img class="playground-image" src={ImageGoogleDoc}/><div>Project PPT</div></div>
            <div class="playground-section col-6 col-lg-2 col-md-3" onClick={MaintenanceLDPOnClick} style={{padding:20}}><img class="playground-image" src={ImageGoogleDoc}/><div>Maintenance LDP</div></div>
        </div>
     </div>
  )
}

export default ActMainProjAssigned