import React from 'react'

const Provider = () => {
  return (
    <div class="row" style="display: flex; flex-wrap:wrap; justify-content: space-evenly">
    <div class="m-portlet col-md-5 col-xs-12">
        <div class="m-portlet__head">
            <div class="m-portlet__head-caption">
                <div class="m-portlet__head-title">
                    <h3 class="m-portlet__head-text">Hosting Provider
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
            <div class="m-form m-form--label-align-right m--margin-top-20 m--margin-bottom-30">
                <div class="row align-items-center">
                    <div class="col-xl-4 order-1 order-xl-2 m--align-left">
                        <a href="#m_modal_1" data-toggle="modal" data-target="#m_modal_add_hosting_provider" class="btn btn-primary m-btn m-btn--custom m-btn--icon m-btn--air m-btn--pill">
                            <span>
                                <i class="la la-plus"></i>
                                <span>New Hosting Provider</span>
                            </span>
                        </a>               
                         <div class="m-separator m-separator--dashed d-xl-none"></div>
                    </div>
                    <div class="col-xl-4 order-1 order-xl-2 m--align-right">
                         <a class="btn btn-primary m-btn m-btn--custom m-btn--icon m-btn--air m-btn--pill" onclick="GenerateExcelFile()">
                            <span>
                                <i class="fa fa-file-excel-o" style="color: green;"></i>
                                <span style="color:white">Export excel</span>
                            </span>
                        </a>
                         <div class="m-separator m-separator--dashed d-xl-none"></div>
                    </div>
                </div>
            </div>
            <table class="table">
                <thead>
                    <tr>
                        <th>No.</th>
                        <th>Hosting Provider</th>
                        <th>Actions</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td></td>
                        <td></td>
                        <td data-field="Actions" class="m-datatable__cell">
                            <span style="overflow: visible; position: relative; width: 110px;">
                                <div class="dropdown ">
                                    <a href="#" onclick='hostingclick("<%=provider.ID %>")' class="btn m-btn m-btn--hover-accent m-btn--icon m-btn--icon-only m-btn--pill" data-toggle="dropdown"><i class="la la-ellipsis-h"></i></a>
                                    <div class="dropdown-menu dropdown-menu-right">
                                        <a class="dropdown-item" data-toggle='modal' onclick='getHostingUpdateId("<%=provider.ID %>")' data-target='#UpdateHostingProviderModal'><i class="la la-edit"></i>Update</a>
                                        <a class="dropdown-item" data-toggle='modal' onclick='getHostingDeleteId("<%=provider.ID %>")' data-target='#deleteHostingModal'><i class="la la-trash"></i>Delete</a>
                                    </div>
                                </div>
                            </span>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
    <div class="m-portlet col-md-5 col-xs-12">
        <div class="m-portlet__head">
            <div class="m-portlet__head-caption">
                <div class="m-portlet__head-title">
                    <h3 class="m-portlet__head-text">Domain Provider
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
                    <div class="col-xl-4 order-1 order-xl-2 m--align-right">
                        <a href="#m_modal_1" data-toggle="modal" data-target="#m_modal_add_domain_provider" class="btn btn-primary m-btn m-btn--custom m-btn--icon m-btn--air m-btn--pill">
                            <span>
                                <i class="la la-plus"></i>
                                <span>New Domain Provider</span>
                            </span>
                        </a>
                        <div class="m-separator m-separator--dashed d-xl-none"></div>
                    </div>
                </div>
            </div>
            <table class="table">
                <thead>
                    <tr>
                        <th>No.</th>
                        <th>Domain Provider</th>
                        <th>Actions</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td></td>
                        <td></td>
                        <td data-field="Actions" class="m-datatable__cell">
                            <span style="overflow: visible; position: relative; width: 110px;">
                                <div class="dropdown ">
                                    <a href="#" onclick='domainclick("<%=provider.ID %>")' class="btn m-btn m-btn--hover-accent m-btn--icon m-btn--icon-only m-btn--pill" data-toggle="dropdown"><i class="la la-ellipsis-h"></i></a>
                                    <div class="dropdown-menu dropdown-menu-right">
                                        <a class="dropdown-item" data-toggle='modal' onclick='getDomainUpdateId("<%=provider.ID %>")' data-target='#UpdateDomainProviderModal'><i class="la la-edit"></i>Update</a>
                                        <a class="dropdown-item" data-toggle='modal' onclick='getDomainDeleteId("<%=provider.ID %>")' data-target='#deleteDomainModal'><i class="la la-trash"></i>Delete</a>
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
  )
}

export default Provider