import axios from "axios"
import axiosClient from "services/api/axiosClient.js"
import {start,success,failed} from './slice.js'
export const getExpiry120Days_emailSystem = async(dispatch) =>{
    dispatch(start())
    try{
        const res = await axiosClient.get("Dashboards/ListProject120Email")
        dispatch(success(res))
    }catch(err){
        dispatch(failed(err))
    }
}