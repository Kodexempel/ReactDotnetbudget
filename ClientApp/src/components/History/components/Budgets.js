import React, { useState } from "react";
import HistorySidebar from "./HistorySidebar";
import BudgetData from "./BudgetData";


export default function Budgets(props) {
    const [active, setActive] = useState("");

    return (
        <>
            <div className="__history-sidebar">
                <ul>
                    <li>
                        <button className="__budget-btn" onClick={() => active ? setActive("") : setActive("FirstCard")}>2021</button>
                        {active === "FirstCard" && <HistorySidebar data={BudgetData} cardIndex={0} />}
                    </li>
                    <li>
                        <button className="__budget-btn" onClick={() => active ? setActive("") : setActive("SecondCard")}>2020</button>
                        {active === "SecondCard" && <HistorySidebar data={BudgetData} cardIndex={1} />}
                    </li>
                    <li>
                        <button className="__budget-btn" onClick={() => active ? setActive("") : setActive("ThirdCard")}>2019</button>
                        {active === "ThirdCard" && <HistorySidebar data={BudgetData} cardIndex={2} />}
                    </li>
                </ul>

            </div>
            <div className="__line2"></div>
            <div className="__history-content">
                <h2>Budget för Maj</h2>
                <div className="from-to-date">
                    <p>2021-05-01</p>
                    <p>-</p>
                    <p>2021-05-31</p>
                </div>
            </div>
            <div className="__history-table">
                <table>
                    <thead>
                        <tr>
                            <th>Inkomster</th>
                            <th>Fasta Kostnader</th>
                            <th>Sparmål</th>
                            <th>Rörliga Kostnader</th>
                            <th>Totalt</th>
                            <th>Obudgeterat</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>36000</td>
                            <td>Skatt - 10800</td>
                            <td>Resa - 1000</td>
                            <td>Mat - 5000</td>
                            <td>17800</td>
                            <td>9 200 SEK</td>
                        </tr>

                        <tr>
                            <td></td>
                            <td>Hyra - 3000</td>
                            <td></td>
                            <td>Nöje - 3000</td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td>Lån - 1000</td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td>Fordon - 3000</td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </>
    );
};
