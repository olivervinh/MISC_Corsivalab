import React, { useState } from 'react'
import './index.css'
import Image from '../../../assets/login/images/corsivalab.png'
import Tilt from 'react-tilt'
import { loginUser } from "../../../services/api/userApiRequest";
import { useDispatch } from "react-redux";
import { useEffect } from 'react';
import { useHistory } from 'react-router-dom';
 function  SignIn(){
    //init use stage
    const history = useHistory()
    const [username,setUserName]=useState("hoongyaw@corsivalab.com")
    const [password,setPassword]=useState("corsiva_LAB_1991")
    const [localStorage_user,setLocalStorage_user] = useState()
    const dispatch = useDispatch()
    const handleLogin= (e)=>{
        e.preventDefault()
        const newUser={
            username:username,
            password:password,
        }
        var result = loginUser(newUser,dispatch)
        result.then(function(res){
            localStorage.setItem('user',res)
            console.log("user object",res)
            if(res!=null){
                history.push('/admin')
            }
        })
    }
    return (
        <div className="limiter">
            <div className="container-login100">
                <div className="wrap-login100">
                    <div className="login100-pic Tilt">
                        <Tilt className="Tilt" options={{ max: 25 }} style={{ height: 250, width: 250 }} >
                            <img className="Tilt-inner" src={Image} />
                        </Tilt>
                    </div>
                    <form className="login100-form validate-form" onSubmit={handleLogin}>
                        <div className="mobile-logo"><img width="150" height="150" src={Image} /></div>
                        <span className="login100-form-title">Login</span>
                        <div className="wrap-input100 validate-input">
                            <input className="input100" placeholder="Email" value={"hoongyaw@corsivalab.com"} onChange={(e)=>setUserName(e.target.value)}></input>
                            <span className="focus-input100"></span>
                            <span className="symbol-input100">
                                <i className="fa fa-envelope" aria-hidden="true"></i>
                            </span>
                        </div>
                        <div className="wrap-input100 validate-input">
                            <input TextMode="Password" className="input100" value={"corsiva_LAB_1991"}  placeholder="password" onChange={(e)=>setPassword(e.target.value)}></input>
                            <span className="focus-input100"></span>
                            <span className="symbol-input100">
                                <i className="fa fa-lock" aria-hidden="true"></i>
                            </span>
                        </div>
                        <div className="container-login100-form-btn">
                            <button className="login100-form-btn" type='submit'>Login</button>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    )
}
export default SignIn

