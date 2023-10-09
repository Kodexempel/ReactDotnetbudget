import { React, useEffect, useState } from 'react'
import './HomePage.css'

export default function Income(props) {
    const [income, setIncome] = useState([])

    useEffect(() => {
        if (props.data.inkomst) {
            setIncome(props.data.inkomst)
        }
    }, [props.data.inkomst])


    return (
        <div className="income__fullpage">
            <div className="income__headerdiv">
                <label>Inkomster</label>
            </div>
            <div className="income__contentdiv">
                <label>{income}</label>
            </div>
        </div>
    )
}
