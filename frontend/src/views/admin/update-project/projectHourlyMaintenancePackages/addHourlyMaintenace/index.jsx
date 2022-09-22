import React from 'react'

const Index = () => {
  return (
    <div className="modal fade" id="AddHourlyMaintenace" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
    <div className="modal-dialog" role="document">
        <div className="modal-content">
            <div className="modal-header">
                <h5 className="modal-title">Add Hourly Maintenance Details</h5>
                <button type="button" className="close" data-dismiss="modal" aria-label="Close">
                    <i aria-hidden="true" className="ki ki-close"></i>
                </button>
            </div>
            <div className="modal-body">
                <div className="form-group m-form__group form" runat="server">
                    <label for="exampleInputPassword1">Hour Packge</label>
                    <select className="form-control m-input m-input--air" ID="DropDownListAddHourlyMaintenace" runat="server">
                        <option value="1 Hour">1 Hour</option>
                        <option value="2 Hours">2 Hours</option>
                        <option value="3 Hours">3 Hours</option>
                        <option value="4 Hours">4 Hours</option>
                        <option value="5 Hours">5 Hours</option>
                        <option value="6 Hours">6 Hours</option>
                        <option value="7 Hours">7 Hours</option>
                        <option value="8 Hours">8 Hours</option>
                        <option value="9 Hours">9 Hours</option>
                        <option value="10 Hours">10 Hours</option>
                        <option value="15 Hours">15 Hours</option>
                        <option value="20 Hours">20 Hours</option>
                        <option value="50 Hours">50 Hours</option>
                        <option value="100 Hours">100 Hours</option>
                    </select>
                </div>
                <div className="form-group m-form__group form" runat="server">
                    <label for="exampleInputPassword1">Amount</label>
                    <input className="form-control m-input" placeholder="Cost" ID="AddCostHourlyMaintenace" runat="server"></input>
                </div>
                  <div className="form-group m-form__group form" runat="server">
                    <label for="currency">Currency</label>
                         <div className="">
                        <div className="input-group-append">
                            <select runat="server" ID="CurrencyDropDownList_Hourly_Add" className="form-control">
                            </select>
                        </div>
                    </div>
                </div>
                <div className="form-group m-form__group form" runat="server">
                    <label for="exampleSelect1">Purchased Date</label>
                    <input ID="TextBoxBoughtTime" className="form-control" runat="server" type="date" value="10-11-2021"></input>
                </div>
                 <div className="form-group m-form__group form" runat="server">
                    <label for="exampleInputRemark1">Remark</label>
                    <div className="input-group remark">
                        <input TextMode="MultiLine" className="form-control m-input" ID="RemarkAddHourlyMaintenance" runat="server"></input>
                    </div>
                </div>
            </div>
            <div className="modal-footer">
                <button type="button" className="btn btn-light-primary font-weight-bold" data-dismiss="modal">Close</button>
                <button className="btn btn-primary font-weight-bold" runat="server" Text="Add" ID="AddRemarkHourlyMaintenance" OnClick="AddHourlyMaintenaceBtn_Click" />
            </div>
        </div>
    </div>
</div>
  )
}
export default Index