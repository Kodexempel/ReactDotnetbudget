import React, { useEffect, useState } from 'react'

export default function SavingGoal(props) {
    const [savingGoal, setSavingGoal] = useState([])

    useEffect(() => {
        if (props.data.sparmål) {
            setSavingGoal(props.data.sparmål)
        }
    }, [props.data.sparmål])

    return (

        <div className="savinggoal__fullpage">
            <div className="savinggoal__headerdiv">
                <label className="savinggoal__title_label">Sparmål</label>
            </div>


            <div className="savinggoal__contentdiv">

                {savingGoal.map((x, i) => (
                    <div key={i} className="savinggoal__divformap">
                        <label className="savinggoal__content_label">{x.namn}</label> <label className="savinggoal__content_label2"> Att Spara: {x.attSpara}</label> <label className="savinggoal__content_label3">Sparat: {x.sparat}</label>
                    </div>
                ))}

            </div>


        </div>
    )
}
