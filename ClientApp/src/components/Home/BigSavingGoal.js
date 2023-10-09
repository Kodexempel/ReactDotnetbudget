import { React, useState, useEffect } from 'react'
import { CircularProgressbar } from 'react-circular-progressbar';
import 'react-circular-progressbar/dist/styles.css';

export default function BigSavingGoal(props) {
    const [bigSavingGoal, setBigSavingGoal] = useState([])

    useEffect(() => {
        if (props.data.sparmål) {
            setBigSavingGoal(props.data.sparmål)
        }

    }, [props.data.sparmål])

    function percentage(partialValue, totalValue) {
        return (100 * partialValue) / totalValue;
    }
    return (

        <div className="bigsavinggoal__fullpage">
            <div className="bigsavinggoal__headerdiv">
                <label className="bigsavinggoal__title_label">Sparmål</label>
            </div>
            <div className="bigsavinggoal__contentdiv">
                {
                    bigSavingGoal.map((x, i) => (
                        <div key={i} className="bigsavinggoal__contentdiv2">
                            <div className="bigsavinggoal__progressbar" style={{ width: 250, height: 250 }}>
                                <label className="bigsavinggoal__LabelSaving1">{x.namn}</label>
                                <CircularProgressbar value={percentage(x.sparat, x.attSpara)} text={`${percentage(x.sparat, x.attSpara)}%`} />
                                <label className="bigsavinggoal__LabelSaving3" >Sparat: {x.sparat}</label>
                                <label className="bigsavinggoal__LabelSaving3">Mål: {x.attSpara}</label>
                            </div>
                        </div>
                    ))
                }
            </div>
        </div>

    )
}
