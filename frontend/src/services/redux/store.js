//trước hết phải có thằng config store
import { combineReducers, configureStore } from "@reduxjs/toolkit"
import authReducer from "../../views/auth/signIn/authSlice" //import nó vào
import userReducer from "./userSlice"
import actMainProjAssignedReducer from "../../views/admin/dashboard/components/ActMainProjAssigned/slice"
import countProjNotTaggedReducer from "../../views/admin/dashboard/components/CountProjNotTagged/slice"
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
    //dashboard
    actMainProjAssigned:actMainProjAssignedReducer,
    countProjNotTagged:countProjNotTaggedReducer
    //dashboard
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