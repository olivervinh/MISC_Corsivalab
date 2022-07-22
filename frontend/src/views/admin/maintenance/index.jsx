import React from 'react'
import Tab from 'react-bootstrap/Tab';
import Tabs from 'react-bootstrap/Tabs';
import TableHourly from './components/TableHourly';
import TableMonthly from './components/TableMonthly';
const Index = () => {
    return (
        <div className="m-portlet__body" style={{marginTop:130+"px"}}>
            <div className="row">
                <div className="col-md-12">
                    <div className="m-content">
                        <Tabs
                            defaultActiveKey="profile"
                            id="uncontrolled-tab-example"
                            className="mb-3"
                        >
                            <Tab eventKey="monthly" title="Monthly" style={{marginRight:20+"px"}}>
                                <div className="custom-table-responsive">
                                   <TableMonthly/>
                                </div>
                            </Tab>
                            <Tab eventKey="hourly" title="Hourly">
                                <div className="custom-table-responsive">
                                <TableHourly/>
                                </div>
                            </Tab>
                        </Tabs>
                    </div>
                </div>
            </div>
        </div>
    )
}

export default Index