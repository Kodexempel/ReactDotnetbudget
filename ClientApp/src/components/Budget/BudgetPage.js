import React from "react";
import Accordion from './Accordion'
import './BudgetPage.css'
import CreateCategoryModal from './CreateCategoryModal';
import CreateBudgetModal from './CreateBudgetModal';




function BudgetPage() {
    return (
        <div>
            <Accordion
                title="Datum"
                content="16-06-2021 - 31-06-2021"
            />


            <Accordion
                title="Bostad      3000kr/mån"
                content="3000:- Bostad"
            />


            <Accordion
                title="Fordon      3000kr/mån"
                content="1000:-    Volvo" />

            <Accordion
                title="Rörliga kostnader    8000kr/mån"
                content="500:-    SF Bio" />

            <Accordion
                title="Fasta utgifter     1000kr/mån"
                content="1000:-        CSN-Lån" />

            <Accordion
                title="Obudgeterat   1000kr/mån"
                content="1000:-  Cykelaffär" />

            <Accordion
                title="Inkomst   37000 SEK"
                content="37000:-   Lön"
            />


            <div className="buttons">

                <CreateCategoryModal />

                <CreateBudgetModal />




            </div>













        </div>



    );
}



export default BudgetPage;