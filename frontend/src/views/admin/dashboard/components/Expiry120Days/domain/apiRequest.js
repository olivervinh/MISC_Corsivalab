import axios from "axios"
import axiosClient from "services/api/axiosClient.js"
import {start,success,failed} from './slice.js'
export const getExpiry120Days_domain = async(dispatch) =>{
    dispatch(start())
    try{
        const res = await axiosClient.get("Dashboards/ListProject120Domain")
        dispatch(success(res))
    }catch(err){
        dispatch(failed(err))
    }
}