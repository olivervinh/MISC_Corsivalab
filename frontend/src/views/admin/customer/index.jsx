import React from 'react'
import Customers from './components/index'
const Index = () => {
  return (
    <div className="m-portlet__body"style={{marginTop:130+"px"}}>
    <div className="row">
        <div className="col-md-12">
            <div className="m-content">
               <Customers/>
            </div>
        </div>
    </div>
</div>
  )
}
export default Index