import axios from "axios"
import { loginFailed, loginStart, loginSuccess } from "./authSlice.js"
import  { Redirect } from 'react-router-dom'
import axiosClient from "../../../services/api/axiosClient"
//npm install axios
export const loginUser = async(user, dispatch,navigate) => {
    dispatch(loginStart())
    try {
        const url = 'staffs/login'
        const res = await axiosClient.post(url,user)
        dispatch(loginSuccess(res.responseObject)) //dispatch loginSuccess res.data
        return res.responseObject
    } catch (err) {
        dispatch(loginFailed())
        return err
    }
}