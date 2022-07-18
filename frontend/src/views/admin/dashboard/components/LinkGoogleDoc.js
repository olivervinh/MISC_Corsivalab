import React from 'react'
import ImageGoogleDoc from '../../../../assets/dashboard/google-docs-144.png'
import urlGoogleDoc from '../variables/urlGoogleDoc'
import { Link} from 'react-router-dom';
function LinkGoogleDoc() {
    const HandoverRecordOnClick = () => {
        window.open(urlGoogleDoc.HandoverRecord)
    }
    const HostingRecordOnClick = () => {
        window.open(urlGoogleDoc.HostingRecord)
    }
    const HourlyMaintenanceTrackingOnClick = () => {
        window.open(urlGoogleDoc.HourlyMaintenanceTracking)
    }
    const ReplyTemplateOnClick = () => {
        window.open(urlGoogleDoc.ReplyTemplate)
    }
    const RenewalRecordOnClick = () => {
        window.open(urlGoogleDoc.RenewalRecord)
    }
    const CustomerEmailRecordOnClick = () => {
        window.open(urlGoogleDoc.CustomerEmailRecord)
    }
    const ProjectPPTOnClick = () => {
        window.open(urlGoogleDoc.ProjectPPT)
    }
    const MaintenanceLDPOnClick = () => {
        window.open(urlGoogleDoc.MaintenanceLDP)
    }
  return (
    <div className="col-md-12 col-lg-12 col-sm-12" style={{background:"white",borderRadius:"20px"}}>
       <h3 className="m-portlet__head-text" style={{margin:"20px",padding:"24px"}}>Playground</h3>
        <div className="row" style={{textAlign:"center"}}>
            <div className="playground-section col-6 col-lg-2 col-md-3" onClick={HandoverRecordOnClick} style={{padding:20}}><img className="playground-image" src={ImageGoogleDoc}/><div>Handover Record</div></div>
            <div className="playground-section col-6 col-lg-2 col-md-3" onClick={HostingRecordOnClick} style={{padding:20}}><img className="playground-image" src={ImageGoogleDoc}/><div>Hosting Record</div></div>
            <div className="playground-section col-6 col-lg-2 col-md-3" onClick={HourlyMaintenanceTrackingOnClick} style={{padding:20}}><img className="playground-image" src={ImageGoogleDoc}/><div>Hourly Maintenance Tracking</div></div>
            <div className="playground-section col-6 col-lg-2 col-md-3" onClick={ReplyTemplateOnClick} style={{padding:20}}><img className="playground-image" src={ImageGoogleDoc}/><div>Reply Template</div></div>
            <div className="playground-section col-6 col-lg-2 col-md-3" onClick={RenewalRecordOnClick} style={{padding:20}}><img className="playground-image" src={ImageGoogleDoc}/><div>Renewal Record</div></div>
            <div className="playground-section col-6 col-lg-2 col-md-3" onClick={CustomerEmailRecordOnClick} style={{padding:20}}><img className="playground-image" src={ImageGoogleDoc}/><div>Customer Email Record</div></div>
            <div className="playground-section col-6 col-lg-2 col-md-3" onClick={ProjectPPTOnClick} style={{padding:20}}><img className="playground-image" src={ImageGoogleDoc}/><div>Project PPT</div></div>
            <div className="playground-section col-6 col-lg-2 col-md-3" onClick={MaintenanceLDPOnClick} style={{padding:20}}><img className="playground-image" src={ImageGoogleDoc}/><div>Maintenance LDP</div></div>
        </div>
     </div>
  )
}

export default LinkGoogleDoc