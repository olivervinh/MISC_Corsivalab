import React, { useEffect, useState } from 'react'
import Tab from 'react-bootstrap/Tab';
import Tabs from 'react-bootstrap/Tabs';
import Domain from "./domain/index"
import EmailSystem from "./emailSystem/index"
import Hosting from "./hosting/index"
import Maintenance from "./maintenance/index"
const Index = () => {

    //tab domain

    //tab domain

    //tab hosting
    //tab hosting

    //email system
    //email system

    //maintenance
    //maintenance

    return (
        <div style={{ backgroundColor: "white", borderRadius: 20 + "px" }}>
            <h3 className="m-portlet__head-text" style={{ margin: 20 + "px", padding: 24 + "px" }}>Active Maintenance Project Assigned</h3>
            <div style={{ padding: 20 + "px" }}>
                <Tabs
                    defaultActiveKey="profile"
                    id="uncontrolled-tab-example"
                    className="mb-3"
                >
                    <Tab eventKey="domain" title="Domain">
                        <div className="custom-table-responsive">
                            <Domain />
                        </div>
                    </Tab>
                    <Tab eventKey="hosting" title="Hosting">
                        <div className="custom-table-responsive">
                            <Hosting />
                        </div>
                    </Tab>
                    <Tab eventKey="emailSystem" title="EmailSystem">
                        <div className="custom-table-responsive">
                            <EmailSystem />
                        </div>
                    </Tab>
                    <Tab eventKey="monthlyMaintenance" title="MonthlyMaintenance">
                        <div className="custom-table-responsive">
                            <Maintenance />
                        </div>
                    </Tab>
                </Tabs>
            </div>
        </div>

    )
}

export default Index