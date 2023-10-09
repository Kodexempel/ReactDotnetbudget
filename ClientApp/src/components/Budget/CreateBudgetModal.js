import "./BudgetPage";
import React, { useState, useEffect, useContext } from "react";
import { makeStyles } from "@material-ui/core/styles";
import Modal from "@material-ui/core/Modal";
import { Input } from "@material-ui/core";


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

function CreateBudgetModal() {
    const classes = useStyles();
    const [modalStyle] = React.useState(getModalStyle);
    const [summary, setSummary] = useState("");
    const [open, setOpen] = useState(false);
    const [startdate, setStartDate] = useState("");
    const [enddate, setEndDate] = useState("");
    const [budgetName, setBudgetName] = useState("");







    // reset fields and close modal 
    const ResetForm = (data) => {

        setBudgetName('')
        setStartDate('')
        setEndDate('')
        setOpen(false)
        window.alert('Your :D has succesfully been uploaded!')
    }

    const handleBudgetChange = (e) => {
        e.preventDefault();

        console.log('handleBudgetChange fired')
    }



    const setBudgetName1 = (e) => {
        if (purchaseRegex.exec(e.target.value)) {
            setSummary("");
            setBudgetName(e.target.value);
        } else {
            setSummary("no numbers allowed");
        }
    };

    const purchaseRegex = new RegExp("^[A-ZÅÄÖÈa-zåäöé ]{0,29}$");

    return (
        <div className="rpm">
            <button className="btn2" onClick={() => setOpen(true)}>Lägg till en budget</button>

            <Modal open={open} onClose={() => setOpen(false)}>
                <div style={modalStyle} className={classes.paper}>
                    <form className="rpm__registerbudget">
                        <center>
                            <h2 className="rpm__budgettext">Skapa Budget</h2>
                        </center>
                        {summary}
                        <input
                            type="text"
                            className="modalinputs"
                            name="budgetName"
                            pattern="^[a-zåäöé]{0,19}$"
                            placeholder="Budget Name"
                            //   value={budgetName}
                            onChange={setBudgetName}
                            required
                        ></input>

                        <input
                            placeholder="Budget Start"
                            className="modalinputs"
                            type="date"
                            value={startdate}
                            onChange={(e) => setStartDate(e.target.value)}
                        />

                        <input
                            placeholder="Budget End"
                            className="modalinputs"
                            type="date"
                            value={enddate}
                            onChange={(e) => setEndDate(e.target.value)}
                        />



                        <button
                            variant="contained"
                            className="modalinputssubmit"
                        //   onClick={handlePurchase}
                        >
                            Skapa
                        </button>
                    </form>
                </div>
            </Modal>
        </div>
    );
}


export default CreateBudgetModal;
