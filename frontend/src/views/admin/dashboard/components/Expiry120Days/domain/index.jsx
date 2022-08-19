import React, { useEffect, useState } from 'react'
import moment from 'moment'
import Tab from 'react-bootstrap/Tab';
import { getExpiry120Days_domain } from './apiRequest'
import { useDispatch, useSelector } from 'react-redux';
import { Pagination } from 'antd';
const Index = () => {
<Pagination defaultCurrent={1} total={50} />
}

export default Index