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
import confirm2020Reducer from "../../views/admin/ataglance/components/MaintenanceRevenueBreakdown/confirm2020/slice"
import confirm2021Reducer from "../../views/admin/ataglance/components/MaintenanceRevenueBreakdown/confirm2021/slice"
import confirm2022Reducer from "../../views/admin/ataglance/components/MaintenanceRevenueBreakdown/confirm2022/slice"
import confirm2023Reducer from "../../views/admin/ataglance/components/MaintenanceRevenueBreakdown/confirm2023/slice"
import forecast2020Reducer from "../../views/admin/ataglance/components/MaintenanceRevenueBreakdown/forecast2020/slice"
import forecast2021Reducer from "../../views/admin/ataglance/components/MaintenanceRevenueBreakdown/forecast2021/slice"
import forecast2022Reducer from "../../views/admin/ataglance/components/MaintenanceRevenueBreakdown/forecast2022/slice"
import forecast2023Reducer from "../../views/admin/ataglance/components/MaintenanceRevenueBreakdown/forecast2023/slice"
import maintenance_MonthlyReducer from "../../views/admin/maintenance/components/Monthly/slice"
import maintenance_HourlyReducer from "../../views/admin/maintenance/components/Hourly/slice"
import maintenanceProjectAssignedsReducer from "../../views/admin/dashboard/components/ActMainProjAssigned/MaintenanceProjectAssigned/slice" 
import UpdateProject_GetProjectDetailReducer from "../../views/admin/update-project/projectDetails/slice"
import UpdateProject_ProjectMonthlyMaintenancePackagesReducer from "../../views/admin/update-project/projectMonthlyMaintenancePackages/slice"
import UpedateProject_HourlyMonthlyMaintenancePackagesReducer from "../../views/admin/update-project/projectHourlyMaintenancePackages/slice"
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
    //MaintenanceProjectAssigneds
    maintenanceProjectAssigneds:maintenanceProjectAssignedsReducer,
    //MaintenanceProjectAssigneds
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
    confirm2020:confirm2020Reducer,
    confirm2021:confirm2021Reducer,
    confirm2022:confirm2022Reducer,
    confirm2023:confirm2023Reducer,
    forecast2020:forecast2020Reducer,
    forecast2021:forecast2021Reducer,
    forecast2022:forecast2022Reducer,
    forecast2023:forecast2023Reducer,
    //ataglance
    //maintenance
    maintenance_Monthly:maintenance_MonthlyReducer,
    maintenance_Hourly:maintenance_HourlyReducer,
    //maintenance
    //update-project
    UpdateProject_GetProjectDetail:UpdateProject_GetProjectDetailReducer,
    UpdateProject_ProjectMonthlyMaintenancePackages:UpdateProject_ProjectMonthlyMaintenancePackagesReducer
    //update-project
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