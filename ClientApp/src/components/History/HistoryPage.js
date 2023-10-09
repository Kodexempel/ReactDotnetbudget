import React, {useState, useEffect } from "react";
import "../History/HistoryPage.css";
import Budgets from "./components/Budgets";
import Transactions from "./components/Transactions";
import authService from '../api-authorization/AuthorizeService';
import {
    BrowserRouter as Router,
    Switch,
    Route,
    NavLink,
    useParams,
    useRouteMatch,
} from "react-router-dom";

export default function HistoryPage() {
    let { path, url } = useRouteMatch();
    const [budgetData, setBudgetData] = useState([]);

    const fetchBudgets = () => {
        const token = authService.getAccessToken();
        console.log(token)
        fetch('api/budget', {
            method: "GET",
            headers: !token ? {} : {
                'Authorization': "Bearer " + token,
                'Content-Type': 'application/json',
                'Accept': 'application/json'
            },

        })
            /*.then((data) => data.json())*/
            .then((data) => {
                setBudgetData(data)
            })
            .catch((err) => {
                console.error(err);
            });

    }

    useEffect(() => {
        fetchBudgets()

    }, []);

    return (
        <>
            <Router>
                <div className="__container">
                    <nav className="__history-nav">
                        <ul>
                            <li>
                                <NavLink to="/history" className="__history-nav-btn">
                                    Budgets
                                </NavLink>
                            </li>
                            <div className="__line1"></div>
                            <li>
                                <NavLink to="/transactions" className="__history-nav-btn">
                                    Transactions
                                </NavLink>
                            </li>
                        </ul>
                        <hr />
                    </nav>

                    <Switch>
                        <Route exact path="/history">
                            <Budgets data={budgetData} />
                        </Route>
                        <Route exact path="/transactions">
                            <Transactions />
                        </Route>
                    </Switch>
                </div>
            </Router>
        </>
    );
}
