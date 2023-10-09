import { React, useEffect, useState } from 'react'


export default function Unbudgeted(props) {
    const [unbudgeted, setUnbudgeted] = useState([])

    useEffect(() => {
        if (props.data.obudgeterat) {
            setUnbudgeted(props.data.obudgeterat)
        }
    }, [props.data.obudgeterat])

    return (
        <div>
            <label className="unbudgeted__headlines_label">Obudgeterat</label>

            <label>{unbudgeted}</label>
        </div>
    )
}
