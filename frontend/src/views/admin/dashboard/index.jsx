import './css/index.css'
import LinkGoogleDoc from './components/LinkGoogleDoc'
import ActMainProjAssigned from './components/ActMainProjAssigned'
import CountProjNotTagged from './components/CountProjNotTagged'

function Index() {
   
  return (
    <div className="m-portlet__body">
    <div className="row">
        <div className="col-md-12">
            <div className="m-content">
                <LinkGoogleDoc/>
                <ActMainProjAssigned/>
                <CountProjNotTagged/>
            </div>
        </div>
    </div>
</div>
  )
}

export default Index