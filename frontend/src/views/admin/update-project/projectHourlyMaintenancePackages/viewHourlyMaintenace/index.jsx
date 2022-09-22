import React from 'react'

const Index = () => {
  return (
    <div className="modal fade" id="ViewHourlyMaintenace" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div className="modal-dialog" role="document">
            <div className="modal-content">
                <div className="modal-header">
                    <h5 className="modal-title">Project hourly maintenace record</h5>
                    <button type="button" className="close" data-dismiss="modal" aria-label="Close">
                        <i aria-hidden="true" className="ki ki-close"></i>
                    </button>
                </div>
                <div className="modal-body">
                    <div className="form-group m-form__group form">
                        <label for="exampleInputPassword1">Hour Packge</label>
                        <select className="form-control m-input m-input--air" ID="DropDownList1">
                            <option value="20 Hours">20 Hours</option>
                            <option value="50 Hours">50 Hours</option>
                            <option value="100 Hours">100 Hours</option>
                        </select>
                    </div>
                     <div className="form-group m-form__group form">
                        <label for="currency">Currency</label>
                             <div className="input-group">
                            <div className="input-group-append">
                                <select ID="CurrencyDropDownList_Hourly_View" className="form-control">
                                </select>
                            </div>
                        </div>
                    </div>
                    <div className="form-group m-form__group form">
                        <label for="exampleInputPassword1">Cost</label>
                        <input className="form-control m-input" placeholder="Cost" ID="TextBox1"></input>
                    </div>
                    <div className="form-group m-form__group form">
                        <label for="exampleSelect1">Purchased Date</label>
                        <input ID="TextBox2" className="form-control" type="date" value="10-11-2021"></input>
                    </div>
                    <div className="form-group m-form__group form">
                        <label for="exampleInputRemark1">Remark</label>
                        <div className="input-group remark">
                            <input TextMode="MultiLine" className="form-control m-input" ID="ViewRemarkProjectHourlyMaintenance"></input>
                        </div>
                    </div>
                </div>
                <div className="modal-footer">
                    <button type="button" className="btn btn-light-primary font-weight-bold">Close</button>
                    <button className="btn btn-primary font-weight-bold" Text="Update" ID="Button5" OnClick="EditHourlyMaintenaceBtn_Click" />
                </div>
            </div>
        </div>
    </div>
  )
}
export default Index