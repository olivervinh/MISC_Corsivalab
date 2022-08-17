import { createSelector } from "@reduxjs/toolkit";
export const totalProjectSelector = (state) =>state.total
export const totalRemainingSelector = createSelector(
    totalProjectSelector,(total)=>{
        return total
    }
)