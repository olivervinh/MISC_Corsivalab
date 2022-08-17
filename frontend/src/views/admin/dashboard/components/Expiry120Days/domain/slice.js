import {createSlice} from "@reduxjs/toolkit"
const Expiry120Days_domainSlice = createSlice({
    name:"Expiry120Days_domain",
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
} = Expiry120Days_domainSlice.actions
export default Expiry120Days_domainSlice.reducer