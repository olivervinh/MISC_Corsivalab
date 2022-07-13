import axios from "axios"
import { loginFailed, loginStart, loginSuccess, logOutStart, registerFailed, registerStart, registerSuccess } from "./authSlice"
import { deleteUserFailed, deleteUsersSuccess, deleteUserStart, getUsersFailed, getUsersStart, getUsersSuccess } from "./userSlice"
import  { Redirect } from 'react-router-dom'
//npm install axios
export const loginUser = async(user, dispatch,navigate) => {
    dispatch(loginStart())
    try {
        
        const res = await axios.post(`https://localhost:44328/api/Staffs/login`, user)
        console.log("data",res)
        dispatch(loginSuccess(res.data.responseObject)) //dispatch loginSuccess res.data
        console.log(res.data)
        return <Redirect to='/'/>
    } catch (err) {
        dispatch(loginFailed())
    }
}