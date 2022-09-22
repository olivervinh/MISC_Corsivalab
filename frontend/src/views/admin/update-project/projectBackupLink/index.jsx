import React from 'react'
const Index = () => {
  return (
<div className="m-portlet m-portlet--tab"style={{marginTop:130+"px"}}>
    <div className="m-portlet__head">
        <div className="m-portlet__head-caption">
            <div className="m-portlet__head-title">
                <span className="m-portlet__head-icon m--hide">
                    <i className="la la-gear"></i>
                </span>
                <h3 className="m-portlet__head-text">Project Backup Link
                </h3>
            </div>
        </div>
    </div>
    <div className="m-portlet__body">
        <div className="form-group m-form__group form">
            <label>Link</label>
            <input className="form-control m-input" placeholder="BackUp Link"></input>
        </div>
        <button className="btn btn-primary">Update</button>
    </div>
    <div className="m-portlet__body">
        <div className="form-group m-form__group form">
            <label>Link</label>
            <input className="form-control m-input" placeholder="BackUp Link"></input>
        </div>
        <button className="btn btn-primary">Update</button>
    </div>
</div>
  )
}
export default Index