import { configureStore } from "@reduxjs/toolkit";
import totalProjectSlice from "views/admin/ataglance/slices/totalProjectsSlice";
const storeThunk = configureStore({
    reducer:{
        totalProjectSlice:totalProjectSlice.reducer
    }
})
export default storeThunk