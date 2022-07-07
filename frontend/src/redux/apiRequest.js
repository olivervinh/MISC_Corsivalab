import axios from "axios"
import { loginFailed, loginStart, loginSuccess, logOutStart, registerFailed, registerStart, registerSuccess } from "./authSlice"
import { deleteUserFailed, deleteUsersSuccess, deleteUserStart, getUsersFailed, getUsersStart, getUsersSuccess } from "./userSlice"
//npm install axios
export const loginUser = async(user, dispatch,navigate) => {
    console.log("env is",process.env.Backend_URL)
    dispatch(loginStart())
    try {
        const res = await axios.post(`https://localhost:44328/api/Staffs/login`, user)
        dispatch(loginSuccess(res.data))
        navigate("/admin/dashboard")
        console.log(res.data)
    } catch (err) {
        dispatch(loginFailed())
    }
}
export const registerUser = async(user, dispatch, navigate) => {
    dispatch(registerStart())
    try {
        console.log(user)
        await axios.post("/v1/auth/register", user)
        dispatch(registerSuccess())
        navigate("/login")
    } catch (err) {
        dispatch(registerFailed())
    }
}
export const getAllUsers = async(accessToken, dispatch, axiosJWT) => {
    dispatch(getUsersStart())
    try {
        const res = await axiosJWT.get("/v1/user", {
            headers: {
                token: `Bearer ${accessToken}`
            }
        })
        dispatch(getUsersSuccess(res.data))
    } catch (err) {
        dispatch(getUsersFailed())
    }
}
export const deleteUser = async(accessToken, dispatch, id, axiosJWT) => {
    dispatch(deleteUserStart())
    try {
        const res = await axiosJWT.delete("/v1/user/" + id, {
            headers: {
                token: `Bearer ${accessToken}`
            },
        });
        dispatch(deleteUsersSuccess(res.data))
    } catch (err) {
        dispatch(deleteUserFailed(err.response.data))
    }
}

// export const logOut = async(dispatch, navigate) => {
//     dispatch(logOutStart())
//     try {
      
//     }
// }