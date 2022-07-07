//trước hết phải có thằng config store
import { combineReducers, configureStore } from "@reduxjs/toolkit"
import authReducer from "./authSlice" //import nó vào
import userReducer from "./userSlice"
import {
    persistStore,
    persistReducer,
    FLUSH,
    REHYDRATE,
    PAUSE,
    PERSIST,
    PURGE,
    REGISTER,
} from 'redux-persist'
import storage from "redux-persist/lib/storage"
const persistConfig = {
    key: 'root',
    version: 1,
    storage
}
const rootReducer = combineReducers({
    auth: authReducer,
    users: userReducer,
})
const persistedReducer = persistReducer(persistConfig, rootReducer)
export const store = configureStore({ //export cái store này ra
    reducer: persistedReducer, 
    middleware: (getDefaultMiddleware) =>
        getDefaultMiddleware({
            serializableCheck: {
                ignoredActions: [FLUSH, REHYDRATE, PAUSE, PERSIST, PURGE, REGISTER],
            },
        }),
})

export let persistor = persistStore(store)
//store là nơi chứa toàn bộ reduce
//redux toolkit là 1 cách sử dụng stage bất cứ đâu trong React App, ko cần phải truyền qua props
//export default configureStore({
// reducer:{
//    auth:authReducer  //export cái này ra
//},    
//}) 