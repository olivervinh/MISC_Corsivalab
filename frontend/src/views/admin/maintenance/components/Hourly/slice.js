import {createSlice} from "@reduxjs/toolkit"
const Maintenance_HourlySlice = createSlice({
    name:"Maintenance_Hourly",
    initialState:{
        object:{
            data : [],
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
} = Maintenance_HourlySlice.actions
export default Maintenance_HourlySlice.reducer