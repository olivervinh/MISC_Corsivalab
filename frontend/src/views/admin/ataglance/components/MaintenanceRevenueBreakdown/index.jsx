import React, { useEffect, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { getTotalConfirm2020 } from './confirm2020/apiRequest'
import { getTotalConfirm2021 } from './confirm2021/apiRequest'
import { getTotalConfirm2022 } from './confirm2022/apiRequest'
import { getTotalConfirm2023 } from './confirm2023/apiRequest'
import { getTotalForecast2020 } from './forecast2020/apiRequest'
import { getTotalForecast2021 } from './forecast2021/apiRequest'
import { getTotalForecast2022 } from './forecast2022/apiRequest'
import { getTotalForecast2023 } from './forecast2023/apiRequest'
import Loading from '../../../../../components/loading/index'
const Index = () => {
    const [loadingTotalConfirm2020,setLoadingTotalConfirm2020] = useState([])
    const [loadingTotalConfirm2021,setLoadingTotalConfirm2021] = useState([])
    const [loadingTotalConfirm2022,setLoadingTotalConfirm2022] = useState([])
    const [loadingTotalConfirm2023,setLoadingTotalConfirm2023] = useState([])
    const [loadingTotalForecast2020,setLoadingTotalForecast2020] = useState([])
    const [loadingTotalForecast2021,setLoadingTotalForecast2021] = useState([])
    const [loadingTotalForecast2022,setLoadingTotalForecast2022] = useState([])
    const [loadingTotalForecast2023,setLoadingTotalForecast2023] = useState([])
    const TotalConfirm2020 = useSelector((state)=>state.confirm2020.object.data)
    const TotalConfirm2021 = useSelector((state)=>state.confirm2021.object.data)
    const TotalConfirm2022 = useSelector((state)=>state.confirm2022.object.data)
    const TotalConfirm2023 = useSelector((state)=>state.confirm2023.object.data)
    const TotalForecast2020 = useSelector((state)=>state.forecast2020.object.data)
    const TotalForecast2021 = useSelector((state)=>state.forecast2021.object.data)
    const TotalForecast2022 = useSelector((state)=>state.forecast2022.object.data)
    const TotalForecast2023 = useSelector((state)=>state.forecast2023.object.data)
    const dispatch = useDispatch()
    useEffect(()=>{
        getTotalConfirm2020(dispatch)
        if(TotalConfirm2020!=null)
        setLoadingTotalConfirm2020(true)
    },[])
    useEffect(()=>{
        getTotalConfirm2021(dispatch)
        if(TotalConfirm2021!=null)
        setLoadingTotalConfirm2021(true)
    },[])
    useEffect(()=>{
        getTotalConfirm2022(dispatch)
        if(TotalConfirm2022!=null)
        setLoadingTotalConfirm2022(true)
    },[])
    useEffect(()=>{
        getTotalConfirm2023(dispatch)
        if(TotalConfirm2023!=null)
        setLoadingTotalConfirm2023(true)
    },[])
    useEffect(()=>{
        getTotalForecast2020(dispatch)
        if(TotalForecast2020!=null)
        setLoadingTotalForecast2020(true)
    },[])
    useEffect(()=>{
        getTotalForecast2021(dispatch)
        if(TotalForecast2021!=null)
        setLoadingTotalForecast2021(true)
    },[])
    useEffect(()=>{
        getTotalForecast2022(dispatch)
        if(TotalForecast2022!=null)
        setLoadingTotalForecast2022(true)
    },[])
    useEffect(()=>{
        getTotalForecast2023(dispatch)
        if(TotalForecast2023!=null)
        setLoadingTotalForecast2023(true)
    },[])
  return (
<div className="m-portlet m-portlet--tab">
    <div className="m-portlet__head">
        <div className="m-portlet__head-caption">
            <div className="m-portlet__head-title">
                <h3 className="m-portlet__head-text">Maintenance Revenue Breakdown</h3>
            </div>
        </div>
    </div>
    <div className="m-portlet__body">
    {loadingTotalConfirm2020==true
    &&loadingTotalConfirm2021==true
    &&loadingTotalConfirm2022==true
    &&loadingTotalConfirm2023==true
    &&loadingTotalForecast2020==true
    &&loadingTotalForecast2021==true
    &&loadingTotalForecast2022==true
    &&loadingTotalForecast2023==true?<table className="table table-bordered">
    <thead>
        <tr>
            <th scope="col">Year</th>
            <th scope="col">Total forecast plus confirmed revenue </th>
            <th scope="col">Total confirmed revenue</th>
            <th scope="col">Average Confirmed Revenue per month</th>
            <th scope="col">Average forecast plus confirmed revenue per month</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>2020</td>
            <td>${(TotalForecast2020+TotalConfirm2020)}</td>
            <td>${TotalConfirm2020}</td>
            <td>${TotalConfirm2020/12}</td>
            <td>${(TotalForecast2020+TotalConfirm2020)/12}</td>
        </tr>
        <tr>
            <td>2021</td>
            <td>${TotalForecast2021+TotalConfirm2021}</td>
            <td>${TotalConfirm2021}</td>
            <td>${(TotalConfirm2021)/12}</td>
            <td>${(TotalForecast2021+TotalConfirm2021)/12}</td>
        </tr>
        <tr>
            <td>2022</td>
            <td>${TotalConfirm2022+TotalConfirm2022}</td>
            <td>${TotalConfirm2022}</td>
            <td>${(TotalConfirm2022)/12}</td>
            <td>${(TotalForecast2022+TotalConfirm2022)/12}</td>
        </tr>
        <tr>
            <td>2023</td>
            <td>${TotalForecast2023+TotalConfirm2023}</td>
            <td>${TotalConfirm2023}</td>
            <td>${(TotalConfirm2023)/12}</td>
            <td>${(TotalForecast2023+TotalConfirm2023)/12}</td>
        </tr>
    </tbody>
</table>:<Loading/>}
    </div>
</div>
  )
}
export default Index