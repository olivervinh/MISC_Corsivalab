import axios from "axios"
import axiosClient from "services/api/axiosClient.js"
import {start,success,failed} from './slice.js'
export const getMaintenance_Hourly = async(dispatch) =>{
    dispatch(start())
    try{
        const res = await axiosClient.get("Maintenances/GetMaintenanceHourly")
        console.log('data value hourly',res)
        dispatch(success(res))
    }catch(err){
        dispatch(failed(err))
    }
}