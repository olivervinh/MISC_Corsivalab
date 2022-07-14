import React, { useState } from 'react'
import './index.css'
import Image from '../../../assets/login/images/corsivalab.png'
import Tilt from 'react-tilt'
import { loginUser } from "../../../services/api/userApiRequest";
import { useDispatch } from "react-redux";
function SignIn(){
    //init use stage
    const [username,setUserName]=useState("hoongyaw@corsivalab.com")
    const [password,setPassword]=useState("corsiva_LAB_1991")
    const dispatch = useDispatch()
    const handleLogin=(e)=>{
        e.preventDefault()
        const newUser={
            username:username,
            password:password,
        }
        console.log(newUser)
        loginUser(newUser,dispatch)
    }
    return (
        <div class="limiter">
            <div class="container-login100">
                <div class="wrap-login100">
                    <div class="login100-pic Tilt">
                        <Tilt className="Tilt" options={{ max: 25 }} style={{ height: 250, width: 250 }} >
                            <img className="Tilt-inner" src={Image} />
                        </Tilt>
                    </div>
                    <form class="login100-form validate-form" onSubmit={handleLogin}>
                        <div class="mobile-logo"><img width="150" height="150" src={Image} /></div>
                        <span class="login100-form-title">Login</span>
                        <div class="wrap-input100 validate-input">
                            <input class="input100" placeholder="Email" value={"hoongyaw@corsivalab.com"} onChange={(e)=>setUserName(e.target.value)}></input>
                            <span class="focus-input100"></span>
                            <span class="symbol-input100">
                                <i class="fa fa-envelope" aria-hidden="true"></i>
                            </span>
                        </div>
                        <div class="wrap-input100 validate-input">
                            <input TextMode="Password" class="input100" value={"corsiva_LAB_1991"}  placeholder="password" onChange={(e)=>setPassword(e.target.value)}></input>
                            <span class="focus-input100"></span>
                            <span class="symbol-input100">
                                <i class="fa fa-lock" aria-hidden="true"></i>
                            </span>
                        </div>
                        <div class="container-login100-form-btn">
                            <button class="login100-form-btn" type='submit'>Login</button>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    )
}
export default SignIn

