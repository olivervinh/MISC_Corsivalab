import axios from "axios"
import axiosClient from "../../../../../../services/api/axiosClient"
import {start,success,failed} from './slice.js'
export const getTotalForecast2023 = async(dispatch) =>{
    dispatch(start())
    try{
        const res = await axiosClient.get("Ataglances/TotalForecast2023")
        dispatch(success(res))
    }catch(err){
        dispatch(failed(err))
    }
}