import React, { useState } from 'react'


export default function BudgetCategory(props) {

    const [total, setTotal] = useState();

    const CountTotal = (props) => {
        let localTotal = 0;
    }
    return (
        <div>
            <label>{props.headline}</label>
            <label>{total}</label>
        </div>
    )
}
