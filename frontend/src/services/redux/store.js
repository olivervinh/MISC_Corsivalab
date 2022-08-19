//trước hết phải có thằng config store
import { combineReducers, configureStore } from "@reduxjs/toolkit"
import authReducer from "../../views/auth/signIn/authSlice" //import nó vào
import actMainProjAssignedReducer from "../../views/admin/dashboard/components/ActMainProjAssigned/slice"
import countProjNotTaggedReducer from "../../views/admin/dashboard/components/CountProjNotTagged/slice"
import expiry120Days_domainReducer from "../../views/admin/dashboard/components/Expiry120Days/domain/slice"
import expiry120Days_emailSystemReducer from "../../views/admin/dashboard/components/Expiry120Days/emailSystem/slice"
import expiry120Days_hostingReducer from "../../views/admin/dashboard/components/Expiry120Days/hosting/slice"
import expiry120Days_maintenanceReducer from "../../views/admin/dashboard/components/Expiry120Days/maintenance/slice"
import projectsReducer from "../../views/admin/projects/components/slice"
import customersReducer from "../../views/admin/customer/components/slice"
import tableMaintePeriodReducer from "../../views/admin/ataglance/components/TableMaintPeriod/slice"
import totalDomainRevenueBreakdownReducer from "../../views/admin/ataglance/components/TotalDomainRevenueBreakdown/slice"
import totalEmailMaintRevenueBreakdownReducer from "../../views/admin/ataglance/components/TotalEmailMaintRevenueBreakdown/slice"
import totalHostingRevenueBreakdownReducer from "../../views/admin/ataglance/components/TotalHostingRevenueBreakdown/slice"
import totalProjectsReducer from "../../views/admin/ataglance/components/TotalProjects/slice"
import maintenance_MonthlyReducer from "../../views/admin/maintenance/components/Monthly/slice"
import maintenance_HourlyReducer from "../../views/admin/maintenance/components/Hourly/slice"
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
    //dashboard
    actMainProjAssigned:actMainProjAssignedReducer,
    countProjNotTagged:countProjNotTaggedReducer,
    //120 days
    expiry120Days_domain : expiry120Days_domainReducer,
    expiry120Days_emailSystem : expiry120Days_emailSystemReducer,
    expiry120Days_hosting:expiry120Days_hostingReducer,
    expiry120Days_maintenance:expiry120Days_maintenanceReducer,
    //120 days
    //dashboard

    //projects
    projects:projectsReducer,
    //projects

    //customer
    customers :customersReducer,
    //customer

    //ataglance
    tableMaintePeriod:tableMaintePeriodReducer,
    totalDomainRevenueBreakdown:totalDomainRevenueBreakdownReducer,
    totalEmailRevenueBreakdown:totalEmailMaintRevenueBreakdownReducer,
    totalHostingRevenueBreakdown:totalHostingRevenueBreakdownReducer,
    totalProjects:totalProjectsReducer,
    //ataglance

    //maintenance
    maintenance_Monthly:maintenance_MonthlyReducer,
    maintenance_Hourly:maintenance_HourlyReducer
    //maintenance

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