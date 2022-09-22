import axios from "axios"
import axiosClient from "../../../../../../services/api/axiosClient"
import {start,success,failed} from './slice.js'
export const getTotalConfirm2021 = async(dispatch) =>{
    dispatch(start())
    try{
        const res = await axiosClient.get("Ataglances/TotalConfirm2021")
        dispatch(success(res))
    }catch(err){
        dispatch(failed(err))
    }
}