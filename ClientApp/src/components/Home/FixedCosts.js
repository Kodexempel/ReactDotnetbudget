import React, { useState, useEffect } from 'react'
import './HomePage.css'

export default function FixedCosts(props) {

    const [total, setTotal] = useState();
    const [total1, setTotal1] = useState();


    useEffect(() => {
        if (props.data.fasta) {
            let localTotal = 0;
            console.log(props.data.fasta)
            props.data.fasta.forEach((element, i) => localTotal += (element.summa));
            setTotal1(localTotal);
            localTotal += props.data.bostad;
            localTotal += props.data.fordon;
            setTotal(localTotal);
        }
    }, [props.data.fasta])




    return (
        <div className="fixedcosts__fullpage">
            <div className="fixedcosts__headline_div">
                <label >Fasta Utgifter</label>
            </div>
            <div className="fixedcosts__content">

                <label className="fixedcosts__labels">Total: {total}</label>
                <label className="fixedcosts__labels">Bostad: {props.data.bostad}</label>
                <label className="fixedcosts__labels">Fordon: {props.data.fordon}</label>
                <label className="fixedcosts__labels">Övrigt: {total1}</label>

            </div>
        </div>
    )
}
