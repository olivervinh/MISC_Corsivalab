import axiosClient from "../../../../services/api/axiosClient"
import {start,success,failed} from './slice.js'
export const get_UpdateProject_GetProjectDetail = async(dispatch,param) =>{
    console.log('param',param)
    dispatch(start())
    try{
        console.log('param',param)
        const res = await axiosClient.get("ProjectDetails?id="+param.Id+"")
        console.log('res',res)
        dispatch(success(res))
    }catch(err){
        dispatch(failed(err))
    }
}