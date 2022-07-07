import React from 'react'

const Dashboard = () => {
  return (
    <div class="m-portlet__body">
        <div class="row">
            <div class="col-md-12">
                <div class="m-content">
                    <div class="col-md-12 col-lg-12 col-sm-12" style="background:white;border-radius:20px;">
                        <h3 class="m-portlet__head-text" style="margin:20px;padding:24px">Playground</h3>
                        <div class="row" style="text-align:center;">
                            <div onclick="window.open('https://docs.google.com/spreadsheets/d/11UbCMGAYbzOwORi1bruC5HUsTifY9B-5GVfBwcaUAQo/edit?usp=drive_web&ouid=101690653334038670521', '_blank')" class="playground-section col-6 col-lg-2 col-md-3" style="padding:20px;"><img class="playground-image" src="../assets/images/google-docs-144.png"><div>Handover Record</div></div>
                            <div onclick="window.open('https://docs.google.com/spreadsheets/d/120O6FCLKruWfIZVkcyUObkhYXymA5W3tthKzn7roGeI/edit#gid=1266764925', '_blank')" class="playground-section col-6 col-lg-2 col-md-3" style="padding:20px;"><img class="playground-image" src="../assets/images/google-docs-144.png"><div>Hosting Record</div></div>
                            <div onclick="window.open('https://docs.google.com/spreadsheets/d/1sDbRVlvZ2klVUrcXnRwws4jh0EF78vBPtNBt9IoMqM4/edit#gid=0', '_blank')" class="playground-section col-6 col-lg-2 col-md-3" style="padding:20px;"><img class="playground-image" src="../assets/images/google-docs-144.png"><div>Hourly Maintenance Tracking</div></div>
                            <div onclick="window.open('https://docs.google.com/document/d/1ZRUx6LDApIenp0DwICg0rzLmiqE-ddecnFzaQzyvtz8/edit#', '_blank')" class="playground-section col-6 col-lg-2 col-md-3" style="padding:20px;"><img class="playground-image" src="../assets/images/google-docs-144.png"><div>Reply Template</div></div>
                            <div onclick="window.open('https://docs.google.com/spreadsheets/d/1jI0KyZMZmWt7Fbc24CxvoFoN1I7C42D_YwaAiXt-sPM/edit#gid=43041470', '_blank')" class="playground-section col-6 col-lg-2 col-md-3" style="padding:20px;"><img class="playground-image" src="../assets/images/google-docs-144.png"><div>Renewal Record</div></div>
                            <div onclick="window.open('https://docs.google.com/spreadsheets/d/1211pTD5LpcP1nQGBeR6yiVLzSk2d286q/edit?usp=sharing&ouid=101690653334038670521&rtpof=true&sd=true', '_blank')" class="playground-section col-6 col-lg-2 col-md-3" style="padding:20px;"><img class="playground-image" src="../assets/images/google-docs-144.png"><div>Customer Email Record</div></div>
                            <div onclick="window.open('https://drive.google.com/drive/folders/13p1Jf7eSNzMkwS42uAeHPIhJzZRSkbcb', '_blank')" class="playground-section col-6 col-lg-2 col-md-3" style="padding:20px;"><img class="playground-image" src="../assets/images/google-docs-144.png"><div>Project PPT</div></div>
                               <div onclick="window.open('https://drive.google.com/drive/folders/1jlhSCZh9pXw7IiR5zUNluSYoywODFVg1', '_blank')" class="playground-section col-6 col-lg-2 col-md-3" style="padding:20px;"><img class="playground-image" src="../assets/images/google-docs-144.png"><div>Maintenance LDP</div></div>
                        </div>
                    </div>
                    <div style="background-color:white;border-radius:20px;">
                          <h3 class="m-portlet__head-text" style="margin:20px;padding:24px">Active Maintenance Project Assigned</h3>
                        <div class="custom-table-responsive">
                            <table class="table" style="margin:20px">
                                <thead>
                                    <tr>
                                        <th scope="col">#</th>
                                        <th scope="col">Maintain by</th>
                                        <th scope="col">Count</th>
                                        <th scope="col">Action</th>
                                    </tr>
                                </thead>
                                <tbody>

                                    <tr>
                                        <th scope="row"></th>
                                        <td></td>
                                        <td></td>
                                         <td><a class="btn btn-primary editemailbtn" href="MaintenanceProjectAssigned.aspx?rq=<%=a.MaintainBy %>"  style="color: #ffffff">View Projects</a></td>
                                    </tr>  
                                </tbody>
                            </table>
                        </div>
                    </div>
                    <div style="background-color: white;margin-top:24px;border-radius:20px;" >
                          <h3 class="m-portlet__head-text" style="margin:20px;padding:24px;display:inline-block">Count projects not tagged to any maintenance person </h3>
                          <h5 style="display:inline-block"><%=countnottagged %></h5>
                          <td><a class="btn btn-primary editemailbtn" href="MaintenanceProjectAssigned.aspx?rqno=no person"  style="color: #ffffff">  View projects</a>
                                </td>
                        <div class="custom-table-responsive">
                            <table class="table" style="margin:20px">
                                <thead>
                                    <tr>
                                        <th style="width:33.33%" scope="col">#</th>
                                        <th style="width:33.33%" scope="col">Count</th>
                                        <th style="width:33.33%" scope="col">Action</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <th scope="row">1</th>
                                        <td></td>
                                         <td><a class="btn btn-primary editemailbtn" href="MaintenanceProjectAssigned.aspx?rqno=no person"  style="color: #ffffff">  View projects</a></td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                        <div style="padding:24px"></div>
                    </div>
                    <div class="m-portlet m-portlet--mobile" style="margin-top:30px;border-radius:20px;">
                        <h3 class="m-portlet__head-text" style="margin:20px;padding:24px;">Expiry within 120 Days</h3>
                        <div class="m-portlet__body">
                            <div class="m-form m-form--label-align-right">
                                <div class="row align-items-center  m--margin-bottom-20">
                                    <div class="col-xl-12 order-2 order-xl-1">
                                        <div class="form-group m-form__group row align-items-center">
                                            <div class="col-md-12">
                                                <div class="m-input-icon m-input-icon--left">
                                                    <input type="text" class="form-control m-input" placeholder="Search..." id="generalSearch2">
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
                            <ul class="nav nav-tabs nav-fill" role="tablist">
                                <li class="nav-item">
                                    <a class="nav-link active" data-toggle="tab" href="#m_tabs_2_1">Domain</a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" data-toggle="tab" href="#m_tabs_2_2">Hosting</a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" data-toggle="tab" href="#m_tabs_2_3">Email System</a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" data-toggle="tab" href="#m_tabs_2_4">Monthly Maintenance</a>
                                </li>
                            </ul>
                            <div class="tab-content">
                                <div class="tab-pane active" id="m_tabs_2_1" role="tabpanel">
                                    <!--begin: Datatable -->
                                    <table class="m-datatable3" id="html_table" width="100%">
                                        <thead>
                                            <tr>
                                                <th title="Field #1">ID</th>
                                                <th title="Field #2">Title</th>
                                                <th title="Field #2">Customer</th>
                                                <th title="Field #2">Maintain By</th>
                                                <th title="Field #2">Expiry</th>
                                                <th title="Field #6">Actions</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td></td>
                                                <td></td>
                                                <td></td>
                                                <td></td>
                                                <td> </td>
                                                <td data-field="Actions" class="m-datatable__cell">
                                                    <span style="overflow: visible; position: relative; width: 110px;">
                                                        <div class="dropdown ">
                                                            <a href="#" onclick='lolclick("<% Response.Write(a.Id); %>")' class="btn m-btn m-btn--hover-accent m-btn--icon m-btn--icon-only m-btn--pill" data-toggle="dropdown"><i class="la la-ellipsis-h"></i></a>
                                                            <div class="dropdown-menu dropdown-menu-right">
                                                                <a class="dropdown-item" href="Update-Project.aspx?id=<%=a.Id%>"><i class="la la-leaf"></i>Update Project</a>
                                                                <a class="dropdown-item" href="View-MaintenanceReport.aspx?id=<%=p.Id%>">View Maintenance Report</a>   --%>
                                                            </div>
                                                        </div>
                                                    </span>
                                                </td>
                                            </tr>                     
                                        </tbody>
                                    </table>        
                                </div>
                                <div class="tab-pane" id="m_tabs_2_2" role="tabpanel">
                                    <table class="m-datatable4" id="html_table" width="100%">
                                        <thead>
                                            <tr>
                                                <th title="Field #1">ID</th>
                                                <th title="Field #2">Title</th>
                                                <th title="Field #2">Customer</th>
                                                <th title="Field #2">Maintain By</th>
                                                <th title="Field #2">Expiry</th>
                                                <th title="Field #6">Actions</th>
                                            </tr>
                                        </thead>
                                        <tbody>  
                                            <tr>
                                                <td></td>
                                                <td></td>
                                                <td></td>
                                                <td></td>
                                                <td></td>
                                                <td data-field="Actions" class="m-datatable__cell">
                                                    <span style="overflow: visible; position: relative; width: 110px;">
                                                        <div class="dropdown ">
                                                            <a href="#" onclick='lolclick("<% Response.Write(a.Id); %>")' class="btn m-btn m-btn--hover-accent m-btn--icon m-btn--icon-only m-btn--pill" data-toggle="dropdown"><i class="la la-ellipsis-h"></i></a>
                                                            <div class="dropdown-menu dropdown-menu-right">
                                                                <a class="dropdown-item" href="Update-Project.aspx?id=<%=a.Id%>"><i class="la la-leaf"></i>Update Project</a>
                                                                <a class="dropdown-item" href="View-MaintenanceReport.aspx?id=<%=p.Id%>">View Maintenance Report</a>   --%>
                                                            </div>
                                                        </div>
                                                    </span>
                                                </td>
                                            </tr>                              
                                        </tbody>
                                    </table>
                                </div>
                                <div class="tab-pane" id="m_tabs_2_3" role="tabpanel">
                                    <table class="m-datatable5" id="html_table" width="100%">
                                        <thead>
                                            <tr>
                                                <th title="Field #1">ID</th>
                                                <th title="Field #2">Title</th>
                                                <th title="Field #2">Customer</th>
                                                <th title="Field #2">Maintain By</th>
                                                <th title="Field #2">Expiry</th>
                                                <th title="Field #6">Actions</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td></td>
                                                <td></td>
                                                <td></td>
                                                <td></td>
                                                <td></td>
                                                <td data-field="Actions" class="m-datatable__cell">
                                                    <span style="overflow: visible; position: relative; width: 110px;">
                                                        <div class="dropdown ">
                                                            <a href="#" onclick='lolclick("<% Response.Write(a.Id); %>")' class="btn m-btn m-btn--hover-accent m-btn--icon m-btn--icon-only m-btn--pill" data-toggle="dropdown"><i class="la la-ellipsis-h"></i></a>
                                                            <div class="dropdown-menu dropdown-menu-right">
                                                                <a class="dropdown-item" href="Update-Project.aspx?id=<%=a.Id%>"><i class="la la-leaf"></i>Update Project</a>
                                                              <a class="dropdown-item" href="View-MaintenanceReport.aspx?id=<%=p.Id%>">View Maintenance Report</a>
                                                            </div>
                                                        </div>
                                                    </span>
                                                </td>
                                            </tr>           
                                        </tbody>
                                    </table>
                                </div>
                                <div class="tab-pane" id="m_tabs_2_4" role="tabpanel"> 
                                    <table class="m-datatable6" id="html_table" width="100%">
                                        <thead class="m-datatable__head">
                                            <tr>
                                                <th title="Field #1">ID</th>
                                                <th title="Field #2">Title</th>
                                                <th title="Field #2">Customer</th>
                                                <th title="Field #2">Maintain By</th>
                                                <th title="Field #2">Expiry</th>
                                                <th title="Field #6">Actions</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td></td>
                                                <td></td>
                                                <td></td>
                                                <td></td>
                                                <td></td>
                                                <td data-field="Actions" class="m-datatable__cell">
                                                    <span style="overflow: visible; position: relative; width: 110px;">
                                                        <div class="dropdown ">
                                                            <a href="#" onclick='lolclick("<% Response.Write(a.Id); %>")' class="btn m-btn m-btn--hover-accent m-btn--icon m-btn--icon-only m-btn--pill" data-toggle="dropdown"><i class="la la-ellipsis-h"></i></a>
                                                            <div class="dropdown-menu dropdown-menu-right">
                                                                <a class="dropdown-item" href="Update-Project.aspx?id=<%=a.Id%>"><i class="la la-leaf"></i>Update Project</a>
                                                              <a class="dropdown-item" href="View-MaintenanceReport.aspx?id=<%=p.Id%>">View Maintenance Report</a>  
                                                            </div>
                                                        </div>
                                                    </span>
                                                </td>
                                            </tr>                    
                                        </tbody>
                                    </table> 
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
  )
}

export default Dashboard
