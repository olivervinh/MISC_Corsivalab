import axiosClient from "../../../../services/api/axiosClient"
import {start,success,failed} from './slice.js'
export const get_UpdateProject_GetForecastMaintenance = async(dispatch,param) =>{
    dispatch(start())
    try{
        const res = await axiosClient.get("GetForecastMaintenance?id="+param.Id+"")
        dispatch(success(res))
    }catch(err){
        dispatch(failed(err))
    }
}