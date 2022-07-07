import React from 'react'

const Maintenance = () => {
  return (
    <div class="m-content">
    <div class="m-portlet m-portlet--mobile">
        <div class="m-portlet__head">
            <div class="m-portlet__head-caption">
                <div class="m-portlet__head-title">
                    <h3 class="m-portlet__head-text">Maintenance Table
                    </h3>
                </div>
            </div>
            <div class="m-portlet__head-tools">
                <ul class="m-portlet__nav">
                    <li class="m-portlet__nav-item"></li>
                </ul>
            </div>
        </div>
        <div class="m-portlet__body">

            <!--begin: Search Form -->
            <div class="m-form m-form--label-align-right m--margin-top-20 m--margin-bottom-30">
                <div class="row align-items-center">
                    <div class="col-xl-8 order-2 order-xl-1">
                        <div class="form-group m-form__group row align-items-center">
                            <div class="col-md-8">
                                <div class="m-input-icon m-input-icon--left">
                                    <input type="text" class="form-control m-input" placeholder="Search..." id="generalSearch">
                                    <span class="m-input-icon__icon m-input-icon__icon--left">
                                        <span>
                                            <i class="la la-search"></i>
                                        </span>
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <!--end: Search Form -->
            <ul class="nav nav-tabs nav-fill" role="tablist">
                <li class="nav-item">
                    <a class="nav-link active" data-toggle="tab" id="month" href="#m_tabs_1_1" runat="server">Monthly</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" data-toggle="tab" id="hour" href="#m_tabs_2_2" runat="server">Hourly</a>
                </li>
            </ul>
            <!--begin: Datatable -->
            <div class="tab-content">
                <div class="tab-pane active" id="m_tabs_1_1" role="tabpanel">
                    <table class="m-datatable" id="html_table" width="100%">
                        <thead>
                            <tr>
                                <th title="Field #1">Customer</th>
                                <th title="Field #2">Project Title</th>
                                <% if (currStaff.Team != "205" && currStaff.Team != "305")
                                    { %>
                                <th>Maintain By</th>
                                <%} %>
                                <th title="Field #2">Project Type</th>
                                <th title="Field #6">Expiry Date</th>
                                <th title="Field #6">Report Last Uploaded</th>
                                <th title="Field #6">Action</th>
                            </tr>
                        </thead>
                        <tbody>
                            <%
                                foreach (MaintenancesMontly m in listMaintenance)
                                {
                            %>
                            <tr>
                                <td><%=m.project.Customer.Company %></td>
                                <%if (m.project != null)
                                    {
                                %>
                                <td><%=m.project.Title %></td>
                                <%
                                    }
                                    else
                                    {
                                %>
                                <td>Null</td>

                                <%
                                    }
                                %>
                                <% if (currStaff.Team != "205" && currStaff.Team != "305")
                                    { %>
                                <td><%=m.project.MaintainBy %></td>
                                <%} %>
                                <%if (m.project.ProjectNature != 0)
                                    {
                                %>
                                <td><%=getProjectNature(m.project.ProjectNature) %></td>

                                <%
                                    }
                                    else
                                    {
                                %>
                                <td>Null</td>

                                <%
                                    }
                                %>
                                <td><%=m.ExpiryTime.ToString("dd MMM yyyy")%></td>
                                <% var LastUploaded = GetLastUploaded(m);
                                    if (LastUploaded != null)
                                    {
                                %>
                                <td><%= (DateTime.UtcNow.AddHours(8) - LastUploaded.CreatedAt).TotalDays > 30 ? "<span style='background-color:#E43A45; color: white; padding: 8px'>" + LastUploaded.CreatedAt.ToString("MMM yyyy") + "</span>" : LastUploaded.CreatedAt.ToString("MMM yyyy")%></td>
                                <td><span style="background-color: #E43A45; color: white; padding: 8px">Null</span></td>
                                <td data-field="Actions" class="m-datatable__cell">
                                    <span style="overflow: visible; position: relative; width: 110px;">
                                        <div class="dropdown ">
                                            <a href="#" onclick='lolclick("<% Response.Write(m.Id); %>")' class="btn m-btn m-btn--hover-accent m-btn--icon m-btn--icon-only m-btn--pill" data-toggle="dropdown"><i class="la la-ellipsis-h"></i></a>
                                            <div class="dropdown-menu dropdown-menu-right">
                                                <a href="View-MaintenanceReport.aspx?id=<%=m.Id %>" class="dropdown-item">View Maintenance Report</a>
                                            </div>
                                        </div>
                                    </span>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <div class="tab-pane" id="m_tabs_2_2" role="tabpanel">
                    <table class="m-datatable1" id="html_table" width="100%">
                        <thead>
                            <tr>
                                <th title="Field #1">ID</th>
                                <th title="Field #2">Project</th>
                                <th title="Field #2">Project Type</th>
                                <th title="Field #2">Service Hour Left</th>

                                <th title="Field #6">Expiry Date</th>
                                <th title="Field #6">Report Last Uploaded</th>
                                <th title="Field #6">Action</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td></td>
                                <td></td>
                                <td>Null</td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td>Null</td>

                                <td data-field="Actions" class="m-datatable__cell">
                                    <span style="overflow: visible; position: relative; width: 110px;">
                                        <div class="dropdown ">
                                            <a href="#" onclick='lolclick2("<% Response.Write(m.Id); %>")' class="btn m-btn m-btn--hover-accent m-btn--icon m-btn--icon-only m-btn--pill" data-toggle="dropdown"><i class="la la-ellipsis-h"></i></a>
                                            <div class="dropdown-menu dropdown-menu-right">
                                                <a class="dropdown-item" id='"<% Response.Write(m.Id); %>"' data-toggle='modal' onclick='getUpdateId("<% Response.Write(m.project.Id); %>")' data-target='#MRModal'><i class="la la-edit"></i>Add Maintenance Report</a>-
                                                <a href="View-MaintenanceReport.aspx?id=<%=m.project.Id %>" class="dropdown-item">View Maintenance Report</a>
                                                <a class="dropdown-item" id='"<% Response.Write(m.Id); %>"' data-toggle='modal' onclick='getUpdateId("<% Response.Write(m.Id); %>")' data-target='#UpdateModalHourly'><i class="la la-edit"></i>Update</a>
                                                <a class="dropdown-item" id='"<% Response.Write(m.Id); %>"' data-toggle='modal' onclick='getDeleteId("<% Response.Write(m.Id); %>")' data-target='#deleteModal2'><i class="la la-trash"></i>Delete</a>
                                            </div>
                                        </div>
                                    </span>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
            <input type="hidden" name="updateId" id="updateId" value="" />
        </div>
    </div>
</div>
  )
}

export default Maintenance