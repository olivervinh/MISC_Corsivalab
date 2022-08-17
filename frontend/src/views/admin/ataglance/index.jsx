import React, { useReducer } from 'react'
import TotalProjects from './components/totalProjects'
import TotalDomainRevenueBreakdown from './components/totalDomainRevenueBreakdown'
import axiosClient from 'services/api/axiosClient'
import { useEffect } from 'react'
const initState = {
  loading : false,
  data :[],
  error:null
}
//domain
const domainReducer = (state,action) =>{
  switch(action.type){
    case 'GET_DOMAIN_REQUEST':
      return{
        ...state, // -> 
        loading:true
      }
    case 'GET_DOMAIN_SUCCESS':
      return{
        ...state,
        loading:false,
        data:action.data
      }
    case 'GET_DOMAIN_ERROR':
      return{
        ...state,
        data:[],
        error:action.data
      }
  }
}
//domain

//email
const emailReducer = (state,action) =>{
  switch(action.type){
    case 'GET_EMAIL_REQUEST':
      return{
        ...state, // -> 
        loading:true
      }
    case 'GET_EMAIL_SUCCESS':
      return{
        ...state,
        loading:false,
        data:action.data
      }
    case 'GET_EMAIL_ERROR':
      return{
        ...state,
        data:[],
        error:action.data
      }
  }
}
//email
const Index = () => {
  // domain
  const [domain,dispatch1] = useReducer(domainReducer,initState)
  useEffect(()=>{
    dispatch1({
      type:'GET_DOMAIN_REQUEST'
    })
    async function getTotalAndDomainRevenueBreakdownList() {
      const res = await axiosClient.get("Ataglances/TotalAndDomainRevenueBreakdownList")
      return res
    }
          //after call domain
    getTotalAndDomainRevenueBreakdownList()
      .then(resolve => dispatch1({
        type:'GET_DOMAIN_SUCCESS',
        data:resolve
      }))
      .catch(err =>   
        dispatch1({
        type:'GET_USER_ERROR',
        data:err
      }))
  },null)
  return (
    <div className="m-content"style={{marginTop:130+"px"}}>
        <div className="row">
            <TotalProjects/>
            <div>
            <div className="col-md-4 col-xs-12">
                <div className="m-portlet m-portlet--tab">
                    {/* <TotalDomainRevenueBreakdown data={domain}/> */}
                </div>
            </div> 
           
        </div>
        </div>
    </div>
  )
}

export default Index