import React, { useEffect, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { get_UpdateProject_GetProjectDetail } from './apiRequest'
import queryString from 'query-string'
import {useLocation } from 'react-router-dom';
import Loading from '../../../../components/loading/index'
const Index = () => {
    const[loading,setLoading] = useState(false)
    const value = useSelector((state)=>state.UpdateProject_GetProjectDetail.object.data)
    const dispatch = useDispatch()
    const {search} = useLocation()
    const param = queryString.parse(search)
    useEffect(()=>{
        get_UpdateProject_GetProjectDetail(dispatch,param)
        if(value!=null)
            setLoading(true)
    },[])
  return(
    <div className="m-portlet m-portlet--tab" style={{marginTop:130+"px"}}>
        {loading?
      <div className="m-portlet__body">
      <h5 style={{fontWeight: 'bold'}}>Project Details</h5>
      <hr/>
      <div className="form-group m-form__group form">
          <label for="exampleInputEmail1">Title</label>
          <input className="form-control m-input" value={value.Title}></input>
          <div></div>
      </div>
      <div className="form-group m-form__group form">
          <label for="exampleSelect1">Project Nature</label>
          <input className="form-control m-input" value={value.ProjectNature}></input>
      </div>
      <div className="form-group m-form__group form">
          <label for="exampleSelect1">Project Phase</label>
          <input className="form-control m-input" value={value.ProjectNature}></input>
      </div>
      <div className="form-group m-form__group form">
          <label for="exampleSelect1">Customer</label>
          <input className="form-control m-input" value={value.CustomerName}></input>
      </div>
      <div className="form-group m-form__group form">
          <label for="exampleSelect1">AM</label>
          <select className="form-control m-input m-input--air" aria-label="Default select example">
              <option selected>Open this select menu</option>
              <option value="1">One</option>
              <option value="2">Two</option>
              <option value="3">Three</option>
          </select>
      </div>
      <div className="form-group m-form__group form">
          <label for="exampleSelect1">Maintain By</label>
          <select className="form-control m-input m-input--air" aria-label="Default select example">
              <option selected>Open this select menu</option>
              <option value="1">One</ option>
              <option value="2">Two</option>
              <option value="3">Three</option>
          </select>
        <div className="form-group m-form__group form">
          <label for="exampleSelect1">Hourly Maintenance Link</label>
          <div className="group-random">
              <input className="form-control m-input input-random" value={value.MaintenanceShortLink}></input>
              <button className="btn btn-primary button-random" type="button">Generate</button>
          </div>
      </div>
      <div>
          <div id="buttonAccessMaintenanceLinkId" style={{display:"flex",justifyContent:"center",marginTop:-10+"px"}}>
              <button className="btn btn-success">Copy Url Link</button>
          </div>
      </div>
      <div className="form-group m-form__group form">
          <label for="exampleSelect1">Google Drive Link</label>
          <div className="group-random">
              <input className="form-control m-input input-random" input={value.TheFirstLink}></input>
              <button className="btn btn-primary button-random">Generate</button>
          </div>
      </div>
      <div className="form-group m-form__group form ">
          <label for="exampleSelect1">Link to give to customer</label>
          <div className="group-random">
          <input className="form-control m-input"></input>
          <input autocomplete="off" className="form-control m-input" input={value.TheSecondLink} style={{display: "none"}}/>
          <button className="btn btn-success">Copy Url Link</button>
      </div>
     </div>
      <h5 style={{marginTop: 3+"rem", fontWeight: "bold"}}>Remarks</h5>
      <hr/>
      <div class="form-group m-form__group form">
          <input className="form-control m-input" rows="4" cols="50" input="" ></input>
      </div>
      <button className="btn btn-primary">Update</button>
   </div>
 </div>:<Loading/>    
    }
      
    </div>
  )
}
export default Index