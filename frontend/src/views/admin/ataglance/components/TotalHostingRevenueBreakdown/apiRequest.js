import axios from "axios"
import axiosClient from "services/api/axiosClient.js"
import {start,success,failed} from './slice.js'
export const getActMainProjAssigned = async(dispatch) =>{
    dispatch(start())
    try{
        const res = await axiosClient.get("Dashboards/ListProjectCountMaintenance")
        dispatch(success(res))
    }catch(err){
        dispatch(failed(err))
    }
}