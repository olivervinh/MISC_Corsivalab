import {createSlice} from "@reduxjs/toolkit"
const get_UpdateProject_ProjectMonthlyMaintenancePackages = createSlice({
    name:"UpdateProject_ProjectMonthlyMaintenancePackages",
    initialState:{
        object:{
            data : null,
            isFetching :false,
            error:false 
        },
        msg: ""
    },
    reducers:{
        start:(state)=>{
            state.object.isFetching = true
        },
        success:(state,action)=>{
            state.object.isFetching = false
            state.object.data = action.payload
        },
        failed :(state,action)=>{
            state.object.isFetching=false
            state.object.error = true
            state.msg = action.payload
        }
    }
})
export const {
    start,
    success,
    failed
} = get_UpdateProject_ProjectMonthlyMaintenancePackages.actions
export default get_UpdateProject_ProjectMonthlyMaintenancePackages.reducer