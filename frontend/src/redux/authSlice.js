import { createSlice } from "@reduxjs/toolkit"
const authSlice = createSlice({
    name: "auth", //đặt tên cho slice này
    initialState: { //
        login: {
            currentUser: null, //khỏi tạo
            isFetching: false, //để làm chức năng loading
            error: false //error false là chưa có lỗi
        },
        register:{
            isFetching:false,
            error:false,
            success:false
        },
        logout:{
            isFetching:false,
            error:false,            
        }
    },
    reducers: { //đây là reducer
        loginStart: (state) => {
            state.login.isFetching = true //đang
        },
        loginSuccess: (state, action) => { // login thành công
            state.login.isFetching = true;
            state.login.currentUser = action.payload;
            console.log(action)
            state.login.error = false; //login error bằng false
        },
        loginFailed: (state) => { // login thất bại
            state.login.isFetching = true; // false
            state.login.error = true; //true
        },
        logOutSuccess: (state) => {
            state.logout.isFetching = false;
            state.login.currentUser = null;
            state.logout.error = false;
        },
        logOutFailed: (state) => {
            state.login.isFetching = false;
            state.login.error = true;
        },
        logOutStart: (state) => {
            state.logout.isFetching = true
        },
    }
})

export const { //export nó ra
    loginStart,
    loginFailed,
    loginSuccess,
    logOutStart,
    logOutSuccess,
    logOutFailed
} = authSlice.actions //từ cái thằng authSlice.actions
export default authSlice.reducer