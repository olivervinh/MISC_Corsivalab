import axios from "axios"
import { loginFailed, loginStart, loginSuccess, logOutStart, registerFailed, registerStart, registerSuccess } from "../redux/authSlice"
import { deleteUserFailed, deleteUsersSuccess, deleteUserStart, getUsersFailed, getUsersStart, getUsersSuccess } from "../redux/userSlice"
import  { Redirect } from 'react-router-dom'
import axiosClient from "./axiosClient"
//npm install axios
export const loginUser = async(user, dispatch) => {
    dispatch(loginStart())
    try {
        const url = 'staffs/login'
        const res = await axiosClient.post(url,user)
        console.log("data",res)
        dispatch(loginSuccess(res.data.responseObject)) //dispatch loginSuccess res.data
        console.log(res.data)
        return <Redirect to='/'/>
    } catch (err) {
        dispatch(loginFailed())
    }
}