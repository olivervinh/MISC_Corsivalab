import React from 'react'

const Emailsystem = () => {
  return (
    <div class="m-content">
    <div class="m-portlet m-portlet--mobile">
        <div class="m-portlet__head">
            <div class="m-portlet__head-caption">
                <div class="m-portlet__head-title">
                    <h3 class="m-portlet__head-text">eEmail System
                    </h3>
                </div>
            </div>
            <div class="m-portlet__head-tools">
                <ul class="m-portlet__nav">
                    <li class="m-portlet__nav-item">

                    </li>
                </ul>
            </div>
        </div>
        <div class="m-portlet__body">
            <div class="m-form m-form--label-align-right m--margin-top-20 m--margin-bottom-30">
                <div class="row align-items-center">
                    <div class="col-xl-8 order-2 order-xl-1">
                        <div class="form-group m-form__group row align-items-center">
                           
                            <div class="col-md-8">
                                <div class="m-input-icon m-input-icon--left">
                                    <input type="text" class="form-control m-input" placeholder="Search..." id="generalSearch"/>
                                    <span class="m-input-icon__icon m-input-icon__icon--left">
                                        <span>
                                            <i class="la la-search"></i>
                                        </span>
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-xl-4 order-1 order-xl-2 m--align-right">
                        <a href="#m_modal_1" data-toggle="modal" data-target="#m_modal_1"  class="btn btn-primary m-btn m-btn--custom m-btn--icon m-btn--air m-btn--pill">
                            <span>
                                <i class="la la-plus"></i>
                                <span>New Email System</span>
                            </span>
                        </a>
                        <div class="m-separator m-separator--dashed d-xl-none"></div>
                    </div>
                </div>
            </div>
            <table class="m-datatable" id="html_table" width="100%">
                <thead>
                    <tr>
                        <th title="Field #1">ID</th>
                        <th title="Field #2">Email System</th>
                        <th title="Field #6">Actions</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td></td>
                        <td></td>
                        <td data-field="Actions" class="m-datatable__cell">
                            <span style="overflow: visible; position: relative; width: 110px;">
                                <div class="dropdown ">
                                    <a href="#" onclick='lolclick("<% Response.Write(i.Id); %>")' class="btn m-btn m-btn--hover-accent m-btn--icon m-btn--icon-only m-btn--pill" data-toggle="dropdown"><i class="la la-ellipsis-h"></i></a>
                                    <div class="dropdown-menu dropdown-menu-right">
                                        <a class="dropdown-item" id='"<% Response.Write(i.Id); %>"' data-toggle='modal' onclick='getUpdateId("<% Response.Write(i.Id); %>")' data-target='#UpdateModal'><i class="la la-edit"></i>Update</a>
                                        <a class="dropdown-item" id='"<% Response.Write(i.Id); %>"' data-toggle='modal' onclick='getDeleteId("<% Response.Write(i.Id); %>")' data-target='#deleteModal'><i class="la la-trash"></i>Delete</a>
                                    </div>
                                </div>
                            </span>
                        </td>
                    </tr>
                </tbody>
            </table>
              <input type="hidden" name="updateId" id="updateId" value="" />
        </div>
    </div>
</div>
  )
}

export default Emailsystem