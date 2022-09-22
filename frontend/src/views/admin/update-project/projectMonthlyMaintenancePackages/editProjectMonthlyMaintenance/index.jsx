import React from 'react'
const index = () => {
  return (
    <div className="modal fade" id="AddProjectMonthlyMaintenace" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
    <div className="modal-dialog" role="document">
        <div className="modal-content">
            <div className="modal-header">
                <h5 className="modal-title">Add Project Monthly Maintenance Details</h5>
                <button type="button" className="close" data-dismiss="modal" aria-label="Close">
                    <i aria-hidden="true" className="ki ki-close"></i>
                </button>
            </div>
            <div className="modal-body">
                <div className="form-group m-form__group form">
                    <label for="exampleInputPassword1">Start Date</label>
                    <input autocomplete="off" TextMode="Date" className="form-control m-input" placeholder="Start Date"></input>
                </div>
                <div className="form-group m-form__group form">
                    <label for="exampleInputPassword1">End Date</label>
                    <input autocomplete="off" TextMode="Date" className="form-control m-input" placeholder="End Date"></input>
                </div>
                <div className="form-group m-form__group form">
                    <label for="exampleInputPassword1">Amount</label>
                    <input autocomplete="off" className="form-control m-input" placeholder="Amount"></input>
                    <p id="add_amount_monthly_maintenance" className="wrong-value-display-none"></p>
                </div>
                <div className="form-group m-form__group form">
                    <label for="currency">Currency</label>
                         <div className="">
                        <div className="input-group-append">
                            <option ID="CurrencyDropDownList_Monthly_Add" className="form-control">
                            </option>
                        </div>
                    </div>
                </div>
                <div className="form-group m-form__group form">
                    <label for="PerMaintenaceMonth">Payment Cycle</label>
                    <div className="">
                        <div className="input-group-append">
                            <option ID="PerMaintenaceMonthDropDownList" className="form-control">
                                <option Value="Month">Month</option>
                                <option Value="Quarter">Quarter</option>
                                <option Value="Semi-Annual">Semi-Annual </option>
                                <option Value="Annual">Annual</option>
                            </option>
                        </div>
                    </div>
                </div>
                 <div className="form-group m-form__group form">
                    <label for="exampleInputRemark1">Remark</label>
                    <div className="input-group remark">
                        <input TextMode="MultiLine" autocomplete="off" className="form-control m-input"></input>
                    </div>
                </div>
            </div>
            <div className="modal-footer">
                <button type="button" className="btn btn-light-primary font-weight-bold" data-dismiss="modal">Close</button>
                <button className="btn btn-primary font-weight-bold" Text="Add" OnClick="AddProjectMonthlyMaintenacesBtn_Click" />
            </div>
        </div>
    </div>
</div>
  )
}
export default index