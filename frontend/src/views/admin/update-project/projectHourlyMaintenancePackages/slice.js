import {createSlice} from "@reduxjs/toolkit"
const UpdateProject_GetProjectHourlyMaintenancePackagesSlice = createSlice({
    name:"UpdateProject_GetProjectHourlyMaintenancePackages",
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
} = UpdateProject_GetProjectHourlyMaintenancePackagesSlice.actions
export default UpdateProject_GetProjectHourlyMaintenancePackagesSlice.reducer