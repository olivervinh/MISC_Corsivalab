import './css/index.css'
import React from 'react'
import CountProjNotTagged from './components/CountProjNotTagged'
import ActMainProjAssigned from './components/ActMainProjAssigned'

function Index() {
  return (
    <div class="m-portlet__body">
    <div class="row">
        <div class="col-md-12">
            <div class="m-content">
                <ActMainProjAssigned/>
            </div>
        </div>
    </div>
</div>
  )
}

export default Index