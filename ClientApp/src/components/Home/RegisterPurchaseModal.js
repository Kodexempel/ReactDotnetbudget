import "./HomePage.css";
import React, { useState, useEffect, useContext } from "react";
import { makeStyles } from "@material-ui/core/styles";
import Modal from "@material-ui/core/Modal";
import { Input } from "@material-ui/core";
// import { UserContext } from "../contexts/UserContext";

function getModalStyle() {
    const top = 50;
    const left = 50;

    return {
        top: `${top}%`,
        left: `${left}%`,
        transform: `translate(-${top}%, -${left}%)`,
    };
}

const useStyles = makeStyles((theme) => ({
    paper: {
        position: "absolute",
        width: 800,
        backgroundColor: '#2A9D8F',
        border: "2px solid #000",
        boxShadow: theme.shadows[5],
        padding: theme.spacing(2, 4, 3),
    },
}));

function RegisterPurchaseModal() {
    const classes = useStyles();
    const [modalStyle] = React.useState(getModalStyle);
    const [summary, setSummary] = useState("");
    //   const user = useContext(UserContext);
    const [open, setOpen] = useState(false);
    const [price, setPrice] = useState("");
    const [purchaseName, setPurchaseName] = useState("");
    const [date, setDate] = useState("");
    const [budgets, setBudgets] = useState([]);
    const [categories, setCategories] = useState([]);
    const [selectedCategory, setSelectedCategory] = useState("");

    //   useEffect(() => {
    //     fetch("http://localhost:65424/api/Budget/GetBudgetList", {
    //       method: "POST",
    //       headers: {
    //         "Content-Type": "application/json",
    //       },
    //       body: JSON.stringify(user),
    //     })
    //       .then((data) => data.json())
    //       .then((data) => {
    //         setBudgets(data);
    //       })
    //       .catch((err) => {
    //         console.error(err);
    //       });
    //   }, []);

    //   const handlePurchase = (event) => {
    //     event.preventDefault();
    //     let requestObject = {
    //       Price: price,
    //       PurchaseName: purchaseName,
    //       Date: date,
    //       User: {
    //         Username: user,
    //       },
    //       Category: {
    //         Id: selectedCategory,
    //       },
    //     };

    //     fetch("http://localhost:65424/api/Purchase/", {
    //       method: "POST",
    //       headers: {
    //         "Content-Type": "application/json",
    //       },
    //       body: JSON.stringify(requestObject),
    //     })
    //       .then(ResetForm())
    //       .catch((err) => {
    //         console.error(err);
    //       });
    //   };

    // reset fields and close modal 
    const ResetForm = (data) => {
        setPrice('')
        setPurchaseName('')
        setDate('')
        setOpen(false)
        window.alert('Your purchase has succesfully been uploaded!')
    }

    const handleBudgetChange = (e) => {
        e.preventDefault();

        console.log('handleBudgetChange fired')
    }

    //   const handleBudgetChange = (e) => {
    //     e.preventDefault();

    //     let requestObject = {
    //       Price: price,
    //       PurchaseName: purchaseName,
    //       Date: date,
    //       User: {
    //         Username: user,
    //       },
    //       Budget: {
    //         Id: e.target.value,
    //       },
    //     };

    //     fetch("http://localhost:65424/api/Category/GetCategoryForPurchase", {
    //       method: "POST",
    //       headers: {
    //         "Content-Type": "application/json",
    //       },
    //       body: JSON.stringify(requestObject),
    //     })
    //       .then((data) => data.json())
    //       .then((data) => {
    //         setCategories(data);
    //       })
    //       .catch((err) => {
    //         console.error(err);
    //       });
    //   };

    const setPurchaseName1 = (e) => {
        if (purchaseRegex.exec(e.target.value)) {
            setSummary("");
            setPurchaseName(e.target.value);
        } else {
            setSummary("no numbers allowed");
        }
    };

    const purchaseRegex = new RegExp("^[A-ZÅÄÖÈa-zåäöé ]{0,29}$");

    return (
        <div className="rpm">
            <button className="btn" onClick={() => setOpen(true)}>Lägg till köp</button>

            <Modal open={open} onClose={() => setOpen(false)}>
                <div style={modalStyle} className={classes.paper}>
                    <form className="rpm__registerpurchase">
                        <center>
                            <h2 className="rpm__purchasetext">Register Purchase</h2>
                        </center>
                        {summary}
                        <input
                            type="text"
                            className="modalinputs"
                            name="purchaseName"
                            pattern="^[a-zåäöé]{0,19}$"
                            placeholder="Purchase Name"
                            value={purchaseName}
                            onChange={setPurchaseName1}
                            required
                        ></input>

                        <input
                            placeholder="Price"
                            className="modalinputs"
                            type="number"
                            value={price}
                            onChange={(e) => setPrice(e.target.value)}
                            onKeyDown={(evt) => ["e", "E", "+", "-"].includes(evt.key) && evt.preventDefault()}
                        />

                        <input
                            placeholder="Date"
                            className="modalinputs"
                            type="date"
                            value={date}
                            onChange={(e) => setDate(e.target.value)}
                        />

                        <select defaultValue={'default'} className="modalinputs" onChange={handleBudgetChange}>
                            <option value="default" disabled hidden>
                                --Choose Budget--
              </option>
                            {/* {budgets.map((x, index) => (
                <option key={index} value={x.Id}>{x.BudgetName}</option>
              ))} */}
                        </select>
                        <select defaultValue={'default'} className="modalinputs" onChange={(e) => setSelectedCategory(e.target.value)}>
                            <option value="default" disabled hidden>
                                --Choose Category--
              </option>
                            {/* {categories.length
                ? categories.map((x, index) => <option key={index} value={x.Id}>{x.Name}</option>)
                : undefined} */}

                        </select>


                        <button
                            variant="contained"
                            className="modalinputssubmit"
                        //   onClick={handlePurchase}
                        >
                            Submit
            </button>
                    </form>
                </div>
            </Modal>
        </div>
    );
}

export default RegisterPurchaseModal;
