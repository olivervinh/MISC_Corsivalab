import axios from "axios"
import axiosClient from "services/api/axiosClient.js"
import {start,success,failed} from './slice.js'
export const getTotalDomainRevenueBreakdown = async(dispatch) =>{
    dispatch(start())
    try{
        const res = await axiosClient.get("Ataglances/TotalAndDomainRevenueBreakdownList")
        dispatch(success(res))
    }catch(err){
        dispatch(failed(err))
    }
}