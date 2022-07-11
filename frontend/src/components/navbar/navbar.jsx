import {Link} from "react-router-dom"
import { useSelector } from "react-redux";
import "./navbar.css"
const NavBar = () => {
    const user = useSelector((state)=>state.auth.login.currentUser)//use selector : react redux là cách để lấy stage : auth
    console.log("user",user)
    return ( 
        <>
        {user?(
            <>
                <Link to="/admin/dashboard">Dashboard</Link>
                <Link to="/admin/customer">customer</Link>
                <Link to="/admin/project">project</Link>
                <Link to="/admin/domain">domain</Link>
                <Link to="/admin/maintenance">maintenance</Link>
                <Link to="/admin/ataglance">ataglance</Link>
                <Link to="/admin/exportexcel">exportexcel</Link>
                <Link to="/admin/datas/emailsystem">emailsystem</Link>
                <Link to="/admin/datas/provider">provider</Link>
            </>
            ):(
                <Link to="/login"> Login </Link>
            )}
        </>
     );
}
 
export default NavBar;