import {Link} from "react-router-dom"
import "./navbar.css"
const NavBar = () => {
    return ( 
        <>
            <nav className="navbar">
                <Link to="/Login">Login</Link>
                <Link to="/admin/dashboard">Dashboard</Link>
                <Link to="/admin/customer">customer</Link>
                <Link to="/admin/project">project</Link>
                <Link to="/admin/domain">domain</Link>
                <Link to="/admin/maintenance">maintenance</Link>
                <Link to="/admin/ataglance">ataglance</Link>
                <Link to="/admin/exportexcel">exportexcel</Link>
                <Link to="/admin/datas/emailsystem">emailsystem</Link>
                <Link to="/admin/datas/provider">provider</Link>
            </nav>
        </>
     );
}
 
export default NavBar;