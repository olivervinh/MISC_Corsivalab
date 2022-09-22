import {createSlice} from "@reduxjs/toolkit"
const TotalForecast2022Slice = createSlice({
    name:"TotalForecast2022",
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
} = TotalForecast2022Slice.actions
export default TotalForecast2022Slice.reducer