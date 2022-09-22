import {createSlice} from "@reduxjs/toolkit"
const TotalConfirm2020Slice = createSlice({
    name:"TotalConfirm2020",
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
} = TotalConfirm2020Slice.actions
export default TotalConfirm2020Slice.reducer