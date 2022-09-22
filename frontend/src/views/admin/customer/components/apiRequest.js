import axios from "axios"
import axiosClient from "services/api/axiosClient.js"
import {start,success,failed} from './slice.js'
export const getCustomers = async(dispatch) =>{
    dispatch(start())
    try{
        const res = await axiosClient.get("Customers/GetAll")
        console.log("data customer", res)
        dispatch(success(res))
    }catch(err){
        dispatch(failed(err))
    }
}