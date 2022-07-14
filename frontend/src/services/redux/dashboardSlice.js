import {createSlice} from "@reduxjs/toolkit"
import { actions } from "react-table";
const authDashboard = createSlice({
    name:"dashboard",
    initialState:{
        ListProjectsNoPerson:{
            data:null,
            isFetching: false, //để làm chức năng loading
            error: false //error false là chưa có lỗi
        }
    },
    reducers:{
        ListProjectsNoPersonStart:(state) => {
            state.ListProjectsNoPerson.isFetching = true
        },
        ListProjectsNoPersonSuccess:(state,action) =>{
            state.ListProjectsNoPerson.isFetching = true;
            state.ListProjectsNoPerson.data = action.payload
            state.ListProjectsNoPerson.error = false
        },
        ListProjectsNoPersonFailed:(state)=>{
            state.ListProjectsNoPerson.isFetching=true
            state.ListProjectsNoPerson.error = true
        }
    }
})
export const{
    ListProjectsNoPersonStart,
    ListProjectsNoPersonSuccess,
    ListProjectsNoPersonFailed
} =  authDashboard.actions
export default authDashboard.reducer