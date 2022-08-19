import {createSlice} from "@reduxjs/toolkit"
const totalHostingRevenueBreakdownSlice = createSlice({
    name:"TotalHostingRevenueBreakdown",
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
} = totalHostingRevenueBreakdownSlice.actions
export default totalHostingRevenueBreakdownSlice.reducer