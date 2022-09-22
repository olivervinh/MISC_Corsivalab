import axios from "axios"
import axiosClient from "../../../../../../services/api/axiosClient.js"
import {start,success,failed} from './slice.js'
export const getMaintenanceProjectAssigned = async(dispatch,params) =>{
    dispatch(start())
    try{
        const res = await axiosClient.get("MaintenanceProjectAssigneds/GetMaintenanceProjectAssigned?maintainBy="+params.MaintainBy)
        dispatch(success(res))
    }catch(err){
        dispatch(failed(err))
    }
}