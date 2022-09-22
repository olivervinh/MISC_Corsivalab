import React from "react";

import { Icon } from "@chakra-ui/react";
import {
  MdBarChart,
  MdPerson,
  MdHome,
  MdLock,
  MdOutlineShoppingCart,
} from "react-icons/md";

// Admin Imports
import MainDashboard from "views/admin/default";
import NFTMarketplace from "views/admin/marketplace";
import Profile from "views/admin/profile";
import DataTables from "views/admin/dataTables";
import RTL from "views/admin/rtl";
import Dashboard from "views/admin/dashboard";
import Project from "views/admin/projects";
import Customer from "views/admin/customer";
import Maintenance from "views/admin/maintenance";
import Ataglance from "views/admin/ataglance";
// Auth Imports
import SignInCentered from "views/auth/signIn";
import Demo from "views/admin/paginationAntd";

//update project
import UpdateProject from "views/admin/update-project"
//update project

//child
 //dashboard
  //ActMainProjAssigned
   import MaintenanceProjectAssigned from "views/admin/dashboard/components/ActMainProjAssigned/MaintenanceProjectAssigned"
const routes = [
  {
    name: "Dashboard",
    layout: "/admin",
    path: "/dashboard",
    icon: <Icon as={MdHome} width='20px' height='20px' color='inherit' />,
    component: Dashboard,
  },
  {
    name:"Project",
    layout:"/admin",
    path:"/project",
    icon: <Icon as={MdHome} width='20px' height='20px' color='inherit' />,
    component:Project
  },
  {
    name:"Customer",
    layout:"/admin",
    path:"/customer",
    icon: <Icon as={MdHome} width='20px' height='20px' color='inherit' />,
    component:Customer
  },
  {
    name:"Maintenance",
    layout:"/admin",
    path:"/maintenance",
    icon: <Icon as={MdHome} width='20px' height='20px' color='inherit' />,
    component:Maintenance
  },
  {
    name:"Ataglance",
    layout:"/admin",
    path:"/ataglance",
    icon:<Icon as={MdHome} width='20px' height='20px' color='inherit'/>,
    component:Ataglance
  },
  {
    name: "Main Dashboard",
    layout: "/admin",
    path: "/default",
    icon: <Icon as={MdHome} width='20px' height='20px' color='inherit' />,
    component: MainDashboard,
  },
  {
    name: "NFT Marketplace",
    layout: "/admin",
    path: "/nft-marketplace",
    icon: (
      <Icon
        as={MdOutlineShoppingCart}
        width='20px'
        height='20px'
        color='inherit'
      />
    ),
    component: NFTMarketplace,
    secondary: true,
  },
  {
    name: "Data Tables",
    layout: "/admin",
    icon: <Icon as={MdBarChart} width='20px' height='20px' color='inherit' />,
    path: "/data-tables",
    component: DataTables,
  },
  {
    name: "Profile",
    layout: "/admin",
    path: "/profile",
    icon: <Icon as={MdPerson} width='20px' height='20px' color='inherit' />,
    component: Profile,
  },
  {
    name: "Sign In",
    layout: "/auth",
    path: "/sign-in",
    icon: <Icon as={MdLock} width='20px' height='20px' color='inherit' />,
    component: SignInCentered,
  },
  {
    layout:"/admin",
    path:"/MaintenanceProjectAssigned",
    component:MaintenanceProjectAssigned,
  },
  {
    layout:"/admin",
    path:"/update-project",
    component:UpdateProject
  }
];
export default routes;
