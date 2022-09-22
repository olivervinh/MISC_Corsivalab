import {createSlice} from "@reduxjs/toolkit"
const UpdateProject_GetForecaseMaintenanceSlice = createSlice({
    name:"UpdateProject_ProjectBackupLink",
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
} = UpdateProject_GetForecaseMaintenanceSlice.actions
export default UpdateProject_GetForecaseMaintenanceSlice.reducer