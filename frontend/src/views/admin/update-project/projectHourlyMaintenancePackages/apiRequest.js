import axiosClient from "../../../../services/api/axiosClient"
import {start,success,failed} from './slice.js'
export const get_UpdateProject_ProjectHourlyMaintenancePackages = async(dispatch,param) =>{
    dispatch(start())
    try{
        const res = await axiosClient.get("ProjectHourlyMaintenancePackages?id="+param.Id+"")
        console.log('res',res)
        dispatch(success(res))
    }catch(err){
        dispatch(failed(err))
    }
}