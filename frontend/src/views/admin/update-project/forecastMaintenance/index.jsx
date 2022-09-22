import React from 'react'
const Index = () => {
  return (
<div className="m-portlet m-portlet--tab" id="monthly" style={{height: 690+"px"}}>
    <div className="m-portlet__head">
        <div className="m-portlet__head-caption">
            <div className="m-portlet__head-title">
                <span className="m-portlet__head-icon m--hide">
                    <i className="la la-gear"></i>
                </span>
                <h3 className="m-portlet__head-text">Forecast Maintenance
                </h3>
            </div>
        </div>
    </div>
    <div className="m-portlet__body">
        <div className="form-group m-form__group form">
            <label for="forecast">Forecast Maintenance</label>
            <div className="input-group">
                <input className="form-control m-input"></input>
            </div>
        </div>
        <div className="form-group m-form__group form">
            <label>Forecast Month to start</label>
            <div className="input-group date">
            <input className="form-control m-input input-random"></input>
            </div>
        </div>
        <div className="form-group m-form__group form">
         <label for="forecast">Forecast Amount</label>
            <div className="input-group">
             <div className="input-group-append">
                <select className="form-control m-input m-input--air" aria-label="Default select example">
                    <option selected>Open this select menu</option>
                    <option value="Month">Month</ option>
                    <option value="Quarter">Quarter</option>
                    <option value="Bi-annual">Bi-annual</option>
                    <option value="Annual">Annual</option>
                </select>
                </div>
            </div>
        </div>
        <button className="btn btn-primary">Update</button>
    </div>
</div>
  )
}

export default Index