import axiosClient from "services/api/axiosClient.js"
import {start,success,failed} from './slice.js'
export const getProjects = async(dispatch) =>{
    dispatch(start())
    try{
        const res = await axiosClient.get("Projects/GetAll")
        console.log('data project',res)
        dispatch(success(res))
    }catch(err){
        dispatch(failed(err))
    }
}