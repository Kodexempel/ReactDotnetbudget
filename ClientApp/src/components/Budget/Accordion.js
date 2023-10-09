import React, { useState, useRef } from "react";
import "./Accordion.css";

function Accordion(props) {
    const [setActive, setActiveState] = useState(false);


    const content = useRef(null);

    function toggleAccordion() {
        setActiveState(!setActive);


    }

    let activeclassName = ''

    if (setActive === true) {
        activeclassName = 'accordion--active'
    }



    return (
        <div className={`accordion__section ${activeclassName}`}>
            <button className={`accordion `} onClick={toggleAccordion}>
                <p className="accordion__title">{props.title}</p>


            </button>

            <div
                ref={content}

                className="accordion__content"


            >
                <button>Lägg till</button>


                <div

                    className="accordion__text"

                    dangerouslySetInnerHTML={{ __html: props.content }}

                />



            </div>
        </div >


    );
}

export default Accordion;