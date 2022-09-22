import axiosClient from "../../../../services/api/axiosClient"
import {start,success,failed} from './slice.js'
export const get_UpdateProject_ProjectMonthlyMaintenancePackages = async(dispatch,param) =>{
    dispatch(start())
    try{
        const res = await axiosClient.get("ProjectMonthlyMaintenancePackages?id="+param.FkProjectId+"")
        dispatch(success(res))
    }catch(err){
        dispatch(failed(err))
    }
}