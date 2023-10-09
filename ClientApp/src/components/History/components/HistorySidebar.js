import React from "react";

const HistorySidebar = ({ data, cardIndex }) => {
    return (
        <div>
            {data[cardIndex].map(item => (
                <div key={cardIndex} className="__card">
                    <ul>
                        <li>{item.budget1}</li>
                        <li>{item.budget2}</li>
                        <li>{item.budget3}</li>
                    </ul>
                </div>
            ))}
        </div>
    );
};

export default HistorySidebar;
