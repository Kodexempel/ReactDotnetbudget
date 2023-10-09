import React from "react";

const Transactions = () => {
    return (
        <>
            
            <div className="__transaction-inputs">
                <form>
                    <label>Datum från:</label>
                    <input type="date" className="__filter-input" />
                    <label>Datum till:</label>
                    <input type="date" className="__filter-input" />
                    <label>Kategori:</label>
                    <input type="text" className="__filter-input" placeholder="Välj" />
                    <button className="__filter-btn">Filtrera</button>
                </form>
            </div>
            <input type="text" className="__search-table" placeholder="Sök"></input>
            <div className="__table-wrapper">
                <table className="__transactions-table">
                    <thead>
                        <tr>
                            <th>Namn</th>
                            <th>Pris</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>Mat</td>
                            <td>500</td>
                        </tr>
                        <tr>
                            <td>Glass</td>
                            <td>25</td>
                        </tr>
                    </tbody>
                </table>
                </div>
                
        </>
    );
};

export default Transactions;
