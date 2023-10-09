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

function CreateCategoryModal() {
    const classes = useStyles();
    const [modalStyle] = React.useState(getModalStyle);
    const [summary, setSummary] = useState("");
    const [open, setOpen] = useState(false);

    const [categoryName, setCategoryName] = useState("");







    // reset fields and close modal 
    const ResetForm = (data) => {

        setCategoryName('')

        setOpen(false)
        window.alert('Your :D has succesfully been uploaded!')
    }

    const handleBudgetChange = (e) => {
        e.preventDefault();

        console.log('handleBudgetChange fired')
    }



    const setPurchaseName1 = (e) => {
        if (purchaseRegex.exec(e.target.value)) {
            setSummary("");
            setCategoryName(e.target.value);
        } else {
            setSummary("no numbers allowed");
        }
    };

    const purchaseRegex = new RegExp("^[A-ZÅÄÖÈa-zåäöé ]{0,29}$");

    return (
        <div className="rpm">
            <button className="btn1" onClick={() => setOpen(true)}>Lägg till en Kategori</button>

            <Modal open={open} onClose={() => setOpen(false)}>
                <div style={modalStyle} className={classes.paper}>
                    <form className="rpm__registerpurchase">
                        <center>
                            <h2 className="rpm__purchasetext">Skapa Kategori</h2>
                        </center>
                        {summary}
                        <input
                            type="text"
                            className="modalinputs"
                            name="categoryName"
                            pattern="^[a-zåäöé]{0,19}$"
                            placeholder="Category Name"
                            //   value={categoryName}
                            onChange={setCategoryName}
                            required
                        ></input>


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


export default CreateCategoryModal;
