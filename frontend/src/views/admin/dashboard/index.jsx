import './css/index.css'
import LinkGoogleDoc from './components/LinkGoogleDoc'
import ActMainProjAssigned from './components/ActMainProjAssigned'
import CountProjNotTagged from './components/CountProjNotTagged'
import Expiry120Days from './components/Expiry120Days'

function Index() {
   
  return (
    <div className="m-portlet__body"style={{marginTop:130+"px"}}>
    <div className="row">
        <div className="col-md-12">
            <div className="m-content">
                <ActMainProjAssigned/>
            </div>
        </div>
    </div>
</div>
  )
}

export default Index