import {createSlice} from "@reduxjs/toolkit"
const Maintenance_MonthlySlice = createSlice({
    name:"Maintenance_Monthly",
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
} = Maintenance_MonthlySlice.actions
export default Maintenance_MonthlySlice.reducer