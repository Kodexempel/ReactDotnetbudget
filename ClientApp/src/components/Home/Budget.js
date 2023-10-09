import React from 'react'
//import './HomePage.css'
//import Income from './Income'
//import FixedCosts from './FixedCosts'
//import SavingGoal from './SavingGoal'
//import Unbudgeted from './Unbudgeted'
//import VariableCosts from './VariableCosts'


export default function Budget(props) {
    
    return (
        <div>
            <label className="budget__centercontent">{props.data.namn}</label>
            <p className="budget__centercontent" className="budget__dates">{props.data.datumtill} - {props.data.datumfrån} </p>
            <div className="budget__headlines_div">
                {/*<Income data={props.data} />*/}
                {/*<FixedCosts data={props.data} />*/}
                {/*<SavingGoal data={props.data} />*/}
                {/*<VariableCosts data={props.data} />*/}
                {/*<Unbudgeted data={props.data} />*/}
            </div>
        </div>
    )
}
